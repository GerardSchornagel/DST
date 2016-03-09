using Microsoft.VisualBasic;
using System;

/// <summary>
/// Description of form/class/etc.
/// </summary>
public partial class formItemManagement
{
    private int integerCounterSearch;
    private int integerCounterArticle;
    private System.Windows.Forms.Timer timerUpdate = new System.Windows.Forms.Timer();

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
        if (gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle != null) {
            labelStorageTotalArticle.Text = "\\ " + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0);
            updownStorageArticle.Maximum = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0);

            textboxStoragePhItem.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].ArticlePath + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].ArticleFile);
            textboxStorageName.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].ItemLink.Name;
            textboxStorageQuantity.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Quantity);
            textboxStorageLastSell.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastSell);
            textboxStorageLastBuy.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastBuy);
        }

        //groupboxStore
        labelStoreTotalLevel.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel.GetUpperBound(0);
        updownStoreLevel.Maximum = gamecache.currentCharacterStore.arrayLevel.GetUpperBound(0);
        labelStoreTotalShelf.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf.GetUpperBound(0);
        updownStoreShelf.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf.GetUpperBound(0);
        if (gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin != null) {
            labelStoreTotalBin.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);
            updownStoreBin.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);

            textboxStorePhItem.Text = Convert.ToString(gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinPath + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinFile);
            textboxStoreName.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].ArticleName;
            textboxStoreQuantity.Text = Convert.ToString((gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinQuantity));
            updownStorePrice.Value = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].ArticleLastSell;
        }
    }

    private void timerUpdate_Tick(object sender, EventArgs e)
    {
        //groupboxStorage
        labelStorageTotalSection.Text = "\\ " + gamecache.currentCharacterStorage.arraySection.GetUpperBound(0);
        updownStorageSection.Maximum = gamecache.currentCharacterStorage.arraySection.GetUpperBound(0);
        if (gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle != null) {
            labelStorageTotalArticle.Text = "\\ " + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0);
            updownStorageArticle.Maximum = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0);

            textboxStoragePhItem.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].ArticlePath + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].ArticleFile;
            textboxStorageName.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].ItemLink.Name;
            textboxStorageQuantity.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Quantity);
            textboxStorageLastSell.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastSell);
            textboxStorageLastBuy.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastBuy);
        }
        //groupboxStore
        labelStoreTotalLevel.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel.GetUpperBound(0);
        updownStoreLevel.Maximum = gamecache.currentCharacterStore.arrayLevel.GetUpperBound(0);
        labelStoreTotalShelf.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf.GetUpperBound(0);
        updownStoreShelf.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf.GetUpperBound(0);
        if (gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin != null) {
            labelStoreTotalBin.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);
            updownStoreBin.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);

            textboxStorePhItem.Text = Convert.ToString(gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinPath + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinFile);
            textboxStoreName.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].ArticleName;
            textboxStoreQuantity.Text = Convert.ToString((gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinQuantity));
            updownStorePrice.Value = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].ArticleLastSell;
        }
    }

    public void updownStoreLevel_ValueChanged(object sender, EventArgs e)
    {
        labelStoreTotalShelf.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf.GetUpperBound(0);
        updownStoreShelf.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf.GetUpperBound(0);
        if (gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin != null) {
            labelStoreTotalBin.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);
            updownStoreBin.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);

            textboxStorePhItem.Text = Convert.ToString(gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinPath + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinFile);
            textboxStoreName.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].ArticleName;
            textboxStoreQuantity.Text = Convert.ToString((gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinQuantity));
            updownStorePrice.Value = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].ArticleLastSell;
        }
    }

    public void updownStoreShelf_ValueChanged(object sender, EventArgs e)
    {
        if (gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin != null) {
            labelStoreTotalBin.Text = "\\ " + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);
            updownStoreBin.Maximum = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin.GetUpperBound(0);

            textboxStorePhItem.Text = Convert.ToString(gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinPath + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinFile);
            textboxStoreName.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].ArticleName;
            textboxStoreQuantity.Text = Convert.ToString((gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinQuantity));
            updownStorePrice.Value = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].ArticleLastSell;
        }
    }

    public void updownStoreBin_ValueChanged(object sender, EventArgs e)
    {
        if (gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin != null) {
            textboxStorePhItem.Text = Convert.ToString(gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinPath + gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinFile);
            textboxStoreName.Text = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].ArticleName;
            textboxStoreQuantity.Text = Convert.ToString((gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].BinQuantity));
            updownStorePrice.Value = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].ArticleLastSell;
        }
    }

    public void updownStorePrice_LostFocus(object sender, EventArgs e)
    {
        updownStorePrice.Value = Convert.ToInt32(updownStorePrice.Value);
        int integerSection = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].LinkSection;
        int integerArticle = gamecache.currentCharacterStore.arrayLevel[Convert.ToInt32(updownStoreLevel.Value)].arrayShelf[Convert.ToInt32(updownStoreShelf.Value)].arrayBin[Convert.ToInt32(updownStoreBin.Value)].LinkArticle;
        gamecache.currentCharacterStorage.arraySection[integerSection].arrayArticle[integerArticle].LastSell = Convert.ToInt32(updownStorePrice.Value);
        gamecache.currentCharacterStorage.arraySection[integerSection].arrayArticle[integerArticle].ArticleSave(gamecache.currentCharacterStorage.arraySection[integerSection].SectionPath);

        formItemManagement_Load(null, null);
    }

    public void updownStorageSection_ValueChanged(object sender, EventArgs e)
    {
        if (gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle != null) {
            labelStorageTotalArticle.Text = "\\ " + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0);
            updownStorageArticle.Maximum = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle.GetUpperBound(0);

            textboxStoragePhItem.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].ArticlePath + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].ArticleFile;
            textboxStorageName.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].ItemLink.Name;
            textboxStorageQuantity.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].Quantity);
            textboxStorageLastSell.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastSell);
            textboxStorageLastBuy.Text = Convert.ToString(gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].LastBuy);
        }
    }

    public void updownStorageArticle_ValueChanged(object sender, EventArgs e)
    {
        if (gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle != null) {
            textboxStoragePhItem.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].ArticlePath + gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].ArticleFile;
            textboxStorageName.Text = gamecache.currentCharacterStorage.arraySection[Convert.ToInt32(updownStorageSection.Value)].arrayArticle[Convert.ToInt32(updownStorageArticle.Value)].ItemLink.Name;
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
            gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].BinQuantity += gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].Quantity;
            gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].Quantity = 0;

            gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].ArticleSave(gamecache.currentCharacterStorage.arraySection[integerStorageSection].SectionPath);
            gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].BinSave(gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].ShelfPath);
        } else {
            if (Interaction.MsgBox("Replaces current item, else add new Bin to current Shelf." + (char)10 + "Use No for the first time when a player is new.", Microsoft.VisualBasic.MsgBoxStyle.YesNo, "Replace?").ToString() == "6") {
                int integerSection = gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].LinkSection;
                int integerArticle = gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].LinkArticle;
                gamecache.currentCharacterStorage.arraySection[integerSection].arrayArticle[integerArticle].Quantity += gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].BinQuantity;
                gamecache.currentCharacterStorage.arraySection[integerSection].arrayArticle[integerArticle].ArticleSave(gamecache.currentCharacterStorage.arraySection[integerSection].SectionPath);

                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].LinkStorage = 0;
                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].LinkSection = integerStorageSection;
                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].LinkArticle = integerStorageArticle;
                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].BinQuantity = gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].Quantity;
                gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].Quantity = 0;

                gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].ArticleSave(gamecache.currentCharacterStorage.arraySection[integerStorageSection].SectionPath);
                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].BinSave(gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].ShelfPath);

            } else {
                gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].BinAdd(new string[] {
                                                                                                                       "0",
                                                                                                                       Convert.ToString(integerStorageSection),
                                                                                                                       Convert.ToString(integerStorageArticle),
                                                                                                                       textboxStorageQuantity.Text
                                                                                                                   });
                gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].Quantity = 0;

                gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].ArticleSave(gamecache.currentCharacterStorage.arraySection[integerStorageSection].SectionPath);

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

        int integerSection = gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].LinkSection;
        int integerArticle = gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].LinkArticle;
        gamecache.currentCharacterStorage.arraySection[integerSection].arrayArticle[integerArticle].Quantity += gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].BinQuantity;
        gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].BinQuantity = 0;

        gamecache.currentCharacterStorage.arraySection[integerStorageSection].arrayArticle[integerStorageArticle].ArticleSave(gamecache.currentCharacterStorage.arraySection[integerStorageSection].SectionPath);
        gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].BinSave(gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].ShelfPath);

        timerUpdate_Tick(null, null);
    }

    public void buttonClose_Click(object sender, EventArgs e)
    {
        this.Hide();
    }
}