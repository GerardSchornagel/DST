using System;

/// <summary>
/// Item information handler
/// </summary>
public class item
{
    public string SettingRequest;
    private iniHandler iniFilehandler = new iniHandler();
    private string stringFileName;
    private string[,] stringItem;

    /// <summary>
    /// Loads the Item into the memory as String(,)
    /// </summary>
    public item(string FileName)
    {
        stringFileName = FileName;
        stringItem = iniFilehandler.Load(stringFileName);
    }

    /// <summary>
    /// Searches in stringItem(,) for requested Setting and returns that value.
    /// </summary>
    /// <returns></returns>
    private string ReturnValue {
        get {
            int integerColumn = 0;
            int integerRow = 0;
            do {
                do {
                    if (stringItem[integerColumn, integerRow] == null) {
                    } else if (stringItem[integerColumn, integerRow].Contains(SettingRequest)) {
                        return stringItem[integerColumn, integerRow + 1];
                    }
                    integerRow += 1;
                } while (!(integerRow > stringItem.GetUpperBound(1)));
                integerColumn += 1;
                integerRow = 0;
            } while (!(integerColumn > stringItem.GetUpperBound(0)));
            return "";
        }
    }

    /// <summary>
    /// A String representing the Description of the item. 1-Line String.
    /// </summary>
    public string Description {
        get {
            SettingRequest = "Description";
            return ReturnValue;
        }
    }
    
    /// <summary>
    /// A String representing the Picture Path & Filename of the item.
    /// </summary>
    public string PictureFileName {
        get {
            SettingRequest = "PictureFilename";
            return ReturnValue;
        }
    }
    
    /// <summary>
    /// A String representing the ItemTier of the item.
    /// </summary>
    public string ItemTier {
        get {
            SettingRequest = "ItemTier";
            return ReturnValue;
        }
    }
    
    /// <summary>
    /// A String representing the BaseWorth of the item.
    /// </summary>
    public string BaseWorth {
        get {
            SettingRequest = "BaseWorth";
            return ReturnValue;
        }
    }

    /// <summary>
    /// A String representing the Rarity of the item.
    /// </summary>
    public string Rarity {
        get {
            SettingRequest = "Rarity";
            return ReturnValue;
        }
    }

    /// <summary>
    /// A String representing the Popularity of the item.
    /// </summary>
    public string Popularity {
        get {
            SettingRequest = "Popularity";
            return ReturnValue;
        }
    }

    /// <summary>
    /// A String representing the Quality of the item.
    /// </summary>
    public string Quality {
        get {
            SettingRequest = "Quality";
            return ReturnValue;
        }
    }

    /// <summary>
    /// A String representing the Family of the item.
    /// </summary>
    public string Family {
        get {
            SettingRequest = "Family";
            return ReturnValue;
        }
    }

    /// <summary>
    /// A String representing the Category of the item.
    /// </summary>
    public string Category {
        get {
            SettingRequest = "Category";
            return ReturnValue;
        }
    }

    /// <summary>
    /// A String representing the Genre of the item.
    /// </summary>
    public string Genre {
        get {
            SettingRequest = "Genre";
            return ReturnValue;
        }
    }

    /// <summary>
    /// A String representing the Company/Publisher of the item.
    /// </summary>
    public string Company_Publisher {
        get {
            SettingRequest = "Company/Publisher";
            return ReturnValue;
        }
    }

    /// <summary>
    /// A String representing the Brand/Author of the item.
    /// </summary>
    public string Brand_Author {
        get {
            SettingRequest = "Brand/Author";
            return ReturnValue;
        }
    }

    /// <summary>
    /// A String representing the Name/Title of the item.
    /// </summary>
    public string Name_Title {
        get {
            SettingRequest = "Name/Title";
            return ReturnValue;
        }
    }
}