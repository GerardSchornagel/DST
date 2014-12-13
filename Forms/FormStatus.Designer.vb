Partial Class formStatus
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
		Me.buttonExit = New System.Windows.Forms.Button()
		Me.labelBalance = New System.Windows.Forms.Label()
		Me.textboxBalance = New System.Windows.Forms.TextBox()
		Me.tabcontrolStatus = New System.Windows.Forms.TabControl()
		Me.tabpagePlayer = New System.Windows.Forms.TabPage()
		Me.groupboxProfile = New System.Windows.Forms.GroupBox()
		Me.labelCreateTime = New System.Windows.Forms.Label()
		Me.textboxCreateTime = New System.Windows.Forms.TextBox()
		Me.labelCreateDate = New System.Windows.Forms.Label()
		Me.textboxCreateDate = New System.Windows.Forms.TextBox()
		Me.labelPlayerID = New System.Windows.Forms.Label()
		Me.textboxPlayerID = New System.Windows.Forms.TextBox()
		Me.labelGender = New System.Windows.Forms.Label()
		Me.textboxBirthYear = New System.Windows.Forms.TextBox()
		Me.labelNameLast = New System.Windows.Forms.Label()
		Me.labelBirthDate = New System.Windows.Forms.Label()
		Me.textboxNameFirst = New System.Windows.Forms.TextBox()
		Me.labelNameNick = New System.Windows.Forms.Label()
		Me.textboxBirthDay = New System.Windows.Forms.TextBox()
		Me.textboxGender = New System.Windows.Forms.TextBox()
		Me.labelNameFirst = New System.Windows.Forms.Label()
		Me.textboxNameLast = New System.Windows.Forms.TextBox()
		Me.textboxBirthMonth = New System.Windows.Forms.TextBox()
		Me.textboxNameNick = New System.Windows.Forms.TextBox()
		Me.tabpageCharacter = New System.Windows.Forms.TabPage()
		Me.groupboxLocation = New System.Windows.Forms.GroupBox()
		Me.labelShelf = New System.Windows.Forms.Label()
		Me.labelLevel = New System.Windows.Forms.Label()
		Me.labelLocation = New System.Windows.Forms.Label()
		Me.textboxShelf = New System.Windows.Forms.TextBox()
		Me.textboxLevel = New System.Windows.Forms.TextBox()
		Me.textboxLocation = New System.Windows.Forms.TextBox()
		Me.textboxStore = New System.Windows.Forms.TextBox()
		Me.labelStore = New System.Windows.Forms.Label()
		Me.groupboxDates = New System.Windows.Forms.GroupBox()
		Me.labelPlaycycles = New System.Windows.Forms.Label()
		Me.textboxPlaycycles = New System.Windows.Forms.TextBox()
		Me.groupboxFinances = New System.Windows.Forms.GroupBox()
		Me.labelItemsSold = New System.Windows.Forms.Label()
		Me.labelMoneyEarned = New System.Windows.Forms.Label()
		Me.textboxItemsSold = New System.Windows.Forms.TextBox()
		Me.textboxMoneyEarned = New System.Windows.Forms.TextBox()
		Me.textboxMoneySpent = New System.Windows.Forms.TextBox()
		Me.labelMoneySpent = New System.Windows.Forms.Label()
		Me.buttonMap = New System.Windows.Forms.Button()
		Me.buttonItemManagement = New System.Windows.Forms.Button()
		Me.buttonDC = New System.Windows.Forms.Button()
		Me.tabcontrolStatus.SuspendLayout
		Me.tabpagePlayer.SuspendLayout
		Me.groupboxProfile.SuspendLayout
		Me.tabpageCharacter.SuspendLayout
		Me.groupboxLocation.SuspendLayout
		Me.groupboxDates.SuspendLayout
		Me.groupboxFinances.SuspendLayout
		Me.SuspendLayout
		'
		'buttonExit
		'
		Me.buttonExit.Location = New System.Drawing.Point(245, 456)
		Me.buttonExit.Name = "buttonExit"
		Me.buttonExit.Size = New System.Drawing.Size(223, 23)
		Me.buttonExit.TabIndex = 6
		Me.buttonExit.Text = "Exit"
		Me.buttonExit.UseVisualStyleBackColor = true
		AddHandler Me.buttonExit.Click, AddressOf Me.buttonExitClick
		'
		'labelBalance
		'
		Me.labelBalance.AutoSize = true
		Me.labelBalance.Location = New System.Drawing.Point(288, 9)
		Me.labelBalance.Name = "labelBalance"
		Me.labelBalance.Size = New System.Drawing.Size(46, 13)
		Me.labelBalance.TabIndex = 0
		Me.labelBalance.Text = "Balance"
		'
		'textboxBalance
		'
		Me.textboxBalance.Location = New System.Drawing.Point(290, 24)
		Me.textboxBalance.Name = "textboxBalance"
		Me.textboxBalance.ReadOnly = true
		Me.textboxBalance.Size = New System.Drawing.Size(169, 20)
		Me.textboxBalance.TabIndex = 1
		'
		'tabcontrolStatus
		'
		Me.tabcontrolStatus.Controls.Add(Me.tabpagePlayer)
		Me.tabcontrolStatus.Controls.Add(Me.tabpageCharacter)
		Me.tabcontrolStatus.Location = New System.Drawing.Point(8, 12)
		Me.tabcontrolStatus.Name = "tabcontrolStatus"
		Me.tabcontrolStatus.SelectedIndex = 0
		Me.tabcontrolStatus.Size = New System.Drawing.Size(460, 409)
		Me.tabcontrolStatus.TabIndex = 7
		'
		'tabpagePlayer
		'
		Me.tabpagePlayer.Controls.Add(Me.groupboxProfile)
		Me.tabpagePlayer.Location = New System.Drawing.Point(4, 22)
		Me.tabpagePlayer.Name = "tabpagePlayer"
		Me.tabpagePlayer.Padding = New System.Windows.Forms.Padding(3)
		Me.tabpagePlayer.Size = New System.Drawing.Size(452, 383)
		Me.tabpagePlayer.TabIndex = 3
		Me.tabpagePlayer.Text = "Profile"
		Me.tabpagePlayer.UseVisualStyleBackColor = true
		'
		'groupboxProfile
		'
		Me.groupboxProfile.Controls.Add(Me.labelCreateTime)
		Me.groupboxProfile.Controls.Add(Me.textboxCreateTime)
		Me.groupboxProfile.Controls.Add(Me.labelCreateDate)
		Me.groupboxProfile.Controls.Add(Me.textboxCreateDate)
		Me.groupboxProfile.Controls.Add(Me.labelPlayerID)
		Me.groupboxProfile.Controls.Add(Me.textboxPlayerID)
		Me.groupboxProfile.Controls.Add(Me.labelGender)
		Me.groupboxProfile.Controls.Add(Me.textboxBirthYear)
		Me.groupboxProfile.Controls.Add(Me.labelNameLast)
		Me.groupboxProfile.Controls.Add(Me.labelBirthDate)
		Me.groupboxProfile.Controls.Add(Me.textboxNameFirst)
		Me.groupboxProfile.Controls.Add(Me.labelNameNick)
		Me.groupboxProfile.Controls.Add(Me.textboxBirthDay)
		Me.groupboxProfile.Controls.Add(Me.textboxGender)
		Me.groupboxProfile.Controls.Add(Me.labelNameFirst)
		Me.groupboxProfile.Controls.Add(Me.textboxNameLast)
		Me.groupboxProfile.Controls.Add(Me.textboxBirthMonth)
		Me.groupboxProfile.Controls.Add(Me.textboxNameNick)
		Me.groupboxProfile.Location = New System.Drawing.Point(6, 6)
		Me.groupboxProfile.Name = "groupboxProfile"
		Me.groupboxProfile.Size = New System.Drawing.Size(437, 365)
		Me.groupboxProfile.TabIndex = 3
		Me.groupboxProfile.TabStop = false
		Me.groupboxProfile.Text = "Profile"
		'
		'labelCreateTime
		'
		Me.labelCreateTime.AutoSize = true
		Me.labelCreateTime.Location = New System.Drawing.Point(3, 211)
		Me.labelCreateTime.Name = "labelCreateTime"
		Me.labelCreateTime.Size = New System.Drawing.Size(70, 13)
		Me.labelCreateTime.TabIndex = 3
		Me.labelCreateTime.Text = "Time Created"
		'
		'textboxCreateTime
		'
		Me.textboxCreateTime.Location = New System.Drawing.Point(6, 227)
		Me.textboxCreateTime.Name = "textboxCreateTime"
		Me.textboxCreateTime.ReadOnly = true
		Me.textboxCreateTime.Size = New System.Drawing.Size(169, 20)
		Me.textboxCreateTime.TabIndex = 5
		'
		'labelCreateDate
		'
		Me.labelCreateDate.AutoSize = true
		Me.labelCreateDate.Location = New System.Drawing.Point(3, 172)
		Me.labelCreateDate.Name = "labelCreateDate"
		Me.labelCreateDate.Size = New System.Drawing.Size(70, 13)
		Me.labelCreateDate.TabIndex = 2
		Me.labelCreateDate.Text = "Date Created"
		'
		'textboxCreateDate
		'
		Me.textboxCreateDate.Location = New System.Drawing.Point(6, 188)
		Me.textboxCreateDate.Name = "textboxCreateDate"
		Me.textboxCreateDate.ReadOnly = true
		Me.textboxCreateDate.Size = New System.Drawing.Size(169, 20)
		Me.textboxCreateDate.TabIndex = 4
		'
		'labelPlayerID
		'
		Me.labelPlayerID.AutoSize = true
		Me.labelPlayerID.Location = New System.Drawing.Point(3, 16)
		Me.labelPlayerID.Name = "labelPlayerID"
		Me.labelPlayerID.Size = New System.Drawing.Size(50, 13)
		Me.labelPlayerID.TabIndex = 0
		Me.labelPlayerID.Text = "Player ID"
		'
		'textboxPlayerID
		'
		Me.textboxPlayerID.Location = New System.Drawing.Point(6, 32)
		Me.textboxPlayerID.Name = "textboxPlayerID"
		Me.textboxPlayerID.ReadOnly = true
		Me.textboxPlayerID.Size = New System.Drawing.Size(169, 20)
		Me.textboxPlayerID.TabIndex = 1
		'
		'labelGender
		'
		Me.labelGender.AutoSize = true
		Me.labelGender.Location = New System.Drawing.Point(178, 55)
		Me.labelGender.Name = "labelGender"
		Me.labelGender.Size = New System.Drawing.Size(42, 13)
		Me.labelGender.TabIndex = 0
		Me.labelGender.Text = "Gender"
		'
		'textboxBirthYear
		'
		Me.textboxBirthYear.Location = New System.Drawing.Point(181, 32)
		Me.textboxBirthYear.Name = "textboxBirthYear"
		Me.textboxBirthYear.ReadOnly = true
		Me.textboxBirthYear.Size = New System.Drawing.Size(39, 20)
		Me.textboxBirthYear.TabIndex = 1
		Me.textboxBirthYear.Text = "1985"
		'
		'labelNameLast
		'
		Me.labelNameLast.AutoSize = true
		Me.labelNameLast.Location = New System.Drawing.Point(3, 133)
		Me.labelNameLast.Name = "labelNameLast"
		Me.labelNameLast.Size = New System.Drawing.Size(75, 13)
		Me.labelNameLast.TabIndex = 0
		Me.labelNameLast.Text = "RL Last Name"
		'
		'labelBirthDate
		'
		Me.labelBirthDate.AutoSize = true
		Me.labelBirthDate.Location = New System.Drawing.Point(178, 16)
		Me.labelBirthDate.Name = "labelBirthDate"
		Me.labelBirthDate.Size = New System.Drawing.Size(53, 13)
		Me.labelBirthDate.TabIndex = 0
		Me.labelBirthDate.Text = "Birth Year"
		'
		'textboxNameFirst
		'
		Me.textboxNameFirst.Location = New System.Drawing.Point(6, 110)
		Me.textboxNameFirst.Name = "textboxNameFirst"
		Me.textboxNameFirst.ReadOnly = true
		Me.textboxNameFirst.Size = New System.Drawing.Size(169, 20)
		Me.textboxNameFirst.TabIndex = 1
		'
		'labelNameNick
		'
		Me.labelNameNick.AutoSize = true
		Me.labelNameNick.Location = New System.Drawing.Point(3, 55)
		Me.labelNameNick.Name = "labelNameNick"
		Me.labelNameNick.Size = New System.Drawing.Size(60, 13)
		Me.labelNameNick.TabIndex = 0
		Me.labelNameNick.Text = "Nick Name"
		'
		'textboxBirthDay
		'
		Me.textboxBirthDay.Location = New System.Drawing.Point(258, 32)
		Me.textboxBirthDay.Name = "textboxBirthDay"
		Me.textboxBirthDay.ReadOnly = true
		Me.textboxBirthDay.Size = New System.Drawing.Size(24, 20)
		Me.textboxBirthDay.TabIndex = 1
		Me.textboxBirthDay.Text = "24"
		'
		'textboxGender
		'
		Me.textboxGender.Location = New System.Drawing.Point(181, 71)
		Me.textboxGender.Name = "textboxGender"
		Me.textboxGender.ReadOnly = true
		Me.textboxGender.Size = New System.Drawing.Size(169, 20)
		Me.textboxGender.TabIndex = 1
		'
		'labelNameFirst
		'
		Me.labelNameFirst.AutoSize = true
		Me.labelNameFirst.Location = New System.Drawing.Point(3, 94)
		Me.labelNameFirst.Name = "labelNameFirst"
		Me.labelNameFirst.Size = New System.Drawing.Size(74, 13)
		Me.labelNameFirst.TabIndex = 0
		Me.labelNameFirst.Text = "RL First Name"
		'
		'textboxNameLast
		'
		Me.textboxNameLast.Location = New System.Drawing.Point(6, 149)
		Me.textboxNameLast.Name = "textboxNameLast"
		Me.textboxNameLast.ReadOnly = true
		Me.textboxNameLast.Size = New System.Drawing.Size(169, 20)
		Me.textboxNameLast.TabIndex = 1
		'
		'textboxBirthMonth
		'
		Me.textboxBirthMonth.Location = New System.Drawing.Point(226, 32)
		Me.textboxBirthMonth.Name = "textboxBirthMonth"
		Me.textboxBirthMonth.ReadOnly = true
		Me.textboxBirthMonth.Size = New System.Drawing.Size(26, 20)
		Me.textboxBirthMonth.TabIndex = 1
		Me.textboxBirthMonth.Text = "09"
		'
		'textboxNameNick
		'
		Me.textboxNameNick.Location = New System.Drawing.Point(6, 71)
		Me.textboxNameNick.Name = "textboxNameNick"
		Me.textboxNameNick.ReadOnly = true
		Me.textboxNameNick.Size = New System.Drawing.Size(169, 20)
		Me.textboxNameNick.TabIndex = 1
		'
		'tabpageCharacter
		'
		Me.tabpageCharacter.Controls.Add(Me.groupboxLocation)
		Me.tabpageCharacter.Controls.Add(Me.groupboxDates)
		Me.tabpageCharacter.Controls.Add(Me.groupboxFinances)
		Me.tabpageCharacter.Location = New System.Drawing.Point(4, 22)
		Me.tabpageCharacter.Name = "tabpageCharacter"
		Me.tabpageCharacter.Padding = New System.Windows.Forms.Padding(3)
		Me.tabpageCharacter.Size = New System.Drawing.Size(452, 383)
		Me.tabpageCharacter.TabIndex = 0
		Me.tabpageCharacter.Text = "Character"
		Me.tabpageCharacter.UseVisualStyleBackColor = true
		'
		'groupboxLocation
		'
		Me.groupboxLocation.Controls.Add(Me.labelShelf)
		Me.groupboxLocation.Controls.Add(Me.labelLevel)
		Me.groupboxLocation.Controls.Add(Me.labelLocation)
		Me.groupboxLocation.Controls.Add(Me.textboxShelf)
		Me.groupboxLocation.Controls.Add(Me.textboxLevel)
		Me.groupboxLocation.Controls.Add(Me.textboxLocation)
		Me.groupboxLocation.Controls.Add(Me.textboxStore)
		Me.groupboxLocation.Controls.Add(Me.labelStore)
		Me.groupboxLocation.Location = New System.Drawing.Point(6, 256)
		Me.groupboxLocation.Name = "groupboxLocation"
		Me.groupboxLocation.Size = New System.Drawing.Size(437, 121)
		Me.groupboxLocation.TabIndex = 7
		Me.groupboxLocation.TabStop = false
		Me.groupboxLocation.Text = "Current Location"
		'
		'labelShelf
		'
		Me.labelShelf.AutoSize = true
		Me.labelShelf.Location = New System.Drawing.Point(181, 63)
		Me.labelShelf.Name = "labelShelf"
		Me.labelShelf.Size = New System.Drawing.Size(31, 13)
		Me.labelShelf.TabIndex = 0
		Me.labelShelf.Text = "Shelf"
		'
		'labelLevel
		'
		Me.labelLevel.AutoSize = true
		Me.labelLevel.Location = New System.Drawing.Point(181, 24)
		Me.labelLevel.Name = "labelLevel"
		Me.labelLevel.Size = New System.Drawing.Size(33, 13)
		Me.labelLevel.TabIndex = 0
		Me.labelLevel.Text = "Level"
		'
		'labelLocation
		'
		Me.labelLocation.AutoSize = true
		Me.labelLocation.Location = New System.Drawing.Point(6, 24)
		Me.labelLocation.Name = "labelLocation"
		Me.labelLocation.Size = New System.Drawing.Size(48, 13)
		Me.labelLocation.TabIndex = 0
		Me.labelLocation.Text = "Location"
		'
		'textboxShelf
		'
		Me.textboxShelf.Location = New System.Drawing.Point(184, 79)
		Me.textboxShelf.Name = "textboxShelf"
		Me.textboxShelf.ReadOnly = true
		Me.textboxShelf.Size = New System.Drawing.Size(169, 20)
		Me.textboxShelf.TabIndex = 1
		'
		'textboxLevel
		'
		Me.textboxLevel.Location = New System.Drawing.Point(184, 40)
		Me.textboxLevel.Name = "textboxLevel"
		Me.textboxLevel.ReadOnly = true
		Me.textboxLevel.Size = New System.Drawing.Size(169, 20)
		Me.textboxLevel.TabIndex = 1
		'
		'textboxLocation
		'
		Me.textboxLocation.Location = New System.Drawing.Point(9, 40)
		Me.textboxLocation.Name = "textboxLocation"
		Me.textboxLocation.ReadOnly = true
		Me.textboxLocation.Size = New System.Drawing.Size(169, 20)
		Me.textboxLocation.TabIndex = 1
		'
		'textboxStore
		'
		Me.textboxStore.Location = New System.Drawing.Point(9, 79)
		Me.textboxStore.Name = "textboxStore"
		Me.textboxStore.ReadOnly = true
		Me.textboxStore.Size = New System.Drawing.Size(169, 20)
		Me.textboxStore.TabIndex = 1
		'
		'labelStore
		'
		Me.labelStore.AutoSize = true
		Me.labelStore.Location = New System.Drawing.Point(6, 63)
		Me.labelStore.Name = "labelStore"
		Me.labelStore.Size = New System.Drawing.Size(32, 13)
		Me.labelStore.TabIndex = 0
		Me.labelStore.Text = "Store"
		'
		'groupboxDates
		'
		Me.groupboxDates.Controls.Add(Me.labelPlaycycles)
		Me.groupboxDates.Controls.Add(Me.textboxPlaycycles)
		Me.groupboxDates.Location = New System.Drawing.Point(6, 6)
		Me.groupboxDates.Name = "groupboxDates"
		Me.groupboxDates.Size = New System.Drawing.Size(437, 112)
		Me.groupboxDates.TabIndex = 7
		Me.groupboxDates.TabStop = false
		Me.groupboxDates.Text = "Time and Dates"
		'
		'labelPlaycycles
		'
		Me.labelPlaycycles.AutoSize = true
		Me.labelPlaycycles.Location = New System.Drawing.Point(6, 16)
		Me.labelPlaycycles.Name = "labelPlaycycles"
		Me.labelPlaycycles.Size = New System.Drawing.Size(88, 13)
		Me.labelPlaycycles.TabIndex = 0
		Me.labelPlaycycles.Text = "Day's in bussines"
		'
		'textboxPlaycycles
		'
		Me.textboxPlaycycles.Location = New System.Drawing.Point(9, 32)
		Me.textboxPlaycycles.Name = "textboxPlaycycles"
		Me.textboxPlaycycles.ReadOnly = true
		Me.textboxPlaycycles.Size = New System.Drawing.Size(169, 20)
		Me.textboxPlaycycles.TabIndex = 1
		'
		'groupboxFinances
		'
		Me.groupboxFinances.Controls.Add(Me.labelItemsSold)
		Me.groupboxFinances.Controls.Add(Me.labelMoneyEarned)
		Me.groupboxFinances.Controls.Add(Me.textboxItemsSold)
		Me.groupboxFinances.Controls.Add(Me.textboxMoneyEarned)
		Me.groupboxFinances.Controls.Add(Me.textboxMoneySpent)
		Me.groupboxFinances.Controls.Add(Me.labelMoneySpent)
		Me.groupboxFinances.Location = New System.Drawing.Point(6, 124)
		Me.groupboxFinances.Name = "groupboxFinances"
		Me.groupboxFinances.Size = New System.Drawing.Size(437, 126)
		Me.groupboxFinances.TabIndex = 6
		Me.groupboxFinances.TabStop = false
		Me.groupboxFinances.Text = "Finances and Items"
		'
		'labelItemsSold
		'
		Me.labelItemsSold.AutoSize = true
		Me.labelItemsSold.Location = New System.Drawing.Point(184, 63)
		Me.labelItemsSold.Name = "labelItemsSold"
		Me.labelItemsSold.Size = New System.Drawing.Size(56, 13)
		Me.labelItemsSold.TabIndex = 0
		Me.labelItemsSold.Text = "Items Sold"
		'
		'labelMoneyEarned
		'
		Me.labelMoneyEarned.AutoSize = true
		Me.labelMoneyEarned.Location = New System.Drawing.Point(6, 24)
		Me.labelMoneyEarned.Name = "labelMoneyEarned"
		Me.labelMoneyEarned.Size = New System.Drawing.Size(76, 13)
		Me.labelMoneyEarned.TabIndex = 0
		Me.labelMoneyEarned.Text = "Money Earned"
		'
		'textboxItemsSold
		'
		Me.textboxItemsSold.Location = New System.Drawing.Point(187, 79)
		Me.textboxItemsSold.Name = "textboxItemsSold"
		Me.textboxItemsSold.ReadOnly = true
		Me.textboxItemsSold.Size = New System.Drawing.Size(169, 20)
		Me.textboxItemsSold.TabIndex = 1
		'
		'textboxMoneyEarned
		'
		Me.textboxMoneyEarned.Location = New System.Drawing.Point(9, 40)
		Me.textboxMoneyEarned.Name = "textboxMoneyEarned"
		Me.textboxMoneyEarned.ReadOnly = true
		Me.textboxMoneyEarned.Size = New System.Drawing.Size(169, 20)
		Me.textboxMoneyEarned.TabIndex = 1
		'
		'textboxMoneySpent
		'
		Me.textboxMoneySpent.Location = New System.Drawing.Point(187, 40)
		Me.textboxMoneySpent.Name = "textboxMoneySpent"
		Me.textboxMoneySpent.ReadOnly = true
		Me.textboxMoneySpent.Size = New System.Drawing.Size(169, 20)
		Me.textboxMoneySpent.TabIndex = 1
		'
		'labelMoneySpent
		'
		Me.labelMoneySpent.AutoSize = true
		Me.labelMoneySpent.Location = New System.Drawing.Point(184, 24)
		Me.labelMoneySpent.Name = "labelMoneySpent"
		Me.labelMoneySpent.Size = New System.Drawing.Size(70, 13)
		Me.labelMoneySpent.TabIndex = 0
		Me.labelMoneySpent.Text = "Money Spent"
		'
		'buttonMap
		'
		Me.buttonMap.Enabled = false
		Me.buttonMap.Location = New System.Drawing.Point(8, 456)
		Me.buttonMap.Name = "buttonMap"
		Me.buttonMap.Size = New System.Drawing.Size(232, 23)
		Me.buttonMap.TabIndex = 8
		Me.buttonMap.Text = "Map"
		Me.buttonMap.UseVisualStyleBackColor = true
		AddHandler Me.buttonMap.Click, AddressOf Me.ButtonMapClick
		'
		'buttonItemManagement
		'
		Me.buttonItemManagement.Location = New System.Drawing.Point(245, 427)
		Me.buttonItemManagement.Name = "buttonItemManagement"
		Me.buttonItemManagement.Size = New System.Drawing.Size(223, 23)
		Me.buttonItemManagement.TabIndex = 8
		Me.buttonItemManagement.Text = "Item Management"
		Me.buttonItemManagement.UseVisualStyleBackColor = true
		AddHandler Me.buttonItemManagement.Click, AddressOf Me.buttonItemManagementClick
		'
		'buttonDC
		'
		Me.buttonDC.Location = New System.Drawing.Point(8, 427)
		Me.buttonDC.Name = "buttonDC"
		Me.buttonDC.Size = New System.Drawing.Size(232, 23)
		Me.buttonDC.TabIndex = 6
		Me.buttonDC.Text = "Distribution Center"
		Me.buttonDC.UseVisualStyleBackColor = true
		AddHandler Me.buttonDC.Click, AddressOf Me.buttonDCClick
		'
		'formStatus
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(477, 487)
		Me.Controls.Add(Me.buttonItemManagement)
		Me.Controls.Add(Me.buttonMap)
		Me.Controls.Add(Me.labelBalance)
		Me.Controls.Add(Me.textboxBalance)
		Me.Controls.Add(Me.buttonDC)
		Me.Controls.Add(Me.buttonExit)
		Me.Controls.Add(Me.tabcontrolStatus)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "formStatus"
		Me.Text = "Status"
		AddHandler Load, AddressOf Me.FormStatusLoad
		Me.tabcontrolStatus.ResumeLayout(false)
		Me.tabpagePlayer.ResumeLayout(false)
		Me.groupboxProfile.ResumeLayout(false)
		Me.groupboxProfile.PerformLayout
		Me.tabpageCharacter.ResumeLayout(false)
		Me.groupboxLocation.ResumeLayout(false)
		Me.groupboxLocation.PerformLayout
		Me.groupboxDates.ResumeLayout(false)
		Me.groupboxDates.PerformLayout
		Me.groupboxFinances.ResumeLayout(false)
		Me.groupboxFinances.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private labelStore As System.Windows.Forms.Label
	Private textboxStore As System.Windows.Forms.TextBox
	Private textboxLocation As System.Windows.Forms.TextBox
	Private textboxLevel As System.Windows.Forms.TextBox
	Private textboxShelf As System.Windows.Forms.TextBox
	Private labelLocation As System.Windows.Forms.Label
	Private labelLevel As System.Windows.Forms.Label
	Private labelShelf As System.Windows.Forms.Label
	Private groupboxLocation As System.Windows.Forms.GroupBox
	Private textboxCreateDate As System.Windows.Forms.TextBox
	Private labelCreateDate As System.Windows.Forms.Label
	Private textboxCreateTime As System.Windows.Forms.TextBox
	Private labelCreateTime As System.Windows.Forms.Label
	Private buttonDC As System.Windows.Forms.Button
	Private buttonItemManagement As System.Windows.Forms.Button
	Private buttonMap As System.Windows.Forms.Button
	Private groupboxDates As System.Windows.Forms.GroupBox
	Private labelPlaycycles As System.Windows.Forms.Label
	Private textboxPlaycycles As System.Windows.Forms.TextBox
	Private groupboxFinances As System.Windows.Forms.GroupBox
	Private labelItemsSold As System.Windows.Forms.Label
	Private labelMoneyEarned As System.Windows.Forms.Label
	Private textboxItemsSold As System.Windows.Forms.TextBox
	Private textboxMoneyEarned As System.Windows.Forms.TextBox
	Private textboxMoneySpent As System.Windows.Forms.TextBox
	Private labelMoneySpent As System.Windows.Forms.Label
	Private buttonExit As System.Windows.Forms.Button
	Private labelBalance As System.Windows.Forms.Label
	Private textboxBalance As System.Windows.Forms.TextBox
	Private tabcontrolStatus As System.Windows.Forms.TabControl
	Private tabpageCharacter As System.Windows.Forms.TabPage
	Private tabpagePlayer As System.Windows.Forms.TabPage
	Private groupboxProfile As System.Windows.Forms.GroupBox
	Private labelPlayerID As System.Windows.Forms.Label
	Private textboxPlayerID As System.Windows.Forms.TextBox
	Private labelGender As System.Windows.Forms.Label
	Private textboxBirthYear As System.Windows.Forms.TextBox
	Private labelNameLast As System.Windows.Forms.Label
	Private labelBirthDate As System.Windows.Forms.Label
	Private textboxNameFirst As System.Windows.Forms.TextBox
	Private labelNameNick As System.Windows.Forms.Label
	Private textboxBirthDay As System.Windows.Forms.TextBox
	Private textboxGender As System.Windows.Forms.TextBox
	Private labelNameFirst As System.Windows.Forms.Label
	Private textboxNameLast As System.Windows.Forms.TextBox
	Private textboxBirthMonth As System.Windows.Forms.TextBox
	Private textboxNameNick As System.Windows.Forms.TextBox
End Class