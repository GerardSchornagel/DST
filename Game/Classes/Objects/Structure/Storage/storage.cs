using System;

/// <summary>
/// DataType representing any number of Section's as a Storage().
/// </summary>
public class storage
{
    public section[] arraySection;
    public int intStorage;
    int intSection;
    
    /// <summary>
    /// Get/Adjust the path of the Storage without Initialize() and Load().
    /// </summary>
    public string storagePath { get; set; }

    /// <summary>
    /// Resizes arraySection() and fill with new Section's.
    /// </summary>
    public void StorageInitialize()
    {
        arraySection = new section[System.IO.Directory.GetDirectories(storagePath, "*", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0) + 1];
        intSection = 0;
        foreach (string folder in System.IO.Directory.GetDirectories(storagePath, "*", System.IO.SearchOption.TopDirectoryOnly)) {
            arraySection[intSection] = new section();
            arraySection[intSection].sectionPath = folder;
            arraySection[intSection].SectionInitialize();
            intSection++;
        }
    }
    
    /// <summary>
    /// Adds a empty Section.
    /// </summary>
    public void SectionAdd()
    {
        if (arraySection.GetUpperBound(0) == -1) {
            arraySection = new section[1];
        } else {
            Array.Resize(ref arraySection, arraySection.GetUpperBound(0) + 1);
        }
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + (char)92 + "save" + (char)92 + gamecache.currentPlayer.ProfileID + (char)92 + "storage" + (char)92 + arraySection.GetUpperBound(0));
        arraySection[arraySection.GetUpperBound(0)] = new section();
        arraySection[arraySection.GetUpperBound(0)].intStorage = intStorage;
        arraySection[arraySection.GetUpperBound(0)].intSection = arraySection.GetUpperBound(0);
        arraySection[arraySection.GetUpperBound(0)].sectionPath = System.IO.Directory.GetCurrentDirectory() + (char)92 + "save" + (char)92 + gamecache.currentPlayer.ProfileID + (char)92 + "storage" + (char)92 + arraySection.GetUpperBound(0);
        arraySection[arraySection.GetUpperBound(0)].SectionInitialize();
    }
}