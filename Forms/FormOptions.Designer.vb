Partial Class formOptions
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.tabcontrolOptions = New System.Windows.Forms.TabControl()
		Me.tabpageMessages = New System.Windows.Forms.TabPage()
		Me.checkboxlistMessages = New System.Windows.Forms.CheckedListBox()
		Me.buttonOK = New System.Windows.Forms.Button()
		Me.buttonCancel = New System.Windows.Forms.Button()
		Me.tabcontrolOptions.SuspendLayout
		Me.tabpageMessages.SuspendLayout
		Me.SuspendLayout
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
		Me.tabpageMessages.UseVisualStyleBackColor = true
		'
		'checkboxlistMessages
		'
		Me.checkboxlistMessages.FormattingEnabled = true
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
		Me.buttonOK.UseVisualStyleBackColor = true
		AddHandler Me.buttonOK.Click, AddressOf Me.ButtonOKClick
		'
		'buttonCancel
		'
		Me.buttonCancel.Location = New System.Drawing.Point(154, 378)
		Me.buttonCancel.Name = "buttonCancel"
		Me.buttonCancel.Size = New System.Drawing.Size(129, 28)
		Me.buttonCancel.TabIndex = 1
		Me.buttonCancel.Text = "Discard && Close"
		Me.buttonCancel.UseVisualStyleBackColor = true
		AddHandler Me.buttonCancel.Click, AddressOf Me.ButtonCancelClick
		'
		'formOptions
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(303, 418)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.tabcontrolOptions)
		Me.Controls.Add(Me.buttonOK)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "formOptions"
		Me.Text = "Options"
		Me.tabcontrolOptions.ResumeLayout(false)
		Me.tabpageMessages.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	
	Private tabcontrolOptions As System.Windows.Forms.TabControl
	Private tabpageMessages As System.Windows.Forms.TabPage
	Private checkboxlistMessages As System.Windows.Forms.CheckedListBox
	Private buttonOK As System.Windows.Forms.Button
	Private buttonCancel As System.Windows.Forms.Button
End Class
