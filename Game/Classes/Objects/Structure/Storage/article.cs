using System;

/// <summary>
/// DataType representing an article containg 1 item datatype.
/// 1.) Initialising create's empty template.
/// 2.) Use Load to fill in variable's.
/// </summary>
public class article
{
    string[,,] stringItem = new string[2, 4, 2];
    ioINI iniDetails = new ioINI();
    public int _Storage;
    public int _Section;
    public int _Article;
    
    //Item Information
    string _Path;
    string _File;
    item itemSelected;
    //Article Information
    int _Quantity;
    int _LastSell;
    int _LastBuy;
    
    /// <summary>
    /// Retrieve Value from given Category && Option.
    /// </summary>
    /// <param name="Category">Category as string.</param>
    /// <param name="Option">Option as string.</param>
    /// <returns>Single string with Value.</returns>
    string Retrieve(string Category, string Option)
    {
        for (int intC = 0; intC <= stringItem.GetUpperBound(0); intC++) {
            if (stringItem[intC, 0, 0] == Category) {
                for (int intO = 0; intO <= stringItem.GetUpperBound(1); intO++) {
                    if (stringItem[intC, intO, 0] == Option) {
                        return stringItem[intC, intO, 1];
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
        for (int intC = 0; intC <= stringItem.GetUpperBound(0); intC++) {
            if (stringItem[intC, 0, 0] == Category) {
                for (int intO = 0; intO <= stringItem.GetUpperBound(1); intO++) {
                    if (stringItem[intC, intO, 0] == Option) {
                        stringItem[intC, intO, 1] = Value;
                    }
                }
            }
        }
    }
    
    /// <summary>
    ///  Loads the article through Storage, Section and Article.
    /// </summary>
    /// <param name="Storage">Storage of Article.</param>
    /// <param name="Section">Section of Article.</param>
    /// <param name="Article">Designated Article.</param>
    public void Load(int Storage, int Section, int Article)
    {
        _Storage = Storage;
        _Section = Section;
        _Article = Article;
        // Check if article exists, yes=load no=new.
        if (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + (char)92 + "save" + (char)92 + gamecache.currentPlayer.ProfileID + (char)92 + "storage" + (char)92 + Storage + (char)92 + Section + (char)92 + Article + (char)92 + "details.ini")) {
            //Item Information
            _Path = "save" + (char)92 + gamecache.currentPlayer.ProfileID + (char)92 + "storage" + (char)92 + Storage + (char)92 + Section + (char)92 + Article;
            _File = "details.ini";
            stringItem = iniDetails.Load(_Path, _File); //Load article ini
            itemSelected = new item(Retrieve("Item Information", "Path of item"), Retrieve("Item Information", "File of item")); //Load item ini
            //Article Information
            _Quantity = Convert.ToInt32(Retrieve("Article Information", "Quantity of article"));
            _LastSell = Convert.ToInt32(Retrieve("Article Information", "Last selling price"));
            _LastBuy = Convert.ToInt32(Retrieve("Article Information", "Last buying price"));
        } else {
            //Item Information
            stringItem[0, 0, 0] = "Item Information";
            stringItem[0, 1, 0] = "Path of item";
            stringItem[0, 1, 1] = "";
            _Path = "";
            stringItem[0, 2, 0] = "File of item";
            stringItem[0, 2, 1] = "";
            _File = "";
            //Article Information
            stringItem[1, 0, 0] = "Article Information";
            stringItem[1, 1, 0] = "Quantity of article";
            stringItem[1, 1, 1] = "0";
            _Quantity = 0;
            stringItem[1, 2, 0] = "Last selling price";
            stringItem[1, 2, 1] = "0";
            _LastSell = 0;
            stringItem[1, 3, 0] = "Last buying price";
            stringItem[1, 3, 1] = "0";
            _LastBuy = 0;
            articleSave();
        }
    }
    
    void articleSave()
    {
        iniDetails.Save("save" + (char)92 + gamecache.currentPlayer.ProfileID + (char)92 + "storage" + (char)92 + _Storage + (char)92 + _Section + (char)92 + _Article, "details.ini", stringItem);
    }

    /// <summary>
    /// Get/Sets the path of the item in the article-slot WITH Change() and WITHOUT articleSave() & new item(,).
    /// When setting the file of the item it will do articleSave() & new item(,).
    /// </summary>
    public string Path {
        get {
            return _Path;
        }
        set {
            _Path = value;
            Change("Item Information", "Path of item", value);
        }
    }

    /// <summary>
    /// Get/Sets the file of the item in the article-slot WITH Change(), articleSave() & new item(,).
    /// </summary>
    public string File {
        get {
            return _File;
        }
        set {
            _File = value;
            Change("Item Information", "File of item", value);
            articleSave();
            itemSelected = new item(Retrieve("Item Information", "Path of item"), Retrieve("Item Information", "File of item")); //Load item ini
        }
    }

    /// <summary>
    /// Get the item datatype. For setting use Path and File.
    /// </summary>
    public item Item {
        get {
            return itemSelected;
        }
    }

    /// <summary>
    /// Get/Sets the quantity of the article. With articleSave().
    /// </summary>
    public int Quantity {
        get {
            return _Quantity;
        }
        set {
            _Quantity = value;
            Change("Article Information", "Quantity of article", value.ToString());
            articleSave();
        }
    }

    /// <summary>
    /// Get/Sets the last selling price. With articleSave().
    /// </summary>
    public int LastSell {
        get {
            return _LastSell;
        }
        set {
            _LastSell = value;
            Change("Article Information", "Last selling price", value.ToString());
            articleSave();
        }
    }
    
    /// <summary>
    /// Get/Sets the last buying price. With articleSave().
    /// </summary>
    public int LastBuy {
        get {
            return _LastBuy;
        }
        set {
            _LastBuy = value;
            Change("Article Information", "Last buying price", value.ToString());
            articleSave();
        }
    }
}