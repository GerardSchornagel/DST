using System;

partial class gamecache : System.Windows.Forms.Form
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
        this.progressbarLoading = new System.Windows.Forms.ProgressBar();
        this.labelLoading = new System.Windows.Forms.Label();
        this.labelDescription = new System.Windows.Forms.Label();
        this.SuspendLayout();
        //
        //progressbarLoading
        //
        this.progressbarLoading.Location = new System.Drawing.Point(12, 38);
        this.progressbarLoading.MarqueeAnimationSpeed = 25;
        this.progressbarLoading.Maximum = 10;
        this.progressbarLoading.Name = "progressbarLoading";
        this.progressbarLoading.Size = new System.Drawing.Size(372, 30);
        this.progressbarLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        this.progressbarLoading.TabIndex = 0;
        //
        //labelLoading
        //
        this.labelLoading.AutoSize = true;
        this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
        this.labelLoading.Location = new System.Drawing.Point(153, 9);
        this.labelLoading.Name = "labelLoading";
        this.labelLoading.Size = new System.Drawing.Size(107, 26);
        this.labelLoading.TabIndex = 1;
        this.labelLoading.Text = "Loading...";
        //
        //labelDescription
        //
        this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
        this.labelDescription.Location = new System.Drawing.Point(12, 71);
        this.labelDescription.Name = "labelDescription";
        this.labelDescription.Size = new System.Drawing.Size(372, 20);
        this.labelDescription.TabIndex = 2;
        this.labelDescription.Text = "Description";
        //
        //gamecache
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(396, 101);
        this.Controls.Add(this.labelDescription);
        this.Controls.Add(this.labelLoading);
        this.Controls.Add(this.progressbarLoading);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        this.Name = "gamecache";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "cache";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
    
    private System.Windows.Forms.Label labelDescription;
    private System.Windows.Forms.Label labelLoading;
    private System.Windows.Forms.ProgressBar progressbarLoading;
}