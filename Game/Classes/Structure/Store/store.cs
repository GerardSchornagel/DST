using System;

/// <summary>
/// DataType representing any number of Level's as a Store().
/// </summary>
public class store
{
    public static level[] arrayLevel;
    private string stringPathStore;
    private int integerLevelCounter;
    
    /// <summary>
    /// Empty Sub.
    /// </summary>
    public store()
    {

    }
    
    /// <summary>
    /// Get/Adjust the path of the Store without Initialize() and Load().
    /// </summary>
    public string StorePath {
        get { return stringPathStore; }
        set { stringPathStore = value; }
    }
    
    /// <summary>
    /// Resizes arrayLevel and fill with New Level(s).
    /// </summary>
    public void StoreInitialize()
    {
        integerLevelCounter = 0;
        arrayLevel = new level[System.IO.Directory.GetDirectories(stringPathStore, "*", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0) + 1];
        foreach (string folder in System.IO.Directory.GetDirectories(stringPathStore, "*", System.IO.SearchOption.TopDirectoryOnly)) {
            arrayLevel[integerLevelCounter] = new level();
            arrayLevel[integerLevelCounter].LevelPath = folder;
            integerLevelCounter += 1;
        }
    }

    /// <summary>
    /// Loads all Levels with all Shelves with all Bin's and all Item's.
    /// </summary>
    public static void StoreLoad()
    {
        foreach (level item in arrayLevel) {
            item.ShelfInitialize();
            item.ShelfLoad();
        }
    }
    
    /// <summary>
    /// Adds a blank Level with 1 Shelf and 1 Bin containing 'Nothing'.
    /// </summary>
    public void LevelAdd()
    {
        int intCheck = 0;
        do {
            if (System.IO.Directory.Exists(stringPathStore + "\\" + intCheck)) {
            } else {
                break; // TODO: might not be correct. Was : Exit Do
            }
            intCheck += 1;
        } while (true);
        Array.Resize(ref arrayLevel, intCheck + 1);
        System.IO.Directory.CreateDirectory(stringPathStore + "\\" + intCheck);
        arrayLevel[arrayLevel.GetUpperBound(0)] = new level();
        arrayLevel[arrayLevel.GetUpperBound(0)].LevelPath = stringPathStore + "\\" + intCheck;
        arrayLevel[arrayLevel.GetUpperBound(0)].ShelfAdd();
    }
}