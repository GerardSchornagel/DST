using System;

partial class formGame : System.Windows.Forms.Form
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
        this.buttonActionStart = new System.Windows.Forms.Button();
        this.labelActionHour = new System.Windows.Forms.Label();
        this.textboxActionHour = new System.Windows.Forms.TextBox();
        this.labelActionLog = new System.Windows.Forms.Label();
        this.textboxActionLog = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        //
        //buttonActionStart
        //
        this.buttonActionStart.AutoSize = false;
        this.buttonActionStart.Location = new System.Drawing.Point(93, 25);
        this.buttonActionStart.Name = "buttonActionStart";
        this.buttonActionStart.Size = new System.Drawing.Size(79, 23);
        this.buttonActionStart.TabIndex = 17;
        this.buttonActionStart.Text = "Start Day";
        this.buttonActionStart.Click += this.buttonActionStart_Click;
        //
        //labelActionHour
        //
        this.labelActionHour.AutoSize = true;
        this.labelActionHour.Location = new System.Drawing.Point(12, 9);
        this.labelActionHour.Name = "labelActionHour";
        this.labelActionHour.Size = new System.Drawing.Size(142, 13);
        this.labelActionHour.TabIndex = 18;
        this.labelActionHour.Text = "Opening hours [0900 - 1800]";
        //
        //textboxActionHour
        //
        this.textboxActionHour.Location = new System.Drawing.Point(12, 25);
        this.textboxActionHour.Name = "textboxActionHour";
        this.textboxActionHour.ReadOnly = true;
        this.textboxActionHour.Size = new System.Drawing.Size(75, 20);
        this.textboxActionHour.TabIndex = 19;
        this.textboxActionHour.Text = "9";
        //
        //labelActionLog
        //
        this.labelActionLog.AutoSize = true;
        this.labelActionLog.Location = new System.Drawing.Point(178, 8);
        this.labelActionLog.Name = "labelActionLog";
        this.labelActionLog.Size = new System.Drawing.Size(80, 13);
        this.labelActionLog.TabIndex = 20;
        this.labelActionLog.Text = "Transaction-log";
        //
        //textboxActionLog
        //
        this.textboxActionLog.Location = new System.Drawing.Point(178, 24);
        this.textboxActionLog.Multiline = true;
        this.textboxActionLog.Name = "textboxActionLog";
        this.textboxActionLog.ReadOnly = true;
        this.textboxActionLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.textboxActionLog.Size = new System.Drawing.Size(310, 256);
        this.textboxActionLog.TabIndex = 21;
        //
        //formGame
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(500, 288);
        this.Controls.Add(this.buttonActionStart);
        this.Controls.Add(this.labelActionHour);
        this.Controls.Add(this.textboxActionHour);
        this.Controls.Add(this.labelActionLog);
        this.Controls.Add(this.textboxActionLog);
        this.Name = "formGame";
        this.Text = "formGame";
        Load += this.formGame_Load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }
    
    private System.Windows.Forms.TextBox textboxActionLog;
    private System.Windows.Forms.Label labelActionLog;
    private System.Windows.Forms.TextBox textboxActionHour;
    private System.Windows.Forms.Label labelActionHour;
    private System.Windows.Forms.Button buttonActionStart;
}