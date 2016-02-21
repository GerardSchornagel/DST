using Microsoft.VisualBasic;
using System;

/// <summary>
/// Main Menu.
/// </summary>
public partial class formMain
{
    public formMain()
    {
        // The Me.InitializeComponent call is required for Windows Forms designer support.
        this.InitializeComponent();
    }

    public void formMain_Load(object sender, EventArgs e)
    {

    }

    public void buttonLoad_Click(object sender, EventArgs e)
    {
        //add filedialog and change lastProfile
        System.Windows.Forms.FolderBrowserDialog folderdialogLoadGame = new System.Windows.Forms.FolderBrowserDialog();
        folderdialogLoadGame.ShowNewFolderButton = false;
        folderdialogLoadGame.SelectedPath = System.IO.Directory.GetCurrentDirectory + "\\save";
        folderdialogLoadGame.Description = "Please select one of the numbered directory's";
        folderdialogLoadGame.ShowDialog();
        gamecache.currentSettings.LastProfile = Convert.ToString(folderdialogLoadGame.SelectedPath.Substring(folderdialogLoadGame.SelectedPath.Length - 1, 1));
        //Load Game
        buttonLastCharacter_Click(null, null);
    }

    public void buttonProfileManagement_Click(object sender, EventArgs e)
    {
        gamecache.InfoProfile();
    }

    public void buttonCharacterManagement_Click(object sender, EventArgs e)
    {

    }

    public void buttonLastCharacter_Click(object sender, EventArgs e)
    {
        gamecache.ResumeGame();
    }

    public void buttonEditor_Click(object sender, EventArgs e)
    {
        gamecache.EditorForm = new formEditor();
        gamecache.EditorForm.Show();
    }

    public void buttonOptions_Click(object sender, EventArgs e)
    {
        formOptions OptionsForm = new formOptions();
        OptionsForm.Show();
    }

    public void buttonQuit_Click(object sender, EventArgs e)
    {
        //Check for WarningMessage Setting and show the warning with Yes/No, else just End
        if (gamecache.currentSettings.MessagesProgramQuit) {
            Environment.Exit(0);
        } else {
            if (Interaction.MsgBox("This will end the game, are you sure?", MsgBoxStyle.YesNo, "Quit")) {
                Environment.Exit(0);
            } else {
                return;
            }
        }
    }
}