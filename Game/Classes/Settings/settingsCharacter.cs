using System;

namespace Game.Classes.Settings
{
    /// <summary>
    /// Contains the settings affecting the Character settings.
    /// </summary>
    public class settingsCharacter
    {
        string[,,] stringSettings;
        ioINI iniSettings = new ioINI();
        //Profile Data
        int _World;
        int _Country;
        int _Place;
        int _Store;
        string _CreateDate;
        string _CreateTime;
        //Statistics Data
        int _Balance;
        int _SpendingsTotal;
        int _EarningsTotal;
        int _ItemsSoldTotal;
        int _ItemsBoughtTotal;
        int _DayCyclesTotal;
        int _PlaytimeTotal;
        
        /// <summary>
        /// Initalization of settings Array and all Variable's.
        /// </summary>
        public settingsCharacter()
        {
            if (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + (char)92 + "save" + (char)92 + "settings" + (char)92 + "Character.ini")) {
                stringSettings = iniSettings.Load("save" + (char)92 + "settings", "Character.ini");
                //Profile Data
                _World = Convert.ToInt32(Retrieve("Profile", "Current World"));
                _Country = Convert.ToInt32(Retrieve("Profile", "Current Country"));
                _Place = Convert.ToInt32(Retrieve("Profile", "Current Place"));
                _Store = Convert.ToInt32(Retrieve("Profile", "Current Store"));
                _CreateDate = (string)Retrieve("Profile", "Date of creation");
                _CreateTime = (string)Retrieve("Profile", "Time of creation");
                //Statistics Data
                _Balance = Convert.ToInt32(Retrieve("Statistics", "Balance on Character."));
                _SpendingsTotal = Convert.ToInt32(Retrieve("Statistics", "Total Spendings"));
                _EarningsTotal = Convert.ToInt32(Retrieve("Statistics", "Total Earnings"));
                _ItemsSoldTotal = Convert.ToInt32(Retrieve("Statistics", "Total Items Sold"));
                _ItemsBoughtTotal = Convert.ToInt32(Retrieve("Statistics", "Total Items Bought"));
                _DayCyclesTotal = Convert.ToInt32(Retrieve("Statistics", "Total Day Cycles"));
                _PlaytimeTotal = Convert.ToInt32(Retrieve("Statistics", "Total Playtime"));
            } else {
                //Profile Data
                stringSettings = new string[2, 8, 2];
                stringSettings[0, 0, 0] = "Profile";
                stringSettings[0, 1, 0] = "Current World";
                stringSettings[0, 1, 1] = "0";
                _World = 0;
                stringSettings[0, 2, 0] = "Current Country";
                stringSettings[0, 2, 1] = "0";
                _Country = 0;
                stringSettings[0, 3, 0] = "Current Place";
                stringSettings[0, 3, 1] = "0";
                _Place = 0;
                stringSettings[0, 4, 0] = "Current Store";
                stringSettings[0, 4, 1] = "0";
                _Store = 0;
                stringSettings[0, 5, 0] = "Date of Creation";
                string stringDate = DateTime.Now.Date.Year + "-";
                if (stringDate.Length == 3) {
                    stringDate = "20" + stringDate;
                }
                stringDate += DateTime.Now.Date.Month + "-";
                if (stringDate.Length == 7) {
                    stringDate = stringDate.Insert(5, "0");
                }
                stringDate += DateTime.Now.Date.Day;
                if (stringDate.Length == 9) {
                    stringDate = stringDate.Insert(8, "0");
                }
                stringSettings[0, 5, 1] = stringDate;
                _CreateDate = stringSettings[0, 5, 1];
                stringSettings[0, 6, 0] = "Time of Creation";
                string stringTime = DateTime.Now.TimeOfDay.Hours + ":";
                if (stringTime.Length == 2) {
                    stringTime = "0" + stringTime;
                }
                stringTime += DateTime.Now.TimeOfDay.Minutes;
                if (stringTime.Length == 4) {
                    stringTime = stringTime.Insert(3, "0");
                }
                stringSettings[0, 6, 1] = stringTime;
                _CreateTime = stringSettings[0, 6, 1];

                
                //Statistics Data
                stringSettings[1, 0, 0] = "Statistics";
                stringSettings[1, 1, 0] = "Balance on Character";
                stringSettings[1, 1, 1] = "0";
                _Balance = 0;
                stringSettings[1, 2, 0] = "Total Spendings";
                stringSettings[1, 2, 1] = "0";
                _SpendingsTotal = 0;
                stringSettings[1, 3, 0] = "Total Earnings";
                stringSettings[1, 3, 1] = "0";
                _EarningsTotal = 0;
                stringSettings[1, 4, 0] = "Total Items Sold";
                stringSettings[1, 4, 1] = "0";
                _ItemsSoldTotal = 0;
                stringSettings[1, 5, 0] = "Total Items Bought";
                stringSettings[1, 5, 1] = "0";
                _ItemsBoughtTotal = 0;
                stringSettings[1, 6, 0] = "Total Day Cycles";
                stringSettings[1, 6, 1] = "0";
                _DayCyclesTotal = 0;
                stringSettings[1, 7, 0] = "Total Playtime";
                stringSettings[1, 7, 1] = "0";
                _PlaytimeTotal = 0;
                saveSettings();
            }
        }
        
