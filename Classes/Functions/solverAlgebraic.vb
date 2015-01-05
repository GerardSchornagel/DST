''' <summary>
''' Description of form/class/etc.
''' </summary>
Public Class solverAlgebraic
	    Enum Operations
        Exponents = 1
        Parenthesis = 2
        Multiplication = 3
        Division = 3
        Addition = 4
        Subtraction = 4
	    End Enum
	    ''' <summary>
	    ''' Enumerates Variable with live lookup, class:setting:parameter
	    ''' customer has "Ethnic as String" parameter.
	    ''' </summary>
	    ''' <param name="expression"></param>
	    ''' <returns></returns>
	Function FillVariables(ByVal expression As String) As String
		Dim stringMediator() As String
		Dim stringOutput As String = ""
			Dim stringVariable As String = ""
		Dim booleanFirstEntry As Boolean = false
		stringMediator = expression.Split(Chr(123)) '123={
		
		For Each line As String In stringMediator
			If booleanFirstEntry = False Then
				booleanFirstEntry = True
				If line IsNot "" Then stringOutput &= line
				Continue For
			End If
			
			stringVariable = line.Split(Chr(125))(0) '125=}
			If stringVariable.Split(Chr(58))(0).ToLower = "customer" Then '58=:
				stringOutput &= gamecache.cacheCustomer.ReturnValue(stringVariable.Split(Chr(58))(2), stringVariable.Split(Chr(58))(1))
			ElseIf stringVariable.Split(Chr(58))(0).ToLower = "characterprofile" Then
				stringOutput &= gamecache.currentCharacterProfile.ReturnValue(stringVariable.Split(Chr(58))(1))
			ElseIf stringVariable.Split(Chr(58))(0).ToLower = "characterstatistics" Then
				stringOutput &= gamecache.currentCharacterStatistics.ReturnValue(stringVariable.Split(Chr(58))(1))
			ElseIf stringVariable.Split(Chr(58))(0).ToLower = "playerprofile" Then
				stringOutput &= gamecache.currentPlayerProfile.ReturnValue(stringVariable.Split(Chr(58))(1))
			ElseIf stringVariable.Split(Chr(58))(0).ToLower = "playerstatistics" Then
				stringOutput &= gamecache.currentPlayerStatistics.ReturnValue(stringVariable.Split(Chr(58))(1))
			End If
			stringOutput &= line.Split(Chr(125))(1) 'Remainder with Operator's
		Next
		
		Return stringOutput
	End Function
    ''' <summary>
    ''' Evaluates a mathematical expression.
    ''' </summary>
    ''' <param name="expression">String; Mathematical expression to be evaluated.</param>
    ''' <returns>Double; Solution.</returns>
    Function SimplifyAlgebraicExpression(ByVal expression As String) As Double
        Dim result As String = expression.Replace(")(", ")*(")
        Dim cArray() As Char = expression.ToCharArray()
        Dim oP As Int32 = 0, cP As Int32 = 0
        Dim p As String 'Part of the expression extracted to be solved.
        Dim s As String 'Solution
        Dim Bracket As Boolean = False

        If result.Contains("(") Then
            Dim c As Char

            'Fix any multiplication that may be without the operator. IE x(x), which is required to look like x*(x).
            For i As Int32 = result.IndexOf("(") to (cArray.Length-1) 'Start at the first opening parenthesis
                If cArray(i) = "("C AndAlso i-1 >= 0 Then
                    c = cArray(i-1)
                    If Char.IsNumber(c) Then
                        result = result.Replace(c & "(", c & "*(")
                    End If
                End If
                If cArray(i) = ")"C AndAlso i+1 <= cArray.Length-1 Then 'Continue to look for the first closing parenthesis.
                    c = cArray(i+1)
                    If Char.IsNumber(c) Then
                        result = result.Replace(")" & c, ")*" & c)
                    End If
                End If
            Next

            'Loop through the expression until all parenthesis have been evaluated.
            Do While result.Contains("(")
                cArray = result.ToCharArray

                For i As Int32 = result.IndexOf("(") to (cArray.Length-1) 'Start at the first opening parenthesis
                    If cArray(i) = "("C Then 
                        oP = i+1 'Remember the position of the opening parenthesis everytime one has been found.
                    End If
                    If cArray(i) = ")"C Then 'Continue to look for the first closing parenthesis.
                        cP = i 'Remember the position.
                        Exit For 'Exit out of the for loop, we
                    End If
                Next

                p = result.Substring(oP,cP-oP) 'Extract the inner algebraic expression to be evaluated.
                s = SimplifySubAlgebraicExpression(p).ToString()

                If cP+1 <= cArray.Length-1 Then 'Make sure we're within range.
                    If cArray(cP+1) = "^" Then 'Check if the sub algebraic expression as a whole has any exponents.
                        s = "[" & s & "]^" 'Add brackets around the solution, which will be handled when solving for exponents.
                        Bracket = True
                    End If
                End If

                'Replace the sub expression including parenthesis with the solution to said sub expression.
                If Bracket Then
                    result = result.Replace("(" & p & ")^", s)
                    Bracket = False
                Else
                    result = result.Replace("(" & p & ")", s)
                End If
                
                cArray = result.ToCharArray() 'Update character array.
            Loop 'Do it all over again till all parenthesis are gone.
        End If

        'Finally solve for the last expression that may be, and return the solution.
        Return SimplifySubAlgebraicExpression(result)
    End Function

    
        ''' <returns>Evaluates a sub expression - one that does not contain any parenthesis.</returns>
    Protected Function SimplifySubAlgebraicExpression(ByVal expression As String) As Double
        'The expression being passed cannot cotain any parenthesis.
        If Not expression.Contains("(") Or Not expression.Contains(")") Then
            Dim result As String = expression.Replace(" ", vbNullString)
            Dim cArray() As Char = result.ToCharArray()

            'Perform the order of operations.
            '1) Solve exponents.
            result = PerformOperation(result, Operations.Exponents)

            '3) Solve all multiplication and division operations.
            result = PerformOperation(result, Operations.Multiplication And Operations.Division)

            '4) Solve all addition and subtraction operations.
            result = PerformOperation(result, Operations.Addition And Operations.Subtraction)
            
            Return Convert.ToDouble(result) 'Return the final solution as a double.
        Else
            MessageBox.Show("Expression cannot contain parenthesis.")
            Return 0
        End If
    End Function

    ''' <returns>Evaluates a particular operation(s) of an expression.</returns>
    Protected Function PerformOperation(ByVal expression As String, ByVal Operation As Operations) As String
        Dim result As String = expression.Replace(" ", vbNullString)
        Dim cArray() As Char = result.ToCharArray()

        Select Case Operation
            Case Operations.Exponents
                If result.Contains("^") Then
                    Do While result.Contains("^") 'Loop through the expression until all root have been evaluated.
                        '   Constant                    Exponent
                        Dim c As String = vbNullString, e As String = vbNullString
                        Dim v As Double 'Value.
                        Dim Brackets As Boolean = False

                        'Obtain the constant.
                        If cArray((result.IndexOf("^")-1)) = "]"C Then
                            For i As Int32 = (result.IndexOf("^")-2) To 0 Step (-1)
                                If cArray(i) = "["C Then Exit For
                                c = cArray(i).ToString & c
                            Next
                            Brackets = True
                        Else
                            For i As Int32 = (result.IndexOf("^")-1) to 0 Step (-1)
                                If Char.IsNumber(cArray(i)) or cArray(i).ToString = "." Then
                                    c = cArray(i).ToString() & c
                                Else
                                    Exit For
                                End If
                            Next
                        End If

                        'Obtain the exponent.
                        For i As Int32 = result.IndexOf("^")+1 to cArray.Length-1
                            If Char.IsNumber(cArray(i)) or cArray(i) = "."C Then
                                e = e & cArray(i).ToString()
                            Else
                                Exit For
                            End If
                        Next

                        'Calculate the value.
                        v = Convert.ToDouble(c)^Convert.ToDouble(e)
                        If Brackets Then
                            result = result.Replace("[" & c & "]^" & e, v.ToString()) 'Insert the value into the expression.
                        Else
                            result = result.Replace(c & "^" & e, v.ToString()) 'Insert the value into the expression.
                        End If
                        cArray = result.ToCharArray() 'Update the character array.
                    Loop
                End If
            Case Operations.Multiplication And Operations.Division 'Both multiplication and division get processed the same.
                If result.Contains("/") Then
                    Do While result.Contains("/")
                        Dim constants(1) As String
                        Dim t As Double = 0 'Total

                        For i As Int32 = result.IndexOf("/")-1 To 0 Step -1
                            If Char.IsNumber(cArray(i)) Then
                                constants(0) = cArray(i).ToString & constants(0)
                            Else
                                Exit For
                            End If
                        Next
                        For i As Int32 = result.IndexOf("/")+1 To cArray.Length-1
                            If Char.IsNumber(cArray(i)) Then
                                constants(1) = constants(1) & cArray(i).ToString
                            Else
                                Exit For
                            End If
                        Next

                        t = Convert.ToDouble(constants(0))/Convert.ToDouble(constants(1))

                        result = result.Replace(constants(0) & "/" & constants(1), t.ToString())
                        cArray = result.ToCharArray()
                    Loop
                End If
                If result.Contains("*") Then
                    Do While result.Contains("*")
                        Dim constants(1) As String
                        Dim t As Double = 0 'Total

                        For i As Int32 = result.IndexOf("*")-1 To 0 Step -1
                            If Char.IsNumber(cArray(i)) Then
                                constants(0) = cArray(i).ToString & constants(0)
                            Else
                                Exit For
                            End If
                        Next
                        For i As Int32 = result.IndexOf("*")+1 To cArray.Length-1
                            If Char.IsNumber(cArray(i)) Then
                                constants(1) = constants(1) & cArray(i).ToString
                            Else
                                Exit For
                            End If
                        Next

                        t = Convert.ToDouble(constants(0))*Convert.ToDouble(constants(1))

                        result = result.Replace(constants(0) & "*" & constants(1), t.ToString())
                        cArray = result.ToCharArray()
                    Loop
                End If
            Case Operations.Addition And Operations.Subtraction 'Addition and subtraction must be processed at the same time.
                If result.Contains("+") Or result.Contains("-") Then
                    Dim constants() As String
                    Dim t As Double = 0 'Total.

                    'Fix any double operators we may have left over.
                    If result.Contains("+-") Then result = result.Replace("+-", "-")
                    If result.Contains("-+") Then result = result.Replace("-+", "-")
                    If result.Contains("++") Then result = result.Replace("++", "+")
                    If result.Contains("--") Then result = result.Replace("--", "+")
                    'Add in the seperator at every operand.
                    result = result.Replace("+", " +")
                    result = result.Replace("-", " -")
                    'Split the result to obtain all constants.
                    constants = result.Split(" "C)

                    For i As Int32 = 0 to constants.Length-1
                        If constants(i) <> vbNullString Then
                            t = t + Convert.ToDouble(constants(i))
                        End If
                    Next

                    result = t.ToString()
                End If
        End Select

        Return result
    End Function
End Class
