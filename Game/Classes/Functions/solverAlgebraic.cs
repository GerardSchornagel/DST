using Microsoft.VisualBasic;
using System;

/// <summary>
/// Description of form/class/etc.
/// </summary>
public class solverAlgebraic
{
    public enum Operations
    {
        Exponents = 1,
        Parenthesis = 2,
        Multiplication = 3,
        Division = 3,
        Addition = 4,
        Subtraction = 4
    }
    
    /// <summary>
    /// Enumerates Variable with live lookup, class:setting:parameter
    /// customer has "Ethnic as String" parameter.
    /// </summary>
    /// <param name="expression"></param>
    /// <returns></returns>
    public string FillVariables(string expression)
    {
        string[] stringMediator = null;
        string stringOutput = "";
        string stringVariable = "";
        bool booleanFirstEntry = false;
        stringMediator = expression.Split((char)123);
        //123={

        foreach (string line in stringMediator) {
            if (booleanFirstEntry == false) {
                booleanFirstEntry = true;
                if (!object.ReferenceEquals(line, ""))
                    stringOutput += line;
                continue;
            }

            stringVariable = line.Split((char)125)[0];
            //125=}
            //58=:
//            if (stringVariable.Split((char)58)[0].ToLower() == "customer") {
//                gamecache.cacheCustomer.stringEthnic = stringVariable.Split((char)58)[2];
//                gamecache.cacheCustomer.SettingRequest = stringVariable.Split((char)58)[1];
//                stringOutput += gamecache.cacheCustomer.ReturnValue;
//            } else if (stringVariable.Split((char)58)[0].ToLower() == "characterprofile") {
//                gamecache.currentCharacter.InformationRequest = stringVariable.Split((char)58)[1];
//                stringOutput += gamecache.currentCharacter.ReturnValue;
//            } else if (stringVariable.Split((char)58)[0].ToLower() == "characterstatistics") {
//                gamecache.currentCharacter.InformationRequest = stringVariable.Split((char)58)[1];
//                stringOutput += gamecache.currentCharacter.ReturnValue;
//            } else if (stringVariable.Split((char)58)[0].ToLower() == "playerprofile") {
//                gamecache.currentCharacter.InformationRequest = stringVariable.Split((char)58)[1];
//                stringOutput += gamecache.currentPlayer.ReturnValue;
//            } else if (stringVariable.Split((char)58)[0].ToLower() == "playerstatistics") {
//                gamecache.currentCharacter.InformationRequest = stringVariable.Split((char)58)[1];
//                stringOutput += gamecache.currentPlayerStatistics.ReturnValue;
//            }
            stringOutput += line.Split((char)125)[1];
            //Remainder with Operator's
        }

        return stringOutput;
    }
    /// <summary>
    /// Evaluates a mathematical expression.
    /// </summary>
    /// <param name="expression">String; Mathematical expression to be evaluated.</param>
    /// <returns>Double; Solution.</returns>
    public double SimplifyAlgebraicExpression(string expression)
    {
        string result = expression.Replace(")(", ")*(");
        char[] cArray = expression.ToCharArray();
        Int32 oP = 0;
        Int32 cP = 0;
        string p = null;
        //Part of the expression extracted to be solved.
        string s = null;
        //Solution
        bool Bracket = false;

        if (result.Contains("(")) {
            char c = '\0';

            //Fix any multiplication that may be without the operator. IE x(x), which is required to look like x*(x).
            //Start at the first opening parenthesis
            for (Int32 i = result.IndexOf("("); i <= (cArray.Length - 1); i++) {
                if (cArray[i] == '(' && i - 1 >= 0) {
                    c = cArray[i - 1];
                    if (char.IsNumber(c)) {
                        result = result.Replace(c + "(", c + "*(");
                    }
                }
                //Continue to look for the first closing parenthesis.
                if (cArray[i] == ')' && i + 1 <= cArray.Length - 1) {
                    c = cArray[i + 1];
                    if (char.IsNumber(c)) {
                        result = result.Replace(")" + c, ")*" + c);
                    }
                }
            }

            //Loop through the expression until all parenthesis have been evaluated.
            while (result.Contains("(")) {
                cArray = result.ToCharArray();

                //Start at the first opening parenthesis
                for (Int32 i = result.IndexOf("("); i <= (cArray.Length - 1); i++) {
                    if (cArray[i] == '(') {
                        oP = i + 1;
                        //Remember the position of the opening parenthesis everytime one has been found.
                    }
                    //Continue to look for the first closing parenthesis.
                    if (cArray[i] == ')') {
                        cP = i;
                        //Remember the position.
                        break; // TODO: might not be correct. Was : Exit For
                        //Exit out of the for loop, we
                    }
                }

                p = result.Substring(oP, cP - oP);
                //Extract the inner algebraic expression to be evaluated.
                s = SimplifySubAlgebraicExpression(p).ToString();

                //Make sure we're within range.
                if (cP + 1 <= cArray.Length - 1) {
                    //Check if the sub algebraic expression as a whole has any exponents.
                    if (cArray[cP + 1] == '^') {
                        s = "[" + s + "]^";
                        //Add brackets around the solution, which will be handled when solving for exponents.
                        Bracket = true;
                    }
                }

                //Replace the sub expression including parenthesis with the solution to said sub expression.
                if (Bracket) {
                    result = result.Replace("(" + p + ")^", s);
                    Bracket = false;
                } else {
                    result = result.Replace("(" + p + ")", s);
                }

                cArray = result.ToCharArray();
                //Update character array.
            }
            //Do it all over again till all parenthesis are gone.
        }

        //Finally solve for the last expression that may be, and return the solution.
        return SimplifySubAlgebraicExpression(result);
    }


