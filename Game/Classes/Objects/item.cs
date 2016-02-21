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
        get { return ReturnValue["Description"].ToString; }
    }
    /// <summary>
    /// A String representing the Picture Path & Filename of the item.
    /// </summary>
    public string PictureFileName {
        get { return ReturnValue["PictureFilename"].ToString; }
    }
    /// <summary>
    /// A String representing the ItemTier of the item.
    /// </summary>
    public string ItemTier {
        get { return ReturnValue["ItemTier"].ToString; }
    }
    /// <summary>
    /// A String representing the BaseWorth of the item.
    /// </summary>
    public string BaseWorth {
        get { return ReturnValue["BaseWorth"].ToString; }
    }
    /// <summary>
    /// A String representing the Rarity of the item.
    /// </summary>
    public string Rarity {
        get { return ReturnValue["Rarity"].ToString; }
    }
    /// <summary>
    /// A String representing the Popularity of the item.
    /// </summary>
    public string Popularity {
        get { return ReturnValue["Popularity"].ToString; }
    }
    /// <summary>
    /// A String representing the Quality of the item.
    /// </summary>
    public string Quality {
        get { return ReturnValue["Quality"].ToString; }
    }
    /// <summary>
    /// A String representing the Family of the item.
    /// </summary>
    public string Family {
        get { return ReturnValue["Family"].ToString; }
    }
    /// <summary>
    /// A String representing the Category of the item.
    /// </summary>
    public string Category {
        get { return ReturnValue["Category"].ToString; }
    }
    /// <summary>
    /// A String representing the Genre of the item.
    /// </summary>
    public string Genre {
        get { return ReturnValue["Genre"].ToString; }
    }
    /// <summary>
    /// A String representing the Company/Publisher of the item.
    /// </summary>
    public string Company_Publisher {
        get { return ReturnValue["Company/Publisher"].ToString; }
    }
    /// <summary>
    /// A String representing the Brand/Author of the item.
    /// </summary>
    public string Brand_Author {
        get { return ReturnValue["Brand/Author"].ToString; }
    }
    /// <summary>
    /// A String representing the Name/Title of the item.
    /// </summary>
    public string Name_Title {
        get { return ReturnValue["Name/Title"].ToString; }
    }
}