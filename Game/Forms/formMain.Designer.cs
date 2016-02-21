using System;

partial class formMain : System.Windows.Forms.Form
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
        this.buttonProfileManagement = new System.Windows.Forms.Button();
        this.buttonCharacterManagement = new System.Windows.Forms.Button();
        this.buttonLastCharacter = new System.Windows.Forms.Button();
        this.buttonEditor = new System.Windows.Forms.Button();
        this.buttonOptions = new System.Windows.Forms.Button();
        this.buttonQuit = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        //buttonProfileManagement
        //
        this.buttonProfileManagement.Location = new System.Drawing.Point(12, 12);
        this.buttonProfileManagement.Name = "buttonProfileManagement";
        this.buttonProfileManagement.Size = new System.Drawing.Size(157, 23);
        this.buttonProfileManagement.TabIndex = 0;
        this.buttonProfileManagement.Text = "Profile Management...";
        this.buttonProfileManagement.UseVisualStyleBackColor = true;
        this.buttonProfileManagement.Click += this.buttonProfileManagement_Click;
        //
        //buttonCharacterManagement
        //
        this.buttonCharacterManagement.Enabled = false;
        this.buttonCharacterManagement.Location = new System.Drawing.Point(12, 41);
        this.buttonCharacterManagement.Name = "buttonCharacterManagement";
        this.buttonCharacterManagement.Size = new System.Drawing.Size(157, 23);
        this.buttonCharacterManagement.TabIndex = 3;
        this.buttonCharacterManagement.Text = "Character Management...";
        this.buttonCharacterManagement.UseVisualStyleBackColor = true;
        this.buttonCharacterManagement.Click += this.buttonCharacterManagement_Click;
        //
        //buttonLastCharacter
        //
        this.buttonLastCharacter.Location = new System.Drawing.Point(12, 85);
        this.buttonLastCharacter.Name = "buttonLastCharacter";
        this.buttonLastCharacter.Size = new System.Drawing.Size(157, 23);
        this.buttonLastCharacter.TabIndex = 2;
        this.buttonLastCharacter.Text = "Continue Character/Game";
        this.buttonLastCharacter.UseVisualStyleBackColor = true;
        this.buttonLastCharacter.Click += this.buttonLastCharacter_Click;
        //
        //buttonEditor
        //
        this.buttonEditor.Location = new System.Drawing.Point(12, 178);
        this.buttonEditor.Name = "buttonEditor";
        this.buttonEditor.Size = new System.Drawing.Size(157, 23);
        this.buttonEditor.TabIndex = 4;
        this.buttonEditor.Text = "Editor...";
        this.buttonEditor.UseVisualStyleBackColor = true;
        this.buttonEditor.Click += this.buttonEditor_Click;
        //
        //buttonOptions
        //
        this.buttonOptions.Location = new System.Drawing.Point(12, 207);
        this.buttonOptions.Name = "buttonOptions";
        this.buttonOptions.Size = new System.Drawing.Size(157, 23);
        this.buttonOptions.TabIndex = 5;
        this.buttonOptions.Text = "Options...";
        this.buttonOptions.UseVisualStyleBackColor = true;
        this.buttonOptions.Click += this.buttonOptions_Click;
        //
        //buttonQuit
        //
        this.buttonQuit.Location = new System.Drawing.Point(12, 236);
        this.buttonQuit.Name = "buttonQuit";
        this.buttonQuit.Size = new System.Drawing.Size(157, 23);
        this.buttonQuit.TabIndex = 6;
        this.buttonQuit.Text = "Quit";
        this.buttonQuit.UseVisualStyleBackColor = true;
        this.buttonQuit.Click += this.buttonQuit_Click;
        //
        //formMain
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(182, 272);
        this.Controls.Add(this.buttonProfileManagement);
        this.Controls.Add(this.buttonLastCharacter);
        this.Controls.Add(this.buttonCharacterManagement);
        this.Controls.Add(this.buttonEditor);
        this.Controls.Add(this.buttonOptions);
        this.Controls.Add(this.buttonQuit);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "formMain";
        this.Text = "Main Menu";
        Load += this.formMain_Load;
        this.ResumeLayout(false);
    }
    
    private System.Windows.Forms.Button buttonProfileManagement;
    private System.Windows.Forms.Button buttonLastCharacter;
    private System.Windows.Forms.Button buttonCharacterManagement;
    private System.Windows.Forms.Button buttonEditor;
    private System.Windows.Forms.Button buttonOptions;
    private System.Windows.Forms.Button buttonQuit;
}