    /// <returns>Evaluates a sub expression - one that does not contain any parenthesis.</returns>
    protected double SimplifySubAlgebraicExpression(string expression)
    {
        //The expression being passed cannot cotain any parenthesis.
        if (!expression.Contains("(") | !expression.Contains(")")) {
            string result = expression.Replace(" ", Constants.vbNullString);
            char[] cArray = result.ToCharArray();

            //Perform the order of operations.
            //1) Solve exponents.
            result = PerformOperation(result, Operations.Exponents);

            //3) Solve all multiplication and division operations.
            result = PerformOperation(result, Operations.Multiplication & Operations.Division);

            //4) Solve all addition and subtraction operations.
            result = PerformOperation(result, Operations.Addition & Operations.Subtraction);

            return Convert.ToDouble(result);
            //Return the final solution as a double.
        } else {
            System.Windows.Forms.MessageBox.Show("Expression cannot contain parenthesis.");
            return 0;
        }
    }

    /// <returns>Evaluates a particular operation(s) of an expression.</returns>
    protected string PerformOperation(string expression, Operations Operation)
    {
        string result = expression.Replace(" ", Constants.vbNullString);
        char[] cArray = result.ToCharArray();

        switch (Operation) {
            case Operations.Exponents:
                if (result.Contains("^")) {
                    //Loop through the expression until all root have been evaluated.
                    while (result.Contains("^")) {
                        //   Constant                    Exponent
                        string c = Constants.vbNullString;
                        string e = Constants.vbNullString;
                        double v = 0;
                        //Value.
                        bool Brackets = false;

                        //Obtain the constant.
                        if (cArray[(result.IndexOf("^") - 1)] == ']') {
                            for (Int32 i = (result.IndexOf("^") - 2); i >= 0; i += (-1)) {
                                if (cArray[i] == '[')
                                    break; // TODO: might not be correct. Was : Exit For
                                c = cArray[i].ToString() + c;
                            }
                            Brackets = true;
                        } else {
                            for (Int32 i = (result.IndexOf("^") - 1); i >= 0; i += (-1)) {
                                if (char.IsNumber(cArray[i]) | cArray[i].ToString() == ".") {
                                    c = cArray[i].ToString() + c;
                                } else {
                                    break; // TODO: might not be correct. Was : Exit For
                                }
                            }
                        }

                        //Obtain the exponent.
                        for (Int32 i = result.IndexOf("^") + 1; i <= cArray.Length - 1; i++) {
                            if (char.IsNumber(cArray[i]) | cArray[i] == '.') {
                                e = e + cArray[i].ToString();
                            } else {
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }

                        //Calculate the value.
                        v = Math.Pow(Convert.ToDouble(c), Convert.ToDouble(e));
                        if (Brackets) {
                            result = result.Replace("[" + c + "]^" + e, v.ToString());
                            //Insert the value into the expression.
                        } else {
                            result = result.Replace(c + "^" + e, v.ToString());
                            //Insert the value into the expression.
                        }
                        cArray = result.ToCharArray();
                        //Update the character array.
                    }
                }
                break;
            case Operations.Multiplication & Operations.Division:
                //Both multiplication and division get processed the same.
                if (result.Contains("/")) {
                    while (result.Contains("/")) {
                        string[] constants = new string[2];
                        double t = 0;
                        //Total

                        for (Int32 i = result.IndexOf("/") - 1; i >= 0; i += -1) {
                            if (char.IsNumber(cArray[i])) {
                                constants[0] = cArray[i].ToString() + constants[0];
                            } else {
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }
                        for (Int32 i = result.IndexOf("/") + 1; i <= cArray.Length - 1; i++) {
                            if (char.IsNumber(cArray[i])) {
                                constants[1] = constants[1] + cArray[i].ToString();
                            } else {
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }

                        t = Convert.ToDouble(constants[0]) / Convert.ToDouble(constants[1]);

                        result = result.Replace(constants[0] + "/" + constants[1], t.ToString());
                        cArray = result.ToCharArray();
                    }
                }
                if (result.Contains("*")) {
                    while (result.Contains("*")) {
                        string[] constants = new string[2];
                        double t = 0;
                        //Total

                        for (Int32 i = result.IndexOf("*") - 1; i >= 0; i += -1) {
                            if (char.IsNumber(cArray[i])) {
                                constants[0] = cArray[i].ToString() + constants[0];
                            } else {
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }
                        for (Int32 i = result.IndexOf("*") + 1; i <= cArray.Length - 1; i++) {
                            if (char.IsNumber(cArray[i])) {
                                constants[1] = constants[1] + cArray[i].ToString();
                            } else {
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }

                        t = Convert.ToDouble(constants[0]) * Convert.ToDouble(constants[1]);

                        result = result.Replace(constants[0] + "*" + constants[1], t.ToString());
                        cArray = result.ToCharArray();
                    }
                }
                break;
            case Operations.Addition & Operations.Subtraction:
                //Addition and subtraction must be processed at the same time.
                if (result.Contains("+") | result.Contains("-")) {
                    string[] constants = null;
                    double t = 0;
                    //Total.

                    //Fix any double operators we may have left over.
                    if (result.Contains("+-"))
                        result = result.Replace("+-", "-");
                    if (result.Contains("-+"))
                        result = result.Replace("-+", "-");
                    if (result.Contains("++"))
                        result = result.Replace("++", "+");
                    if (result.Contains("--"))
                        result = result.Replace("--", "+");
                    //Add in the seperator at every operand.
                    result = result.Replace("+", " +");
                    result = result.Replace("-", " -");
                    //Split the result to obtain all constants.
                    constants = result.Split(' ');

                    for (Int32 i = 0; i <= constants.Length - 1; i++) {
                        if (constants[i] != Constants.vbNullString) {
                            t = t + Convert.ToDouble(constants[i]);
                        }
                    }

                    result = t.ToString();
                }
                break;
        }

        return result;
    }
}