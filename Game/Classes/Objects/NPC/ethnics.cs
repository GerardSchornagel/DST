using System;

/// <summary>
/// Creates a Ethnic database with individuals.
/// </summary>
public class ethnics
{
    public individual[] individualDatabase;
    string[] stringEthnics;
    
    public ethnics()
    {
        //Check for quantity data\customer-Folder.
        stringEthnics = System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory() + (char)92 + "data" + (char)92 + "customers", "*", System.IO.SearchOption.TopDirectoryOnly);
        int intCount = (System.IO.Directory.GetCurrentDirectory() + (char)92 + "data" + (char)92 + "customers" + (char)92).Length;
        for (int i = 0; i <= stringEthnics.GetUpperBound(0); i++) {
            stringEthnics[i] = stringEthnics[i].Substring(intCount);
        }
        
        //ReDim individualDatabase accordingly.
        individualDatabase = new individual[stringEthnics.GetUpperBound(0) + 1];
        //Load all individual's
        for (int i = 0; individualDatabase.GetUpperBound(0) >= i; i++) {
            
            individualDatabase[i] = new individual(stringEthnics[i]);
            individualDatabase[i].Randomize();
        }
    }
}