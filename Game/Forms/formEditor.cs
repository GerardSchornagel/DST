using Microsoft.VisualBasic;
using System;

/// <summary>
/// Description of form/class/etc.
/// </summary>
public partial class formEditor
{
    private string[,] stringExport;
    private iniHandler iniFilehandler = new iniHandler();

    public formEditor()
    {
        // The Me.InitializeComponent call is required for Windows Forms designer support.
        this.InitializeComponent();
        textboxFilename.Text = System.IO.Directory.GetCurrentDirectory + "\\data\\";
    }

    public void buttonClose_Click(object sender, EventArgs e)
    {
        this.Hide();
    }

    public void buttonSave_Click(object sender, EventArgs e)
    {
        textboxEdit.AppendText(Char(13));
        string[] stringMediator = textboxEdit.Text.Split(Char(10));
        int integerCount = 0;
        do {
            stringMediator[integerCount] = stringMediator[integerCount].Remove(stringMediator[integerCount].Length - 1, 1);
            integerCount += 1;
        } while (!(integerCount > stringMediator.GetUpperBound(0)));

        int integerColumn = -1;
        int integerRow = 0;

        string[] stringColumns = null;
        stringColumns = textboxEdit.Text.Split(Char(91));
        foreach (string line in stringColumns) {
            string[] stringRow = line.Split(Char(60));
            if (integerRow < stringRow.GetUpperBound(0))
                integerRow = stringRow.GetUpperBound(0);
        }
        stringExport = new string[stringColumns.GetUpperBound(0), (integerRow * 2) + 1];

        integerRow = 0;
        foreach (string line in stringMediator) {
            if (line.StartsWith(Char(91))) {
                integerColumn += 1;
                integerRow = 0;
                stringExport[integerColumn, integerRow] = line;
            } else if (string.IsNullOrEmpty(line)) {

            } else {
                integerRow += 1;
                stringExport[integerColumn, integerRow] = line;
            }
        }
        iniFilehandler.Save(textboxFilename.Text, stringExport);
    }

    public void buttonLoad_Click(object sender, EventArgs e)
    {
        textboxEdit.Text = "";
        stringExport = iniFilehandler.Load(textboxFilename.Text);
        foreach (string line in stringExport) {
            textboxEdit.AppendText(line + Char(13) + Char(10));
        }
    }

    public void buttonBrowse_Click(object sender, EventArgs e)
    {
        System.Windows.Forms.SaveFileDialog filebrowser = new System.Windows.Forms.SaveFileDialog();
        filebrowser.AddExtension = false;
        filebrowser.DefaultExt = "pd";
        filebrowser.InitialDirectory = System.IO.Directory.GetCurrentDirectory + "\\data";
        filebrowser.Title = "Choose new name or edit existing one.";
        filebrowser.ShowDialog();
        textboxFilename.Text = filebrowser.FileName;
    }

    public void formEditor_Load(object sender, EventArgs e)
    {
        listboxDescription.Items.Add("Items");
        listboxDescription.Items.Add("Customers");
        listboxDescription.Items.Add("Settings");
        listboxDescription.Items.Add("Namelist");
    }

    public void listboxDescription_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (listboxDescription.SelectedIndex) {
            case 0:
                //Items
                textboxDescription.Text = "[ItemInformation]" + Char(13) + Char(10) + "<Name/Title>" + Char(13) + Char(10) + "<Brand/Author>" + Char(13) + Char(10) + "<Company/Publisher>" + Char(13) + Char(10) + "<Genre>" + Char(13) + Char(10) + "<Category>" + Char(13) + Char(10) + "<Family>" + Char(13) + Char(10) + Char(13) + Char(10) + "[Statistics]" + Char(13) + Char(10) + "<Quality>" + Char(13) + Char(10) + "<Popularity>" + Char(13) + Char(10) + "<Rarity>" + Char(13) + Char(10) + "<BaseWorth>" + Char(13) + Char(10) + "<ItemTier>" + Char(13) + Char(10) + Char(13) + Char(10) + "[Various]" + Char(13) + Char(10) + "<PictureFilename>" + Char(13) + Char(10) + "<Description>";
                break;
            case 1:
                //Customers
                textboxDescription.Text = "[Age]" + Char(13) + Char(10) + "<Min>" + Char(13) + Char(10) + "<Max>" + Char(13) + Char(10) + Char(13) + Char(10) + "[Money]" + Char(13) + Char(10) + "<Min>" + Char(13) + Char(10) + "<Max>" + Char(13) + Char(10) + Char(13) + Char(10) + "[Desire]" + Char(13) + Char(10) + "<Min>" + Char(13) + Char(10) + "<Max>";
                break;
            case 2:
                //Settings
                textboxDescription.Text = "[WarningMessages]" + Char(13) + Char(10) + "<LastProfileID>" + Char(13) + Char(10) + "<ProgramQuit>" + Char(13) + Char(10) + "<NewgameOverwrite>" + Char(13) + Char(10) + "<OptionsApplyRestart>";
                break;
            case 3:
                //Namelist
                textboxDescription.Text = "[Name List Data]" + Char(13) + Char(10) + "<Male>" + Char(13) + Char(10) + "<Female>";
                break;
        }
    }
}