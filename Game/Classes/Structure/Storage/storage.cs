using System;

/// <summary>
/// DataType representing any number of Section's as a Storage().
/// </summary>
public class storage
{
    public section[] arraySection;
    string stringPathStorage;
    int integerSectionCounter;

    /// <summary>
    /// Get/Adjust the path of the Storage without Initialize() and Load().
    /// </summary>
    public string StoragePath {
        get { return stringPathStorage; }
        set { stringPathStorage = value; }
    }

    /// <summary>
    /// Resizes arraySection() and fill with New Section's.
    /// </summary>
    public void StorageInitialize()
    {
        integerSectionCounter = 0;
        arraySection = new section[System.IO.Directory.GetDirectories(stringPathStorage, "*", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0) + 1];
        foreach (string folder in System.IO.Directory.GetDirectories(stringPathStorage, "*", System.IO.SearchOption.TopDirectoryOnly)) {
            arraySection[integerSectionCounter] = new section();
            arraySection[integerSectionCounter].SectionPath = folder;
            integerSectionCounter += 1;
        }
    }
    
    /// <summary>
    /// Loads all Shelves with all Bin's with all Items.
    /// </summary>
    public void StorageLoad()
    {
        foreach (section Section in arraySection) {
            Section.SectionInitialize();
            Section.SectionLoad();
        }
    }

    /// <summary>
    /// Adds a empty Storage with 1 Section and 1 Bin containing 'Nothing'.
    /// </summary>
    public void SectionAdd()
    {
        int intCheck = 0;
        do {
            if (System.IO.Directory.Exists(stringPathStorage + "\\" + intCheck)) {
            } else {
                break; // TODO: might not be correct. Was : Exit Do
            }
            intCheck += 1;
        } while (true);
        Array.Resize(ref arraySection, intCheck + 1);
        System.IO.Directory.CreateDirectory(stringPathStorage + "\\" + intCheck);
        arraySection[arraySection.GetUpperBound(0)] = new section();
        arraySection[arraySection.GetUpperBound(0)].SectionPath = stringPathStorage + "\\" + intCheck;
    }
}