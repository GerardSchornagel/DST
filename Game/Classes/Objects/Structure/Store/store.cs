using System;

/// <summary>
/// DataType representing any number of Level's as a Store().
/// </summary>
public class store
{
    public level[] arrayLevel;
    public int intStore;
    int intLevel;
    
    /// <summary>
    /// Get/Adjust the path of the Store without Initialize() and Load().
    /// </summary>
    public string storePath { get; set; }
    
    /// <summary>
    /// Resizes arrayLevel and fill with new Level(s).
    /// </summary>
    public void StoreInitialize()
    {
        arrayLevel = new level[System.IO.Directory.GetDirectories(storePath, "*", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0) + 1];
        intLevel = 0;
        foreach (string folder in System.IO.Directory.GetDirectories(storePath, "*", System.IO.SearchOption.TopDirectoryOnly)) {
            arrayLevel[intLevel] = new level();
            arrayLevel[intLevel].levelPath = folder;
            arrayLevel[intLevel].LevelInitialize();
            intLevel++;
        }
    }

    /// <summary>
    /// Adds a blank Store with 1 Level.
    /// </summary>
    public void LevelAdd()
    {
        if (arrayLevel.GetUpperBound(0) == -1) {
            arrayLevel = new level[1];
        } else {
            Array.Resize(ref arrayLevel, arrayLevel.GetUpperBound(0) + 1);
        }
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + (char)92 + "save" + (char)92 + gamecache.currentPlayer.ProfileID + (char)92 + "store" + (char)92 + intStore + (char)92 + arrayLevel.GetUpperBound(0));
        arrayLevel[arrayLevel.GetUpperBound(0)] = new level();
        arrayLevel[arrayLevel.GetUpperBound(0)].intStore = intStore;
        arrayLevel[arrayLevel.GetUpperBound(0)].intLevel = arrayLevel.GetUpperBound(0);
        arrayLevel[arrayLevel.GetUpperBound(0)].levelPath = System.IO.Directory.GetCurrentDirectory() + (char)92 + "save" + (char)92 + gamecache.currentPlayer.ProfileID + (char)92 + "store" + (char)92 + intStore + (char)92 + arrayLevel.GetUpperBound(0);
        arrayLevel[arrayLevel.GetUpperBound(0)].LevelInitialize();
    }
}