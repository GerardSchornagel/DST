using Microsoft.VisualBasic;
using System;

/// <summary>
/// Description of form/class/etc.
/// </summary>
public class catalog
{
    private item[] itemDatabase;
    private item itemCurrent;
    public catalog()
    {

    }

    //Conains an array all items.
    public void LoadDatabase()
    {
        string[] stringItemPaths = null;
        stringItemPaths = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory + "\\data\\items\\store", "*.ini", System.IO.SearchOption.AllDirectories);
        itemDatabase = new item[stringItemPaths.GetUpperBound(0) + 1];

        int integerEntry = 0;
        foreach (string itempath in stringItemPaths) {
            itemDatabase[integerEntry] = new item(itempath);
            integerEntry += 1;
        }
    }

    //Get return with Family,Category,Genre,Name
    public item GetItem(string Family, string Category, string Genre, string Name)
    {
        foreach (item article in itemDatabase) {
            if (article.Family == Family && article.Category == Category && article.Genre == Genre && article.Name_Title == Name) {
                //Get article to itemCurrent & Return.
                itemCurrent = article;
                return article;
            }
        }
        Interaction.MsgBox("No such item in database." + Char(13) + Family + " - " + Category + " - " + Genre + " - " + Name);
        return null;
    }
}