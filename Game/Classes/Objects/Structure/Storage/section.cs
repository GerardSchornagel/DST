using System;

/// <summary>
/// DataType representing any number of Article's as a section().
/// </summary>
public class section
{
    public article[] arrayArticle;
    public int intStorage;
    public int intSection;

    /// <summary>
    /// Get/Adjust the path of the section without Initialize() and Load().
    /// </summary>
    public string sectionPath { get; set; }

    /// <summary>
    /// Resize arrayArticle and fill with new article's.
    /// </summary>
    public void SectionInitialize()
    { 
        if (System.IO.Directory.GetDirectories(sectionPath, "*", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0) == 0) {
            arrayArticle = new article[1];
        } else {
            arrayArticle = new article[System.IO.Directory.GetDirectories(sectionPath, "*", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0) + 1];
        }
        for (int i = 0; i <= arrayArticle.GetUpperBound(0); i++) {
            arrayArticle[i] = new article();
            arrayArticle[i].Load(intStorage, intSection, i);
        }
    }
    
    /// <summary>
    /// Makes new Article with the given Variable's.
    /// </summary>
    /// <param name="articleItem">Item to be used as article.</param>
    /// <param name="Quantity">Quantity of article's.</param>
    /// <param name="LastBuy">Last buying price of article.</param>
    public void ArticleAdd(item articleItem, int Quantity, int LastBuy)
    {
                if (arrayArticle.GetUpperBound(0) == -1) {
            arrayArticle = new article[1];
        } else {
            Array.Resize(ref arrayArticle, arrayArticle.GetUpperBound(0) + 1);
        }
        arrayArticle[arrayArticle.GetUpperBound(0)] = new article();
        arrayArticle[arrayArticle.GetUpperBound(0)].Load(intStorage, intSection, arrayArticle.GetUpperBound(0));
        arrayArticle[arrayArticle.GetUpperBound(0)].Path = articleItem.stringPath;
        arrayArticle[arrayArticle.GetUpperBound(0)].File = articleItem.stringFilename;
        arrayArticle[arrayArticle.GetUpperBound(0)].Quantity = Quantity;
        arrayArticle[arrayArticle.GetUpperBound(0)].LastBuy = LastBuy;
    }
}