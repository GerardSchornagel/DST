using System;

/// <summary>
/// DataType representing 1 item with 1 article through string().
/// </summary>
public class article
{
    string stringArticlePath = "Nothing";
    string stringArticleFile = "Nothing";
    string stringItemPath = "Nothing";
    string stringItemFile = "Nothing";
    item itemSelected;
    int integerArticleQuantity = 0;
    int integerArticleLastSell = 0;
    int integerArticleLastBuy = 0;

    binaryFileHandler fileHandler = new binaryFileHandler();
    string[] stringDataArticle = {
        "Nothing",
        "Nothing",
        "0",
        "0",
        "0"
    };
    
    /// <summary>
    /// Resizes stringDataArticle to 4 (PathItem, FileItem, Quantity, LastSell, LastBuy).
    /// </summary>
    public article()
    {
        stringDataArticle = new string[5];
    }

    /// <summary>
    /// Loads Article and Item Data.
    /// </summary>
    /// <param name="PathShelf">Needed for path and file seperation.</param>
    public void articleLoad(string PathShelf)
    {
        string[] stringMediator = null;
        stringMediator = stringArticlePath.Split((char)92);
        stringArticleFile = stringMediator[stringMediator.GetUpperBound(0)];
        stringArticlePath = stringArticlePath.Remove(stringArticlePath.Length - stringArticleFile.Length, stringArticleFile.Length);
        stringDataArticle = fileHandler.LoadRow(PathShelf, stringArticleFile);
        stringItemPath = stringDataArticle[0];
        stringItemFile = stringDataArticle[1];
        integerArticleQuantity = Convert.ToInt32(stringDataArticle[2]);
        integerArticleLastSell = Convert.ToInt32(stringDataArticle[3]);
        integerArticleLastBuy = Convert.ToInt32(stringDataArticle[4]);

        if (stringItemPath == "Nothing")
            return;
        itemSelected = new item(stringItemPath, stringItemFile);
    }
    
    /// <summary>
    /// Saves the item and loads the linked Item Data.
    /// </summary>
    /// <param name="PathShelf">Needed for path and file seperation.</param>
    public void ArticleSave(string PathShelf)
    {
        stringDataArticle[0] = stringItemPath;
        stringDataArticle[1] = stringItemFile;
        stringDataArticle[2] = Convert.ToString(integerArticleQuantity);
        stringDataArticle[3] = Convert.ToString(integerArticleLastSell);
        stringDataArticle[4] = Convert.ToString(integerArticleLastBuy);
        fileHandler.Save(PathShelf, stringArticleFile, null, stringDataArticle);

        if (stringItemPath == "Nothing")
            return;
        itemSelected = new item(stringItemPath, stringItemFile);
    }
    
    /// <summary>
    /// Get/Adjust the path of the article in storage without ItemLoad().
    /// </summary>
    public string ArticlePath {
        get { return stringArticlePath; }
        set { stringArticlePath = value; }
    }
    /// <summary>
    /// Get/Adjust the filename of the article in storage without ItemLoad().
    /// </summary>
    public string ArticleFile {
        get { return stringArticleFile; }
        set { stringArticleFile = value; }
    }
    /// <summary>
    /// Get/Adjust the path of the Item Data without ItemLoad() or itemSave().
    /// </summary>
    public string ItemPath {
        get { return stringItemPath; }
        set { stringItemPath = value; }
    }
    /// <summary>
    /// Get/Adjust the Filename of the Item Data without ItemLoad() or itemSave().
    /// </summary>
    public string ItemFile {
        get { return stringItemFile; }
        set { stringItemFile = value; }
    }
    /// <summary>
    /// Get the Name of the Item Data.
    /// </summary>
    public item ItemLink {
        get { return itemSelected; }
    }
    /// <summary>
    /// Get/Adjust the Quantity without itemSave().
    /// </summary>
    public int Quantity {
        get { return integerArticleQuantity; }
        set { integerArticleQuantity = value; }
    }
    /// <summary>
    /// Get/Adjust the Last Sell without itemSave().
    /// </summary>
    public int LastSell {
        get { return integerArticleLastSell; }
        set { integerArticleLastSell = value; }
    }
    /// <summary>
    /// Get/Adjust the Last Buy without itemSave().
    /// </summary>
    public int LastBuy {
        get { return integerArticleLastBuy; }
        set { integerArticleLastBuy = value; }
    }
}