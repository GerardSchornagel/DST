Partial Class formNewGame
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
		Me.checkboxGender = New System.Windows.Forms.CheckBox()
		Me.labelCreateTime = New System.Windows.Forms.Label()
		Me.textboxCreateTime = New System.Windows.Forms.TextBox()
		Me.labelCreateDate = New System.Windows.Forms.Label()
		Me.textboxCreateDate = New System.Windows.Forms.TextBox()
		Me.textboxBirthYear = New System.Windows.Forms.TextBox()
		Me.labelNameLast = New System.Windows.Forms.Label()
		Me.labelBirthDate = New System.Windows.Forms.Label()
		Me.textboxNameFirst = New System.Windows.Forms.TextBox()
		Me.labelNameNick = New System.Windows.Forms.Label()
		Me.textboxBirthDay = New System.Windows.Forms.TextBox()
		Me.labelNameFirst = New System.Windows.Forms.Label()
		Me.textboxNameLast = New System.Windows.Forms.TextBox()
		Me.textboxBirthMonth = New System.Windows.Forms.TextBox()
		Me.textboxNameNick = New System.Windows.Forms.TextBox()
		Me.buttonCreate = New System.Windows.Forms.Button()
		Me.groupboxProfile.SuspendLayout
		Me.SuspendLayout
		'
		'groupboxProfile
		'
		Me.groupboxProfile.Controls.Add(Me.checkboxGender)
		Me.groupboxProfile.Controls.Add(Me.labelCreateTime)
		Me.groupboxProfile.Controls.Add(Me.textboxCreateTime)
		Me.groupboxProfile.Controls.Add(Me.labelCreateDate)
		Me.groupboxProfile.Controls.Add(Me.textboxCreateDate)
		Me.groupboxProfile.Controls.Add(Me.textboxBirthYear)
		Me.groupboxProfile.Controls.Add(Me.labelNameLast)
		Me.groupboxProfile.Controls.Add(Me.labelBirthDate)
		Me.groupboxProfile.Controls.Add(Me.textboxNameFirst)
		Me.groupboxProfile.Controls.Add(Me.labelNameNick)
		Me.groupboxProfile.Controls.Add(Me.textboxBirthDay)
		Me.groupboxProfile.Controls.Add(Me.labelNameFirst)
		Me.groupboxProfile.Controls.Add(Me.textboxNameLast)
		Me.groupboxProfile.Controls.Add(Me.textboxBirthMonth)
		Me.groupboxProfile.Controls.Add(Me.textboxNameNick)
		Me.groupboxProfile.Location = New System.Drawing.Point(12, 12)
		Me.groupboxProfile.Name = "groupboxProfile"
		Me.groupboxProfile.Size = New System.Drawing.Size(146, 295)
		Me.groupboxProfile.TabIndex = 6
		Me.groupboxProfile.TabStop = false
		Me.groupboxProfile.Text = "Profile"
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
		'labelCreateTime
		'
		Me.labelCreateTime.AutoSize = true
		Me.labelCreateTime.Location = New System.Drawing.Point(6, 250)
		Me.labelCreateTime.Name = "labelCreateTime"
		Me.labelCreateTime.Size = New System.Drawing.Size(70, 13)
		Me.labelCreateTime.TabIndex = 3
		Me.labelCreateTime.Text = "Time Created"
		'
		'textboxCreateTime
		'
		Me.textboxCreateTime.Location = New System.Drawing.Point(9, 266)
		Me.textboxCreateTime.Name = "textboxCreateTime"
		Me.textboxCreateTime.ReadOnly = true
		Me.textboxCreateTime.Size = New System.Drawing.Size(128, 20)
		Me.textboxCreateTime.TabIndex = 5
		Me.textboxCreateTime.TabStop = false
		'
		'labelCreateDate
		'
		Me.labelCreateDate.AutoSize = true
		Me.labelCreateDate.Location = New System.Drawing.Point(6, 211)
		Me.labelCreateDate.Name = "labelCreateDate"
		Me.labelCreateDate.Size = New System.Drawing.Size(70, 13)
		Me.labelCreateDate.TabIndex = 2
		Me.labelCreateDate.Text = "Date Created"
		'
		'textboxCreateDate
		'
		Me.textboxCreateDate.Location = New System.Drawing.Point(9, 227)
		Me.textboxCreateDate.Name = "textboxCreateDate"
		Me.textboxCreateDate.ReadOnly = true
		Me.textboxCreateDate.Size = New System.Drawing.Size(128, 20)
		Me.textboxCreateDate.TabIndex = 4
		Me.textboxCreateDate.TabStop = false
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
		Me.labelNameLast.Size = New System.Drawing.Size(75, 13)
		Me.labelNameLast.TabIndex = 0
		Me.labelNameLast.Text = "RL Last Name"
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
		'textboxNameFirst
		'
		Me.textboxNameFirst.Location = New System.Drawing.Point(9, 71)
		Me.textboxNameFirst.Name = "textboxNameFirst"
		Me.textboxNameFirst.Size = New System.Drawing.Size(128, 20)
		Me.textboxNameFirst.TabIndex = 1
		'
		'labelNameNick
		'
		Me.labelNameNick.AutoSize = true
		Me.labelNameNick.Location = New System.Drawing.Point(6, 16)
		Me.labelNameNick.Name = "labelNameNick"
		Me.labelNameNick.Size = New System.Drawing.Size(60, 13)
		Me.labelNameNick.TabIndex = 0
		Me.labelNameNick.Text = "Nick Name"
		'
		'textboxBirthDay
		'
		Me.textboxBirthDay.Location = New System.Drawing.Point(108, 149)
		Me.textboxBirthDay.Name = "textboxBirthDay"
		Me.textboxBirthDay.Size = New System.Drawing.Size(29, 20)
		Me.textboxBirthDay.TabIndex = 5
		AddHandler Me.textboxBirthDay.LostFocus, AddressOf Me.TextboxBirthDayLostFocus
		'
		'labelNameFirst
		'
		Me.labelNameFirst.AutoSize = true
		Me.labelNameFirst.Location = New System.Drawing.Point(6, 55)
		Me.labelNameFirst.Name = "labelNameFirst"
		Me.labelNameFirst.Size = New System.Drawing.Size(74, 13)
		Me.labelNameFirst.TabIndex = 0
		Me.labelNameFirst.Text = "RL First Name"
		'
		'textboxNameLast
		'
		Me.textboxNameLast.Location = New System.Drawing.Point(9, 110)
		Me.textboxNameLast.Name = "textboxNameLast"
		Me.textboxNameLast.Size = New System.Drawing.Size(128, 20)
		Me.textboxNameLast.TabIndex = 2
		'
		'textboxBirthMonth
		'
		Me.textboxBirthMonth.Location = New System.Drawing.Point(71, 149)
		Me.textboxBirthMonth.Name = "textboxBirthMonth"
		Me.textboxBirthMonth.Size = New System.Drawing.Size(31, 20)
		Me.textboxBirthMonth.TabIndex = 4
		AddHandler Me.textboxBirthMonth.LostFocus, AddressOf Me.TextboxBirthMonthLostFocus
		'
		'textboxNameNick
		'
		Me.textboxNameNick.Location = New System.Drawing.Point(9, 32)
		Me.textboxNameNick.Name = "textboxNameNick"
		Me.textboxNameNick.Size = New System.Drawing.Size(128, 20)
		Me.textboxNameNick.TabIndex = 0
		'
		'buttonCreate
		'
		Me.buttonCreate.Location = New System.Drawing.Point(12, 313)
		Me.buttonCreate.Name = "buttonCreate"
		Me.buttonCreate.Size = New System.Drawing.Size(146, 23)
		Me.buttonCreate.TabIndex = 8
		Me.buttonCreate.Text = "Create"
		Me.buttonCreate.UseVisualStyleBackColor = true
		AddHandler Me.buttonCreate.Click, AddressOf Me.ButtonCreateClick
		'
		'formNewGame
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(171, 348)
		Me.Controls.Add(Me.buttonCreate)
		Me.Controls.Add(Me.groupboxProfile)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "formNewGame"
		Me.Text = "New Player"
		AddHandler Load, AddressOf Me.FormNewGameLoad
		Me.groupboxProfile.ResumeLayout(false)
		Me.groupboxProfile.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private checkboxGender As System.Windows.Forms.CheckBox
	Private buttonCreate As System.Windows.Forms.Button
	Private textboxNameNick As System.Windows.Forms.TextBox
	Private textboxBirthMonth As System.Windows.Forms.TextBox
	Private textboxNameLast As System.Windows.Forms.TextBox
	Private labelNameFirst As System.Windows.Forms.Label
	Private textboxBirthDay As System.Windows.Forms.TextBox
	Private labelNameNick As System.Windows.Forms.Label
	Private textboxNameFirst As System.Windows.Forms.TextBox
	Private labelBirthDate As System.Windows.Forms.Label
	Private labelNameLast As System.Windows.Forms.Label
	Private textboxBirthYear As System.Windows.Forms.TextBox
	Private textboxCreateDate As System.Windows.Forms.TextBox
	Private labelCreateDate As System.Windows.Forms.Label
	Private textboxCreateTime As System.Windows.Forms.TextBox
	Private labelCreateTime As System.Windows.Forms.Label
	Private groupboxProfile As System.Windows.Forms.GroupBox
End Class
