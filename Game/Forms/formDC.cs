using Microsoft.VisualBasic;
using System;

public partial class formDC
{
    Random RandomInteger = new Random();
    string[] stringItemOrder;

    int integerCounterArticle;
    int integerCounterSearch;

    public formDC()
    {
        // The Me.InitializeComponent call is required for Windows Forms designer support.
        this.InitializeComponent();
    }

    public void formItemManagement_Load(object sender, EventArgs e)
    {
        //Fill the first dropdown with the Store preset.
        comboboxFamily.Items.Clear();

        string[] stringDirectories = null;
        string[] stringMediator = null;
        stringDirectories = System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory() + "\\data\\items\\store\\", "*", System.IO.SearchOption.TopDirectoryOnly);
        foreach (string directory in stringDirectories) {
            stringMediator = directory.Split((char)92);
            comboboxFamily.Items.Add(stringMediator[stringMediator.GetUpperBound(0)]);
        }
    }

    public void comboboxFamily_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Loop through every file in the correspondending folder and add to listbox.
        comboboxCategory.Items.Clear();

        string[] stringDirectories = null;
        string[] stringMediator = null;
        stringDirectories = System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory() + "\\data\\items\\store\\" + comboboxFamily.SelectedItem.ToString(), "*", System.IO.SearchOption.TopDirectoryOnly);
        foreach (string directory in stringDirectories) {
            stringMediator = directory.Split((char)92);
            comboboxCategory.Items.Add(stringMediator[stringMediator.GetUpperBound(0)]);
        }
    }

    public void comboboxCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Loop through every file in the correspondending folder and add to listbox.
        comboboxGenre.Items.Clear();

        string[] stringDirectories = null;
        string[] stringMediator = null;
        stringDirectories = System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory() + "\\data\\items\\store\\" + comboboxFamily.SelectedItem + "\\" + comboboxCategory.SelectedItem, "*", System.IO.SearchOption.TopDirectoryOnly);
        foreach (string directory in stringDirectories) {
            stringMediator = directory.Split((char)92);
            comboboxGenre.Items.Add(stringMediator[stringMediator.GetUpperBound(0)]);
        }
    }

    public void comboboxGenre_SelectedIndexChanged(object sender, EventArgs e)
    {
        comboboxName.Items.Clear();

        string[] stringFiles = null;
        string[] stringMediator = null;
        stringFiles = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "\\data\\items\\store\\" + comboboxFamily.SelectedItem + "\\" + comboboxCategory.SelectedItem + "\\" + comboboxGenre.SelectedItem, "*", System.IO.SearchOption.TopDirectoryOnly);
        foreach (string file in stringFiles) {
            stringMediator = file.Split((char)92);
            comboboxName.Items.Add((stringMediator[stringMediator.GetUpperBound(0)]).Remove(stringMediator[stringMediator.GetUpperBound(0)].Length - 4, 4));
        }
    }

    public void comboboxName_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Check for miss-click
        if (string.IsNullOrEmpty(comboboxName.Text))
            return;
        item itemSelected = new item("store" + (char)92 + comboboxFamily.SelectedItem + (char)92 + comboboxCategory.SelectedItem + (char)92 + comboboxGenre.Text, comboboxName.Text + ".ini");

        labelItemFamilyDisplay.Text = itemSelected.Family;
        labelItemCategoryDisplay.Text = itemSelected.Category;
        labelItemGenreDisplay.Text = itemSelected.Genre;
        labelItemCompanyDisplay.Text = itemSelected.Company;
        labelItemBrandDisplay.Text = itemSelected.Brand;
        labelItemItemNameDisplay.Text = itemSelected.Name;

        labelStatisticsQualityDisplay.Text = itemSelected.Quality;
        labelStatisticsPopularityDisplay.Text = itemSelected.Popularity;
        labelStatisticsRarityDisplay.Text = itemSelected.Rarity;
        labelStatisticsBaseWorthDisplay.Text = itemSelected.BaseWorth;
        labelStatisticsItemTierDisplay.Text = itemSelected.ItemTier;

        labelVariousPicturePathDisplay.Text = itemSelected.PictureFilename;
        labelVariousDescriptionDisplay.Text = itemSelected.Description;

        textboxBuyPrice.Text = Convert.ToString(RandomInteger.Next(Convert.ToInt32(Convert.ToDouble(labelStatisticsBaseWorthDisplay.Text) - (Convert.ToDouble(labelStatisticsBaseWorthDisplay.Text) * 0.5)), Convert.ToInt32(Convert.ToDouble(labelStatisticsBaseWorthDisplay.Text) + (Convert.ToDouble(labelStatisticsBaseWorthDisplay.Text) * 0.25))));
    }

    public void buttonClose_Click(object sender, EventArgs e)
    {
        this.Hide();
    }

    public void buttonBuy_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textboxBuyAmount.Text))
            return;

        if (gamecache.currentCharacter.Balance < Convert.ToInt32(textboxPriceTotal.Text))
            Interaction.MsgBox("Not enough balance.");

        if (gamecache.currentCharacter.Balance >= Convert.ToInt32(textboxPriceTotal.Text)) {
            Interaction.MsgBox("You bought goods.");

            gamecache.currentCharacter.Balance -= Convert.ToInt32(textboxPriceTotal.Text);
            gamecache.currentCharacter.SpendingsTotal += Convert.ToInt32(textboxPriceTotal.Text);
            //[Department]\[Genre]\[SubGenre]\[Itemname].ini
            //Get product-order into temponary String Array.
            stringItemOrder = new string[5];
            stringItemOrder[0] = System.IO.Directory.GetCurrentDirectory() + "\\Data\\Items\\Store\\" + labelItemFamilyDisplay.Text + "\\" + labelItemCategoryDisplay.Text + "\\" + labelItemGenreDisplay.Text + "\\";
            //ItemPath
            stringItemOrder[1] = labelItemItemNameDisplay.Text + ".ini";
            //ItemFile
            stringItemOrder[2] = textboxBuyAmount.Text;
            //Quantity
            stringItemOrder[3] = "0";
            //Last Selling Price
            stringItemOrder[4] = textboxBuyPrice.Text;
            //Last Buying Price

            integerCounterSearch = 0;
            integerCounterArticle = 0;
            do {
                if (gamecache.currentCharacterStorage.arraySection[integerCounterSearch].arrayArticle == null)
                    break; // TODO: might not be correct. Was : Exit Do
                foreach (article Article in gamecache.currentCharacterStorage.arraySection[integerCounterSearch].arrayArticle) {
                    if (Article.ItemLink.Name == labelItemItemNameDisplay.Text) {
                        gamecache.currentCharacterStorage.arraySection[integerCounterSearch].arrayArticle[integerCounterArticle].Quantity += Convert.ToInt32(stringItemOrder[2]);
                        gamecache.currentCharacterStorage.arraySection[integerCounterSearch].arrayArticle[integerCounterArticle].LastBuy = Convert.ToInt32(stringItemOrder[4]);
                        gamecache.currentCharacterStorage.arraySection[integerCounterSearch].arrayArticle[integerCounterArticle].ArticleSave(gamecache.currentCharacterStorage.arraySection[integerCounterSearch].SectionPath);
                        return;
                    }
                    integerCounterArticle += 1;
                }
                integerCounterArticle = 0;
                integerCounterSearch += 1;
            } while (!(integerCounterSearch >= gamecache.currentCharacterStorage.arraySection.GetUpperBound(0)));

            gamecache.currentCharacterStorage.arraySection[0].ArticleAdd(stringItemOrder);
        }
    }

    public void textboxBuyAmount_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textboxBuyAmount.Text))
            return;
        textboxPriceTotal.Text = Convert.ToString(Convert.ToInt32(textboxBuyAmount.Text) * Convert.ToInt32(textboxBuyPrice.Text));
    }
}