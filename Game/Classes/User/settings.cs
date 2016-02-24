using System;

/// <summary>
/// Global Settings for the game, most will be handled from the Main Menu.
/// </summary>
public class settings
{
    public string SettingRequest;
    iniHandler iniFilehandler = new iniHandler();
    string[,] stringSettings;

    /// <summary>
    /// Makes a new Settings.ini in the Save directory.
    /// </summary>
    public void NewSettings()
    {
        stringSettings = new string[,] {
            { "[WarningMessages]", ""},
            {"<LastProfileID>","0"},
            {"<ProgramQuit>", "False"},
            {"<NewGameOverwrite>", "False"},
            {"<OptionsApplyRestart>", "False"}
        };
        SaveState();
    }

    /// <summary>
    /// Loads a Settings file.
    /// </summary>
    public void LoadSettings()
    {
        stringSettings = iniFilehandler.Load(System.IO.Directory.GetCurrentDirectory() + "\\save\\settings.ini");
    }

    /// <summary>
    /// Searches in stringSettings for requested Setting and set/returns that value.
    /// </summary>
    /// <returns></returns>
    public string ReturnValue {
        get {
            int integerColumn = 0;
            int integerRow = 0;
            do {
                do {
                    if (stringSettings[integerColumn, integerRow].Contains(SettingRequest)) {
                        return stringSettings[integerColumn, integerRow + 1];
                    }
                    integerRow += 1;
                } while (!(integerRow > stringSettings.GetUpperBound(1)));
                integerColumn += 1;
            } while (!(integerColumn > stringSettings.GetUpperBound(0)));
            return "";
        }

        set {
            int integerColumn = 0;
            int integerRow = 0;
            do {
                do {
                    if (stringSettings[integerColumn, integerRow].Contains(SettingRequest)) {
                        stringSettings[integerColumn, integerRow + 1] = value;
                        SaveState();
                        return;
                    }
                    integerRow += 1;
                } while (!(integerRow > stringSettings.GetUpperBound(1)));
                integerColumn += 1;
            } while (!(integerColumn > stringSettings.GetUpperBound(0)));
        }
    }

    /// <summary>
    /// Saves all changes made to Global Settings.
    /// </summary>
    private void SaveState()
    {
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\save\\");
        iniFilehandler.Save(System.IO.Directory.GetCurrentDirectory() + "\\save\\settings.ini", stringSettings);
    }

    /// <summary>
    /// A String representing the last Profile that has played, it is corresponding with the number in the save directory.
    /// </summary>
    public string LastProfile {
        get { SettingRequest = "LastProfileID"; return ReturnValue; }
        set { SettingRequest = "LastProfileID";
            ReturnValue = value;
            SaveState();
        }
    }
    
    /// <summary>
    /// The warning message when quitting the program.
    /// </summary>
    public bool MessagesProgramQuit {
        get { SettingRequest = "ProgramQuit"; return Convert.ToBoolean(ReturnValue); }
        set { SettingRequest = "ProgramQuit";
            ReturnValue = value.ToString();
            SaveState();
        }
    }
    
    /// <summary>
    /// Warning message that the last Profile ID will be overwritten, in Alpha stage this means you lose your prev. game.
    /// </summary>
    public bool MessagesNewgameOverwrite {
        get { SettingRequest = "NewGameOverwrite"; return Convert.ToBoolean(ReturnValue); }
        set { SettingRequest = "NewGameOverwrite";
            ReturnValue = value.ToString();
            SaveState();
        }
    }
    
    /// <summary>
    /// Message if there are options are choosen via the main menu, the program has to be restarted.
    /// </summary>
    public bool MessagesOptionsApplyRestart {
        get { SettingRequest = "OptionsApplyRestart"; return Convert.ToBoolean(ReturnValue); }
        set { SettingRequest = "OptionsApplyRestart";
            ReturnValue = value.ToString();
            SaveState();
        }
    }
}