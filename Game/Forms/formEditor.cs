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
        textboxFilename.Text = System.IO.Directory.GetCurrentDirectory() + "\\data\\";
    }

    public void buttonClose_Click(object sender, EventArgs e)
    {
        this.Hide();
    }

    public void buttonSave_Click(object sender, EventArgs e)
    {
        textboxEdit.AppendText(((char)13).ToString());
        string[] stringMediator = textboxEdit.Text.Split((char)10);
        int integerCount = 0;
        do {
            stringMediator[integerCount] = stringMediator[integerCount].Remove(stringMediator[integerCount].Length - 1, 1);
            integerCount += 1;
        } while (!(integerCount > stringMediator.GetUpperBound(0)));

        int integerColumn = -1;
        int integerRow = 0;

        string[] stringColumns = null;
        stringColumns = textboxEdit.Text.Split((char)91);
        foreach (string line in stringColumns) {
            string[] stringRow = line.Split((char)60);
            if (integerRow < stringRow.GetUpperBound(0))
                integerRow = stringRow.GetUpperBound(0);
        }
        stringExport = new string[stringColumns.GetUpperBound(0), (integerRow * 2) + 1];

        integerRow = 0;
        foreach (string line in stringMediator) {
            if (line.StartsWith(((char)91).ToString())) {
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
            textboxEdit.AppendText(line + (char)13 + (char)10);
        }
    }

    public void buttonBrowse_Click(object sender, EventArgs e)
    {
        System.Windows.Forms.SaveFileDialog filebrowser = new System.Windows.Forms.SaveFileDialog();
        filebrowser.AddExtension = false;
        filebrowser.DefaultExt = "pd";
        filebrowser.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\data";
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
                textboxDescription.Text = "[ItemInformation]" + (char)13 + (char)10 + "<Name/Title>" + (char)13 + (char)10 + "<Brand/Author>" + (char)13 + (char)10 + "<Company/Publisher>" + (char)13 + (char)10 + "<Genre>" + (char)13 + (char)10 + "<Category>" + (char)13 + (char)10 + "<Family>" + (char)13 + (char)10 + (char)13 + (char)10 + "[Statistics]" + (char)13 + (char)10 + "<Quality>" + (char)13 + (char)10 + "<Popularity>" + (char)13 + (char)10 + "<Rarity>" + (char)13 + (char)10 + "<BaseWorth>" + (char)13 + (char)10 + "<ItemTier>" + (char)13 + (char)10 + (char)13 + (char)10 + "[Various]" + (char)13 + (char)10 + "<PictureFilename>" + (char)13 + (char)10 + "<Description>";
                break;
            case 1:
                //Customers
                textboxDescription.Text = "[Age]" + (char)13 + (char)10 + "<Min>" + (char)13 + (char)10 + "<Max>" + (char)13 + (char)10 + (char)13 + (char)10 + "[Money]" + (char)13 + (char)10 + "<Min>" + (char)13 + (char)10 + "<Max>" + (char)13 + (char)10 + (char)13 + (char)10 + "[Desire]" + (char)13 + (char)10 + "<Min>" + (char)13 + (char)10 + "<Max>";
                break;
            case 2:
                //Settings
                textboxDescription.Text = "[WarningMessages]" + (char)13 + (char)10 + "<LastProfileID>" + (char)13 + (char)10 + "<ProgramQuit>" + (char)13 + (char)10 + "<NewgameOverwrite>" + (char)13 + (char)10 + "<OptionsApplyRestart>";
                break;
            case 3:
                //Namelist
                textboxDescription.Text = "[Name List Data]" + (char)13 + (char)10 + "<Male>" + (char)13 + (char)10 + "<Female>";
                break;
        }
    }
}