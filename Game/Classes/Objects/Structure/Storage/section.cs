using System;

/// <summary>
/// DataType representing any number of Item's as a section().
/// </summary>
public class section
{
    public article[] arrayArticle;
    string stringPathSection;
    int integerArticleCounter;

    /// <summary>
    /// Get/Adjust the path of the section without Initialize() and Load().
    /// </summary>
    public string SectionPath {
        get { return stringPathSection; }
        set { stringPathSection = value; }
    }

    /// <summary>
    /// Resize arrayItem and fill with New Item's.
    /// </summary>
    public void SectionInitialize()
    {
        integerArticleCounter = 0;
        arrayArticle = new article[System.IO.Directory.GetFiles(stringPathSection, "*.ini", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0) + 1];
        foreach (string file in System.IO.Directory.GetFiles(stringPathSection, "*.ini", System.IO.SearchOption.TopDirectoryOnly)) {
            arrayArticle[integerArticleCounter] = new article();
            arrayArticle[integerArticleCounter].ArticlePath = file;

            integerArticleCounter += 1;
        }
    }
    
    /// <summary>
    /// Loads all Item's with Item Info.
    /// </summary>
    public void SectionLoad()
    {
        foreach (article Article in arrayArticle) {
            Article.articleLoad(stringPathSection + "\\");
        }
    }
    
    /// <summary>
    /// Makes new Article with the given template. With ArticleSave().
    /// </summary>
    /// <param name="ArticleInfo">New String() {ItemPath, ItemFile, Quantity, LastSell, LastBuy}</param>
    public void ArticleAdd(string[] ArticleInfo)
    {
        int intCheck = 0;
        do {
            if (System.IO.File.Exists(stringPathSection + "\\" + intCheck + ".ini")) {
            } else {
                break; // TODO: might not be correct. Was : Exit Do
            }
            intCheck += 1;
        } while (true);
        Array.Resize(ref arrayArticle, intCheck + 1);
        arrayArticle[arrayArticle.GetUpperBound(0)] = new article();
        arrayArticle[arrayArticle.GetUpperBound(0)].ArticlePath = stringPathSection + "\\";
        arrayArticle[arrayArticle.GetUpperBound(0)].ArticleFile = intCheck + ".ini";
        arrayArticle[arrayArticle.GetUpperBound(0)].ItemPath = ArticleInfo[0];
        arrayArticle[arrayArticle.GetUpperBound(0)].ItemFile = ArticleInfo[1];
        arrayArticle[arrayArticle.GetUpperBound(0)].Quantity = Convert.ToInt32(ArticleInfo[2]);
        arrayArticle[arrayArticle.GetUpperBound(0)].LastSell = Convert.ToInt32(ArticleInfo[3]);
        arrayArticle[arrayArticle.GetUpperBound(0)].LastBuy = Convert.ToInt32(ArticleInfo[4]);
        arrayArticle[arrayArticle.GetUpperBound(0)].ArticleSave(stringPathSection);
    }
}