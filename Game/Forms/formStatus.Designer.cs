using System;

partial class formStatus : System.Windows.Forms.Form
{

    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components;

    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing) {
            if (components != null) {
                components.Dispose();
            }
        }
        base.Dispose(disposing);
    }

    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
        this.buttonExit = new System.Windows.Forms.Button();
        this.labelBalance = new System.Windows.Forms.Label();
        this.textboxBalance = new System.Windows.Forms.TextBox();
        this.tabcontrolStatus = new System.Windows.Forms.TabControl();
        this.tabpagePlayer = new System.Windows.Forms.TabPage();
        this.groupboxProfile = new System.Windows.Forms.GroupBox();
        this.labelCreateTime = new System.Windows.Forms.Label();
        this.textboxCreateTime = new System.Windows.Forms.TextBox();
        this.labelCreateDate = new System.Windows.Forms.Label();
        this.textboxCreateDate = new System.Windows.Forms.TextBox();
        this.labelProfileID = new System.Windows.Forms.Label();
        this.textboxProfileID = new System.Windows.Forms.TextBox();
        this.labelGender = new System.Windows.Forms.Label();
        this.textboxBirthYear = new System.Windows.Forms.TextBox();
        this.labelNameLast = new System.Windows.Forms.Label();
        this.labelBirthDate = new System.Windows.Forms.Label();
        this.textboxNameFirst = new System.Windows.Forms.TextBox();
        this.textboxBirthDay = new System.Windows.Forms.TextBox();
        this.textboxGender = new System.Windows.Forms.TextBox();
        this.labelNameFirst = new System.Windows.Forms.Label();
        this.textboxNameLast = new System.Windows.Forms.TextBox();
        this.textboxBirthMonth = new System.Windows.Forms.TextBox();
        this.tabpageCharacter = new System.Windows.Forms.TabPage();
        this.groupboxLocation = new System.Windows.Forms.GroupBox();
        this.labelStore = new System.Windows.Forms.Label();
        this.labelCountry = new System.Windows.Forms.Label();
        this.labelWorld = new System.Windows.Forms.Label();
        this.textboxStore = new System.Windows.Forms.TextBox();
        this.textboxCountry = new System.Windows.Forms.TextBox();
        this.textboxWorld = new System.Windows.Forms.TextBox();
        this.textboxPlace = new System.Windows.Forms.TextBox();
        this.labelPlace = new System.Windows.Forms.Label();
        this.groupboxDates = new System.Windows.Forms.GroupBox();
        this.labelPlaycycles = new System.Windows.Forms.Label();
        this.textboxPlaycycles = new System.Windows.Forms.TextBox();
        this.groupboxFinances = new System.Windows.Forms.GroupBox();
        this.labelItemsSold = new System.Windows.Forms.Label();
        this.labelMoneyEarned = new System.Windows.Forms.Label();
        this.textboxItemsSold = new System.Windows.Forms.TextBox();
        this.textboxMoneyEarned = new System.Windows.Forms.TextBox();
        this.textboxMoneySpent = new System.Windows.Forms.TextBox();
        this.labelMoneySpent = new System.Windows.Forms.Label();
        this.buttonMap = new System.Windows.Forms.Button();
        this.buttonItemManagement = new System.Windows.Forms.Button();
        this.buttonDC = new System.Windows.Forms.Button();
        this.tabcontrolStatus.SuspendLayout();
        this.tabpagePlayer.SuspendLayout();
        this.groupboxProfile.SuspendLayout();
        this.tabpageCharacter.SuspendLayout();
        this.groupboxLocation.SuspendLayout();
        this.groupboxDates.SuspendLayout();
        this.groupboxFinances.SuspendLayout();
        this.SuspendLayout();
        //
        //buttonExit
        //
        this.buttonExit.Location = new System.Drawing.Point(245, 456);
        this.buttonExit.Name = "buttonExit";
        this.buttonExit.Size = new System.Drawing.Size(223, 23);
        this.buttonExit.TabIndex = 6;
        this.buttonExit.Text = "Exit";
        this.buttonExit.UseVisualStyleBackColor = true;
        this.buttonExit.Click += this.buttonExit_Click;
        //
        //labelBalance
        //
        this.labelBalance.AutoSize = true;
        this.labelBalance.Location = new System.Drawing.Point(288, 9);
        this.labelBalance.Name = "labelBalance";
        this.labelBalance.Size = new System.Drawing.Size(46, 13);
        this.labelBalance.TabIndex = 0;
        this.labelBalance.Text = "Balance";
        //
        //textboxBalance
        //
        this.textboxBalance.Location = new System.Drawing.Point(290, 24);
        this.textboxBalance.Name = "textboxBalance";
        this.textboxBalance.ReadOnly = true;
        this.textboxBalance.Size = new System.Drawing.Size(169, 20);
        this.textboxBalance.TabIndex = 1;
        //
        //tabcontrolStatus
        //
        this.tabcontrolStatus.Controls.Add(this.tabpagePlayer);
        this.tabcontrolStatus.Controls.Add(this.tabpageCharacter);
        this.tabcontrolStatus.Location = new System.Drawing.Point(8, 12);
        this.tabcontrolStatus.Name = "tabcontrolStatus";
        this.tabcontrolStatus.SelectedIndex = 0;
        this.tabcontrolStatus.Size = new System.Drawing.Size(460, 409);
        this.tabcontrolStatus.TabIndex = 7;
        //
        //tabpagePlayer
        //
        this.tabpagePlayer.Controls.Add(this.groupboxProfile);
        this.tabpagePlayer.Location = new System.Drawing.Point(4, 22);
        this.tabpagePlayer.Name = "tabpagePlayer";
        this.tabpagePlayer.Padding = new System.Windows.Forms.Padding(3);
        this.tabpagePlayer.Size = new System.Drawing.Size(452, 383);
        this.tabpagePlayer.TabIndex = 3;
        this.tabpagePlayer.Text = "Profile";
        this.tabpagePlayer.UseVisualStyleBackColor = true;
        //
        //groupboxProfile
        //
        this.groupboxProfile.Controls.Add(this.labelCreateTime);
        this.groupboxProfile.Controls.Add(this.textboxCreateTime);
        this.groupboxProfile.Controls.Add(this.labelCreateDate);
        this.groupboxProfile.Controls.Add(this.textboxCreateDate);
        this.groupboxProfile.Controls.Add(this.labelProfileID);
        this.groupboxProfile.Controls.Add(this.textboxProfileID);
        this.groupboxProfile.Controls.Add(this.labelGender);
        this.groupboxProfile.Controls.Add(this.textboxBirthYear);
        this.groupboxProfile.Controls.Add(this.labelNameLast);
        this.groupboxProfile.Controls.Add(this.labelBirthDate);
        this.groupboxProfile.Controls.Add(this.textboxNameFirst);
        this.groupboxProfile.Controls.Add(this.textboxBirthDay);
        this.groupboxProfile.Controls.Add(this.textboxGender);
        this.groupboxProfile.Controls.Add(this.labelNameFirst);
        this.groupboxProfile.Controls.Add(this.textboxNameLast);
        this.groupboxProfile.Controls.Add(this.textboxBirthMonth);
        this.groupboxProfile.Location = new System.Drawing.Point(6, 6);
        this.groupboxProfile.Name = "groupboxProfile";
        this.groupboxProfile.Size = new System.Drawing.Size(437, 365);
        this.groupboxProfile.TabIndex = 3;
        this.groupboxProfile.TabStop = false;
        this.groupboxProfile.Text = "Profile";
        //
        //labelCreateTime
        //
        this.labelCreateTime.AutoSize = true;
        this.labelCreateTime.Location = new System.Drawing.Point(181, 55);
        this.labelCreateTime.Name = "labelCreateTime";
        this.labelCreateTime.Size = new System.Drawing.Size(70, 13);
        this.labelCreateTime.TabIndex = 3;
        this.labelCreateTime.Text = "Time Created";
        //
        //textboxCreateTime
        //
        this.textboxCreateTime.Location = new System.Drawing.Point(184, 71);
        this.textboxCreateTime.Name = "textboxCreateTime";
        this.textboxCreateTime.ReadOnly = true;
        this.textboxCreateTime.Size = new System.Drawing.Size(169, 20);
        this.textboxCreateTime.TabIndex = 5;
        //
        //labelCreateDate
        //
        this.labelCreateDate.AutoSize = true;
        this.labelCreateDate.Location = new System.Drawing.Point(181, 16);
        this.labelCreateDate.Name = "labelCreateDate";
        this.labelCreateDate.Size = new System.Drawing.Size(70, 13);
        this.labelCreateDate.TabIndex = 2;
        this.labelCreateDate.Text = "Date Created";
        //
        //textboxCreateDate
        //
        this.textboxCreateDate.Location = new System.Drawing.Point(184, 32);
        this.textboxCreateDate.Name = "textboxCreateDate";
        this.textboxCreateDate.ReadOnly = true;
        this.textboxCreateDate.Size = new System.Drawing.Size(169, 20);
        this.textboxCreateDate.TabIndex = 4;
        //
        //labelProfileID
        //
        this.labelProfileID.AutoSize = true;
        this.labelProfileID.Location = new System.Drawing.Point(3, 16);
        this.labelProfileID.Name = "labelProfileID";
        this.labelProfileID.Size = new System.Drawing.Size(50, 13);
        this.labelProfileID.TabIndex = 0;
        this.labelProfileID.Text = "Profile ID";
        //
        //textboxProfileID
        //
        this.textboxProfileID.Location = new System.Drawing.Point(6, 32);
        this.textboxProfileID.Name = "textboxProfileID";
        this.textboxProfileID.ReadOnly = true;
        this.textboxProfileID.Size = new System.Drawing.Size(169, 20);
        this.textboxProfileID.TabIndex = 1;
        //
        //labelGender
        //
        this.labelGender.AutoSize = true;
        this.labelGender.Location = new System.Drawing.Point(6, 133);
        this.labelGender.Name = "labelGender";
        this.labelGender.Size = new System.Drawing.Size(42, 13);
        this.labelGender.TabIndex = 0;
        this.labelGender.Text = "Gender";
        //
        //textboxBirthYear
        //
        this.textboxBirthYear.Location = new System.Drawing.Point(10, 188);
        this.textboxBirthYear.Name = "textboxBirthYear";
        this.textboxBirthYear.ReadOnly = true;
        this.textboxBirthYear.Size = new System.Drawing.Size(39, 20);
        this.textboxBirthYear.TabIndex = 1;
        this.textboxBirthYear.Text = "1985";
        //
        //labelNameLast
        //
        this.labelNameLast.AutoSize = true;
        this.labelNameLast.Location = new System.Drawing.Point(3, 94);
        this.labelNameLast.Name = "labelNameLast";
        this.labelNameLast.Size = new System.Drawing.Size(58, 13);
        this.labelNameLast.TabIndex = 0;
        this.labelNameLast.Text = "Last Name";
        //
        //labelBirthDate
        //
        this.labelBirthDate.AutoSize = true;
        this.labelBirthDate.Location = new System.Drawing.Point(7, 172);
        this.labelBirthDate.Name = "labelBirthDate";
        this.labelBirthDate.Size = new System.Drawing.Size(54, 13);
        this.labelBirthDate.TabIndex = 0;
        this.labelBirthDate.Text = "Birth Date";
        //
        //textboxNameFirst
        //
        this.textboxNameFirst.Location = new System.Drawing.Point(6, 71);
        this.textboxNameFirst.Name = "textboxNameFirst";
        this.textboxNameFirst.ReadOnly = true;
        this.textboxNameFirst.Size = new System.Drawing.Size(169, 20);
        this.textboxNameFirst.TabIndex = 1;
        //
        //textboxBirthDay
        //
        this.textboxBirthDay.Location = new System.Drawing.Point(87, 188);
        this.textboxBirthDay.Name = "textboxBirthDay";
        this.textboxBirthDay.ReadOnly = true;
        this.textboxBirthDay.Size = new System.Drawing.Size(24, 20);
        this.textboxBirthDay.TabIndex = 1;
        this.textboxBirthDay.Text = "24";
        //
        //textboxGender
        //
        this.textboxGender.Location = new System.Drawing.Point(9, 149);
        this.textboxGender.Name = "textboxGender";
        this.textboxGender.ReadOnly = true;
        this.textboxGender.Size = new System.Drawing.Size(169, 20);
        this.textboxGender.TabIndex = 1;
        //
        //labelNameFirst
        //
        this.labelNameFirst.AutoSize = true;
        this.labelNameFirst.Location = new System.Drawing.Point(3, 55);
        this.labelNameFirst.Name = "labelNameFirst";
        this.labelNameFirst.Size = new System.Drawing.Size(57, 13);
        this.labelNameFirst.TabIndex = 0;
        this.labelNameFirst.Text = "First Name";
        //
        //textboxNameLast
        //
        this.textboxNameLast.Location = new System.Drawing.Point(6, 110);
        this.textboxNameLast.Name = "textboxNameLast";
        this.textboxNameLast.ReadOnly = true;
        this.textboxNameLast.Size = new System.Drawing.Size(169, 20);
        this.textboxNameLast.TabIndex = 1;
        //
        //textboxBirthMonth
        //
        this.textboxBirthMonth.Location = new System.Drawing.Point(55, 188);
        this.textboxBirthMonth.Name = "textboxBirthMonth";
        this.textboxBirthMonth.ReadOnly = true;
        this.textboxBirthMonth.Size = new System.Drawing.Size(26, 20);
        this.textboxBirthMonth.TabIndex = 1;
        this.textboxBirthMonth.Text = "09";
        //
        //tabpageCharacter
        //
        this.tabpageCharacter.Controls.Add(this.groupboxLocation);
        this.tabpageCharacter.Controls.Add(this.groupboxDates);
        this.tabpageCharacter.Controls.Add(this.groupboxFinances);
        this.tabpageCharacter.Location = new System.Drawing.Point(4, 22);
        this.tabpageCharacter.Name = "tabpageCharacter";
        this.tabpageCharacter.Padding = new System.Windows.Forms.Padding(3);
        this.tabpageCharacter.Size = new System.Drawing.Size(452, 383);
        this.tabpageCharacter.TabIndex = 0;
        this.tabpageCharacter.Text = "Character";
        this.tabpageCharacter.UseVisualStyleBackColor = true;
        //
        //groupboxLocation
        //
        this.groupboxLocation.Controls.Add(this.labelStore);
        this.groupboxLocation.Controls.Add(this.labelCountry);
        this.groupboxLocation.Controls.Add(this.labelWorld);
        this.groupboxLocation.Controls.Add(this.textboxStore);
        this.groupboxLocation.Controls.Add(this.textboxCountry);
        this.groupboxLocation.Controls.Add(this.textboxWorld);
        this.groupboxLocation.Controls.Add(this.textboxPlace);
        this.groupboxLocation.Controls.Add(this.labelPlace);
        this.groupboxLocation.Enabled = false;
        this.groupboxLocation.Location = new System.Drawing.Point(6, 256);
        this.groupboxLocation.Name = "groupboxLocation";
        this.groupboxLocation.Size = new System.Drawing.Size(437, 121);
        this.groupboxLocation.TabIndex = 7;
        this.groupboxLocation.TabStop = false;
        this.groupboxLocation.Text = "Current Location";
        //
        //labelStore
        //
        this.labelStore.AutoSize = true;
        this.labelStore.Location = new System.Drawing.Point(181, 63);
        this.labelStore.Name = "labelStore";
        this.labelStore.Size = new System.Drawing.Size(32, 13);
        this.labelStore.TabIndex = 0;
        this.labelStore.Text = "Store";
        //
        //labelCountry
        //
        this.labelCountry.AutoSize = true;
        this.labelCountry.Location = new System.Drawing.Point(181, 24);
        this.labelCountry.Name = "labelCountry";
        this.labelCountry.Size = new System.Drawing.Size(43, 13);
        this.labelCountry.TabIndex = 0;
        this.labelCountry.Text = "Country";
        //
        //labelWorld
        //
        this.labelWorld.AutoSize = true;
        this.labelWorld.Location = new System.Drawing.Point(6, 24);
        this.labelWorld.Name = "labelWorld";
        this.labelWorld.Size = new System.Drawing.Size(35, 13);
        this.labelWorld.TabIndex = 0;
        this.labelWorld.Text = "World";
        //
        //textboxStore
        //
        this.textboxStore.Location = new System.Drawing.Point(184, 79);
        this.textboxStore.Name = "textboxStore";
        this.textboxStore.ReadOnly = true;
        this.textboxStore.Size = new System.Drawing.Size(169, 20);
        this.textboxStore.TabIndex = 1;
        //
        //textboxCountry
        //
        this.textboxCountry.Location = new System.Drawing.Point(184, 40);
        this.textboxCountry.Name = "textboxCountry";
        this.textboxCountry.ReadOnly = true;
        this.textboxCountry.Size = new System.Drawing.Size(169, 20);
        this.textboxCountry.TabIndex = 1;
        //
        //textboxWorld
        //
        this.textboxWorld.Location = new System.Drawing.Point(9, 40);
        this.textboxWorld.Name = "textboxWorld";
        this.textboxWorld.ReadOnly = true;
        this.textboxWorld.Size = new System.Drawing.Size(169, 20);
        this.textboxWorld.TabIndex = 1;
        //
        //textboxPlace
        //
        this.textboxPlace.Location = new System.Drawing.Point(9, 79);
        this.textboxPlace.Name = "textboxPlace";
        this.textboxPlace.ReadOnly = true;
        this.textboxPlace.Size = new System.Drawing.Size(169, 20);
        this.textboxPlace.TabIndex = 1;
        //
        //labelPlace
        //
        this.labelPlace.AutoSize = true;
        this.labelPlace.Location = new System.Drawing.Point(6, 63);
        this.labelPlace.Name = "labelPlace";
        this.labelPlace.Size = new System.Drawing.Size(34, 13);
        this.labelPlace.TabIndex = 0;
        this.labelPlace.Text = "Place";
        //
        //groupboxDates
        //
        this.groupboxDates.Controls.Add(this.labelPlaycycles);
        this.groupboxDates.Controls.Add(this.textboxPlaycycles);
        this.groupboxDates.Location = new System.Drawing.Point(6, 6);
        this.groupboxDates.Name = "groupboxDates";
        this.groupboxDates.Size = new System.Drawing.Size(437, 112);
        this.groupboxDates.TabIndex = 7;
        this.groupboxDates.TabStop = false;
        this.groupboxDates.Text = "Time and Dates";
        //
        //labelPlaycycles
        //
        this.labelPlaycycles.AutoSize = true;
        this.labelPlaycycles.Location = new System.Drawing.Point(6, 16);
        this.labelPlaycycles.Name = "labelPlaycycles";
        this.labelPlaycycles.Size = new System.Drawing.Size(88, 13);
        this.labelPlaycycles.TabIndex = 0;
        this.labelPlaycycles.Text = "Day's in bussines";
        //
        //textboxPlaycycles
        //
        this.textboxPlaycycles.Location = new System.Drawing.Point(9, 32);
        this.textboxPlaycycles.Name = "textboxPlaycycles";
        this.textboxPlaycycles.ReadOnly = true;
        this.textboxPlaycycles.Size = new System.Drawing.Size(169, 20);
        this.textboxPlaycycles.TabIndex = 1;
        //
        //groupboxFinances
        //
        this.groupboxFinances.Controls.Add(this.labelItemsSold);
        this.groupboxFinances.Controls.Add(this.labelMoneyEarned);
        this.groupboxFinances.Controls.Add(this.textboxItemsSold);
        this.groupboxFinances.Controls.Add(this.textboxMoneyEarned);
        this.groupboxFinances.Controls.Add(this.textboxMoneySpent);
        this.groupboxFinances.Controls.Add(this.labelMoneySpent);
        this.groupboxFinances.Location = new System.Drawing.Point(6, 124);
        this.groupboxFinances.Name = "groupboxFinances";
        this.groupboxFinances.Size = new System.Drawing.Size(437, 126);
        this.groupboxFinances.TabIndex = 6;
        this.groupboxFinances.TabStop = false;
        this.groupboxFinances.Text = "Finances and Items";
        //
        //labelItemsSold
        //
        this.labelItemsSold.AutoSize = true;
        this.labelItemsSold.Location = new System.Drawing.Point(184, 63);
        this.labelItemsSold.Name = "labelItemsSold";
        this.labelItemsSold.Size = new System.Drawing.Size(56, 13);
        this.labelItemsSold.TabIndex = 0;
        this.labelItemsSold.Text = "Items Sold";
        //
        //labelMoneyEarned
        //
        this.labelMoneyEarned.AutoSize = true;
        this.labelMoneyEarned.Location = new System.Drawing.Point(6, 24);
        this.labelMoneyEarned.Name = "labelMoneyEarned";
        this.labelMoneyEarned.Size = new System.Drawing.Size(76, 13);
        this.labelMoneyEarned.TabIndex = 0;
        this.labelMoneyEarned.Text = "Money Earned";
        //
        //textboxItemsSold
        //
        this.textboxItemsSold.Location = new System.Drawing.Point(187, 79);
        this.textboxItemsSold.Name = "textboxItemsSold";
        this.textboxItemsSold.ReadOnly = true;
        this.textboxItemsSold.Size = new System.Drawing.Size(169, 20);
        this.textboxItemsSold.TabIndex = 1;
        //
        //textboxMoneyEarned
        //
        this.textboxMoneyEarned.Location = new System.Drawing.Point(9, 40);
        this.textboxMoneyEarned.Name = "textboxMoneyEarned";
        this.textboxMoneyEarned.ReadOnly = true;
        this.textboxMoneyEarned.Size = new System.Drawing.Size(169, 20);
        this.textboxMoneyEarned.TabIndex = 1;
        //
        //textboxMoneySpent
        //
        this.textboxMoneySpent.Location = new System.Drawing.Point(187, 40);
        this.textboxMoneySpent.Name = "textboxMoneySpent";
        this.textboxMoneySpent.ReadOnly = true;
        this.textboxMoneySpent.Size = new System.Drawing.Size(169, 20);
        this.textboxMoneySpent.TabIndex = 1;
        //
        //labelMoneySpent
        //
        this.labelMoneySpent.AutoSize = true;
        this.labelMoneySpent.Location = new System.Drawing.Point(184, 24);
        this.labelMoneySpent.Name = "labelMoneySpent";
        this.labelMoneySpent.Size = new System.Drawing.Size(70, 13);
        this.labelMoneySpent.TabIndex = 0;
        this.labelMoneySpent.Text = "Money Spent";
        //
        //buttonMap
        //
        this.buttonMap.Enabled = false;
        this.buttonMap.Location = new System.Drawing.Point(8, 456);
        this.buttonMap.Name = "buttonMap";
        this.buttonMap.Size = new System.Drawing.Size(232, 23);
        this.buttonMap.TabIndex = 8;
        this.buttonMap.Text = "Map";
        this.buttonMap.UseVisualStyleBackColor = true;
        this.buttonMap.Click += this.buttonMap_Click;
        //
        //buttonItemManagement
        //
        this.buttonItemManagement.Location = new System.Drawing.Point(245, 427);
        this.buttonItemManagement.Name = "buttonItemManagement";
        this.buttonItemManagement.Size = new System.Drawing.Size(223, 23);
        this.buttonItemManagement.TabIndex = 8;
        this.buttonItemManagement.Text = "Item Management";
        this.buttonItemManagement.UseVisualStyleBackColor = true;
        this.buttonItemManagement.Click += this.buttonItemManagement_Click;
        //
        //buttonDC
        //
        this.buttonDC.Location = new System.Drawing.Point(8, 427);
        this.buttonDC.Name = "buttonDC";
        this.buttonDC.Size = new System.Drawing.Size(232, 23);
        this.buttonDC.TabIndex = 6;
        this.buttonDC.Text = "Distribution Center";
        this.buttonDC.UseVisualStyleBackColor = true;
        this.buttonDC.Click += this.buttonDC_Click;
        //
        //formStatus
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(477, 487);
        this.Controls.Add(this.buttonItemManagement);
        this.Controls.Add(this.buttonMap);
        this.Controls.Add(this.labelBalance);
        this.Controls.Add(this.textboxBalance);
        this.Controls.Add(this.buttonDC);
        this.Controls.Add(this.buttonExit);
        this.Controls.Add(this.tabcontrolStatus);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "formStatus";
        this.Text = "Status";
        Load += this.formStatus_Load;
        this.tabcontrolStatus.ResumeLayout(false);
        this.tabpagePlayer.ResumeLayout(false);
        this.groupboxProfile.ResumeLayout(false);
        this.groupboxProfile.PerformLayout();
        this.tabpageCharacter.ResumeLayout(false);
        this.groupboxLocation.ResumeLayout(false);
        this.groupboxLocation.PerformLayout();
        this.groupboxDates.ResumeLayout(false);
        this.groupboxDates.PerformLayout();
        this.groupboxFinances.ResumeLayout(false);
        this.groupboxFinances.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
    
    private System.Windows.Forms.Label labelPlace;
    private System.Windows.Forms.TextBox textboxPlace;
    private System.Windows.Forms.TextBox textboxWorld;
    private System.Windows.Forms.TextBox textboxCountry;
    private System.Windows.Forms.TextBox textboxStore;
    private System.Windows.Forms.Label labelWorld;
    private System.Windows.Forms.Label labelCountry;
    private System.Windows.Forms.Label labelStore;
    private System.Windows.Forms.GroupBox groupboxLocation;
    private System.Windows.Forms.TextBox textboxCreateDate;
    private System.Windows.Forms.Label labelCreateDate;
    private System.Windows.Forms.TextBox textboxCreateTime;
    private System.Windows.Forms.Label labelCreateTime;
    private System.Windows.Forms.Button buttonDC;
    private System.Windows.Forms.Button buttonItemManagement;
    private System.Windows.Forms.Button buttonMap;
    private System.Windows.Forms.GroupBox groupboxDates;
    private System.Windows.Forms.Label labelPlaycycles;
    private System.Windows.Forms.TextBox textboxPlaycycles;
    private System.Windows.Forms.GroupBox groupboxFinances;
    private System.Windows.Forms.Label labelItemsSold;
    private System.Windows.Forms.Label labelMoneyEarned;
    private System.Windows.Forms.TextBox textboxItemsSold;
    private System.Windows.Forms.TextBox textboxMoneyEarned;
    private System.Windows.Forms.TextBox textboxMoneySpent;
    private System.Windows.Forms.Label labelMoneySpent;
    private System.Windows.Forms.Button buttonExit;
    private System.Windows.Forms.Label labelBalance;
    private System.Windows.Forms.TextBox textboxBalance;
    private System.Windows.Forms.TabControl tabcontrolStatus;
    private System.Windows.Forms.TabPage tabpageCharacter;
    private System.Windows.Forms.TabPage tabpagePlayer;
    private System.Windows.Forms.GroupBox groupboxProfile;
    private System.Windows.Forms.Label labelProfileID;
    private System.Windows.Forms.TextBox textboxProfileID;
    private System.Windows.Forms.Label labelGender;
    private System.Windows.Forms.TextBox textboxBirthYear;
    private System.Windows.Forms.Label labelNameLast;
    private System.Windows.Forms.Label labelBirthDate;
    private System.Windows.Forms.TextBox textboxNameFirst;
    private System.Windows.Forms.TextBox textboxBirthDay;
    private System.Windows.Forms.TextBox textboxGender;
    private System.Windows.Forms.Label labelNameFirst;
    private System.Windows.Forms.TextBox textboxNameLast;
    private System.Windows.Forms.TextBox textboxBirthMonth;
}