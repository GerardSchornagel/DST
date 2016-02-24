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
        if (gamecache.currentSettings.LastProfile == "0") {
            Interaction.MsgBox("Please create a first Player Profile to enter the MainMenu.");

        } else {
            foreach (string file in System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory() + "\\save\\")) {
                string[] profileID = file.Split((char)92);
                listboxProfile.Items.Add(profileID[profileID.GetUpperBound(0)]);
            }
        }
    }

    public void buttonCreate_Click(object sender, EventArgs e)
    {
        string[] ProfileInfo = new string[10];
        ProfileInfo[0] = textboxProfileID.Text;
        ProfileInfo[1] = textboxNameFirst.Text;
        ProfileInfo[2] = textboxNameLast.Text;
        ProfileInfo[3] = textboxBirthYear.Text;
        ProfileInfo[4] = textboxBirthMonth.Text;
        ProfileInfo[5] = textboxBirthDay.Text;
        ProfileInfo[6] = checkboxGender.Text;
        ProfileInfo[7] = textboxEMail.Text;
        ProfileInfo[8] = Convert.ToString(checkboxNotification.Checked.ToString());
        gamecache.currentPlayerProfile.NewPlayerProfile(ProfileInfo);
        gamecache.currentPlayerStatistics.NewPlayerStatistics(new string[] {
                                                                  Convert.ToString((System.DateTime.Now.Day + "-" + System.DateTime.Now.Month + "-" + System.DateTime.Now.Year)),
                                                                  Convert.ToString(System.DateTime.Now.Hour + ":" + System.DateTime.Now.Minute)
                                                              });
        gamecache.currentCharacterProfile.NewCharacterProfile(new string[] {
                                                                  Convert.ToString((System.DateTime.Now.Day + "-" + System.DateTime.Now.Month + "-" + System.DateTime.Now.Year)),
                                                                  Convert.ToString(System.DateTime.Now.Hour + ":" + System.DateTime.Now.Minute)
                                                              });
        gamecache.currentCharacterStatistics.NewCharacterStatistics();
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
        gamecache.currentSettings.LastProfile = listboxProfile.SelectedItem.ToString();
        gamecache.ResumeGame();
    }
}