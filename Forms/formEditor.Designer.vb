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
		Me.textboxSetting1 = New System.Windows.Forms.TextBox()
		Me.textboxValue1 = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.textboxSetting2 = New System.Windows.Forms.TextBox()
		Me.textboxValue2 = New System.Windows.Forms.TextBox()
		Me.textboxValue3 = New System.Windows.Forms.TextBox()
		Me.textboxSetting3 = New System.Windows.Forms.TextBox()
		Me.textboxValue4 = New System.Windows.Forms.TextBox()
		Me.textboxValue5 = New System.Windows.Forms.TextBox()
		Me.textboxSetting4 = New System.Windows.Forms.TextBox()
		Me.textboxSetting5 = New System.Windows.Forms.TextBox()
		Me.textboxValue6 = New System.Windows.Forms.TextBox()
		Me.textboxSetting6 = New System.Windows.Forms.TextBox()
		Me.textboxSetting7 = New System.Windows.Forms.TextBox()
		Me.textboxValue7 = New System.Windows.Forms.TextBox()
		Me.textboxValue8 = New System.Windows.Forms.TextBox()
		Me.textboxValue10 = New System.Windows.Forms.TextBox()
		Me.textboxValue9 = New System.Windows.Forms.TextBox()
		Me.textboxValue11 = New System.Windows.Forms.TextBox()
		Me.textboxValue0 = New System.Windows.Forms.TextBox()
		Me.textboxSetting8 = New System.Windows.Forms.TextBox()
		Me.textboxSetting10 = New System.Windows.Forms.TextBox()
		Me.textboxSetting9 = New System.Windows.Forms.TextBox()
		Me.textboxSetting11 = New System.Windows.Forms.TextBox()
		Me.textboxSetting0 = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.textboxFilename = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.buttonBrowse = New System.Windows.Forms.Button()
		Me.buttonLoad = New System.Windows.Forms.Button()
		Me.buttonSave = New System.Windows.Forms.Button()
		Me.buttonClose = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'textboxSetting1
		'
		Me.textboxSetting1.Location = New System.Drawing.Point(12, 77)
		Me.textboxSetting1.Name = "textboxSetting1"
		Me.textboxSetting1.Size = New System.Drawing.Size(161, 20)
		Me.textboxSetting1.TabIndex = 75
		'
		'textboxValue1
		'
		Me.textboxValue1.Location = New System.Drawing.Point(179, 77)
		Me.textboxValue1.Multiline = true
		Me.textboxValue1.Name = "textboxValue1"
		Me.textboxValue1.Size = New System.Drawing.Size(250, 46)
		Me.textboxValue1.TabIndex = 75
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Location = New System.Drawing.Point(12, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(40, 13)
		Me.label1.TabIndex = 76
		Me.label1.Text = "Setting"
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(179, 9)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(34, 13)
		Me.label2.TabIndex = 76
		Me.label2.Text = "Value"
		'
		'textboxSetting2
		'
		Me.textboxSetting2.Location = New System.Drawing.Point(12, 129)
		Me.textboxSetting2.Name = "textboxSetting2"
		Me.textboxSetting2.Size = New System.Drawing.Size(161, 20)
		Me.textboxSetting2.TabIndex = 75
		'
		'textboxValue2
		'
		Me.textboxValue2.Location = New System.Drawing.Point(179, 129)
		Me.textboxValue2.Multiline = true
		Me.textboxValue2.Name = "textboxValue2"
		Me.textboxValue2.Size = New System.Drawing.Size(250, 46)
		Me.textboxValue2.TabIndex = 75
		'
		'textboxValue3
		'
		Me.textboxValue3.Location = New System.Drawing.Point(179, 181)
		Me.textboxValue3.Multiline = true
		Me.textboxValue3.Name = "textboxValue3"
		Me.textboxValue3.Size = New System.Drawing.Size(250, 46)
		Me.textboxValue3.TabIndex = 75
		'
		'textboxSetting3
		'
		Me.textboxSetting3.Location = New System.Drawing.Point(12, 181)
		Me.textboxSetting3.Name = "textboxSetting3"
		Me.textboxSetting3.Size = New System.Drawing.Size(161, 20)
		Me.textboxSetting3.TabIndex = 75
		'
		'textboxValue4
		'
		Me.textboxValue4.Location = New System.Drawing.Point(179, 233)
		Me.textboxValue4.Multiline = true
		Me.textboxValue4.Name = "textboxValue4"
		Me.textboxValue4.Size = New System.Drawing.Size(250, 46)
		Me.textboxValue4.TabIndex = 75
		'
		'textboxValue5
		'
		Me.textboxValue5.Location = New System.Drawing.Point(179, 285)
		Me.textboxValue5.Multiline = true
		Me.textboxValue5.Name = "textboxValue5"
		Me.textboxValue5.Size = New System.Drawing.Size(250, 46)
		Me.textboxValue5.TabIndex = 75
		'
		'textboxSetting4
		'
		Me.textboxSetting4.Location = New System.Drawing.Point(12, 233)
		Me.textboxSetting4.Name = "textboxSetting4"
		Me.textboxSetting4.Size = New System.Drawing.Size(161, 20)
		Me.textboxSetting4.TabIndex = 75
		'
		'textboxSetting5
		'
		Me.textboxSetting5.Location = New System.Drawing.Point(12, 285)
		Me.textboxSetting5.Name = "textboxSetting5"
		Me.textboxSetting5.Size = New System.Drawing.Size(161, 20)
		Me.textboxSetting5.TabIndex = 75
		'
		'textboxValue6
		'
		Me.textboxValue6.Location = New System.Drawing.Point(602, 25)
		Me.textboxValue6.Multiline = true
		Me.textboxValue6.Name = "textboxValue6"
		Me.textboxValue6.Size = New System.Drawing.Size(250, 46)
		Me.textboxValue6.TabIndex = 75
		'
		'textboxSetting6
		'
		Me.textboxSetting6.Location = New System.Drawing.Point(435, 25)
		Me.textboxSetting6.Name = "textboxSetting6"
		Me.textboxSetting6.Size = New System.Drawing.Size(161, 20)
		Me.textboxSetting6.TabIndex = 75
		'
		'textboxSetting7
		'
		Me.textboxSetting7.Location = New System.Drawing.Point(435, 77)
		Me.textboxSetting7.Name = "textboxSetting7"
		Me.textboxSetting7.Size = New System.Drawing.Size(161, 20)
		Me.textboxSetting7.TabIndex = 75
		'
		'textboxValue7
		'
		Me.textboxValue7.Location = New System.Drawing.Point(602, 77)
		Me.textboxValue7.Multiline = true
		Me.textboxValue7.Name = "textboxValue7"
		Me.textboxValue7.Size = New System.Drawing.Size(250, 46)
		Me.textboxValue7.TabIndex = 75
		'
		'textboxValue8
		'
		Me.textboxValue8.Location = New System.Drawing.Point(602, 129)
		Me.textboxValue8.Multiline = true
		Me.textboxValue8.Name = "textboxValue8"
		Me.textboxValue8.Size = New System.Drawing.Size(250, 46)
		Me.textboxValue8.TabIndex = 75
		'
		'textboxValue10
		'
		Me.textboxValue10.Location = New System.Drawing.Point(602, 233)
		Me.textboxValue10.Multiline = true
		Me.textboxValue10.Name = "textboxValue10"
		Me.textboxValue10.Size = New System.Drawing.Size(250, 46)
		Me.textboxValue10.TabIndex = 75
		'
		'textboxValue9
		'
		Me.textboxValue9.Location = New System.Drawing.Point(602, 181)
		Me.textboxValue9.Multiline = true
		Me.textboxValue9.Name = "textboxValue9"
		Me.textboxValue9.Size = New System.Drawing.Size(250, 46)
		Me.textboxValue9.TabIndex = 75
		'
		'textboxValue11
		'
		Me.textboxValue11.Location = New System.Drawing.Point(602, 285)
		Me.textboxValue11.Multiline = true
		Me.textboxValue11.Name = "textboxValue11"
		Me.textboxValue11.Size = New System.Drawing.Size(250, 46)
		Me.textboxValue11.TabIndex = 75
		'
		'textboxValue0
		'
		Me.textboxValue0.Location = New System.Drawing.Point(179, 25)
		Me.textboxValue0.Multiline = true
		Me.textboxValue0.Name = "textboxValue0"
		Me.textboxValue0.Size = New System.Drawing.Size(250, 46)
		Me.textboxValue0.TabIndex = 75
		'
		'textboxSetting8
		'
		Me.textboxSetting8.Location = New System.Drawing.Point(435, 129)
		Me.textboxSetting8.Name = "textboxSetting8"
		Me.textboxSetting8.Size = New System.Drawing.Size(161, 20)
		Me.textboxSetting8.TabIndex = 75
		'
		'textboxSetting10
		'
		Me.textboxSetting10.Location = New System.Drawing.Point(435, 233)
		Me.textboxSetting10.Name = "textboxSetting10"
		Me.textboxSetting10.Size = New System.Drawing.Size(161, 20)
		Me.textboxSetting10.TabIndex = 75
		'
		'textboxSetting9
		'
		Me.textboxSetting9.Location = New System.Drawing.Point(435, 181)
		Me.textboxSetting9.Name = "textboxSetting9"
		Me.textboxSetting9.Size = New System.Drawing.Size(161, 20)
		Me.textboxSetting9.TabIndex = 75
		'
		'textboxSetting11
		'
		Me.textboxSetting11.Location = New System.Drawing.Point(435, 285)
		Me.textboxSetting11.Name = "textboxSetting11"
		Me.textboxSetting11.Size = New System.Drawing.Size(161, 20)
		Me.textboxSetting11.TabIndex = 75
		'
		'textboxSetting0
		'
		Me.textboxSetting0.Location = New System.Drawing.Point(12, 25)
		Me.textboxSetting0.Name = "textboxSetting0"
		Me.textboxSetting0.Size = New System.Drawing.Size(161, 20)
		Me.textboxSetting0.TabIndex = 75
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(435, 9)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(40, 13)
		Me.label3.TabIndex = 76
		Me.label3.Text = "Setting"
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Location = New System.Drawing.Point(602, 9)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(34, 13)
		Me.label4.TabIndex = 76
		Me.label4.Text = "Value"
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
		Me.buttonLoad.Size = New System.Drawing.Size(219, 34)
		Me.buttonLoad.TabIndex = 80
		Me.buttonLoad.Text = "Load"
		Me.buttonLoad.UseVisualStyleBackColor = true
		AddHandler Me.buttonLoad.Click, AddressOf Me.ButtonLoadClick
		'
		'buttonSave
		'
		Me.buttonSave.Location = New System.Drawing.Point(237, 379)
		Me.buttonSave.Name = "buttonSave"
		Me.buttonSave.Size = New System.Drawing.Size(219, 34)
		Me.buttonSave.TabIndex = 80
		Me.buttonSave.Text = "Save"
		Me.buttonSave.UseVisualStyleBackColor = true
		AddHandler Me.buttonSave.Click, AddressOf Me.ButtonSaveClick
		'
		'buttonClose
		'
		Me.buttonClose.Location = New System.Drawing.Point(462, 379)
		Me.buttonClose.Name = "buttonClose"
		Me.buttonClose.Size = New System.Drawing.Size(390, 34)
		Me.buttonClose.TabIndex = 80
		Me.buttonClose.Text = "Close"
		Me.buttonClose.UseVisualStyleBackColor = true
		AddHandler Me.buttonClose.Click, AddressOf Me.ButtonCloseClick
		'
		'formEditor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(866, 426)
		Me.Controls.Add(Me.buttonClose)
		Me.Controls.Add(Me.buttonSave)
		Me.Controls.Add(Me.buttonLoad)
		Me.Controls.Add(Me.buttonBrowse)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.textboxFilename)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.textboxSetting0)
		Me.Controls.Add(Me.textboxSetting6)
		Me.Controls.Add(Me.textboxSetting11)
		Me.Controls.Add(Me.textboxSetting5)
		Me.Controls.Add(Me.textboxSetting9)
		Me.Controls.Add(Me.textboxSetting3)
		Me.Controls.Add(Me.textboxSetting10)
		Me.Controls.Add(Me.textboxSetting4)
		Me.Controls.Add(Me.textboxSetting8)
		Me.Controls.Add(Me.textboxSetting2)
		Me.Controls.Add(Me.textboxValue0)
		Me.Controls.Add(Me.textboxValue6)
		Me.Controls.Add(Me.textboxValue11)
		Me.Controls.Add(Me.textboxValue5)
		Me.Controls.Add(Me.textboxValue9)
		Me.Controls.Add(Me.textboxValue3)
		Me.Controls.Add(Me.textboxValue10)
		Me.Controls.Add(Me.textboxValue4)
		Me.Controls.Add(Me.textboxValue8)
		Me.Controls.Add(Me.textboxValue2)
		Me.Controls.Add(Me.textboxValue7)
		Me.Controls.Add(Me.textboxValue1)
		Me.Controls.Add(Me.textboxSetting7)
		Me.Controls.Add(Me.textboxSetting1)
		Me.Name = "formEditor"
		Me.Text = "formEditor"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private buttonClose As System.Windows.Forms.Button
	Private buttonSave As System.Windows.Forms.Button
	Private buttonLoad As System.Windows.Forms.Button
	Private buttonBrowse As System.Windows.Forms.Button
	Private label5 As System.Windows.Forms.Label
	Private textboxFilename As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private textboxSetting0 As System.Windows.Forms.TextBox
	Private textboxSetting11 As System.Windows.Forms.TextBox
	Private textboxSetting9 As System.Windows.Forms.TextBox
	Private textboxSetting10 As System.Windows.Forms.TextBox
	Private textboxSetting8 As System.Windows.Forms.TextBox
	Private textboxValue0 As System.Windows.Forms.TextBox
	Private textboxValue11 As System.Windows.Forms.TextBox
	Private textboxValue9 As System.Windows.Forms.TextBox
	Private textboxValue10 As System.Windows.Forms.TextBox
	Private textboxValue8 As System.Windows.Forms.TextBox
	Private textboxValue7 As System.Windows.Forms.TextBox
	Private textboxSetting7 As System.Windows.Forms.TextBox
	Private textboxSetting6 As System.Windows.Forms.TextBox
	Private textboxValue6 As System.Windows.Forms.TextBox
	Private textboxSetting5 As System.Windows.Forms.TextBox
	Private textboxSetting4 As System.Windows.Forms.TextBox
	Private textboxValue5 As System.Windows.Forms.TextBox
	Private textboxValue4 As System.Windows.Forms.TextBox
	Private textboxSetting3 As System.Windows.Forms.TextBox
	Private textboxValue3 As System.Windows.Forms.TextBox
	Private textboxValue2 As System.Windows.Forms.TextBox
	Private textboxSetting2 As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private textboxValue1 As System.Windows.Forms.TextBox
	Private textboxSetting1 As System.Windows.Forms.TextBox
End Class