        void saveSettings()
        {
            iniSettings.Save("save" + (char)92 + "settings", "Character.ini", stringSettings);
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

        /// <summary>
        /// An int of the current World.
        /// When set, it saves to file.
        /// </summary>
        public int World {
            get {
                return _World;
            }
            set {
                _World = value;
                Change("Profile", "Current World", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// An int of the Current Country.
        /// When set, it saves to file.
        /// </summary>
        public int Country {
            get {
                return _Country;
            }
            set {
                _Country = value;
                Change("Profile", "Current Country", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// An int of the current Place.
        /// When set, it saves to file.
        /// </summary>
        public int Place {
            get {
                return _Place;
            }
            set {
                _Place = value;
                Change("Profile", "Current Place", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// An int of the current Store.
        /// When set, it saves to file.
        /// </summary>
        public int Store {
            get {
                return _Store;
            }
            set {
                _Store = value;
                Change("Profile", "Current Store", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// A string with the creation Date of the Character.
        /// When set, it saves to file.
        /// </summary>
        public string CreateDate {
            get {
                return _CreateDate;
            }
            set {
                _CreateDate = value;
                Change("Profile", "Date of Creation", value);
                saveSettings();
            }
        }
        
        /// <summary>
        /// A string with the creation Time of the Character.
        /// When set, it saves to file.
        /// </summary>
        public string CreateTime {
            get {
                return _CreateTime;
            }
            set {
                _CreateTime = value;
                Change("Profile", "Time of Creation", value);
                saveSettings();
            }
        }

        /// <summary>
        /// An int with the current balance of the Character.
        /// When set, it saves to file.
        /// </summary>
        public int Balance {
            get {
                return _Balance;
            }
            set {
                _Balance = value;
                Change("Statistics", "Balance on Character", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// An int representing the total spendings of this Character.
        /// When set, it saves to file.
        /// </summary>
        public int SpendingsTotal {
            get {
                return _SpendingsTotal;
            }
            set {
                _SpendingsTotal = value;
                Change("Statistics", "Total Spendings", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// An int representing the total earnings of this Character.
        /// When set, it saves to file.
        /// </summary>
        public int EarningsTotal {
            get {
                return _EarningsTotal;
            }
            set {
                _EarningsTotal = value;
                Change("Statistics", "Total Earnings", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// An int representing the total items sold of this Character.
        /// When set, it saves to file.
        /// </summary>
        public int ItemsSoldTotal {
            get {
                return _ItemsSoldTotal;
            }
            set {
                _ItemsSoldTotal = value;
                Change("Statistics", "Total Items Sold", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// An int representing the total items bought of this Character.
        /// When set, it saves to file.
        /// </summary>
        public int ItemsBoughtTotal {
            get {
                return _ItemsBoughtTotal;
            }
            set {
                _ItemsBoughtTotal = value;
                Change("Statistics", "Total Items Bought", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// An int representing the total completed day cycles of this Character.
        /// When set, it saves to file.
        /// </summary>
        public int DayCyclesTotal {
            get {
                return _DayCyclesTotal;
            }
            set {
                _DayCyclesTotal = value;
                Change("Statistics", "Total Day Cycles", value.ToString());
                saveSettings();
            }
        }

        /// <summary>
        /// An int representing the total playing time of this Character in minutes.
        /// When set, it saves to file.
        /// </summary>
        public int PlaytimeTotal {
            get {
                return _PlaytimeTotal;
            }
            set {
                _PlaytimeTotal = value;
                Change("Statistics", "Total Playtime", value.ToString());
                saveSettings();
            }
        }
    }
}