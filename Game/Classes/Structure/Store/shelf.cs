using System;

/// <summary>
/// DataType representing any number of Bin's as a Shelf().
/// </summary>
public class shelf
{
    public static bin[] arrayBin;
    private string stringPathShelf;
    private int integerBinCounter;

    /// <summary>
    /// Empty Sub.
    /// </summary>
    public shelf()
    {

    }

    /// <summary>
    /// Get/Adjust the path of the Shelf without Initialize() and Load().
    /// </summary>
    public string ShelfPath {
        get { return stringPathShelf; }
        set { stringPathShelf = value; }
    }

    /// <summary>
    /// Resize arrayBin and fill with New Bin's.
    /// </summary>
    public void ShelfInitialize()
    {
        integerBinCounter = 0;
        arrayBin[integerBinCounter] = bin(System.IO.Directory.GetFiles(stringPathShelf, "*.ini", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0) + 1);
        foreach (string file in System.IO.Directory.GetFiles(stringPathShelf, "*.ini", System.IO.SearchOption.TopDirectoryOnly)) {
            arrayBin[integerBinCounter] = new bin();
            arrayBin[integerBinCounter].BinPath = file;
            integerBinCounter += 1;
        }
    }
    
    /// <summary>
    /// Loads all Bin's with Item Info.
    /// </summary>
    public void ShelfLoad()
    {
        foreach (bin item in arrayBin) {
            item.BinLoad(stringPathShelf);
        }
    }
    
    /// <summary>
    /// Makes new Bin with the given template.
    /// </summary>
    /// <param name="ArticleInfo">New String() {LinkStorage, LinkSection, LinkArticle, Quantity}</param>
    public void BinAdd(string[] ArticleInfo)
    {
        int intCheck = 0;
        do {
            if (System.IO.File.Exists(stringPathShelf + "\\" + intCheck + ".ini")) {
            } else {
                break; // TODO: might not be correct. Was : Exit Do
            }
            intCheck += 1;
        } while (true);
        Array.Resize(ref arrayBin, intCheck + 1);
        arrayBin[arrayBin.GetUpperBound(0)] = new Bin();
        arrayBin[arrayBin.GetUpperBound(0)].BinPath = stringPathShelf + "\\";
        arrayBin[arrayBin.GetUpperBound(0)].BinFile = intCheck + ".ini";
        arrayBin[arrayBin.GetUpperBound(0)].LinkStorage = Convert.ToInt32(ArticleInfo[0]);
        arrayBin[arrayBin.GetUpperBound(0)].LinkSection = Convert.ToInt32(ArticleInfo[1]);
        arrayBin[arrayBin.GetUpperBound(0)].LinkArticle = Convert.ToInt32(ArticleInfo[2]);
        arrayBin[arrayBin.GetUpperBound(0)].BinQuantity = Convert.ToInt32(ArticleInfo[3]);

        arrayBin[arrayBin.GetUpperBound(0)].BinSave(stringPathShelf);
    }
}