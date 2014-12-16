Partial Class formEditor
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
		Me.textboxFilename = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.buttonBrowse = New System.Windows.Forms.Button()
		Me.buttonLoad = New System.Windows.Forms.Button()
		Me.buttonSave = New System.Windows.Forms.Button()
		Me.buttonClose = New System.Windows.Forms.Button()
		Me.textboxEdit = New System.Windows.Forms.TextBox()
		Me.textboxDescription = New System.Windows.Forms.TextBox()
		Me.listboxDescription = New System.Windows.Forms.ListBox()
		Me.SuspendLayout
		'
		'textboxFilename
		'
		Me.textboxFilename.Location = New System.Drawing.Point(12, 352)
		Me.textboxFilename.Name = "textboxFilename"
		Me.textboxFilename.Size = New System.Drawing.Size(444, 20)
		Me.textboxFilename.TabIndex = 77
		'
		'label5
		'
		Me.label5.AutoSize = true
		Me.label5.Location = New System.Drawing.Point(12, 336)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(49, 13)
		Me.label5.TabIndex = 78
		Me.label5.Text = "Filename"
		'
		'buttonBrowse
		'
		Me.buttonBrowse.Location = New System.Drawing.Point(462, 352)
		Me.buttonBrowse.Name = "buttonBrowse"
		Me.buttonBrowse.Size = New System.Drawing.Size(24, 21)
		Me.buttonBrowse.TabIndex = 79
		Me.buttonBrowse.Text = "..."
		Me.buttonBrowse.UseVisualStyleBackColor = true
		AddHandler Me.buttonBrowse.Click, AddressOf Me.ButtonBrowseClick
		'
		'buttonLoad
		'
		Me.buttonLoad.Location = New System.Drawing.Point(12, 379)
		Me.buttonLoad.Name = "buttonLoad"
		Me.buttonLoad.Size = New System.Drawing.Size(114, 34)
		Me.buttonLoad.TabIndex = 80
		Me.buttonLoad.Text = "Load"
		Me.buttonLoad.UseVisualStyleBackColor = true
		AddHandler Me.buttonLoad.Click, AddressOf Me.ButtonLoadClick
		'
		'buttonSave
		'
		Me.buttonSave.Location = New System.Drawing.Point(132, 380)
		Me.buttonSave.Name = "buttonSave"
		Me.buttonSave.Size = New System.Drawing.Size(114, 34)
		Me.buttonSave.TabIndex = 80
		Me.buttonSave.Text = "Save"
		Me.buttonSave.UseVisualStyleBackColor = true
		AddHandler Me.buttonSave.Click, AddressOf Me.ButtonSaveClick
		'
		'buttonClose
		'
		Me.buttonClose.Location = New System.Drawing.Point(252, 380)
		Me.buttonClose.Name = "buttonClose"
		Me.buttonClose.Size = New System.Drawing.Size(234, 34)
		Me.buttonClose.TabIndex = 80
		Me.buttonClose.Text = "Close"
		Me.buttonClose.UseVisualStyleBackColor = true
		AddHandler Me.buttonClose.Click, AddressOf Me.ButtonCloseClick
		'
		'textboxEdit
		'
		Me.textboxEdit.Location = New System.Drawing.Point(12, 12)
		Me.textboxEdit.Multiline = true
		Me.textboxEdit.Name = "textboxEdit"
		Me.textboxEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.textboxEdit.Size = New System.Drawing.Size(474, 321)
		Me.textboxEdit.TabIndex = 0
		'
		'textboxDescription
		'
		Me.textboxDescription.Location = New System.Drawing.Point(492, 74)
		Me.textboxDescription.Multiline = true
		Me.textboxDescription.Name = "textboxDescription"
		Me.textboxDescription.Size = New System.Drawing.Size(199, 339)
		Me.textboxDescription.TabIndex = 81
		'
		'listboxDescription
		'
		Me.listboxDescription.FormattingEnabled = true
		Me.listboxDescription.Location = New System.Drawing.Point(492, 12)
		Me.listboxDescription.Name = "listboxDescription"
		Me.listboxDescription.Size = New System.Drawing.Size(199, 56)
		Me.listboxDescription.TabIndex = 82
		AddHandler Me.listboxDescription.SelectedIndexChanged, AddressOf Me.ListboxDescriptionSelectedIndexChanged
		'
		'formEditor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(703, 426)
		Me.Controls.Add(Me.listboxDescription)
		Me.Controls.Add(Me.textboxDescription)
		Me.Controls.Add(Me.textboxEdit)
		Me.Controls.Add(Me.buttonClose)
		Me.Controls.Add(Me.buttonSave)
		Me.Controls.Add(Me.buttonLoad)
		Me.Controls.Add(Me.buttonBrowse)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.textboxFilename)
		Me.Name = "formEditor"
		Me.Text = "formEditor"
		AddHandler Load, AddressOf Me.FormEditorLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private listboxDescription As System.Windows.Forms.ListBox
	Private textboxDescription As System.Windows.Forms.TextBox
	Private textboxEdit As System.Windows.Forms.TextBox
	Private buttonClose As System.Windows.Forms.Button
	Private buttonSave As System.Windows.Forms.Button
	Private buttonLoad As System.Windows.Forms.Button
	Private buttonBrowse As System.Windows.Forms.Button
	Private label5 As System.Windows.Forms.Label
	Private textboxFilename As System.Windows.Forms.TextBox
End Class
