using Microsoft.VisualBasic;
using System;

/// <summary>
/// For data to file Conversion.
/// </summary>
public class binaryFileHandler
{
    private string stringStream;
    private string stringLine;
    private string[] stringRow;
    private string[,] stringTable;

    private int integerRawCounter;
    private int integerRowCounter;
    private int integerColumnCounter;

    /// <summary>
    /// Initialize class.
    /// </summary>
    public binaryFileHandler()
    {

    }

    /// <summary>
    /// Save input to file on given location.
    /// </summary>
    /// <param name="path">Complete path with ending slash.</param>
    /// <param name="file">Complete with extension.</param>
    /// <param name="line">Use with one-liners.</param>
    /// <param name="row">Simple array's.</param>
    /// <param name="table">2D array's.</param>
    /// <param name="bound">Bound index for 2D array's.</param>
    public void Save(string path, string file, string line = null, string[] row = null, string[,] table = null, int bound = 0)
    {
        //Make directory
        System.IO.Directory.CreateDirectory(path);
        //Preparing input for binaryWriter
        stringStream = "";
        if (line != null) {
            stringStream = line;

        } else if (row != null) {
            do {
                stringStream += "<>" + Convert.ToString(row[integerRowCounter]);
                integerRowCounter += 1;
            } while (!(integerRowCounter > row.GetUpperBound(0)));
            stringStream = stringStream.Remove(0, 2);

        } else if (table != null) {
            integerRowCounter = 0;
            integerColumnCounter = 0;
            integerRawCounter = 0;
            do {
                do {
                    stringStream += "<>" + Convert.ToString(table[integerColumnCounter, integerRowCounter]);
                    integerRowCounter += 1;
                } while (!(integerRowCounter > bound));
                integerRowCounter = 0;
                integerColumnCounter += 1;
            } while (!(integerColumnCounter > table.GetUpperBound(0)));
            stringStream = stringStream.Remove(0, 2);
        }

        //Fill Array for character per character progressing
        Int32[] int32Stream = new Int32[stringStream.Length + 1];
        integerRowCounter = 0;
        foreach (char character in stringStream) {
            int32Stream[integerRowCounter] = Strings.Asc(character);
            integerRowCounter += 1;
        }
        //Use BinaryWriter with the int32Stream to write to path & file.
        using (System.IO.BinaryWriter binWriter = new System.IO.BinaryWriter(System.IO.File.Open(path + "\\" + file, System.IO.FileMode.Create))) {
            foreach (Int32 integer32 in int32Stream) {
                binWriter.Write(integer32);
            }
        }
        //Resetting variables
        stringLine = null;
        stringRow = null;
        stringTable = null;
        stringStream = "";
        integerRowCounter = 0;
        integerColumnCounter = 0;
        int32Stream = null;
    }

    /// <summary>
    /// Load given file to String.
    /// </summary>
    /// <param name="path">Complete path with ending slash.</param>
    /// <param name="file">Complete with extension.</param>
    /// <returns>One-line String.</returns>
    public string LoadLine(string path, string file)
    {
        stringStream = "";
        //Check for existing file.
        if (System.IO.File.Exists(path + file)) {
        } else {
            Interaction.MsgBox(path + file + " doesn't exist..." + (char)10 + "Aborting current load, going to next command.");
            return null;
        }
        //Get all info from File to String.
        using (System.IO.BinaryReader binReader = new System.IO.BinaryReader(System.IO.File.Open(path + file, System.IO.FileMode.Open))) {
            
            int pos = 0;
            int length = (int)binReader.BaseStream.Length;
            while (pos < length) {
                stringStream += char.ConvertFromUtf32(binReader.ReadInt32());
                // Advance our position variable.
                pos += sizeof(int);
            }
        }
        return stringStream;
    }
    
    /// <summary>
    /// Load given file to String().
    /// </summary>
    /// <param name="path">Complete path with ending slash.</param>
    /// <param name="file">Complete with extension.</param>
    /// <returns>1D String array.</returns>
    public string[] LoadRow(string path, string file)
    {
        //Resetting variable
        stringStream = "";
        stringRow = null;

        //Check for existing file.
        if (System.IO.File.Exists(path + file)) {
        } else {
            Interaction.MsgBox(path + file + " doesn't exist..." + (char)10 + "Aborting current load, going to next command.");
            return null;
        }

        //Get all info from File to String.
        using (System.IO.BinaryReader binReader = new System.IO.BinaryReader(System.IO.File.Open(path + file, System.IO.FileMode.Open))) {
            int pos = 0;
            int length = (int)binReader.BaseStream.Length;
            while (pos < length) {
                stringStream += char.ConvertFromUtf32(binReader.ReadInt32());
                // Advance our position variable.
                pos += sizeof(int);
            }
        }
        //Split raw data in String-Array
        stringRow = stringStream.Split(new string[] { "<>" }, StringSplitOptions.None);
        return stringRow;
    }

    /// <summary>
    /// Load given file to String(,)
    /// </summary>
    /// <param name="path">Complete path with ending slash.</param>
    /// <param name="file">Complete with extension.</param>
    /// <param name="bound">Used to determine second bound.</param>
    /// <returns>2D String array.</returns>
    public string[,] LoadTable(string path, string file, int bound)
    {
        //Resetting variable
        stringStream = "";
        stringRow = null;
        stringTable = null;
        integerRowCounter = 0;
        integerColumnCounter = 0;
        integerRawCounter = 0;

        //Check for existing file.
        if (System.IO.File.Exists(path + file)) {
        } else {
            Interaction.MsgBox(path + file + " doesn't exist..." + (char)10 + "Aborting current load, going to next command.");
            return null;
        }

        //Get all info from File to String.
        using (System.IO.BinaryReader binReader = new System.IO.BinaryReader(System.IO.File.Open(path + file, System.IO.FileMode.Open))) {
            int pos = 0;
            int length = (int)binReader.BaseStream.Length;
            while (pos < length) {
                stringStream += char.ConvertFromUtf32(binReader.ReadInt32());
                // Advance our position variable.
                pos += sizeof(int);
            }
        }

        //Split raw data in String-Array
        stringRow = stringStream.Split(new string[] { "<>" }, StringSplitOptions.None);
        stringTable = new string[Convert.ToInt32(((stringRow.GetUpperBound(0) + 1) / (bound + 1)) - 1) + 1, bound + 1];
        do {
            do {
                stringTable[integerColumnCounter, integerRowCounter] = stringRow[integerRawCounter];
                integerRawCounter += 1;
                integerRowCounter += 1;
            } while (!(integerRowCounter > bound));
            integerColumnCounter += 1;
            integerRowCounter = 0;
        } while (!(integerColumnCounter > stringTable.GetUpperBound(0)));
        return stringTable;
    }
}