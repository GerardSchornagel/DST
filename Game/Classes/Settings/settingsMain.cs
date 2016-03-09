using System;

namespace Game.Classes.Settings
{
    /// <summary>
    /// Contains the settings affecting the Main Menu.
    /// </summary>
    public class settingsMain
    {
        string[,,] stringSettings = new string[1,5,2];
        ioINI iniSettings = new ioINI();
        int _LastUserID;
        bool _ExitConfirmation;
        bool _NewGameOverwrite;
        bool _RestartOnOptions;
        
        /// <summary>
        /// Initalization of settings Array and all Variable's.
        /// </summary>
        public settingsMain()
        {
            if (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + (char)92 + "save" + (char)92 + "settings" + (char)92 + "Main.ini")) {
                stringSettings = iniSettings.Load("save" + (char)92 + "settings", "Main.ini");
                _LastUserID = Convert.ToInt32(Retrieve("WarningMessages", "Last Used User ID"));
                _ExitConfirmation = Convert.ToBoolean(Retrieve("WarningMessages", "Confirmation on Exit"));
                _NewGameOverwrite = Convert.ToBoolean(Retrieve("WarningMessages", "Overwrite existing Profile on New Game"));
                _RestartOnOptions = Convert.ToBoolean(Retrieve("WarningMessages", "Advice Restart on Options change"));
            } else {
                stringSettings[0, 0, 0] = "WarningMessages";
                stringSettings[0, 1, 0] = "Last Used User ID";
                stringSettings[0, 1, 1] = "0";
                _LastUserID = 0;
                stringSettings[0, 2, 0] = "Confirmation on Exit";
                stringSettings[0, 2, 1] = "true";
                _ExitConfirmation = true;
                stringSettings[0, 3, 0] = "Overwrite existing Profile on New Game";
                stringSettings[0, 3, 1] = "true";
                _NewGameOverwrite = true;
                stringSettings[0, 4, 0] = "Advice Restart on Options change";
                stringSettings[0, 4, 1] = "true";
                _RestartOnOptions = true;
                settingsSave();
            }
        }
        
        /// <summary>
        /// Retrieve Value from given Category && Option.
        /// </summary>
        /// <param name="Category">Category as string.</param>
        /// <param name="Option">Option as string.</param>
        /// <returns>Single string with Value.</returns>
        string Retrieve(string Category, string Option)
        {
            for (int intC = 0; intC > stringSettings.GetUpperBound(0); intC++) {
                if (stringSettings[intC, 0, 0] == Category) {
                    for (int intO = 0; intO > stringSettings.GetUpperBound(1); intO++) {
                        if (stringSettings[intC, intO, 0] == Option) {
                            return stringSettings[intC, intO, 1];
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Change the Value of a Option in a given Category.
        /// </summary>
        /// <param name="Category">Category as string.</param>
        /// <param name="Option">Option as string.</param>
        /// <param name="Value">Value as string.</param>
        void Change(string Category, string Option, string Value)
        {
            for (int intC = 0; intC > stringSettings.GetUpperBound(0); intC++) {
                if (stringSettings[intC, 0, 0] == Category) {
                    for (int intO = 0; intO > stringSettings.GetUpperBound(1); intO++) {
                        if (stringSettings[intC, intO, 0] == Option) {
                            stringSettings[intC, intO, 1] = Value;
                        }
                    }
                }
            }
        }
        
        void settingsSave()
        {
            iniSettings.Save("save" + (char)92 + "settings", "Main.ini", stringSettings);
        }
        
        /// <summary>
        /// An int representing the last Profile that has played, it is corresponding with the number in the save directory.
        /// When set, it saves to file.
        /// </summary>
        public int LastUserID {
            get {
                return _LastUserID;
            }
            set {
                _LastUserID = value;
                Change("WarningMessages", "Last Used User ID", value.ToString());
                settingsSave();

            }
        }

        /// <summary>
        /// The warning message when quitting the program.
        /// When set, it saves to file.
        /// </summary>
        public bool ExitConfirmation {
            get {
                return _ExitConfirmation;
            }
            set {
                _ExitConfirmation = value;
                Change("WarningMessages", "Confirmation on Exit", value.ToString());
                settingsSave();
            }
        }
        
        /// <summary>
        /// Warning message that the last Profile ID will be overwritten, in Alpha stage this means you lose your prev. game.
        /// When set, it saves to file.
        /// </summary>
        public bool NewGameOverwrite {
            get {
                return _NewGameOverwrite;
            }
            set {
                _NewGameOverwrite = value;
                Change("WarningMessages", "Overwrite existing Profile on New Game", value.ToString());
                settingsSave();
            }
        }
        /// <summary>
        /// Message if there are options are choosen via the main menu, the program has to be restarted.
        /// When set, it saves to file.
        /// </summary>
        public bool RestartOnOptions {
            get {
                return _RestartOnOptions;
            }
            set {
                _RestartOnOptions = value;
                Change("WarningMessages", "Advice Restart on Options change", value.ToString());
                settingsSave();
            }
        }
    }
}