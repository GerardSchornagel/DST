using System;
//TODO: convert this functions to an object, so the settings can be stored in memory organised
//      instead of reopening every time or retrieving from loose variables.
/// <summary>
/// Will write/read 3-column string-array's to/from read-able .ini files.
/// Zero base is name, +1 is next dimension.
/// 0,0,0 = Category
/// 0,1,0 = Option
/// 0,1,1 = Value
/// </summary>
public class ioINI
{
    string stringIO;
    string stringConvert;
    string[] stringSplitted;
    //TODO: Make a piece of code to auto-increase (by steps?) array-size of Load.
    string[,,] stringLoad = new string[50, 25, 10];
    string[,,] stringSave;

    int intCategory;
    int intOption;
    int intValue;
    int intSplitted;
    int intRBound0;
    int[] intRBound1;
    
    /// <summary>
    /// Loads an .ini file to a 3-column array from the Game-directory (GetCurrentDirectory())
    /// </summary>
    /// <param name="path">Pathname in Game-directory without leading and trailing backslashes (ie. "data/customers")</param>
    /// <param name="file">Filename of ini-file with extension (ie. "profile.ini")</param>
    /// <returns>Returns a 3-column string-array.</returns>
    public string[,,] Load(string path, string file)
    {
        // Load ini file to single string.
        stringIO = null;
        using (System.IO.StreamReader streamReader = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + (char)92 + path + (char)92 + file)) {
            stringIO = streamReader.ReadToEnd();
        }

        //start bounds counter.
        //-count every "<" and reset with every "[" (<= also count). Compare current count with saved count and use higher.
        intRBound0 = 0;
        intRBound1 = new int[2]{ 0, 0 };
        foreach (char character in stringIO) {
            if (character == (char)91) { //(char)91 = [
                intRBound0++;
                if (intRBound1[0] >= intRBound1[1]) { intRBound1[1] = intRBound1[0];}
                intRBound1[0] = 0;
            }
            if (character == (char)60) { //(char)60 = <
                intRBound1[0] += 1;
            }
        }
        //initialize stringArray with bounds.
        if (intRBound1[0] >= intRBound1[1]) { intRBound1[1] = intRBound1[0];}
        stringLoad = new string[intRBound0, intRBound1[1] + 1, 2];
        //Split stringIO to stringSplitted, seperated by (char)10 (newline)
        stringSplitted = null;
        stringSplitted = stringIO.Split((char)10);
        //Split stringSplitted to stringLoad while qualifying.
        intCategory = -1; //intCategory has -1 due to effects of loop.
        intOption = 0;
        intValue = 0;
        // Take each string and qualify it as Category, Option or value and remove brackets and/or (char)13 (returncarriage)
        foreach (string line in stringSplitted) {
            // If empty line, goto next iteration.
            if (line == null || line == "\r" || line == "") {
                continue;
            }
            // ifelse Category, then place in [+1,0,0] & goto next iteration. (reset int option&value)
            if (line.Substring(0, 1) == "[") {
                intCategory++;
                //if (intCategory == -1) { intCategory = 0; }
                intOption = 0;
                intValue = 0;
                stringConvert = line.Split((char)91)[1]; //Take string after opening bracket "["
                stringConvert = stringConvert.Split((char)93)[0]; //Take data before closing bracket. "]"
                stringLoad[intCategory, 0, 0] = stringConvert;
                continue;
            }
            // ifelse Option, then place in [0,+1,0] & goto next iteration. (reset int value)
            if (line.Substring(0, 1) == "<") {
                intOption += 1;
                intValue = 0;
                stringConvert = line.Split((char)60)[1]; //Take string after opening angled bracket "<"
                stringConvert = stringConvert.Split((char)62)[0]; //Take data before closing angled bracket ">"
                stringLoad[intCategory, intOption, 0] = stringConvert;
                continue;
            }
            // else = Value, then place in [0,0,+1] & goto next iteration.
            intValue += 1;
            stringConvert = line.Split((char)13)[0]; //Take string before carriage return.
            stringLoad[intCategory, intOption, intValue] = stringConvert;

        }
        while ((intSplitted > stringSplitted.GetUpperBound(0)));

        // Reset variable's
        stringConvert = null;
        stringSplitted = null;
        stringIO = null;
        intCategory = 0;
        intOption = 0;
        intValue = 0;
        intSplitted = 0;

        // return whole ini as string[,,]
        return stringLoad;
    }

    /// <summary>
    /// Saves a 3-column string-array to directory and file.
    /// </summary>
    /// <param name="path">Path in Game-directory without leading and trailing backslash.</param>
    /// <param name="file">File name of ini file, with extension.</param>
    /// <param name="SavingFile">Input 2D string-array.</param>
    public void Save(string path, string file, string[,,] SavingFile)
    {
        //TODO TODO REMOVE EMPTY ENTRIES FROM SavingFile TODO TODO 
        // Change value given by caller - search for (C)ategory on [#,0,0] - (O)ption on [C,#,0] - value = [C,O,1]
        // Save to new ini file
        
        // loop all Category's and add brackets
        int intSFBound0 = SavingFile.GetUpperBound(0);
        int intSFBound1 = SavingFile.GetUpperBound(1);
        int intSFBound2 = SavingFile.GetUpperBound(2);
        stringSave = new string[intSFBound0 + 1, intSFBound1 + 1, intSFBound2 + 1];
        for (intCategory = 0; intCategory <= intSFBound0; intCategory++) {
            if (SavingFile[intCategory, 0, 0] == null) { continue; }
            stringSave[intCategory, 0, 0] = (char)91 + SavingFile[intCategory, 0, 0] + (char)93;
            // loop all Options and add angled bracket, while copying value too.
            for (intOption = 1; intOption <= intSFBound1; intOption++) {
                if (SavingFile[intCategory, intOption, 0] == null) { continue; }
                stringSave[intCategory, intOption, 0] = (char)60 + SavingFile[intCategory, intOption, 0] + (char)62;
                stringSave[intCategory, intOption, 1] = SavingFile[intCategory, intOption, 1];
            }
        }
        stringIO = "";
        // add all entry's to stringIO with foreach
        foreach (string line in stringSave) {
            if (line == null) { continue; }
            stringIO += line + (char)13 + (char)10;
        }
        stringIO = stringIO.Substring(0, (stringIO.Length - 2));
        
        // Use StringBuilder for writing
        System.Text.StringBuilder stringbuilderIO = new System.Text.StringBuilder();
        using (System.IO.StringReader streamreaderIO = new System.IO.StringReader(stringIO)) {
            stringbuilderIO.Append(streamreaderIO.ReadToEnd());
        }
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + (char)92 + path);
        using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + (char)92 + path + (char)92 + file, false, System.Text.Encoding.Default)) {
            streamWriter.Write(stringbuilderIO);
        }
    }
}