<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.tabcontrolOptions = New System.Windows.Forms.TabControl()
    Me.tabpageMessages = New System.Windows.Forms.TabPage()
    Me.checkboxlistMessages = New System.Windows.Forms.CheckedListBox()
    Me.buttonOK = New System.Windows.Forms.Button()
    Me.buttonCancel = New System.Windows.Forms.Button()
    Me.tabcontrolOptions.SuspendLayout()
    Me.tabpageMessages.SuspendLayout()
    Me.SuspendLayout()
    '
    'tabcontrolOptions
    '
    Me.tabcontrolOptions.Controls.Add(Me.tabpageMessages)
    Me.tabcontrolOptions.Location = New System.Drawing.Point(12, 14)
    Me.tabcontrolOptions.Name = "tabcontrolOptions"
    Me.tabcontrolOptions.SelectedIndex = 0
    Me.tabcontrolOptions.Size = New System.Drawing.Size(281, 358)
    Me.tabcontrolOptions.TabIndex = 0
    '
    'tabpageMessages
    '
    Me.tabpageMessages.Controls.Add(Me.checkboxlistMessages)
    Me.tabpageMessages.Location = New System.Drawing.Point(4, 22)
    Me.tabpageMessages.Name = "tabpageMessages"
    Me.tabpageMessages.Padding = New System.Windows.Forms.Padding(3)
    Me.tabpageMessages.Size = New System.Drawing.Size(273, 332)
    Me.tabpageMessages.TabIndex = 1
    Me.tabpageMessages.Text = "Messages"
    Me.tabpageMessages.UseVisualStyleBackColor = True
    '
    'checkboxlistMessages
    '
    Me.checkboxlistMessages.FormattingEnabled = True
    Me.checkboxlistMessages.Items.AddRange(New Object() {"Exiting Program", "Creating New Game Overwrite", "Apply Changes requires restart of program"})
    Me.checkboxlistMessages.Location = New System.Drawing.Point(6, 6)
    Me.checkboxlistMessages.Name = "checkboxlistMessages"
    Me.checkboxlistMessages.Size = New System.Drawing.Size(261, 319)
    Me.checkboxlistMessages.TabIndex = 0
    '
    'buttonOK
    '
    Me.buttonOK.Location = New System.Drawing.Point(22, 378)
    Me.buttonOK.Name = "buttonOK"
    Me.buttonOK.Size = New System.Drawing.Size(126, 28)
    Me.buttonOK.TabIndex = 1
    Me.buttonOK.Text = "Apply && Close"
    Me.buttonOK.UseVisualStyleBackColor = True
    '
    'buttonCancel
    '
    Me.buttonCancel.Location = New System.Drawing.Point(154, 378)
    Me.buttonCancel.Name = "buttonCancel"
    Me.buttonCancel.Size = New System.Drawing.Size(129, 28)
    Me.buttonCancel.TabIndex = 1
    Me.buttonCancel.Text = "Discard && Close"
    Me.buttonCancel.UseVisualStyleBackColor = True
    '
    'FormOptions
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(303, 418)
    Me.Controls.Add(Me.buttonCancel)
    Me.Controls.Add(Me.tabcontrolOptions)
    Me.Controls.Add(Me.buttonOK)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FormOptions"
    Me.Text = "Options"
    Me.tabcontrolOptions.ResumeLayout(False)
    Me.tabpageMessages.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tabcontrolOptions As System.Windows.Forms.TabControl
  Friend WithEvents tabpageMessages As System.Windows.Forms.TabPage
  Friend WithEvents checkboxlistMessages As System.Windows.Forms.CheckedListBox
  Friend WithEvents buttonOK As System.Windows.Forms.Button
  Friend WithEvents buttonCancel As System.Windows.Forms.Button
End Class
