using System;

/// <summary>
/// All Character Profile Variables are retrieved/stored here.
/// </summary>
public class characterProfile
{
    public string InformationRequest;
    iniHandler iniFileHandler = new iniHandler();
    string[,] stringCharacterData;

    /// <summary>
    /// Creates a new Character file.
    /// </summary>
    internal void NewCharacterProfile(string[] CharacterInfo)
    {
        stringCharacterData = new string[,] {
            { "[Character Profile]", "" },
            { "<World>", "0" },
            { "<Country>", "0" },
            { "<Place>", "0" },
            { "<Store>", "0" },
            { "<CreateDate>", CharacterInfo[0] },
            { "<CreateTime>", CharacterInfo[1] }
        };

        //Start Writing New Profile
        SaveState();
    }
    
    /// <summary>
    /// Loads a Profile Statistics.
    /// </summary>
    internal void LoadCharacterProfile()
    {
        stringCharacterData = iniFileHandler.Load(System.IO.Directory.GetCurrentDirectory() + "\\save\\" + gamecache.currentSettings.LastProfile + "\\character\\profile.ini");
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
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\save\\" + gamecache.currentSettings.LastProfile + "\\character");
        iniFileHandler.Save(System.IO.Directory.GetCurrentDirectory() + "\\save\\" + gamecache.currentSettings.LastProfile + "\\character\\profile.ini", stringCharacterData);
    }
    
    /// <summary>
    /// Returns a String with the current World.
    /// </summary>
    public string CurrentWorld {
        get {
            InformationRequest = "World";
            return ReturnValue;
        }
        set {
            InformationRequest = "World";
            ReturnValue = value;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns a String with the current Country.
    /// </summary>
    public string CurrentCountry {
        get {
            InformationRequest = "Country";
            return ReturnValue;
        }
        set {
            InformationRequest = "Country";
            ReturnValue = value;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns a String with the current Place.
    /// </summary>
    public string CurrentPlace {
        get {
            InformationRequest = "Place";
            return ReturnValue;
        }
        set {
            InformationRequest = "Place";
            ReturnValue = value;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns a String with the current Store.
    /// </summary>
    public string CurrentStore {
        get {
            InformationRequest = "Store";
            return ReturnValue;
        }
        set {
            InformationRequest = "Store";

            ReturnValue = value;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns a String with the Created Date.
    /// </summary>
    public string CreateDate {
        get {
            InformationRequest = "CreateDate";
            return ReturnValue;
        }
        set {
            InformationRequest = "CreateDate";
            ReturnValue = value;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns a String with the Created Time.
    /// </summary>
    public string CreateTime {
        get {
            InformationRequest = "CreateTime";
            return ReturnValue;
        }
        set {
            InformationRequest = "CreateTime";
            ReturnValue = value;
            SaveState();
        }
    }
}