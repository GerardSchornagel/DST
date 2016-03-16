using System;

/// <summary>
/// DataType representing any number of Shelf's as a Level().
/// </summary>
public class level
{
    public shelf[] arrayShelf;
    public int intStore;
    public int intLevel;
    int intShelf;

    /// <summary>
    /// Get/Adjust the path of the Level without Initialize() and Load().
    /// </summary>
    public string levelPath { get; set; }

    /// <summary>
    /// Resizes arrayShelf() and fill with new Shelf's.
    /// </summary>
    public void LevelInitialize()
    {
        arrayShelf = new shelf[System.IO.Directory.GetDirectories(levelPath, "*", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0) + 1];
        intShelf = 0;
        foreach (string folder in System.IO.Directory.GetDirectories(levelPath, "*", System.IO.SearchOption.TopDirectoryOnly)) {
            arrayShelf[intShelf] = new shelf();
            arrayShelf[intShelf].shelfPath = folder;
            arrayShelf[intShelf].ShelfInitialize();
            intShelf++;
        }
    }
    
    /// <summary>
    /// Adds a empty Level with 1 shelf.
    /// </summary>
    public void ShelfAdd()
    {
        if (arrayShelf.GetUpperBound(0) == -1) {
            arrayShelf = new shelf[1];
        } else {
            Array.Resize(ref arrayShelf, arrayShelf.GetUpperBound(0) + 1);
        }
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + (char)92 + "save" + (char)92 + gamecache.currentPlayer.ProfileID + (char)92 + "store" + (char)92 + intStore + (char)92 + intLevel + (char)92 + arrayShelf.GetUpperBound(0));
        arrayShelf[arrayShelf.GetUpperBound(0)] = new shelf();
        arrayShelf[arrayShelf.GetUpperBound(0)].intStore = intStore;
        arrayShelf[arrayShelf.GetUpperBound(0)].intLevel = intLevel;
        arrayShelf[arrayShelf.GetUpperBound(0)].intShelf = arrayShelf.GetUpperBound(0);
        arrayShelf[arrayShelf.GetUpperBound(0)].shelfPath = System.IO.Directory.GetCurrentDirectory() + (char)92 + "save" + (char)92 + gamecache.currentPlayer.ProfileID + (char)92 + "store" + (char)92 + intStore + (char)92 + intLevel + (char)92 + arrayShelf.GetUpperBound(0);
        arrayShelf[arrayShelf.GetUpperBound(0)].ShelfInitialize();
    }
}