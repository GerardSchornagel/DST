using Microsoft.VisualBasic;
using System;

/// <summary>
/// Description of form/class/etc.
/// </summary>
public partial class formItemManagement
{
    System.Windows.Forms.Timer timerUpdate = new System.Windows.Forms.Timer();

    public formItemManagement()
    {
        // The Me.InitializeComponent call is required for Windows Forms designer support.
        this.InitializeComponent();
    }

    internal void formItemManagement_Load(object sender, EventArgs e)
    {
        timerUpdate.Tick += timerUpdate_Tick;
        //TODO:Make a minium Interval value based on pc time to process random data equal to a medium big Savegame-size.
        timerUpdate.Interval = 5000;
        timerUpdate.Start();

        //groupboxStorage
        labelStorageTotalSection.Text = "\\ " + gamecache.currentCharacterStorage.arraySection.GetUpperBound(0);
        updownStorageSection.Maximum = gamecache.currentCharacterStorage.arraySection.GetUpperBound(0);
        if (gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0) != -1) {
            labelStorageTotalArticle.Text = "\\ " + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0);
            updownStorageArticle.Maximum = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0);

            textboxStoragePhItem.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Path + (char)92 + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].File);
            textboxStorageName.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Item.Name;
            textboxStorageQuantity.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Quantity);
            textboxStorageLastSell.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastSell);
            textboxStorageLastBuy.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastBuy);
        }

        //groupboxStore
        labelStoreTotalLevel.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel.GetUpperBound(0);
        updownStoreLevel.Maximum = gamecache.currentCharacterStore.arrayLevel.GetUpperBound(0);
        labelStoreTotalShelf.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf.GetUpperBound(0);
        updownStoreShelf.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf.GetUpperBound(0);
        if (gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0) != -1) {
            labelStoreTotalBin.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);
            updownStoreBin.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);

            textboxStorePhItem.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)]._Path + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)]._File;
            textboxStoreName.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Article_Data.Item.Name;
            textboxStoreQuantity.Text = Convert.ToString((gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Quantity));
            updownStorePrice.Value = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Price;
        }
    }

    private void timerUpdate_Tick(object sender, EventArgs e)
    {
        //groupboxStorage
        labelStorageTotalSection.Text = "\\ " + gamecache.currentCharacterStorage.arraySection.GetUpperBound(0);
        updownStorageSection.Maximum = gamecache.currentCharacterStorage.arraySection.GetUpperBound(0);
        if (gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0) != -1) {
            labelStorageTotalArticle.Text = "\\ " + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0);
            updownStorageArticle.Maximum = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0);

            textboxStoragePhItem.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Path + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].File;
            textboxStorageName.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Item.Name;
            textboxStorageQuantity.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Quantity);
            textboxStorageLastSell.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastSell);
            textboxStorageLastBuy.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastBuy);
        }
        //groupboxStore
        labelStoreTotalLevel.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel.GetUpperBound(0);
        updownStoreLevel.Maximum = gamecache.currentCharacterStore.arrayLevel.GetUpperBound(0);
        labelStoreTotalShelf.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf.GetUpperBound(0);
        updownStoreShelf.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf.GetUpperBound(0);
        if (gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0) != -1) {
            labelStoreTotalBin.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);
            updownStoreBin.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);

            textboxStorePhItem.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)]._Path + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)]._File;
            textboxStoreName.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Article_Data.Item.Name;
            textboxStoreQuantity.Text = Convert.ToString((gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Quantity));
            updownStorePrice.Value = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Price;
        }
    }

    public void updownStoreLevel_ValueChanged(object sender, EventArgs e)
    {
        labelStoreTotalShelf.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf.GetUpperBound(0);
        updownStoreShelf.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf.GetUpperBound(0);
        if (gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0) != -1) {
            labelStoreTotalBin.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);
            updownStoreBin.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);

            textboxStorePhItem.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)]._Path + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)]._File;
            textboxStoreName.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Article_Data.Item.Name;
            textboxStoreQuantity.Text = Convert.ToString((gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Quantity));
            updownStorePrice.Value = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Price;
        }
    }

    public void updownStoreShelf_ValueChanged(object sender, EventArgs e)
    {
        if (gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0) != -1) {
            labelStoreTotalBin.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);
            updownStoreBin.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);

            textboxStorePhItem.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)]._Path + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)]._File;
            textboxStoreName.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Article_Data.Item.Name;
            textboxStoreQuantity.Text = Convert.ToString((gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Quantity));
            updownStorePrice.Value = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Price;
        }
    }

    public void updownStoreBin_ValueChanged(object sender, EventArgs e)
    {
        if (gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0) != -1) {
            textboxStorePhItem.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)]._Path + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)]._File;
            textboxStoreName.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Article_Data.Item.Name;
            textboxStoreQuantity.Text = Convert.ToString((gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Quantity));
            updownStorePrice.Value = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Price;
        }
    }

    public void updownStorePrice_LostFocus(object sender, EventArgs e)
    {
        updownStorePrice.Value = Convert.ToInt32(updownStorePrice.Value);
        int integerSection = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Section;
        int integerArticle = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].Article;
        gamecache.currentCharacterStorage.arraySection[integerSection].arrayArticle[integerArticle].LastSell = Convert.ToInt32(updownStorePrice.Value);

        formItemManagement_Load(null, null);
    }

    public void updownStorageSection_ValueChanged(object sender, EventArgs e)
    {
        if (gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0) != -1) {
            labelStorageTotalArticle.Text = "\\ " + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0);
            updownStorageArticle.Maximum = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0);

            textboxStoragePhItem.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Path + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].File;
            textboxStorageName.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Item.Name;
            textboxStorageQuantity.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Quantity);
            textboxStorageLastSell.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastSell);
            textboxStorageLastBuy.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastBuy);
        }
    }

    public void updownStorageArticle_ValueChanged(object sender, EventArgs e)
    {
        if (gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0) != -1) {
            textboxStoragePhItem.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Path + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].File;
            textboxStorageName.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Item.Name;
            textboxStorageQuantity.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Quantity);
            textboxStorageLastSell.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastSell);
            textboxStorageLastBuy.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastBuy);
        }
    }

    public void buttonToStore_Click(object sender, EventArgs e)
    {
        timerUpdate.Enabled = false;
        int integerStoreLevel = Convert.ToInt32(updownStoreLevel.Value);
        int integerStoreShelf = Convert.ToInt32(updownStoreShelf.Value);
        int integerStoreBin = Convert.ToInt32(updownStoreBin.Value);
        int integerStorageSection = Convert.ToInt32(updownStorageSection.Value);
        int integerStorageArticle = Convert.ToInt32(updownStorageArticle.Value);

        if (textboxStoreName.Text == textboxStorageName.Text) {
            gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].Quantity += gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].Quantity;
            gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].Quantity = 0;

        } else {
            if (Interaction.MsgBox("Replaces current item, else add new Bin to current Shelf." + (char)10 + "Use No for the first time when a player is new.", Microsoft.VisualBasic.MsgBoxStyle.YesNo, "Replace?").ToString() == "6") {
                int integerSection = gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].Section;
                int integerArticle = gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].Article;
                gamecache.currentCharacterStorage.arraySection[integerSection].arrayArticle[integerArticle].Quantity += gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].Quantity;

                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].Storage = 0;
                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].Section = integerStorageSection;
                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].Article = integerStorageArticle;
                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].Quantity = gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].Quantity;
                gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].Quantity = 0;

            } else {
                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].BinAdd(new article(), Convert.ToInt32(textboxStorageQuantity.Text), 0);
                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin.GetUpperBound(0)].Storage = 0;
                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin.GetUpperBound(0)].Section = integerStorageSection;
                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin.GetUpperBound(0)].Article = integerStorageArticle;
                gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].Quantity = 0;
            }
        }
        timerUpdate.Enabled = true;
        timerUpdate_Tick(null, null);
    }

    public void buttonToStorage_Click(object sender, EventArgs e)
    {
        int integerStoreLevel = Convert.ToInt32(updownStoreLevel.Value);
        int integerStoreShelf = Convert.ToInt32(updownStoreShelf.Value);
        int integerStoreBin = Convert.ToInt32(updownStoreBin.Value);
        int integerStorageSection = Convert.ToInt32(updownStorageSection.Value);
        int integerStorageArticle = Convert.ToInt32(updownStorageArticle.Value);

        int integerSection = gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].Section;
        int integerArticle = gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].Article;
        gamecache.currentCharacterStorage.arraySection[integerSection].arrayArticle[integerArticle].Quantity += gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].Quantity;
        gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].Quantity = 0;
        timerUpdate_Tick(null, null);
    }

    public void buttonClose_Click(object sender, EventArgs e)
    {
        this.Hide();
    }
}