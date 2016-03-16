using System;

/// <summary>
/// DataType representing any number of Bin's as a Shelf().
/// </summary>
public class shelf
{
    public bin[] arrayBin;
    public int intStore;
    public int intLevel;
    public int intShelf;

    /// <summary>
    /// Get/Adjust the path of the Shelf without Initialize() and Load().
    /// </summary>
    public string shelfPath { get; set; }

    /// <summary>
    /// Resize arrayBin and fill with new Bin's.
    /// </summary>
    public void ShelfInitialize()
    {
        if (System.IO.Directory.GetDirectories(shelfPath, "*", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0) == 0) {
            arrayBin = new bin[1];
        } else {
            arrayBin = new bin[System.IO.Directory.GetDirectories(shelfPath, "*", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0) + 1];
        }
        for (int i = 0; i <= arrayBin.GetUpperBound(0); i++) {
            arrayBin[i] = new bin();
            arrayBin[i].Load(intStore, intLevel, intShelf, i);
        }
    }
    
    /// <summary>
    /// Makes a new Bin with the given Variable's.
    /// </summary>
    public void BinAdd(article articleBin, int Quantity, int Price)
    {
        if (arrayBin.GetUpperBound(0) == -1) {
            arrayBin = new bin[1];
        } else {
            Array.Resize(ref arrayBin, arrayBin.GetUpperBound(0) + 1);
        }
        arrayBin[arrayBin.GetUpperBound(0)] = new bin();
        arrayBin[arrayBin.GetUpperBound(0)].Load(intStore, intLevel, intShelf, arrayBin.GetUpperBound(0));
        arrayBin[arrayBin.GetUpperBound(0)].Storage = articleBin._Storage;
        arrayBin[arrayBin.GetUpperBound(0)].Section = articleBin._Section;
        arrayBin[arrayBin.GetUpperBound(0)].Article = articleBin._Article;
        arrayBin[arrayBin.GetUpperBound(0)].Quantity = Quantity;
        arrayBin[arrayBin.GetUpperBound(0)].Price = Price;
    }
}