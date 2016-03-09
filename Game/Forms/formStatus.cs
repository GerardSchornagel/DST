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

        textboxBalance.Text = Convert.ToString(gamecache.currentCharacter.Balance);
        //Profile Tab
        textboxProfileID.Text = Convert.ToString(gamecache.currentPlayer.ProfileID);
        textboxNameFirst.Text = gamecache.currentPlayer.NameFirst;
        textboxNameLast.Text = gamecache.currentPlayer.NameLast;
        textboxBirthYear.Text = Convert.ToString(gamecache.currentPlayer.BirthYear);
        textboxBirthMonth.Text = Convert.ToString(gamecache.currentPlayer.BirthMonth);
        textboxBirthDay.Text = Convert.ToString(gamecache.currentPlayer.BirthDay);
        textboxGender.Text = gamecache.currentPlayer.Gender;
        textboxCreateDate.Text = gamecache.currentPlayer.CreateDate;
        textboxCreateTime.Text = gamecache.currentPlayer.CreateTime;
        //Character Tab
        textboxWorld.Text = gamecache.currentCharacter.World.ToString();
        textboxCountry.Text = gamecache.currentCharacter.Country.ToString();
        textboxPlace.Text = gamecache.currentCharacter.Place.ToString();
        textboxStore.Text = gamecache.currentCharacter.Store.ToString();
        textboxMoneyEarned.Text = Convert.ToString(gamecache.currentCharacter.EarningsTotal);
        textboxMoneySpent.Text = Convert.ToString(gamecache.currentCharacter.SpendingsTotal);
        textboxItemsSold.Text = Convert.ToString(gamecache.currentCharacter.ItemsSoldTotal);
        textboxPlaycycles.Text = Convert.ToString(gamecache.currentCharacter.DayCyclesTotal);
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
        textboxBalance.Text = Convert.ToString(gamecache.currentCharacter.Balance);
        textboxWorld.Text = gamecache.currentCharacter.World.ToString();
        textboxCountry.Text = gamecache.currentCharacter.Country.ToString();
        textboxPlace.Text = gamecache.currentCharacter.Place.ToString();
        textboxStore.Text = gamecache.currentCharacter.Store.ToString();
        textboxMoneyEarned.Text = Convert.ToString(gamecache.currentCharacter.EarningsTotal);
        textboxMoneySpent.Text = Convert.ToString(gamecache.currentCharacter.SpendingsTotal);
        textboxItemsSold.Text = Convert.ToString(gamecache.currentCharacter.ItemsSoldTotal);
        textboxPlaycycles.Text = Convert.ToString(gamecache.currentCharacter.DayCyclesTotal);
    }
}