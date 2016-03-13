using System;
using System.Windows.Forms;

namespace Game.Classes.Settings
{
    /// <summary>
    /// Contains the settings affecting the Player settings.
    /// </summary>
    public class settingsPlayer
    {
        string[,,] stringSettings;
        ioINI iniSettings = new ioINI();
        //Profile Data
        int _ProfileID;
        string _NameFirst;
        string _NameLast;
        int _BirthYear;
        int _BirthMonth;
        int _BirthDay;
        string _Gender;
        string _Email;
        bool _NotificationEmail;
        //Statistics Data
        int _CharactersTotal;
        int _SpendingsTotal;
        int _EarningsTotal;
        int _PlaytimeTotal;
        string _CreateDate;
        string _CreateTime;
        
        /// <summary>
        /// Initalization of settings Array and all Variable's.
        /// </summary>
        public settingsPlayer()
        {
            if (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + (char)92 + "save" + (char)92 + "settings" + (char)92 + "Player.ini")) {
                stringSettings = iniSettings.Load("save" + (char)92 + "settings", "Player.ini");
                //Profile Data
                _ProfileID = Convert.ToInt32(Retrieve("Profile", "Profile ID"));
                _NameFirst = (string)Retrieve("Profile", "First Name");
                _NameLast = (string)Retrieve("Profile", "Last Name");
                _BirthYear = Convert.ToInt32(Retrieve("Profile", "Year of Birth"));
                _BirthMonth = Convert.ToInt32(Retrieve("Profile", "Month of Birth"));
                _BirthDay = Convert.ToInt32(Retrieve("Profile", "Day of Birth"));
                _Gender = (string)Retrieve("Profile", "Gender");
                _Email = (string)Retrieve("Profile", "E-Mail");
                _NotificationEmail = Convert.ToBoolean(Retrieve("Profile", "E-Mail Notification"));
                //Statistics Data
                _CharactersTotal = Convert.ToInt32(Retrieve("Statistics", "Total Characters"));
                _SpendingsTotal = Convert.ToInt32(Retrieve("Statistics", "Total Spendings"));
                _EarningsTotal = Convert.ToInt32(Retrieve("Statistics", "Total Earnings"));
                _PlaytimeTotal = Convert.ToInt32(Retrieve("Statistics", "Total Playtime"));
                _CreateDate = (string)Retrieve("Statistics", "Date of Creation");
                _CreateTime = (string)Retrieve("Statistics", "Time of Creation");
            } else {
                //Profile Data
                stringSettings = new string[2, 10, 2];
                stringSettings[0, 0, 0] = "Profile";
                stringSettings[0, 1, 0] = "Profile ID";
                stringSettings[0, 1, 1] = "0";
                _ProfileID = 0;
                stringSettings[0, 2, 0] = "First Name";
                stringSettings[0, 2, 1] = "John";
                _NameFirst = "John";
                stringSettings[0, 3, 0] = "Last Name";
                stringSettings[0, 3, 1] = "Doe";
                _NameLast = "Doe";
                stringSettings[0, 4, 0] = "Year of Birth";
                stringSettings[0, 4, 1] = "1985";
                _BirthYear = 1985;
                stringSettings[0, 5, 0] = "Month of Birth";
                stringSettings[0, 5, 1] = "9";
                _BirthMonth = 9;
                stringSettings[0, 6, 0] = "Day of birth";
                stringSettings[0, 6, 1] = "24";
                _BirthDay = 24;
                stringSettings[0, 7, 0] = "Gender";
                stringSettings[0, 7, 1] = "male";
                _Gender = "male";
                stringSettings[0, 8, 0] = "E-Mail";
                stringSettings[0, 8, 1] = "a@b.com";
                _Email = "a@b.com";
                stringSettings[0, 9, 0] = "E-Mail Notification";
                stringSettings[0, 9, 1] = "False";
                _NotificationEmail = false;
                //Statistics Data
                stringSettings[1, 0, 0] = "Statistics";
                stringSettings[1, 1, 0] = "Total Characters";
                stringSettings[1, 1, 1] = "1";
                _CharactersTotal = 1;
                stringSettings[1, 2, 0] = "Total Spendings";
                stringSettings[1, 2, 1] = "0";
                _SpendingsTotal = 0;
                stringSettings[1, 3, 0] = "Total Earnings";
                stringSettings[1, 3, 1] = "0";
                _EarningsTotal = 0;
                stringSettings[1, 4, 0] = "Total Playttime";
                stringSettings[1, 4, 1] = "0";
                _PlaytimeTotal = 0;
                stringSettings[1, 5, 0] = "Date of Creation";
                string stringDate = DateTime.Now.Date.Year + "-";
                if (stringDate.Length == 3) { stringDate = "20" + stringDate; }
                stringDate += DateTime.Now.Date.Month + "-";
                if (stringDate.Length == 7) { stringDate = stringDate.Insert(5, "0"); }
                stringDate += DateTime.Now.Date.Day;
                if (stringDate.Length == 9) { stringDate = stringDate.Insert(8, "0"); }
                stringSettings[1, 5, 1] = stringDate;
                _CreateDate = stringSettings[1, 5, 1];
                stringSettings[1, 6, 0] = "Time of Creation";
                string stringTime = DateTime.Now.TimeOfDay.Hours + ":";
                if (stringTime.Length == 2) { stringTime = "0" + stringTime; }
                stringTime += DateTime.Now.TimeOfDay.Minutes;
                if (stringTime.Length == 4) { stringTime = stringTime.Insert(3, "0"); }
                stringSettings[1, 6, 1] = stringTime;
                _CreateTime = stringSettings[1, 6, 1];
                saveSettings();
            }
        }
        
