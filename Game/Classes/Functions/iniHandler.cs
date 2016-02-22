using System;

/// <summary>
/// Will write/read 2D string-array's to/from read-able .ini files.
/// </summary>
public class iniHandler
{
    private string stringIO;
    string[] stringMediator;
    string[,] stringOutput;

    private int integerColumn;
    private int integerRow;
    private int integerMediator;

    /// <summary>
    /// Saves a 2d string-array to directory and file.
    /// </summary>
    /// <param name="Pathname">Complete Path and File.</param>
    /// <param name="SavingFile">Input 2D string-array.</param>
    public void Save(string Pathname, string[,] SavingFile)
    {
        //Prepare variable's for new content.
        stringMediator = new string[(((SavingFile.GetUpperBound(0) + 1) * (SavingFile.GetUpperBound(1) + 1)) - 1) * 2 + 1];
        stringIO = "";
        integerColumn = 0;
        integerRow = 0;
        integerMediator = 0;

        //Loops all the Columns of the table.
        do {
            //Loops all the Row Items.
            do {
                //Just continue next row.
                if (string.IsNullOrEmpty(SavingFile[integerColumn, integerRow])) {
                    //Save the row item to the stringMediator
                } else {
                    stringMediator[integerMediator] = SavingFile[integerColumn, integerRow];
                    integerMediator += 1;
                }
                integerRow += 1;
            } while (!(integerRow > SavingFile.GetUpperBound(1)));
            //Prepare variable's for next Do for next Column.
            integerRow = 0;
            integerColumn += 1;
            stringMediator[integerMediator] = "";
            integerMediator += 1;
        } while (!(integerColumn > SavingFile.GetUpperBound(0)));

        //Add the Column max. bound to the file.
        if (SavingFile.GetUpperBound(0) > 9) {
            stringIO += SavingFile.GetUpperBound(0);
        } else {
            stringIO += "0" + SavingFile.GetUpperBound(0);
        }
        //Add the Row max. bound to the file.
        if (SavingFile.GetUpperBound(1) > 9) {
            stringIO += SavingFile.GetUpperBound(1);
        } else {
            stringIO += "0" + SavingFile.GetUpperBound(1);
        }
        //Loop through all stringMediator items and write as 1 string.
        integerMediator = 0;
        do {
            stringIO += stringMediator[integerMediator] + (char)13 + (char)10;
            integerMediator += 1;
        } while (!(integerMediator > stringMediator.GetUpperBound(0)));
        //REMOVE:stringIO.Remove(stringIO.Length - 2, 2) 'Remove last two Chr's
        //Use StringBuilder for writing
        System.Text.StringBuilder stringbuilderIO = new System.Text.StringBuilder();
        using (System.IO.StringReader streamreaderIO = new System.IO.StringReader(stringIO)) {
            stringbuilderIO.Append(streamreaderIO.ReadToEnd());
        }
        using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(Pathname, false, System.Text.Encoding.Default)) {
            streamWriter.Write(stringbuilderIO);
        }
    }

    /// <summary>
    /// Load an 2d string-array from a .ini file.
    /// </summary>
    /// <param name="Pathname">Complete Path and File.</param>
    /// <returns>Returns a 2D string-array.</returns>
    public string[,] Load(string Pathname)
    {
        stringIO = "";
        using (System.IO.StreamReader streamReader = new System.IO.StreamReader(Pathname)) {
            stringIO = streamReader.ReadToEnd();
        }

        stringOutput = new string[Convert.ToInt32(stringIO.Substring(0, 2)) + 1, Convert.ToInt32(stringIO.Substring(2, 2)) + 1];
        stringIO = stringIO.Remove(0, 4);

        stringMediator = stringIO.Split((char)10);
        integerMediator = 0;
        foreach (string line in stringMediator) {
            if (string.IsNullOrEmpty(stringMediator[integerMediator])) {
                integerMediator += 1;
                continue;
            }
            stringMediator[integerMediator] = line.Remove(line.Length - 1, 1);
            integerMediator += 1;
        }
        integerColumn = -1;
        integerRow = 0;
        integerMediator = 0;

        do {
            if (string.IsNullOrEmpty(stringMediator[integerMediator])) {
                integerMediator += 1;
                continue;
            } if (stringMediator[integerMediator].Substring(0, 1) == "[") {
                integerColumn += 1;
                integerRow = 0;
                stringOutput[integerColumn, integerRow] = stringMediator[integerMediator];
                integerRow += 1;
                integerMediator += 1;
            } else {
                stringOutput[integerColumn, integerRow] = stringMediator[integerMediator];
                integerMediator += 1;
                integerRow += 1;
            }

        } while (!(integerMediator > stringMediator.GetUpperBound(0)));
        return stringOutput;
    }
}