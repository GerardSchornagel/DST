using System;

/// <summary>
/// Creates a Customer database with individuals for storing all Ehtnics.
/// </summary>
public class customer
{
    individual[] individualDatabase;
    individual individualCurrent;
    public string stringEthnic;
    public string SettingRequest;
    public string stringCurrent;
    
    public customer()
    {
        //Check for quantity data\customer-Folder.
        string[] stringEthnics = System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory() + "\\data\\customer\\", "*", System.IO.SearchOption.TopDirectoryOnly);
        //ReDim individualDatabase accordingly.
        individualDatabase = new individual[stringEthnics.GetUpperBound(0) + 1];
        //Load all individual's
        int integerCounter = 0;
        foreach (string line in stringEthnics) {
            individualDatabase[integerCounter] = new individual();
            individualDatabase[integerCounter].Load(line);
            integerCounter += 1;
        }
    }

    //Make Function for choosing Random & Specified Ethic-individual.
    /// <summary>
    /// Gets the current Individual. Empty Parameters will be random.
    /// (Ethnic, Name, Gender, Age, Money, Desire) as String(5)
    /// </summary>
    public string[] GetCurrentCustomer {
        //test for correct output.
        get { return new string[] {
                stringCurrent,
                individualCurrent.ToStrings[0],
                individualCurrent.ToStrings[1],
                individualCurrent.ToStrings[2],
                individualCurrent.ToStrings[3],
                individualCurrent.ToStrings[4]
            }; }
        set {
            string[] stringCurrentCustomer = new string[5];
            Random randomGenerator = new Random();
            string stringEthnic = null;
            if (value[0] != null) {
                stringEthnic = individualDatabase[randomGenerator.Next(individualDatabase.GetUpperBound(0))].Ethnic;
            } else {
                stringEthnic = value[0];
                individualCurrent = new individual();
                individualCurrent.Load(System.IO.Directory.GetCurrentDirectory() + "\\data\\customer\\" + stringEthnic);
                stringCurrentCustomer[0] = value[1];
                stringCurrentCustomer[1] = value[2];
                stringCurrentCustomer[2] = value[3];
                stringCurrentCustomer[3] = value[4];
                stringCurrentCustomer[4] = value[5];
                individualCurrent.ToStrings = stringCurrentCustomer;
            }
        }
    }

    public string ReturnValue {
        get {
            foreach (individual guest in individualDatabase) {
                if (guest.Ethnic.ToLower() == stringEthnic.ToLower()) {
                    guest.SettingRequest = SettingRequest;
                    return guest.ReturnValue;
                }
            }
            return null;
        }
    }
}