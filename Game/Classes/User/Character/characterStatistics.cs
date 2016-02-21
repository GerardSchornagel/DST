using System;

/// <summary>
/// All Character Statistics Variables are retrieved/stored here.
/// </summary>
public class characterStatistics
{
    public string InformationRequest;
    private iniHandler iniFileHandler = new iniHandler();
    string[,] stringCharacterData;

    /// <summary>
    /// Retrieves Character Variables.
    /// </summary>
    internal characterStatistics()
    {

    }

    /// <summary>
    /// Creates a new Character file.
    /// </summary>
    internal void NewCharacterStatistics()
    {
        stringCharacterData = new string[ +1, +1] { {
                "[Character Statistics]",
                "<Balance>",
                "25",
                "<TotalSpendings>",
                "0",
                "<TotalEarnings>",
                "0",
                "<TotalItemsSold>",
                "0",
                "<TotalItemsBought>",
                "0",
                "<TotalDayCycles>",
                "0",
                "<TotalPlayTime>",
                "0"
            }
        };
        //Start Writing New Profile
        SaveState();
    }

    /// <summary>
    /// Loads a Profile Statistics.
    /// </summary>
    internal void LoadCharacterStatistics()
    {
        stringCharacterData = iniFileHandler.Load(System.IO.Directory.GetCurrentDirectory + "\\save\\" + gamecache.currentSettings.LastProfile + "\\character\\statistics.ini");
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
        iniFileHandler.Save(System.IO.Directory.GetCurrentDirectory + "\\save\\" + gamecache.currentSettings.LastProfile + "\\character\\statistics.ini", stringCharacterData);
    }

    /// <summary>
    /// Returns an Integer with the current balance.
    /// </summary>
    public int Balance {
        get { return Convert.ToInt32(ReturnValue["Balance"]); }
        set {
            ReturnValue["Balance"] = value.ToString;
            SaveState();
        }
    }

    /// <summary>
    /// Returns an Integer with the Total Spendings.
    /// </summary>
    public int TotalSpendings {
        get { return Convert.ToInt32(ReturnValue["TotalSpendings"]); }
        set {
            ReturnValue["TotalSpendings"] = value.ToString;
            SaveState();
        }
    }

    /// <summary>
    /// Returns an Integer with the Total Earnings.
    /// </summary>
    public int TotalEarnings {
        get { return Convert.ToInt32(ReturnValue["TotalEarnings"]); }
        set {
            ReturnValue["TotalEarnings"] = value.ToString;
            SaveState();
        }
    }

    /// <summary>
    /// Returns an Integer with the Total Items Sold.
    /// </summary>
    public int TotalItemsSold {
        get { return Convert.ToInt32(ReturnValue["TotalItemsSold"]); }
        set {
            ReturnValue["TotalItemsSold"] = value.ToString;
            SaveState();
        }
    }

    /// <summary>
    /// Returns an Integer with the Total Items Bought.
    /// </summary>
    public int TotalItemsBought {
        get { return Convert.ToInt32(ReturnValue["TotalItemsBought"]); }
        set {
            ReturnValue["TotalItemsBought"] = value.ToString;
            SaveState();
        }
    }

    /// <summary>
    /// Returns an Integer with the current Total Day-Cycles.
    /// </summary>
    public int TotalDayCycles {
        get { return Convert.ToInt32(ReturnValue["TotalDayCycles"]); }
        set {
            ReturnValue["TotalDayCycles"] = value.ToString;
            SaveState();
        }
    }

    /// <summary>
    /// Returns an Integer with the Total Play-Time.
    /// </summary>
    public int TotalPlayTime {
        get { return Convert.ToInt32(ReturnValue["TotalPlayTime"]); }
        set {
            ReturnValue["TotalPlayTime"] = value.ToString;
            SaveState();
        }
    }
}