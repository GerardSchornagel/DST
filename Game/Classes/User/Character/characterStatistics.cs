using System;

/// <summary>
/// All Character Statistics Variables are retrieved/stored here.
/// </summary>
public class characterStatistics
{
    public string InformationRequest;
    iniHandler iniFileHandler = new iniHandler();
    string[,] stringCharacterData;

    /// <summary>
    /// Creates a new Character file.
    /// </summary>
    internal void NewCharacterStatistics()
    {
        stringCharacterData = new string[,] {
            { "[Character Statistics]", "" },
            { "<Balance>", "25" },
            { "<TotalSpendings>", "0" },
            { "<TotalEarnings>", "0" },
            { "<TotalItemsSold>", "0" },
            { "<TotalItemsBought>", "0" },
            { "<TotalDayCycles>", "0" },
            { "<TotalPlayTime>", "0" }
        };
        //Start Writing New Profile
        SaveState();
    }

    /// <summary>
    /// Loads a Profile Statistics.
    /// </summary>
    internal void LoadCharacterStatistics()
    {
        stringCharacterData = iniFileHandler.Load(System.IO.Directory.GetCurrentDirectory() + "\\save\\" + gamecache.currentSettings.LastProfile + "\\character\\statistics.ini");
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
        iniFileHandler.Save(System.IO.Directory.GetCurrentDirectory() + "\\save\\" + gamecache.currentSettings.LastProfile + "\\character\\statistics.ini", stringCharacterData);
    }

    /// <summary>
    /// Returns an Integer with the current balance.
    /// </summary>
    public int Balance {
        get {
            InformationRequest = "Balance";
            return Convert.ToInt32(ReturnValue);
        }
        set {
            InformationRequest = "Balance";
            ReturnValue = value.ToString();
            SaveState();
        }
    }

    /// <summary>
    /// Returns an Integer with the Total Spendings.
    /// </summary>
    public int TotalSpendings {
        get {
            InformationRequest = "TotalSpendings";
            return Convert.ToInt32(ReturnValue);
        }
        set {
            InformationRequest = "TotalSpendings";
            ReturnValue = value.ToString();
            SaveState();
        }
    }

    /// <summary>
    /// Returns an Integer with the Total Earnings.
    /// </summary>
    public int TotalEarnings {
        get {
            InformationRequest = "TotalEarnings";
            return Convert.ToInt32(ReturnValue);
        }
        set {
            InformationRequest = "TotalEarnings";
            ReturnValue = value.ToString();
            SaveState();
        }
    }

    /// <summary>
    /// Returns an Integer with the Total Items Sold.
    /// </summary>
    public int TotalItemsSold {
        get {
            InformationRequest = "TotalItemsSold";
            return Convert.ToInt32(ReturnValue);
        }
        set {
            InformationRequest = "TotalItemsSold";
            ReturnValue = value.ToString();
            SaveState();
        }
    }

    /// <summary>
    /// Returns an Integer with the Total Items Bought.
    /// </summary>
    public int TotalItemsBought {
        get {
            InformationRequest = "TotalItemsBought";
            return Convert.ToInt32(ReturnValue);
        }
        set {
            InformationRequest = "TotalItemsBought";
            ReturnValue = value.ToString();
            SaveState();
        }
    }

    /// <summary>
    /// Returns an Integer with the current Total Day-Cycles.
    /// </summary>
    public int TotalDayCycles {
        get {
            InformationRequest = "TotalDayCycles";
            return Convert.ToInt32(ReturnValue);
        }
        set {
            InformationRequest = "TotalDayCycles";
            ReturnValue = value.ToString();
            SaveState();
        }
    }

    /// <summary>
    /// Returns an Integer with the Total Play-Time.
    /// </summary>
    public int TotalPlayTime {
        get {
            InformationRequest = "TotalPlayTime";
            return Convert.ToInt32(ReturnValue);
        }
        set {
            InformationRequest = "TotalPlayTime";
            ReturnValue = value.ToString();
            SaveState();
        }
    }
}