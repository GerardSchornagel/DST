using System;

/// <summary>
/// Creates a individual with Ethnic, Gender, Name, Age, Money & Desire.
/// First load Ethnic into it sand then use through ReturnRandom()
/// </summary>
public class individual
{
    public string SettingRequest;
    iniHandler iniFilehandler = new iniHandler();
    Random randomGenerator = new Random();
    
    int integerRandomMin;
    int integerRandomMax;

    string[,] stringDetails;
    string[] stringNamelistM;
    string[] stringNamelistF;
    string stringEthnic;
    string[] stringRandom = new string[5];
    
    /// <summary>
    /// Loads all the data of the specified Ethnic.
    /// </summary>
    /// <param name="pathEthnic">Full path of chosen Ethnic.</param>
    public void Load(string pathEthnic)
    {
        //Set current Ethnic Variable to memory
        string[] stringConversion = pathEthnic.Split((char)92);
        stringEthnic = stringConversion[stringConversion.GetUpperBound(0)];
        //Fill stringDetails with pathEthnic
        stringDetails = iniFilehandler.Load(pathEthnic + "\\details.ini");
        //Fill stringNamelistM with pathEthnic
        stringNamelistM = LoadNamelist(pathEthnic + "\\NamelistM.nld");
        //Fill stringNamelistF with pathEthnic
        stringNamelistF = LoadNamelist(pathEthnic + "\\NamelistF.nld");
    }
    
    /// <summary>
    /// Loads a namelist according to set Ethnic and Gender.
    /// </summary>
    /// <param name="pathNamelist">complete path with file.</param>
    /// <returns>String() with single name per dimension.</returns>
    private string[] LoadNamelist(string pathNamelist)
    {
        string[] stringMediator = null;
        string stringStream = "";
        using (System.IO.StreamReader streamReader = new System.IO.StreamReader(pathNamelist)) {
            stringStream = streamReader.ReadToEnd();
        }

        stringMediator = stringStream.Split((char)10);
        int integerMediator = 0;
        foreach (string line in stringMediator) {
            if (string.IsNullOrEmpty(stringMediator[integerMediator])) {
                integerMediator += 1;
                continue;
            }
            stringMediator[integerMediator] = line.Remove(line.Length - 1, 1);
            integerMediator += 1;
        }
        return stringMediator;
    }
    
    /// <summary>
    /// Gets or Sets an Individual, empty variable's will be random according to [Ethnic]\details.ini.
    /// (Name, Gender, Age, Money, Desire) as String(4)
    /// </summary>
    public string[] ToStrings {
        get {
            //Gender based on WikiPedia (101M on 100F)
            if (string.IsNullOrEmpty(stringRandom[1])) {
                if (randomGenerator.Next(2010) <= 1000)
                    stringRandom[1] = "F";
            } else {
                stringRandom[1] = "M";
            }
            //Age
            if (string.IsNullOrEmpty(stringRandom[2])) {
                SettingRequest = "AgeMinimum";
                integerRandomMin = Convert.ToInt32(ReturnValue);
                SettingRequest = "AgeMaximum";
                integerRandomMax = Convert.ToInt32(ReturnValue);
                stringRandom[2] = Convert.ToString(randomGenerator.Next(integerRandomMin, integerRandomMax));
            }
            //Money
            if (string.IsNullOrEmpty(stringRandom[3])) {
                SettingRequest = "MoneyMinimum";
                integerRandomMin = Convert.ToInt32(ReturnValue);
                SettingRequest = "MoneyMaximum";
                integerRandomMax = Convert.ToInt32(ReturnValue);
                stringRandom[3] = Convert.ToString(randomGenerator.Next(integerRandomMin, integerRandomMax));
            }
            //Desire
            if (string.IsNullOrEmpty(stringRandom[4])) {
                SettingRequest = "DesireMinimum";
                integerRandomMin = Convert.ToInt32(ReturnValue);
                SettingRequest = "DesireMaximum";
                integerRandomMax = Convert.ToInt32(ReturnValue);
                stringRandom[4] = Convert.ToString(randomGenerator.Next(integerRandomMin, integerRandomMax));
            }
            //Name
            if (string.IsNullOrEmpty(stringRandom[0])) {
                if (stringRandom[1] == "M")
                    stringRandom[0] = stringNamelistM[randomGenerator.Next(stringNamelistM.GetUpperBound(0))];
            } else {
                stringRandom[0] = stringNamelistF[randomGenerator.Next(stringNamelistF.GetUpperBound(0))];
            }

            return stringRandom;
        }
        //Set all info from Value()
        set { stringRandom = value; }
    }
    
    /// <summary>
    /// Searches in stringDetails for requested Setting and set/returns that value.
    /// </summary>
    /// <returns></returns>
    public string ReturnValue {
        get {
            int integerColumn = 0;
            int integerRow = 0;
            do {
                do {
                    if (stringDetails[integerColumn, integerRow].Contains(SettingRequest)) {
                        return stringDetails[integerColumn, integerRow + 1];
                    }
                    integerRow += 1;
                } while (!(integerRow > stringDetails.GetUpperBound(1)));
                integerColumn += 1;
            } while (!(integerColumn > stringDetails.GetUpperBound(0)));
            return "";
        }
    }

    public string Ethnic {
        get { return stringEthnic; }
    }
}