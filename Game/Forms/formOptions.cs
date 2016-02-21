using Microsoft.VisualBasic;
using System;

public partial class formOptions
{
    public formOptions()
    {
        // The Me.InitializeComponent call is required for Windows Forms designer support.
        this.InitializeComponent();
    }

    public void formOptions_Load(object sender, EventArgs e)
    {
        checkboxlistMessages.SetItemChecked(0, gamecache.currentSettings.MessagesProgramQuit);
        checkboxlistMessages.SetItemChecked(1, gamecache.currentSettings.MessagesNewgameOverwrite);
        checkboxlistMessages.SetItemChecked(2, gamecache.currentSettings.MessagesOptionsApplyRestart);
    }

    public void buttonOK_Click(object sender, EventArgs e)
    {
        //Save all options to save\setting.ini
        gamecache.currentSettings.MessagesProgramQuit = Convert.ToBoolean(checkboxlistMessages.GetItemCheckState(0));
        gamecache.currentSettings.MessagesNewgameOverwrite = Convert.ToBoolean(checkboxlistMessages.GetItemCheckState(1));
        gamecache.currentSettings.MessagesOptionsApplyRestart = Convert.ToBoolean(checkboxlistMessages.GetItemCheckState(2));
        //Warn before restarting
        if (gamecache.currentSettings.MessagesOptionsApplyRestart == false)
            Interaction.MsgBox("The program has to be restarted to take full effect.", MsgBoxStyle.Exclamation, "Please restart.");
        this.Dispose();
    }

    public void buttonCancel_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }
}