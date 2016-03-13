using System;

partial class formPlayerManagement : System.Windows.Forms.Form
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
        this.groupboxProfile = new System.Windows.Forms.GroupBox();
        this.checkboxNotification = new System.Windows.Forms.CheckBox();
        this.checkboxGender = new System.Windows.Forms.CheckBox();
        this.textboxBirthYear = new System.Windows.Forms.TextBox();
        this.labelNameLast = new System.Windows.Forms.Label();
        this.labelBirthDate = new System.Windows.Forms.Label();
        this.textboxEMail = new System.Windows.Forms.TextBox();
        this.textboxNameFirst = new System.Windows.Forms.TextBox();
        this.labelProfileID = new System.Windows.Forms.Label();
        this.textboxBirthDay = new System.Windows.Forms.TextBox();
        this.labelEMail = new System.Windows.Forms.Label();
        this.labelNameFirst = new System.Windows.Forms.Label();
        this.textboxNameLast = new System.Windows.Forms.TextBox();
        this.textboxBirthMonth = new System.Windows.Forms.TextBox();
        this.textboxProfileID = new System.Windows.Forms.TextBox();
        this.buttonCreate = new System.Windows.Forms.Button();
        this.listboxProfile = new System.Windows.Forms.ListBox();
        this.buttonLoad = new System.Windows.Forms.Button();
        this.groupboxProfile.SuspendLayout();
        this.SuspendLayout();
        // 
        // groupboxProfile
        // 
        this.groupboxProfile.Controls.Add(this.checkboxNotification);
        this.groupboxProfile.Controls.Add(this.checkboxGender);
        this.groupboxProfile.Controls.Add(this.textboxBirthYear);
        this.groupboxProfile.Controls.Add(this.labelNameLast);
        this.groupboxProfile.Controls.Add(this.labelBirthDate);
        this.groupboxProfile.Controls.Add(this.textboxEMail);
        this.groupboxProfile.Controls.Add(this.textboxNameFirst);
        this.groupboxProfile.Controls.Add(this.labelProfileID);
        this.groupboxProfile.Controls.Add(this.textboxBirthDay);
        this.groupboxProfile.Controls.Add(this.labelEMail);
        this.groupboxProfile.Controls.Add(this.labelNameFirst);
        this.groupboxProfile.Controls.Add(this.textboxNameLast);
        this.groupboxProfile.Controls.Add(this.textboxBirthMonth);
        this.groupboxProfile.Controls.Add(this.textboxProfileID);
        this.groupboxProfile.Location = new System.Drawing.Point(12, 12);
        this.groupboxProfile.Name = "groupboxProfile";
        this.groupboxProfile.Size = new System.Drawing.Size(146, 292);
        this.groupboxProfile.TabIndex = 6;
        this.groupboxProfile.TabStop = false;
        this.groupboxProfile.Text = "Profile";
        // 
        // checkboxNotification
        // 
        this.checkboxNotification.Location = new System.Drawing.Point(6, 253);
        this.checkboxNotification.Name = "checkboxNotification";
        this.checkboxNotification.Size = new System.Drawing.Size(127, 33);
        this.checkboxNotification.TabIndex = 8;
        this.checkboxNotification.Text = "E-Mail Notification";
        this.checkboxNotification.UseVisualStyleBackColor = true;
        // 
        // checkboxGender
        // 
        this.checkboxGender.Appearance = System.Windows.Forms.Appearance.Button;
        this.checkboxGender.Location = new System.Drawing.Point(10, 175);
        this.checkboxGender.Name = "checkboxGender";
        this.checkboxGender.Size = new System.Drawing.Size(127, 33);
        this.checkboxGender.TabIndex = 5;
        this.checkboxGender.Text = "Male";
        this.checkboxGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.checkboxGender.UseVisualStyleBackColor = true;
        this.checkboxGender.CheckedChanged += new System.EventHandler(this.checkboxGender_CheckedChanged);
        // 
        // textboxBirthYear
        // 
        this.textboxBirthYear.Location = new System.Drawing.Point(9, 149);
        this.textboxBirthYear.Name = "textboxBirthYear";
        this.textboxBirthYear.Size = new System.Drawing.Size(56, 20);
        this.textboxBirthYear.TabIndex = 2;
        this.textboxBirthYear.LostFocus += new System.EventHandler(this.textboxBirthYear_LostFocus);
        // 
        // labelNameLast
        // 
        this.labelNameLast.AutoSize = true;
        this.labelNameLast.Location = new System.Drawing.Point(6, 94);
        this.labelNameLast.Name = "labelNameLast";
        this.labelNameLast.Size = new System.Drawing.Size(58, 13);
        this.labelNameLast.TabIndex = 0;
        this.labelNameLast.Text = "Last Name";
        // 
        // labelBirthDate
        // 
        this.labelBirthDate.AutoSize = true;
        this.labelBirthDate.Location = new System.Drawing.Point(6, 133);
        this.labelBirthDate.Name = "labelBirthDate";
        this.labelBirthDate.Size = new System.Drawing.Size(131, 13);
        this.labelBirthDate.TabIndex = 0;
        this.labelBirthDate.Text = "Birth Date (YYYY-MM-DD)";
        // 
        // textboxEMail
        // 
        this.textboxEMail.Location = new System.Drawing.Point(9, 227);
        this.textboxEMail.Name = "textboxEMail";
        this.textboxEMail.Size = new System.Drawing.Size(128, 20);
        this.textboxEMail.TabIndex = 7;
        // 
        // textboxNameFirst
        // 
        this.textboxNameFirst.Location = new System.Drawing.Point(9, 71);
        this.textboxNameFirst.Name = "textboxNameFirst";
        this.textboxNameFirst.Size = new System.Drawing.Size(128, 20);
        this.textboxNameFirst.TabIndex = 0;
        this.textboxNameFirst.TextChanged += this.textboxNameFirst_TextChanged;
        // 
        // labelProfileID
        // 
        this.labelProfileID.AutoSize = true;
        this.labelProfileID.Location = new System.Drawing.Point(6, 16);
        this.labelProfileID.Name = "labelProfileID";
        this.labelProfileID.Size = new System.Drawing.Size(67, 13);
        this.labelProfileID.TabIndex = 0;
        this.labelProfileID.Text = "Profile Name";
        // 
        // textboxBirthDay
        // 
        this.textboxBirthDay.Location = new System.Drawing.Point(108, 149);
        this.textboxBirthDay.Name = "textboxBirthDay";
        this.textboxBirthDay.Size = new System.Drawing.Size(29, 20);
        this.textboxBirthDay.TabIndex = 4;
        this.textboxBirthDay.LostFocus += this.textboxBirthDay_LostFocus;
        // 
        // labelEMail
        // 
        this.labelEMail.AutoSize = true;
        this.labelEMail.Location = new System.Drawing.Point(6, 211);
        this.labelEMail.Name = "labelEMail";
        this.labelEMail.Size = new System.Drawing.Size(36, 13);
        this.labelEMail.TabIndex = 0;
        this.labelEMail.Text = "E-Mail";
        // 
        // labelNameFirst
        // 
        this.labelNameFirst.AutoSize = true;
        this.labelNameFirst.Location = new System.Drawing.Point(6, 55);
        this.labelNameFirst.Name = "labelNameFirst";
        this.labelNameFirst.Size = new System.Drawing.Size(57, 13);
        this.labelNameFirst.TabIndex = 0;
        this.labelNameFirst.Text = "First Name";
        // 
        // textboxNameLast
        // 
        this.textboxNameLast.Location = new System.Drawing.Point(9, 110);
        this.textboxNameLast.Name = "textboxNameLast";
        this.textboxNameLast.Size = new System.Drawing.Size(128, 20);
        this.textboxNameLast.TabIndex = 1;
        this.textboxNameLast.TextChanged += this.textboxNameLast_TextChanged;
        // 
        // textboxBirthMonth
        // 
        this.textboxBirthMonth.Location = new System.Drawing.Point(71, 149);
        this.textboxBirthMonth.Name = "textboxBirthMonth";
        this.textboxBirthMonth.Size = new System.Drawing.Size(31, 20);
        this.textboxBirthMonth.TabIndex = 3;
        this.textboxBirthMonth.LostFocus += this.textboxBirthMonth_LostFocus;
        // 
        // textboxProfileID
        // 
        this.textboxProfileID.Location = new System.Drawing.Point(9, 32);
        this.textboxProfileID.Name = "textboxProfileID";
        this.textboxProfileID.ReadOnly = true;
        this.textboxProfileID.Size = new System.Drawing.Size(128, 20);
        this.textboxProfileID.TabIndex = 0;
        this.textboxProfileID.TabStop = false;
        // 
        // buttonCreate
        // 
        this.buttonCreate.Location = new System.Drawing.Point(12, 310);
        this.buttonCreate.Name = "buttonCreate";
        this.buttonCreate.Size = new System.Drawing.Size(71, 29);
        this.buttonCreate.TabIndex = 9;
        this.buttonCreate.Text = "Create";
        this.buttonCreate.UseVisualStyleBackColor = true;
        this.buttonCreate.Click += this.buttonCreate_Click;
        // 
        // listboxProfile
        // 
        this.listboxProfile.FormattingEnabled = true;
        this.listboxProfile.Location = new System.Drawing.Point(164, 13);
        this.listboxProfile.Name = "listboxProfile";
        this.listboxProfile.Size = new System.Drawing.Size(130, 329);
        this.listboxProfile.TabIndex = 10;
        // 
        // buttonLoad
        // 
        this.buttonLoad.Location = new System.Drawing.Point(89, 310);
        this.buttonLoad.Name = "buttonLoad";
        this.buttonLoad.Size = new System.Drawing.Size(69, 29);
        this.buttonLoad.TabIndex = 11;
        this.buttonLoad.Text = "Use";
        this.buttonLoad.UseVisualStyleBackColor = true;
        this.buttonLoad.Click += this.buttonLoad_Click;
        // 
        // formPlayerManagement
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(309, 353);
        this.Controls.Add(this.buttonLoad);
        this.Controls.Add(this.listboxProfile);
        this.Controls.Add(this.buttonCreate);
        this.Controls.Add(this.groupboxProfile);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        Load += this.formPlayerManagement_Load;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "formPlayerManagement";
        this.Text = "New Player";
        this.groupboxProfile.ResumeLayout(false);
        this.groupboxProfile.PerformLayout();
        this.ResumeLayout(false);

    }
    
    private System.Windows.Forms.Button buttonLoad;
    private System.Windows.Forms.ListBox listboxProfile;
    private System.Windows.Forms.TextBox textboxProfileID;
    private System.Windows.Forms.Label labelEMail;
    private System.Windows.Forms.Label labelProfileID;
    private System.Windows.Forms.TextBox textboxEMail;
    private System.Windows.Forms.CheckBox checkboxNotification;
    private System.Windows.Forms.CheckBox checkboxGender;
    private System.Windows.Forms.Button buttonCreate;
    private System.Windows.Forms.TextBox textboxBirthMonth;
    private System.Windows.Forms.TextBox textboxNameLast;
    private System.Windows.Forms.Label labelNameFirst;
    private System.Windows.Forms.TextBox textboxBirthDay;
    private System.Windows.Forms.TextBox textboxNameFirst;
    private System.Windows.Forms.Label labelBirthDate;
    private System.Windows.Forms.Label labelNameLast;
    private System.Windows.Forms.TextBox textboxBirthYear;
    private System.Windows.Forms.GroupBox groupboxProfile;
}