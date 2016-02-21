using System;

partial class formEditor : System.Windows.Forms.Form
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
        this.textboxFilename = new System.Windows.Forms.TextBox();
        this.labelFilename = new System.Windows.Forms.Label();
        this.buttonBrowse = new System.Windows.Forms.Button();
        this.buttonLoad = new System.Windows.Forms.Button();
        this.buttonSave = new System.Windows.Forms.Button();
        this.buttonClose = new System.Windows.Forms.Button();
        this.textboxEdit = new System.Windows.Forms.TextBox();
        this.textboxDescription = new System.Windows.Forms.TextBox();
        this.listboxDescription = new System.Windows.Forms.ListBox();
        this.SuspendLayout();
        //
        //textboxFilename
        //
        this.textboxFilename.Location = new System.Drawing.Point(12, 352);
        this.textboxFilename.Name = "textboxFilename";
        this.textboxFilename.Size = new System.Drawing.Size(444, 20);
        this.textboxFilename.TabIndex = 77;
        //
        //label5
        //
        this.labelFilename.AutoSize = true;
        this.labelFilename.Location = new System.Drawing.Point(12, 336);
        this.labelFilename.Name = "labelFilename";
        this.labelFilename.Size = new System.Drawing.Size(49, 13);
        this.labelFilename.TabIndex = 78;
        this.labelFilename.Text = "Filename";
        //
        //buttonBrowse
        //
        this.buttonBrowse.Location = new System.Drawing.Point(462, 352);
        this.buttonBrowse.Name = "buttonBrowse";
        this.buttonBrowse.Size = new System.Drawing.Size(24, 21);
        this.buttonBrowse.TabIndex = 79;
        this.buttonBrowse.Text = "...";
        this.buttonBrowse.UseVisualStyleBackColor = true;
        this.buttonBrowse.Click += this.buttonBrowse_Click;
        //
        //buttonLoad
        //
        this.buttonLoad.Location = new System.Drawing.Point(12, 379);
        this.buttonLoad.Name = "buttonLoad";
        this.buttonLoad.Size = new System.Drawing.Size(114, 34);
        this.buttonLoad.TabIndex = 80;
        this.buttonLoad.Text = "Load";
        this.buttonLoad.UseVisualStyleBackColor = true;
        this.buttonLoad.Click += this.buttonLoad_Click;
        //
        //buttonSave
        //
        this.buttonSave.Location = new System.Drawing.Point(132, 380);
        this.buttonSave.Name = "buttonSave";
        this.buttonSave.Size = new System.Drawing.Size(114, 34);
        this.buttonSave.TabIndex = 80;
        this.buttonSave.Text = "Save";
        this.buttonSave.UseVisualStyleBackColor = true;
        this.buttonSave.Click += this.buttonSave_Click;
        //
        //buttonClose
        //
        this.buttonClose.Location = new System.Drawing.Point(252, 380);
        this.buttonClose.Name = "buttonClose";
        this.buttonClose.Size = new System.Drawing.Size(234, 34);
        this.buttonClose.TabIndex = 80;
        this.buttonClose.Text = "Close";
        this.buttonClose.UseVisualStyleBackColor = true;
        this.buttonClose.Click += this.buttonClose_Click;
        //
        //textboxEdit
        //
        this.textboxEdit.Location = new System.Drawing.Point(12, 12);
        this.textboxEdit.Multiline = true;
        this.textboxEdit.Name = "textboxEdit";
        this.textboxEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.textboxEdit.Size = new System.Drawing.Size(474, 321);
        this.textboxEdit.TabIndex = 0;
        //
        //textboxDescription
        //
        this.textboxDescription.Location = new System.Drawing.Point(492, 74);
        this.textboxDescription.Multiline = true;
        this.textboxDescription.Name = "textboxDescription";
        this.textboxDescription.Size = new System.Drawing.Size(199, 339);
        this.textboxDescription.TabIndex = 81;
        //
        //listboxDescription
        //
        this.listboxDescription.FormattingEnabled = true;
        this.listboxDescription.Location = new System.Drawing.Point(492, 12);
        this.listboxDescription.Name = "listboxDescription";
        this.listboxDescription.Size = new System.Drawing.Size(199, 56);
        this.listboxDescription.TabIndex = 82;
        this.listboxDescription.SelectedIndexChanged += this.listboxDescription_SelectedIndexChanged;
        //
        //formEditor
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(703, 426);
        this.Controls.Add(this.listboxDescription);
        this.Controls.Add(this.textboxDescription);
        this.Controls.Add(this.textboxEdit);
        this.Controls.Add(this.buttonClose);
        this.Controls.Add(this.buttonSave);
        this.Controls.Add(this.buttonLoad);
        this.Controls.Add(this.buttonBrowse);
        this.Controls.Add(this.labelFilename);
        this.Controls.Add(this.textboxFilename);
        this.Name = "formEditor";
        this.Text = "formEditor";
        Load += this.formEditor_Load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }
    
    private System.Windows.Forms.ListBox listboxDescription;
    private System.Windows.Forms.TextBox textboxDescription;
    private System.Windows.Forms.TextBox textboxEdit;
    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Button buttonLoad;
    private System.Windows.Forms.Button buttonBrowse;
    private System.Windows.Forms.Label labelFilename;
    private System.Windows.Forms.TextBox textboxFilename;
}