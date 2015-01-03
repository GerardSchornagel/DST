Partial Class formPlayerManagement
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
		Me.groupboxProfile = New System.Windows.Forms.GroupBox()
		Me.checkboxNotification = New System.Windows.Forms.CheckBox()
		Me.checkboxGender = New System.Windows.Forms.CheckBox()
		Me.textboxBirthYear = New System.Windows.Forms.TextBox()
		Me.labelNameLast = New System.Windows.Forms.Label()
		Me.labelBirthDate = New System.Windows.Forms.Label()
		Me.textboxEMail = New System.Windows.Forms.TextBox()
		Me.textboxNameFirst = New System.Windows.Forms.TextBox()
		Me.labelProfileID = New System.Windows.Forms.Label()
		Me.textboxBirthDay = New System.Windows.Forms.TextBox()
		Me.labelEMail = New System.Windows.Forms.Label()
		Me.labelNameFirst = New System.Windows.Forms.Label()
		Me.textboxNameLast = New System.Windows.Forms.TextBox()
		Me.textboxBirthMonth = New System.Windows.Forms.TextBox()
		Me.textboxProfileID = New System.Windows.Forms.TextBox()
		Me.buttonCreate = New System.Windows.Forms.Button()
		Me.listboxProfile = New System.Windows.Forms.ListBox()
		Me.buttonLoad = New System.Windows.Forms.Button()
		Me.groupboxProfile.SuspendLayout
		Me.SuspendLayout
		'
		'groupboxProfile
		'
		Me.groupboxProfile.Controls.Add(Me.checkboxNotification)
		Me.groupboxProfile.Controls.Add(Me.checkboxGender)
		Me.groupboxProfile.Controls.Add(Me.textboxBirthYear)
		Me.groupboxProfile.Controls.Add(Me.labelNameLast)
		Me.groupboxProfile.Controls.Add(Me.labelBirthDate)
		Me.groupboxProfile.Controls.Add(Me.textboxEMail)
		Me.groupboxProfile.Controls.Add(Me.textboxNameFirst)
		Me.groupboxProfile.Controls.Add(Me.labelProfileID)
		Me.groupboxProfile.Controls.Add(Me.textboxBirthDay)
		Me.groupboxProfile.Controls.Add(Me.labelEMail)
		Me.groupboxProfile.Controls.Add(Me.labelNameFirst)
		Me.groupboxProfile.Controls.Add(Me.textboxNameLast)
		Me.groupboxProfile.Controls.Add(Me.textboxBirthMonth)
		Me.groupboxProfile.Controls.Add(Me.textboxProfileID)
		Me.groupboxProfile.Location = New System.Drawing.Point(12, 12)
		Me.groupboxProfile.Name = "groupboxProfile"
		Me.groupboxProfile.Size = New System.Drawing.Size(146, 292)
		Me.groupboxProfile.TabIndex = 6
		Me.groupboxProfile.TabStop = false
		Me.groupboxProfile.Text = "Profile"
		'
		'checkboxNotification
		'
		Me.checkboxNotification.Location = New System.Drawing.Point(6, 253)
		Me.checkboxNotification.Name = "checkboxNotification"
		Me.checkboxNotification.Size = New System.Drawing.Size(127, 33)
		Me.checkboxNotification.TabIndex = 8
		Me.checkboxNotification.Text = "E-Mail Notification"
		Me.checkboxNotification.UseVisualStyleBackColor = true
		AddHandler Me.checkboxNotification.CheckedChanged, AddressOf Me.CheckboxGenderCheckedChanged
		'
		'checkboxGender
		'
		Me.checkboxGender.Location = New System.Drawing.Point(10, 175)
		Me.checkboxGender.Name = "checkboxGender"
		Me.checkboxGender.Size = New System.Drawing.Size(127, 33)
		Me.checkboxGender.TabIndex = 6
		Me.checkboxGender.Text = "Male"
		Me.checkboxGender.UseVisualStyleBackColor = true
		AddHandler Me.checkboxGender.CheckedChanged, AddressOf Me.CheckboxGenderCheckedChanged
		'
		'textboxBirthYear
		'
		Me.textboxBirthYear.Location = New System.Drawing.Point(9, 149)
		Me.textboxBirthYear.Name = "textboxBirthYear"
		Me.textboxBirthYear.Size = New System.Drawing.Size(56, 20)
		Me.textboxBirthYear.TabIndex = 3
		AddHandler Me.textboxBirthYear.LostFocus, AddressOf Me.TextboxBirthYearLostFocus
		'
		'labelNameLast
		'
		Me.labelNameLast.AutoSize = true
		Me.labelNameLast.Location = New System.Drawing.Point(6, 94)
		Me.labelNameLast.Name = "labelNameLast"
		Me.labelNameLast.Size = New System.Drawing.Size(58, 13)
		Me.labelNameLast.TabIndex = 0
		Me.labelNameLast.Text = "Last Name"
		'
		'labelBirthDate
		'
		Me.labelBirthDate.AutoSize = true
		Me.labelBirthDate.Location = New System.Drawing.Point(6, 133)
		Me.labelBirthDate.Name = "labelBirthDate"
		Me.labelBirthDate.Size = New System.Drawing.Size(131, 13)
		Me.labelBirthDate.TabIndex = 0
		Me.labelBirthDate.Text = "Birth Date (YYYY-MM-DD)"
		'
		'textboxEMail
		'
		Me.textboxEMail.Location = New System.Drawing.Point(9, 227)
		Me.textboxEMail.Name = "textboxEMail"
		Me.textboxEMail.Size = New System.Drawing.Size(128, 20)
		Me.textboxEMail.TabIndex = 7
		'
		'textboxNameFirst
		'
		Me.textboxNameFirst.Location = New System.Drawing.Point(9, 71)
		Me.textboxNameFirst.Name = "textboxNameFirst"
		Me.textboxNameFirst.Size = New System.Drawing.Size(128, 20)
		Me.textboxNameFirst.TabIndex = 1
		AddHandler Me.textboxNameFirst.TextChanged, AddressOf Me.TextboxNameFirstTextChanged
		'
		'labelProfileID
		'
		Me.labelProfileID.AutoSize = true
		Me.labelProfileID.Location = New System.Drawing.Point(6, 16)
		Me.labelProfileID.Name = "labelProfileID"
		Me.labelProfileID.Size = New System.Drawing.Size(67, 13)
		Me.labelProfileID.TabIndex = 0
		Me.labelProfileID.Text = "Profile Name"
		'
		'textboxBirthDay
		'
		Me.textboxBirthDay.Location = New System.Drawing.Point(108, 149)
		Me.textboxBirthDay.Name = "textboxBirthDay"
		Me.textboxBirthDay.Size = New System.Drawing.Size(29, 20)
		Me.textboxBirthDay.TabIndex = 5
		AddHandler Me.textboxBirthDay.LostFocus, AddressOf Me.TextboxBirthDayLostFocus
		'
		'labelEMail
		'
		Me.labelEMail.AutoSize = true
		Me.labelEMail.Location = New System.Drawing.Point(6, 211)
		Me.labelEMail.Name = "labelEMail"
		Me.labelEMail.Size = New System.Drawing.Size(36, 13)
		Me.labelEMail.TabIndex = 0
		Me.labelEMail.Text = "E-Mail"
		'
		'labelNameFirst
		'
		Me.labelNameFirst.AutoSize = true
		Me.labelNameFirst.Location = New System.Drawing.Point(6, 55)
		Me.labelNameFirst.Name = "labelNameFirst"
		Me.labelNameFirst.Size = New System.Drawing.Size(57, 13)
		Me.labelNameFirst.TabIndex = 0
		Me.labelNameFirst.Text = "First Name"
		'
		'textboxNameLast
		'
		Me.textboxNameLast.Location = New System.Drawing.Point(9, 110)
		Me.textboxNameLast.Name = "textboxNameLast"
		Me.textboxNameLast.Size = New System.Drawing.Size(128, 20)
		Me.textboxNameLast.TabIndex = 2
		AddHandler Me.textboxNameLast.TextChanged, AddressOf Me.TextboxNameLastTextChanged
		'
		'textboxBirthMonth
		'
		Me.textboxBirthMonth.Location = New System.Drawing.Point(71, 149)
		Me.textboxBirthMonth.Name = "textboxBirthMonth"
		Me.textboxBirthMonth.Size = New System.Drawing.Size(31, 20)
		Me.textboxBirthMonth.TabIndex = 4
		AddHandler Me.textboxBirthMonth.LostFocus, AddressOf Me.TextboxBirthMonthLostFocus
		'
		'textboxProfileID
		'
		Me.textboxProfileID.Location = New System.Drawing.Point(9, 32)
		Me.textboxProfileID.Name = "textboxProfileID"
		Me.textboxProfileID.ReadOnly = true
		Me.textboxProfileID.Size = New System.Drawing.Size(128, 20)
		Me.textboxProfileID.TabIndex = 0
		'
		'buttonCreate
		'
		Me.buttonCreate.Location = New System.Drawing.Point(12, 310)
		Me.buttonCreate.Name = "buttonCreate"
		Me.buttonCreate.Size = New System.Drawing.Size(71, 29)
		Me.buttonCreate.TabIndex = 9
		Me.buttonCreate.Text = "Create"
		Me.buttonCreate.UseVisualStyleBackColor = true
		AddHandler Me.buttonCreate.Click, AddressOf Me.ButtonCreateClick
		'
		'listboxProfile
		'
		Me.listboxProfile.FormattingEnabled = true
		Me.listboxProfile.Location = New System.Drawing.Point(164, 13)
		Me.listboxProfile.Name = "listboxProfile"
		Me.listboxProfile.Size = New System.Drawing.Size(130, 329)
		Me.listboxProfile.TabIndex = 10
		'
		'buttonLoad
		'
		Me.buttonLoad.Location = New System.Drawing.Point(89, 310)
		Me.buttonLoad.Name = "buttonLoad"
		Me.buttonLoad.Size = New System.Drawing.Size(69, 29)
		Me.buttonLoad.TabIndex = 11
		Me.buttonLoad.Text = "Use"
		Me.buttonLoad.UseVisualStyleBackColor = true
		AddHandler Me.buttonLoad.Click, AddressOf Me.ButtonLoadClick
		'
		'formProfileManagement
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(309, 353)
		Me.Controls.Add(Me.buttonLoad)
		Me.Controls.Add(Me.listboxProfile)
		Me.Controls.Add(Me.buttonCreate)
		Me.Controls.Add(Me.groupboxProfile)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "formPlayerManagement"
		Me.Text = "New Player"
		AddHandler Load, AddressOf Me.formPlayerManagementLoad
		Me.groupboxProfile.ResumeLayout(false)
		Me.groupboxProfile.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private buttonLoad As System.Windows.Forms.Button
	Private listboxProfile As System.Windows.Forms.ListBox
	Private textboxProfileID As System.Windows.Forms.TextBox
	Private labelEMail As System.Windows.Forms.Label
	Private labelProfileID As System.Windows.Forms.Label
	Private textboxEMail As System.Windows.Forms.TextBox
	Private checkboxNotification As System.Windows.Forms.CheckBox
	Private checkboxGender As System.Windows.Forms.CheckBox
	Private buttonCreate As System.Windows.Forms.Button
	Private textboxBirthMonth As System.Windows.Forms.TextBox
	Private textboxNameLast As System.Windows.Forms.TextBox
	Private labelNameFirst As System.Windows.Forms.Label
	Private textboxBirthDay As System.Windows.Forms.TextBox
	Private textboxNameFirst As System.Windows.Forms.TextBox
	Private labelBirthDate As System.Windows.Forms.Label
	Private labelNameLast As System.Windows.Forms.Label
	Private textboxBirthYear As System.Windows.Forms.TextBox
	Private groupboxProfile As System.Windows.Forms.GroupBox
End Class
