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
        checkboxlistMessages.SetItemChecked(0, gamecache.MainSettings.ExitConfirmation);
        checkboxlistMessages.SetItemChecked(1, gamecache.MainSettings.NewGameOverwrite);
        checkboxlistMessages.SetItemChecked(2, gamecache.MainSettings.RestartOnOptions);
    }

    public void buttonOK_Click(object sender, EventArgs e)
    {
        //Save all options to save\setting.ini
        gamecache.MainSettings.ExitConfirmation = Convert.ToBoolean(checkboxlistMessages.GetItemCheckState(0));
        gamecache.MainSettings.NewGameOverwrite = Convert.ToBoolean(checkboxlistMessages.GetItemCheckState(1));
        gamecache.MainSettings.RestartOnOptions = Convert.ToBoolean(checkboxlistMessages.GetItemCheckState(2));
        //Warn before restarting
        if (gamecache.MainSettings.RestartOnOptions == false)
            Interaction.MsgBox("The program has to be restarted to take full effect.", MsgBoxStyle.Exclamation, "Please restart.");
        this.Dispose();
    }

    public void buttonCancel_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }
}