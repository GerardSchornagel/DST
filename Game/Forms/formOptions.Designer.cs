using System;

partial class formOptions : System.Windows.Forms.Form
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
        this.tabcontrolOptions = new System.Windows.Forms.TabControl();
        this.tabpageMessages = new System.Windows.Forms.TabPage();
        this.checkboxlistMessages = new System.Windows.Forms.CheckedListBox();
        this.buttonOK = new System.Windows.Forms.Button();
        this.buttonCancel = new System.Windows.Forms.Button();
        this.tabcontrolOptions.SuspendLayout();
        this.tabpageMessages.SuspendLayout();
        this.SuspendLayout();
        //
        //tabcontrolOptions
        //
        this.tabcontrolOptions.Controls.Add(this.tabpageMessages);
        this.tabcontrolOptions.Location = new System.Drawing.Point(12, 14);
        this.tabcontrolOptions.Name = "tabcontrolOptions";
        this.tabcontrolOptions.SelectedIndex = 0;
        this.tabcontrolOptions.Size = new System.Drawing.Size(281, 358);
        this.tabcontrolOptions.TabIndex = 0;
        //
        //tabpageMessages
        //
        this.tabpageMessages.Controls.Add(this.checkboxlistMessages);
        this.tabpageMessages.Location = new System.Drawing.Point(4, 22);
        this.tabpageMessages.Name = "tabpageMessages";
        this.tabpageMessages.Padding = new System.Windows.Forms.Padding(3);
        this.tabpageMessages.Size = new System.Drawing.Size(273, 332);
        this.tabpageMessages.TabIndex = 1;
        this.tabpageMessages.Text = "Messages";
        this.tabpageMessages.UseVisualStyleBackColor = true;
        //
        //checkboxlistMessages
        //
        this.checkboxlistMessages.FormattingEnabled = true;
        this.checkboxlistMessages.Items.AddRange(new object[] {
                                                     "Exiting Program",
                                                     "Creating New Game Overwrite",
                                                     "Apply Changes requires restart of program"
                                                 });
        this.checkboxlistMessages.Location = new System.Drawing.Point(6, 6);
        this.checkboxlistMessages.Name = "checkboxlistMessages";
        this.checkboxlistMessages.Size = new System.Drawing.Size(261, 319);
        this.checkboxlistMessages.TabIndex = 0;
        //
        //buttonOK
        //
        this.buttonOK.Location = new System.Drawing.Point(22, 378);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new System.Drawing.Size(126, 28);
        this.buttonOK.TabIndex = 1;
        this.buttonOK.Text = "Apply && Close";
        this.buttonOK.UseVisualStyleBackColor = true;
        this.buttonOK.Click += this.buttonOK_Click;
        //
        //buttonCancel
        //
        this.buttonCancel.Location = new System.Drawing.Point(154, 378);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new System.Drawing.Size(129, 28);
        this.buttonCancel.TabIndex = 1;
        this.buttonCancel.Text = "Discard && Close";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click += this.buttonCancel_Click;
        //
        //formOptions
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(303, 418);
        this.Controls.Add(this.buttonCancel);
        this.Controls.Add(this.tabcontrolOptions);
        this.Controls.Add(this.buttonOK);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "formOptions";
        this.Text = "Options";
        this.tabcontrolOptions.ResumeLayout(false);
        this.tabpageMessages.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.TabControl tabcontrolOptions;
    private System.Windows.Forms.TabPage tabpageMessages;
    private System.Windows.Forms.CheckedListBox checkboxlistMessages;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Button buttonCancel;
}