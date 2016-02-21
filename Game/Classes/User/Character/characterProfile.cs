using System;

/// <summary>
/// All Character Profile Variables are retrieved/stored here.
/// </summary>
public class characterProfile
{
    public string InformationRequest;
    private iniHandler iniFileHandler = new iniHandler();
    string[,] stringCharacterData;

    /// <summary>
    /// Retrieves Character Variables.
    /// </summary>
    internal characterProfile()
    {

    }
    
    /// <summary>
    /// Creates a new Character file.
    /// </summary>
    internal void NewCharacterProfile(string[] CharacterInfo)
    {
        stringCharacterData = new string[ +1, +1] { {
                "[Character Profile]",
                "<World>",
                "0",
                "<Country>",
                "0",
                "<Place>",
                "0",
                "<Store>",
                "0",
                "<CreateDate>",
                CharacterInfo(0),
                "<CreateTime>",
                CharacterInfo(1)
            }
        };
        //Start Writing New Profile
        SaveState();
    }
    
    /// <summary>
    /// Loads a Profile Statistics.
    /// </summary>
    internal void LoadCharacterProfile()
    {
        stringCharacterData = iniFileHandler.Load(System.IO.Directory.GetCurrentDirectory + "\\save\\" + gamecache.currentSettings.LastProfile + "\\character\\profile.ini");
    }
    
    /// <summary>
    /// Searches in stringCharacterData for requested Setting and set/returns that value.
    /// </summary>
    /// <returns></returns>
    public string ReturnValue {
        get {
            int integerColumn = 0;
            int integerRow = 0;
            do {
                do {
                    if (stringCharacterData[integerColumn, integerRow].Contains(InformationRequest)) {
                        return stringCharacterData[integerColumn, integerRow + 1];
                    }
                    integerRow += 1;
                } while (!(integerRow > stringCharacterData.GetUpperBound(1)));
                integerColumn += 1;
            } while (!(integerColumn > stringCharacterData.GetUpperBound(0)));
            return "";
        }

        set {
            int integerColumn = 0;
            int integerRow = 0;
            do {
                do {
                    if (stringCharacterData[integerColumn, integerRow].Contains(InformationRequest)) {
                        stringCharacterData[integerColumn, integerRow + 1] = value;
                        SaveState();
                        return;
                    }
                    integerRow += 1;
                } while (!(integerRow > stringCharacterData.GetUpperBound(1)));
                integerColumn += 1;
            } while (!(integerColumn > stringCharacterData.GetUpperBound(0)));
        }
    }
    
    /// <summary>
    /// Saves the current state of the Profile Statistics data.
    /// </summary>
    public void SaveState()
    {
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\\save\\" + gamecache.currentSettings.LastProfile + "\\character");
        iniFileHandler.Save(System.IO.Directory.GetCurrentDirectory + "\\save\\" + gamecache.currentSettings.LastProfile + "\\character\\profile.ini", stringCharacterData);
    }
    
    /// <summary>
    /// Returns a String with the current World.
    /// </summary>
    public string CurrentWorld {
        get { return ReturnValue["World"].ToString; }
        set {
            ReturnValue["World"] = value.ToString;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns a String with the current Country.
    /// </summary>
    public string CurrentCountry {
        get { return ReturnValue["Country"].ToString; }
        set {
            ReturnValue["Country"] = value.ToString;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns a String with the current Place.
    /// </summary>
    public string CurrentPlace {
        get { return ReturnValue["Place"].ToString; }
        set {
            ReturnValue["Place"] = value.ToString;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns a String with the current Store.
    /// </summary>
    public string CurrentStore {
        get { return ReturnValue["Store"].ToString; }
        set {
            ReturnValue["Store"] = value.ToString;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns a String with the Created Date.
    /// </summary>
    public string CreateDate {
        get { return ReturnValue["CreateDate"].ToString; }
        set {
            ReturnValue["CreateDate"] = value.ToString;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns a String with the Created Time.
    /// </summary>
    public string CreateTime {
        get { return ReturnValue["CreateTime"].ToString; }
        set {
            ReturnValue["CreateTime"] = value.ToString;
            SaveState();
        }
    }
}