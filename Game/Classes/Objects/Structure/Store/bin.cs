using System;

/// <summary>
/// DataType representing 1 bin with 1 article through string().
/// </summary>
public class bin
{
    string stringBinPath = "Nothing";
    string stringBinFile = "Nothing";
    string stringLinkPath = "Nothing";
    string stringLinkFile = "Nothing";
    int integerLinkStorage = 0;
    int integerLinkSection = 0;
    int integerLinkArticle = 0;
    int integerBinQuantity = 0;

    binaryFileHandler fileHandler = new binaryFileHandler();
    string[] stringBinData;

    /// <summary>
    /// Resizes stringDataBin to 3 (LinkStorage, LinkSection, LinkArticle, Quantity).
    /// </summary>
    public bin()
    {
        stringBinData = new string[4];
    }

    /// <summary>
    /// Loads Bin and Item Data.
    /// </summary>
    /// <param name="PathShelf">Needed for path and file seperation.</param>
    public void BinLoad(string PathShelf)
    {
        string[] stringMediator = null;
        stringMediator = stringBinPath.Split((char)92);
        stringBinFile = stringMediator[stringMediator.GetUpperBound(0)];
        stringBinPath = stringBinPath.Remove(stringBinPath.Length - stringBinFile.Length, stringBinFile.Length);
        stringBinData = fileHandler.LoadRow(PathShelf, stringBinFile);
        integerLinkStorage = Convert.ToInt32(stringBinData[0]);
        integerLinkSection = Convert.ToInt32(stringBinData[1]);
        integerLinkArticle = Convert.ToInt32(stringBinData[2]);
        integerBinQuantity = Convert.ToInt32(stringBinData[3]);

        stringLinkPath = gamecache.currentCharacterStorage.arraySection[integerLinkSection].arrayArticle[integerLinkArticle].ArticlePath;
        stringLinkFile = gamecache.currentCharacterStorage.arraySection[integerLinkSection].arrayArticle[integerLinkArticle].ArticleFile;
    }
    
    /// <summary>
    /// Saves the Bin and loads the linked Item Data.
    /// </summary>
    /// <param name="PathShelf">Needed for path and file seperation.</param>
    public void BinSave(string PathShelf)
    {
        stringBinData[0] = Convert.ToString(integerLinkStorage);
        stringBinData[1] = Convert.ToString(integerLinkSection);
        stringBinData[2] = Convert.ToString(integerLinkArticle);
        stringBinData[3] = Convert.ToString(integerBinQuantity);
        fileHandler.Save(PathShelf, stringBinFile, null, stringBinData);

        stringLinkPath = gamecache.currentCharacterStorage.arraySection[integerLinkSection].arrayArticle[integerLinkArticle].ArticlePath;
        stringLinkFile = gamecache.currentCharacterStorage.arraySection[integerLinkSection].arrayArticle[integerLinkArticle].ArticleFile;
    }
    
    /// <summary>
    /// Get/Adjust the path of the Bin without ItemLoad().
    /// </summary>
    public string BinPath {
        get { return stringBinPath; }
        set { stringBinPath = value; }
    }
    
    /// <summary>
    /// Get/Adjust the filename of the Bin without ItemLoad().
    /// </summary>
    public string BinFile {
        get { return stringBinFile; }
        set { stringBinFile = value; }
    }
    
    /// <summary>
    /// Get/Adjust the Storage linked for this Bin.
    /// </summary>
    public int LinkStorage {
        get { return integerLinkStorage; }
        set { integerLinkStorage = value; }
    }
    
    /// <summary>
    /// Get/Adjust the Section linked for this Bin.
    /// </summary>
    public int LinkSection {
        get { return integerLinkSection; }
        set { integerLinkSection = value; }
    }
    
    /// <summary>
    /// Get/Adjust the Article linked for this Bin.
    /// </summary>
    public int LinkArticle {
        get { return integerLinkArticle; }
        set { integerLinkArticle = value; }
    }
    
    /// <summary>
    /// Get/Adjust the Quantity without BinSave().
    /// </summary>
    public int BinQuantity {
        get { return integerBinQuantity; }
        set { integerBinQuantity = value; }
    }
    
    /// <summary>
    /// Get the Item Name from Linked Article.
    /// </summary>
    public string ArticleName {
        get { return gamecache.currentCharacterStorage.arraySection[integerLinkSection].arrayArticle[integerLinkArticle].ItemLink.Name; }
    }
    
    /// <summary>
    /// Get the Last Selling price from Linked Article.
    /// </summary>
    public int ArticleLastSell {
        get { return gamecache.currentCharacterStorage.arraySection[integerLinkSection].arrayArticle[integerLinkArticle].LastSell; }
    }
}