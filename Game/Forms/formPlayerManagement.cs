using Microsoft.VisualBasic;
using System;

/// <summary>
/// Used for creating new Profiles and characters.
/// </summary>
public partial class formPlayerManagement
{
    public formPlayerManagement()
    {
        // The Me.InitializeComponent call is required for Windows Forms designer support.
        this.InitializeComponent();
    }

    public void formPlayerManagement_Load(object sender, EventArgs e)
    {
        listboxProfile.Items.Clear();
        if (gamecache.MainSettings.LastUserID == 0) {
            Interaction.MsgBox("Please create a first Player Profile to enter the MainMenu.");

        } else {
            foreach (string file in System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory() + (char)92 + "save" + (char)92)) {
                string[] profileID = file.Split((char)92);
                if (profileID[profileID.GetUpperBound(0)] == "settings") {
                    continue;
                } else {
                    listboxProfile.Items.Add(profileID[profileID.GetUpperBound(0)]);
                }
            }
        }
    }

    public void buttonCreate_Click(object sender, EventArgs e)
    {
        //Little loop to determine what slot to use. (max=256 slots|decide to auto-overwrite last or to stop proccess?)
        int intS = 0;
        while (intS <= 255) {
            if (System.IO.Directory.Exists(System.IO.Directory.GetCurrentDirectory() + (char)92 + "save" + (char)92 + intS)) {
                intS++;
            } else {
                gamecache.currentPlayer.ProfileID = intS;
                intS = 256;
            }
        }
        gamecache.currentPlayer.ProfileName = textboxProfileID.Text;
        gamecache.currentPlayer.NameFirst = textboxNameFirst.Text;
        gamecache.currentPlayer.NameLast = textboxNameLast.Text;
        gamecache.currentPlayer.BirthYear = Convert.ToInt32(textboxBirthYear.Text);
        gamecache.currentPlayer.BirthMonth = Convert.ToInt32(textboxBirthMonth.Text);
        gamecache.currentPlayer.BirthDay = Convert.ToInt32(textboxBirthDay.Text);
        gamecache.currentPlayer.Gender = checkboxGender.Text;
        gamecache.currentPlayer.Email = textboxEMail.Text;
        gamecache.currentPlayer.NotificationEmail = checkboxNotification.Checked;
        gamecache.currentPlayer.CreateDate = Convert.ToString((DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year));
        gamecache.currentPlayer.CreateTime = Convert.ToString(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
        gamecache.currentCharacter.CreateDate = Convert.ToString((DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year));
        gamecache.currentCharacter.CreateTime = Convert.ToString(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
        
        gamecache.NewProfile();
    }

    public void textboxBirthYear_LostFocus(object sender, EventArgs e)
    {
        try {
            textboxBirthYear.Text = Convert.ToString(Convert.ToInt32(textboxBirthYear.Text));
        } catch (System.FormatException ex) {
            Interaction.MsgBox(ex);
            textboxBirthYear.Text = "";
        }
    }

    public void textboxBirthMonth_LostFocus(object sender, EventArgs e)
    {
        try {
            textboxBirthMonth.Text = Convert.ToString(Convert.ToInt32(textboxBirthMonth.Text));
        } catch (System.FormatException ex) {
            Interaction.MsgBox(ex);
            textboxBirthMonth.Text = "";
        }
    }

    public void textboxBirthDay_LostFocus(object sender, EventArgs e)
    {
        try {
            textboxBirthDay.Text = Convert.ToString(Convert.ToInt32(textboxBirthDay.Text));
        } catch (System.FormatException ex) {
            Interaction.MsgBox(ex);
            textboxBirthDay.Text = "";
        }
    }

    public void checkboxGender_CheckedChanged(object sender, EventArgs e)
    {
        if (checkboxGender.Checked) {
            checkboxGender.Text = "Female";
        } else {
            checkboxGender.Text = "Male";
        }
    }

    public void textboxNameFirst_TextChanged(object sender, EventArgs e)
    {
        textboxProfileID.Text = textboxNameLast.Text + "_" + textboxNameFirst.Text;
    }

    public void textboxNameLast_TextChanged(object sender, EventArgs e)
    {
        textboxProfileID.Text = textboxNameLast.Text + "_" + textboxNameFirst.Text;
    }

    public void buttonLoad_Click(object sender, EventArgs e)
    {
        gamecache.MainSettings.LastUserID = Convert.ToInt32(listboxProfile.SelectedItem.ToString());
        gamecache.ResumeGame();
    }
    
    public void formPlayerManagement_Dispose(object sender, EventArgs e)
    {
        gamecache.MainMenu.Show();
    }
}