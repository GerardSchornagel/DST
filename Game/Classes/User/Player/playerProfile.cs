using System;

/// <summary>
/// Get or Set the current Player data.
/// </summary>
public class playerProfile
{
    public string InformationRequest;
    private iniHandler iniFileHandler = new iniHandler();
    string[,] stringProfileData;

    /// <summary>
    /// Initializes Profile class.
    /// </summary>
    internal playerProfile()
    {

    }

    /// <summary>
    /// Creates a new Profile.
    /// </summary>
    public void NewPlayerProfile(string[] ProfileInfo)
    {
        stringProfileData = new string[ +1, +1] { {
                "[Player Profile]",
                "<ProfileID>",
                ProfileInfo(0),
                "<NameFirst>",
                ProfileInfo(1),
                "<NameLast>",
                ProfileInfo(2),
                "<BirthYear>",
                ProfileInfo(3),
                "<BirthMonth>",
                ProfileInfo(4),
                "<BirthDay>",
                ProfileInfo(5),
                "<Gender>",
                ProfileInfo(6),
                "<E-Mail>",
                ProfileInfo(7),
                "<E-Mail Notification>",
                ProfileInfo(8)
            }
        };
        gamecache.currentSettings.LastProfile = ProfileInfo[0];
        //Start Writing New Profile
        SaveState();
    }
    
    /// <summary>
    /// Loads a Profile file.
    /// </summary>
    internal void LoadPlayerProfile()
    {
        stringProfileData = iniFileHandler.Load(System.IO.Directory.GetCurrentDirectory + "\\save\\" + gamecache.currentSettings.LastProfile + "\\player\\profile.ini");
    }
    
    /// <summary>
    /// Searches in stringProfileData for requested Setting and set/returns that value.
    /// </summary>
    /// <returns></returns>
    public string ReturnValue {
        get {
            int integerColumn = 0;
            int integerRow = 0;
            do {
                do {
                    if (stringProfileData[integerColumn, integerRow].Contains(InformationRequest)) {
                        return stringProfileData[integerColumn, integerRow + 1];
                    }
                    integerRow += 1;
                } while (!(integerRow > stringProfileData.GetUpperBound(1)));
                integerColumn += 1;
            } while (!(integerColumn > stringProfileData.GetUpperBound(0)));
            return "";
        }

        set {
            int integerColumn = 0;
            int integerRow = 0;
            do {
                do {
                    if (stringProfileData[integerColumn, integerRow].Contains(InformationRequest)) {
                        stringProfileData[integerColumn, integerRow + 1] = value;
                        SaveState();
                        return;
                    }
                    integerRow += 1;
                } while (!(integerRow > stringProfileData.GetUpperBound(1)));
                integerColumn += 1;
            } while (!(integerColumn > stringProfileData.GetUpperBound(0)));
        }
    }

    /// <summary>
    /// Saves all changes made to the Profile data.
    /// </summary>
    private void SaveState()
    {
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\\save\\" + gamecache.currentSettings.LastProfile + "\\player");
        iniFileHandler.Save(System.IO.Directory.GetCurrentDirectory + "\\save\\" + gamecache.currentSettings.LastProfile + "\\player\\profile.ini", stringProfileData);
    }

    /// <summary>
    /// Returns a String with the ProfileID.
    /// </summary>
    public string ProfileID {
        get { return ReturnValue["ProfileID"].ToString; }
        set {
            ReturnValue["ProfileID"].ToString = value;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns a String with the First name.
    /// </summary>
    public string FirstName {
        get { return ReturnValue["NameFirst"].ToString; }
        set {
            ReturnValue["NameFirst"].ToString = value;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns a String with the Last name.
    /// </summary>
    public string LastName {
        get { return ReturnValue["NameLast"].ToString; }
        set {
            ReturnValue["NameLast"].ToString = value;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns an Integer with the Birth Year.
    /// </summary>
    public int BirthYear {
        get { return Convert.ToInt32(ReturnValue["BirthYear"]); }
        set {
            ReturnValue["BirthYear"] = value.ToString;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns an Integer with the Birth Month.
    /// </summary>
    public int BirthMonth {
        get { return Convert.ToInt32(ReturnValue["BirthMonth"]); }
        set {
            ReturnValue["BirthMonth"] = value.ToString;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns an Integer with the Birth Day.
    /// </summary>
    public int BirthDay {
        get { return Convert.ToInt32(ReturnValue["BirthDay"]); }
        set {
            ReturnValue["BirthDay"] = value.ToString;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns/Sets an String with the Gender
    /// </summary>
    public string Gender {
        get { return ReturnValue["Gender"].ToString; }
        set {
            ReturnValue["Gender"].ToString = value;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns/Sets a String with the stringEMail.
    /// </summary>
    public string EMail {
        get { return ReturnValue["EMail"].ToString; }
        set {
            ReturnValue["EMail"].ToString = value;
            SaveState();
        }
    }
    
    /// <summary>
    /// Returns/Sets a True/False if subscribed to EMail Notification.
    /// </summary>
    public bool Notification {
        get { return Convert.ToBoolean(ReturnValue["Notification"]); }
        set {
            ReturnValue["Notification"] = value.ToString;
            SaveState();
        }
    }
}