        void saveSettings()
        {
            iniSettings.Save("save" + (char)92 + "settings", "Player.ini", stringSettings);
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
        /// An int representing the last Profile that has played, it is corresponding with the number in the save directory.
        /// When set, it saves to file.
        /// </summary>
        public int ProfileID {
            get {
                return _ProfileID;
            }
            set {
                _ProfileID = value;
                Change("Profile", "Profile ID", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// A string with the first name of the Player.
        /// When set, it saves to file.
        /// </summary>
        public string NameFirst {
            get {
                return _NameFirst;
            }
            set {
                _NameFirst = value;
                Change("Profile", "First Name", value);
                saveSettings();
            }
        }

        /// <summary>
        /// A string of the last name of the Player.
        /// When set, it saves to file.
        /// </summary>
        public string NameLast {
            get {
                return _NameLast;
            }
            set {
                _NameLast = value;
                Change("Profile", "Last Name", value);
                saveSettings();
            }
        }

        /// <summary>
        /// An int with the year of Birth of the Player.
        /// When set, it saves to file.
        /// </summary>
        public int BirthYear {
            get {
                return _BirthYear;
            }
            set {
                _BirthYear = value;
                Change("Profile", "Year of Birth", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// An int with the month of Birth of the Player.
        /// When set, it saves to file.
        /// </summary>
        public int BirthMonth {
            get {
                return _BirthMonth;
            }
            set {
                _BirthMonth = value;
                Change("Profile", "Month of Birth", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// An int with the day of Birth of the Player.
        /// When set, it saves to file.
        /// </summary>
        public int BirthDay {
            get {
                return _BirthDay;
            }
            set {
                _BirthDay = value;
                Change("Profile", "Day of Birth", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// A string with "male" -or- "female".
        /// When set, it saves to file.
        /// </summary>
        public string Gender {
            get {
                return _Gender;
            }
            set {
                _Gender = value;
                Change("Profile", "Gender", value);
                saveSettings();
            }
        }

        /// <summary>
        /// A string with the E-Mail of the Player.
        /// When set, it saves to file.
        /// </summary>
        public string Email {
            get {
                return _Email;
            }
            set {
                _Email = value;
                Change("Profile", "E-Mail", value);
                saveSettings();
            }
        }

        /// <summary>
        /// A Boolean for Notification on E-Mail.
        /// When set, it saves to file.
        /// </summary>
        public bool NotificationEmail {
            get {
                return _NotificationEmail;
            }
            set {
                _NotificationEmail = value;
                Change("Profile", "E-Mail Notification", value.ToString());
                saveSettings();
            }
        }

        /// <summary>
        /// An int of the Total Characters of this Player.
        /// When set, it saves to file.
        /// </summary>
        public int CharactersTotal {
            get {
                return _CharactersTotal;
            }
            set {
                _CharactersTotal = value;
                Change("Profile", "Total Characters", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// An int with the Total Spendings of the Player (all Characters).
        /// When set, it saves to file.
        /// </summary>
        public int SpendingsTotal {
            get {
                return _SpendingsTotal;
            }
            set {
                _SpendingsTotal = value;
                Change("Profile", "Total Spendings", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// An int with the Total Earnings of the Player (all Characters).
        /// When set, it saves to file.
        /// </summary>
        public int EarningsTotal {
            get {
                return _EarningsTotal;
            }
            set {
                _EarningsTotal = value;
                Change("Profile", "Total Earnings", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// An int of the total played minutes.
        /// When set, it saves to file.
        /// </summary>
        public int PlaytimeTotal {
            get {
                return _PlaytimeTotal;
            }
            set {
                _PlaytimeTotal = value;
                Change("Profile", "Total Playtime", value.ToString());
                saveSettings();
            }
        }
        
        /// <summary>
        /// A string representing the creation date of the Player.
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
        /// a string representing the creation time of the Player.
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
    }
}