using System;

/// <summary>
/// DataType representing any number of Shelf's as a Level().
/// </summary>
public class level
{
    public static shelf[] arrayShelf;
    private string stringPathLevel;
    private int integerShelfCounter;

    /// <summary>
    /// Empty Sub.
    /// </summary>
    public level()
    {

    }

    /// <summary>
    /// Get/Adjust the path of the Level without Initialize() and Load().
    /// </summary>
    public string LevelPath {
        get { return stringPathLevel; }
        set { stringPathLevel = value; }
    }

    /// <summary>
    /// Resizes arrayShelf() and fill with New Shelf's.
    /// </summary>
    public void ShelfInitialize()
    {
        integerShelfCounter = 0;
        arrayShelf = new shelf[System.IO.Directory.GetDirectories(stringPathLevel, "*", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0) + 1];
        foreach (string folder in System.IO.Directory.GetDirectories(stringPathLevel, "*", System.IO.SearchOption.TopDirectoryOnly)) {
            arrayShelf[integerShelfCounter] = new shelf();
            arrayShelf[integerShelfCounter].ShelfPath = folder + "\\";
            integerShelfCounter += 1;
        }
    }
    
    /// <summary>
    /// Loads all Shelves with all Bin's with all Items.
    /// </summary>
    public static void ShelfLoad()
    {
        foreach (shelf item in arrayShelf) {
            item.ShelfInitialize();
            item.ShelfLoad();
        }
    }
    
    /// <summary>
    /// Adds a empty Level with 1 Shelf and 1 Bin containing 'Nothing'.
    /// </summary>
    public void ShelfAdd()
    {
        int intCheck = 0;
        do {
            if (System.IO.Directory.Exists(stringPathLevel + "\\" + intCheck)) {
            } else {
                break; // TODO: might not be correct. Was : Exit Do
            }
            intCheck += 1;
        } while (true);
        Array.Resize(ref arrayShelf, intCheck + 1);
        System.IO.Directory.CreateDirectory(stringPathLevel + "\\" + intCheck);
        arrayShelf[arrayShelf.GetUpperBound(0)] = new shelf();
        arrayShelf[arrayShelf.GetUpperBound(0)].ShelfPath = stringPathLevel + "\\" + intCheck;
    }
}