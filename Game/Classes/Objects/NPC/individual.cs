using System;

/// <summary>
/// 
/// </summary>
public class individual
{
    ioINI iniFilehandler = new ioINI();
    Random randomGenerator = new Random();
    
    string stringEthnic;
    string[,,] stringEthnicDetails;
    string[] stringEthnicNameMale;
    string[] stringEthnicNameFemale;

    string[] stringConvert;
    string stringIO = "";
    
    public string Gender { get; set; }
    public string Name { get; set; }
    public int AgeMinimum { get; set; }
    public int AgeMaximum { get; set; }
    public int AgeRandom { get; set; }
    public int MoneyMinimum { get; set; }
    public int MoneyMaximum { get; set; }
    public int MoneyRandom { get; set; }
    public int DesireMinimum { get; set; }
    public int DesireMaximum { get; set; }
    public int DesireRandom { get; set; }
    
    /// <summary>
    /// Loads all the data of the specified Ethnic.
    /// </summary>
    /// <param name="Ethnic">Chosen Ethnic.</param>
    public individual(string Ethnic)
    {
        //Set current Ethnic Variable to memory
        stringEthnic = Ethnic;
        //Fill stringDetails with pathEthnic
        stringEthnicDetails = iniFilehandler.Load("data" + (char)92 + "customers" + (char)92 + Ethnic, "details.ini");
        AgeMinimum = Convert.ToInt32(stringEthnicDetails[0, 1, 1]);
        AgeMaximum = Convert.ToInt32(stringEthnicDetails[0, 2, 1]);
        MoneyMinimum = Convert.ToInt32(stringEthnicDetails[0, 3, 1]);
        MoneyMaximum = Convert.ToInt32(stringEthnicDetails[0, 4, 1]);
        DesireMinimum = Convert.ToInt32(stringEthnicDetails[0, 5, 1]);
        DesireMaximum = Convert.ToInt32(stringEthnicDetails[0, 6, 1]);
        
        //Fill stringNamelistM with pathEthnic
        stringEthnicNameMale = LoadNamelist(System.IO.Directory.GetCurrentDirectory() + (char)92 + "data" + (char)92 + "customers" + (char)92 + Ethnic + (char)92 + "NamelistM.nld");
        //Fill stringNamelistF with pathEthnic
        stringEthnicNameFemale = LoadNamelist(System.IO.Directory.GetCurrentDirectory() + (char)92 + "data" + (char)92 + "customers" + (char)92 + Ethnic + (char)92 + "NamelistF.nld");
        
        Randomize();
    }
    
    /// <summary>
    /// Loads a namelist according to set Ethnic and Gender.
    /// </summary>
    /// <param name="pathNamelist">complete path with file.</param>
    /// <returns>string[] with single name per iteration.</returns>
    string[] LoadNamelist(string pathNamelist)
    {
        using (System.IO.StreamReader streamReader = new System.IO.StreamReader(pathNamelist)) {
            stringIO = streamReader.ReadToEnd();
        }

        stringConvert = stringIO.Split((char)10);
        for (int i = 0; stringConvert.GetUpperBound(0) > i; i++) {
            if (stringConvert[i].Length == 0) {
                continue;
            }
            stringConvert[i] = stringConvert[i].Split((char)13)[0];
        }
        return stringConvert;
    }
    
    public void Randomize() {
        //Gender based on WikiPedia (101M on 100F)
        if (randomGenerator.Next(2010) <= 1000) {
            Gender = "female";
        } else {
            Gender = "male";
        }
        //Age
        AgeRandom = randomGenerator.Next(AgeMinimum, AgeMaximum);
        //Money
        MoneyRandom = randomGenerator.Next(MoneyMinimum, MoneyMaximum);
        //Desire
        DesireRandom = randomGenerator.Next(DesireMinimum, DesireMaximum);
        //Name
        if (Gender == "male") {
            Name = stringEthnicNameMale[randomGenerator.Next(stringEthnicNameMale.GetUpperBound(0))];
        } else {
            Name = stringEthnicNameFemale[randomGenerator.Next(stringEthnicNameFemale.GetUpperBound(0))];
        }
    }
}