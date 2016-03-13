using System;

/// <summary>
/// Item information handler
/// </summary>
public class item
{
    ioINI iniFilehandler = new ioINI();
    string stringPath;
    string stringFilename;
    string[,,] stringItem;

    //Item Information
    public string Name { get; set; }
    public string Brand { get; set; }
    public string Company { get; set; }
    public string Genre { get; set; }
    public string Category { get; set; }
    public string Family { get; set; }
    //Statistics
    public string Quality { get; set; }
    public string Popularity { get; set; }
    public string Rarity { get; set; }
    public string BaseWorth { get; set; }
    public string ItemTier { get; set; }
    //Various
    public string PictureFilename { get; set; }
    public string Description { get; set; }

    public item(string path, string file)
    {
        //Set current Ethnic Variable to memory
        stringPath = path;
        stringFilename = file;
        //Fill stringDetails with pathEthnic
        stringItem = iniFilehandler.Load(path, file);
        //Item Information
        Name = stringItem[0, 1, 1];
        Brand = stringItem[0, 2, 1];
        Company = stringItem[0, 3, 1];
        Genre = stringItem[0, 4, 1];
        Category = stringItem[0, 5, 1];
        Family = stringItem[0, 6, 1];
        //Statistics
        Quality = stringItem[1, 1, 1];
        Popularity = stringItem[1, 2, 1];
        Rarity = stringItem[1, 3, 1];
        BaseWorth = stringItem[1, 4, 1];
        ItemTier = stringItem[1, 5, 1];
        //Various
        PictureFilename = stringItem[2, 1, 1];
        Description = stringItem[2, 2, 1];
    }
}