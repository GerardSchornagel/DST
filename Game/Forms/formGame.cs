using System;

public partial class formGame
{
    private Random randomGenerator = new Random();
    private System.Windows.Forms.Timer timerHour = new System.Windows.Forms.Timer();
    private System.Windows.Forms.Timer timerCustomer = new System.Windows.Forms.Timer();
    private int integerCustomerNumber;

    public formGame()
    {
        // The Me.InitializeComponent call is required for Windows Forms designer support.
        this.InitializeComponent();
    }

    public void formGame_Load(object sender, EventArgs e)
    {
        timerHour.Tick += timerHour_Tick;
        timerCustomer.Tick += timerCustomer_Tick;
    }

    private void buttonActionStart_Click(object sender, System.EventArgs e)
    {
        textboxActionHour.Text = "9";
        buttonActionStart.Text = "Day Started...";
        buttonActionStart.Enabled = false;
        //Write away previous log an d proccess data to/through formStatus
        textboxActionLog.Text = "";
        //Add 4 buttons for speed control (Pause/Slow[1Thread]/Medium[2Threads]/Fast[4Threads])
        //I think I've to adapt the randomgenerator for this with 4 customs seeds provided by 5th random for cycling the lesser.
        timerHour.Interval = 1000;
        timerHour.Start();
    }

    private void timerHour_Tick(object sender, System.EventArgs e)
    {
        //Before zero
        if (Convert.ToDouble(textboxActionHour.Text) > 0) {
            //For deciding how many customers per hour
            integerCustomerNumber = randomGenerator.Next(5);
            timerCustomer.Interval = 250;
            //Stop this element and let timerCustomer take over.
            timerCustomer.Start();
            textboxActionHour.Text = Convert.ToString(Convert.ToDouble(textboxActionHour.Text) - 1);
            timerHour.Stop();

            //Beneath zero
        } else {
            //Pass information for procces to/through formStatus
            gamecache.currentCharacterStatistics.TotalDayCycles += 1;
            buttonActionStart.Text = "Start Day";
            buttonActionStart.Enabled = true;
            textboxActionHour.Text = Convert.ToString(9);
            gamecache.currentCharacterProfile.SaveState();
            timerHour.Stop();
        }
    }

    private void timerCustomer_Tick(object sender, System.EventArgs e)
    {
        //More then Zero
        if (integerCustomerNumber > 0) {
            textboxActionLog.AppendText("[" + textboxActionHour.Text + "] " + mathematics.CustomerBuying);
            integerCustomerNumber -= 1;
            //Less then zero customers
        } else {
            timerCustomer.Stop();
            timerHour.Start();
        }
    }
}