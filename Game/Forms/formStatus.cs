using System;

public partial class formStatus
{
    private System.Windows.Forms.Timer timerUpdate = new System.Windows.Forms.Timer();
    private solverAlgebraic algebraic = new solverAlgebraic();

    public formStatus()
    {
        // The Me.InitializeComponent call is required for Windows Forms designer support.
        this.InitializeComponent();
    }

    public void formStatus_Load(object sender, EventArgs e)
    {
        timerUpdate.Tick += timerUpdate_Tick;
        //Make a minium Interval value based on pc time to process random data equal to a medium big Savegame-size.
        timerUpdate.Interval = 2500;
        timerUpdate.Start();

        textboxBalance.Text = Convert.ToString(gamecache.currentCharacterStatistics.Balance);
        //Profile Tab
        textboxProfileID.Text = Convert.ToString(gamecache.currentPlayerProfile.ProfileID);
        textboxNameFirst.Text = gamecache.currentPlayerProfile.FirstName;
        textboxNameLast.Text = gamecache.currentPlayerProfile.LastName;
        textboxBirthYear.Text = Convert.ToString(gamecache.currentPlayerProfile.BirthYear);
        textboxBirthMonth.Text = Convert.ToString(gamecache.currentPlayerProfile.BirthMonth);
        textboxBirthDay.Text = Convert.ToString(gamecache.currentPlayerProfile.BirthDay);
        textboxGender.Text = gamecache.currentPlayerProfile.Gender;
        textboxCreateDate.Text = gamecache.currentPlayerStatistics.CreateDate;
        textboxCreateTime.Text = gamecache.currentPlayerStatistics.CreateTime;
        //Character Tab
        textboxWorld.Text = gamecache.currentCharacterProfile.CurrentWorld;
        textboxCountry.Text = gamecache.currentCharacterProfile.CurrentCountry;
        textboxPlace.Text = gamecache.currentCharacterProfile.CurrentPlace;
        textboxStore.Text = gamecache.currentCharacterProfile.CurrentStore;
        textboxMoneyEarned.Text = Convert.ToString(gamecache.currentCharacterStatistics.TotalEarnings);
        textboxMoneySpent.Text = Convert.ToString(gamecache.currentCharacterStatistics.TotalSpendings);
        textboxItemsSold.Text = Convert.ToString(gamecache.currentCharacterStatistics.TotalItemsSold);
        textboxPlaycycles.Text = Convert.ToString(gamecache.currentCharacterStatistics.TotalDayCycles);
    }

    public void buttonExit_Click(object sender, EventArgs e)
    {
        //Add code for clearing and 'Resetting' the gamecache.
        System.Windows.Forms.Application.Exit();
    }

    public void buttonMap_Click(object sender, EventArgs e)
    {
        gamecache.MapForm.Show();
        gamecache.MapForm.ShowInTaskbar = true;
        gamecache.MapForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
    }

    public void buttonDC_Click(object sender, EventArgs e)
    {
        gamecache.DCForm.Show();
        gamecache.DCForm.ShowInTaskbar = true;
        gamecache.DCForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
    }

    public void buttonItemManagement_Click(object sender, EventArgs e)
    {
        gamecache.ItemManagementForm.Show();
        gamecache.ItemManagementForm.ShowInTaskbar = true;
        gamecache.ItemManagementForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
    }

    private void timerUpdate_Tick(object sender, EventArgs e)
    {
        Reload();
    }

    private void Reload()
    {
        textboxBalance.Text = Convert.ToString(gamecache.currentCharacterStatistics.Balance);
        textboxWorld.Text = gamecache.currentCharacterProfile.CurrentWorld;
        textboxCountry.Text = gamecache.currentCharacterProfile.CurrentCountry;
        textboxPlace.Text = gamecache.currentCharacterProfile.CurrentPlace;
        textboxStore.Text = gamecache.currentCharacterProfile.CurrentStore;
        textboxMoneyEarned.Text = Convert.ToString(gamecache.currentCharacterStatistics.TotalEarnings);
        textboxMoneySpent.Text = Convert.ToString(gamecache.currentCharacterStatistics.TotalSpendings);
        textboxItemsSold.Text = Convert.ToString(gamecache.currentCharacterStatistics.TotalItemsSold);
        textboxPlaycycles.Text = Convert.ToString(gamecache.currentCharacterStatistics.TotalDayCycles);
    }
}