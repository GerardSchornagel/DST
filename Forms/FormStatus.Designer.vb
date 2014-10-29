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
		Me.buttonSave = New System.Windows.Forms.Button()
		Me.groupboxDates = New System.Windows.Forms.GroupBox()
		Me.labelPlaySaved = New System.Windows.Forms.Label()
		Me.textboxPlaySaved = New System.Windows.Forms.TextBox()
		Me.labelCreatedTime = New System.Windows.Forms.Label()
		Me.labelPlayHours = New System.Windows.Forms.Label()
		Me.textboxCreatedTime = New System.Windows.Forms.TextBox()
		Me.textboxPlayHours = New System.Windows.Forms.TextBox()
		Me.labelCreatedDate = New System.Windows.Forms.Label()
		Me.textboxCreatedDate = New System.Windows.Forms.TextBox()
		Me.labelPlaycycles = New System.Windows.Forms.Label()
		Me.textboxPlaycycles = New System.Windows.Forms.TextBox()
		Me.groupboxFinances = New System.Windows.Forms.GroupBox()
		Me.labelItemsSold = New System.Windows.Forms.Label()
		Me.labelMoneyEarned = New System.Windows.Forms.Label()
		Me.textboxItemsSold = New System.Windows.Forms.TextBox()
		Me.textboxMoneyEarned = New System.Windows.Forms.TextBox()
		Me.textboxMoneySpent = New System.Windows.Forms.TextBox()
		Me.labelMoneySpent = New System.Windows.Forms.Label()
		Me.tabpageStatistics = New System.Windows.Forms.TabPage()
		Me.tabpageInventory = New System.Windows.Forms.TabPage()
		Me.groupboxDetails = New System.Windows.Forms.GroupBox()
		Me.labelAmount = New System.Windows.Forms.Label()
		Me.textboxLastBuying = New System.Windows.Forms.TextBox()
		Me.textboxLastSelling = New System.Windows.Forms.TextBox()
		Me.labelLastBuying = New System.Windows.Forms.Label()
		Me.labelLastSelling = New System.Windows.Forms.Label()
		Me.textboxAmount = New System.Windows.Forms.TextBox()
		Me.groupboxSelection = New System.Windows.Forms.GroupBox()
		Me.listboxInventory = New System.Windows.Forms.ListBox()
		Me.buttonExport = New System.Windows.Forms.Button()
		Me.buttonExit = New System.Windows.Forms.Button()
		Me.labelBalance = New System.Windows.Forms.Label()
		Me.textboxBalance = New System.Windows.Forms.TextBox()
		Me.tabcontrolStatus = New System.Windows.Forms.TabControl()
		Me.tabpagePlayer = New System.Windows.Forms.TabPage()
		Me.groupboxProfile = New System.Windows.Forms.GroupBox()
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
		Me.groupboxGrades = New System.Windows.Forms.GroupBox()
		Me.labelGradeInventory = New System.Windows.Forms.Label()
		Me.textboxGradeInventory = New System.Windows.Forms.TextBox()
		Me.textboxGradeShelf = New System.Windows.Forms.TextBox()
		Me.labelGradePopularity = New System.Windows.Forms.Label()
		Me.labelGradeShelf = New System.Windows.Forms.Label()
		Me.textboxGradePopularity = New System.Windows.Forms.TextBox()
		Me.groupboxDates.SuspendLayout
		Me.groupboxFinances.SuspendLayout
		Me.tabpageStatistics.SuspendLayout
		Me.tabpageInventory.SuspendLayout
		Me.groupboxDetails.SuspendLayout
		Me.groupboxSelection.SuspendLayout
		Me.tabcontrolStatus.SuspendLayout
		Me.tabpagePlayer.SuspendLayout
		Me.groupboxProfile.SuspendLayout
		Me.tabpageCharacter.SuspendLayout
		Me.groupboxGrades.SuspendLayout
		Me.SuspendLayout
		'
		'buttonSave
		'
		Me.buttonSave.Location = New System.Drawing.Point(238, 421)
		Me.buttonSave.Name = "buttonSave"
		Me.buttonSave.Size = New System.Drawing.Size(227, 23)
		Me.buttonSave.TabIndex = 5
		Me.buttonSave.Text = "Save"
		Me.buttonSave.UseVisualStyleBackColor = true
		AddHandler Me.buttonSave.Click, AddressOf Me.ButtonSaveClick
		'
		'groupboxDates
		'
		Me.groupboxDates.Controls.Add(Me.labelPlaySaved)
		Me.groupboxDates.Controls.Add(Me.textboxPlaySaved)
		Me.groupboxDates.Controls.Add(Me.labelCreatedTime)
		Me.groupboxDates.Controls.Add(Me.labelPlayHours)
		Me.groupboxDates.Controls.Add(Me.textboxCreatedTime)
		Me.groupboxDates.Controls.Add(Me.textboxPlayHours)
		Me.groupboxDates.Controls.Add(Me.labelCreatedDate)
		Me.groupboxDates.Controls.Add(Me.textboxCreatedDate)
		Me.groupboxDates.Controls.Add(Me.labelPlaycycles)
		Me.groupboxDates.Controls.Add(Me.textboxPlaycycles)
		Me.groupboxDates.Location = New System.Drawing.Point(6, 6)
		Me.groupboxDates.Name = "groupboxDates"
		Me.groupboxDates.Size = New System.Drawing.Size(437, 139)
		Me.groupboxDates.TabIndex = 5
		Me.groupboxDates.TabStop = false
		Me.groupboxDates.Text = "Time and Dates"
		'
		'labelPlaySaved
		'
		Me.labelPlaySaved.AutoSize = true
		Me.labelPlaySaved.Location = New System.Drawing.Point(6, 94)
		Me.labelPlaySaved.Name = "labelPlaySaved"
		Me.labelPlaySaved.Size = New System.Drawing.Size(69, 13)
		Me.labelPlaySaved.TabIndex = 0
		Me.labelPlaySaved.Text = "Times Saved"
		'
		'textboxPlaySaved
		'
		Me.textboxPlaySaved.Location = New System.Drawing.Point(9, 110)
		Me.textboxPlaySaved.Name = "textboxPlaySaved"
		Me.textboxPlaySaved.ReadOnly = true
		Me.textboxPlaySaved.Size = New System.Drawing.Size(169, 20)
		Me.textboxPlaySaved.TabIndex = 1
		'
		'labelCreatedTime
		'
		Me.labelCreatedTime.AutoSize = true
		Me.labelCreatedTime.Location = New System.Drawing.Point(184, 55)
		Me.labelCreatedTime.Name = "labelCreatedTime"
		Me.labelCreatedTime.Size = New System.Drawing.Size(70, 13)
		Me.labelCreatedTime.TabIndex = 0
		Me.labelCreatedTime.Text = "Time Created"
		'
		'labelPlayHours
		'
		Me.labelPlayHours.AutoSize = true
		Me.labelPlayHours.Location = New System.Drawing.Point(6, 55)
		Me.labelPlayHours.Name = "labelPlayHours"
		Me.labelPlayHours.Size = New System.Drawing.Size(70, 13)
		Me.labelPlayHours.TabIndex = 0
		Me.labelPlayHours.Text = "Hours Played"
		'
		'textboxCreatedTime
		'
		Me.textboxCreatedTime.Location = New System.Drawing.Point(187, 71)
		Me.textboxCreatedTime.Name = "textboxCreatedTime"
		Me.textboxCreatedTime.ReadOnly = true
		Me.textboxCreatedTime.Size = New System.Drawing.Size(169, 20)
		Me.textboxCreatedTime.TabIndex = 1
		'
		'textboxPlayHours
		'
		Me.textboxPlayHours.Location = New System.Drawing.Point(9, 71)
		Me.textboxPlayHours.Name = "textboxPlayHours"
		Me.textboxPlayHours.ReadOnly = true
		Me.textboxPlayHours.Size = New System.Drawing.Size(169, 20)
		Me.textboxPlayHours.TabIndex = 1
		'
		'labelCreatedDate
		'
		Me.labelCreatedDate.AutoSize = true
		Me.labelCreatedDate.Location = New System.Drawing.Point(184, 16)
		Me.labelCreatedDate.Name = "labelCreatedDate"
		Me.labelCreatedDate.Size = New System.Drawing.Size(70, 13)
		Me.labelCreatedDate.TabIndex = 0
		Me.labelCreatedDate.Text = "Date Created"
		'
		'textboxCreatedDate
		'
		Me.textboxCreatedDate.Location = New System.Drawing.Point(187, 32)
		Me.textboxCreatedDate.Name = "textboxCreatedDate"
		Me.textboxCreatedDate.ReadOnly = true
		Me.textboxCreatedDate.Size = New System.Drawing.Size(169, 20)
		Me.textboxCreatedDate.TabIndex = 1
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
		Me.groupboxFinances.Location = New System.Drawing.Point(6, 151)
		Me.groupboxFinances.Name = "groupboxFinances"
		Me.groupboxFinances.Size = New System.Drawing.Size(428, 158)
		Me.groupboxFinances.TabIndex = 0
		Me.groupboxFinances.TabStop = false
		Me.groupboxFinances.Text = "Finances and Items"
		'
		'labelItemsSold
		'
		Me.labelItemsSold.AutoSize = true
		Me.labelItemsSold.Location = New System.Drawing.Point(6, 102)
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
		Me.textboxItemsSold.Location = New System.Drawing.Point(9, 118)
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
		Me.textboxMoneySpent.Location = New System.Drawing.Point(9, 79)
		Me.textboxMoneySpent.Name = "textboxMoneySpent"
		Me.textboxMoneySpent.ReadOnly = true
		Me.textboxMoneySpent.Size = New System.Drawing.Size(169, 20)
		Me.textboxMoneySpent.TabIndex = 1
		'
		'labelMoneySpent
		'
		Me.labelMoneySpent.AutoSize = true
		Me.labelMoneySpent.Location = New System.Drawing.Point(6, 63)
		Me.labelMoneySpent.Name = "labelMoneySpent"
		Me.labelMoneySpent.Size = New System.Drawing.Size(70, 13)
		Me.labelMoneySpent.TabIndex = 0
		Me.labelMoneySpent.Text = "Money Spent"
		'
		'tabpageStatistics
		'
		Me.tabpageStatistics.Controls.Add(Me.groupboxDates)
		Me.tabpageStatistics.Controls.Add(Me.groupboxFinances)
		Me.tabpageStatistics.Location = New System.Drawing.Point(4, 22)
		Me.tabpageStatistics.Name = "tabpageStatistics"
		Me.tabpageStatistics.Padding = New System.Windows.Forms.Padding(3)
		Me.tabpageStatistics.Size = New System.Drawing.Size(449, 377)
		Me.tabpageStatistics.TabIndex = 1
		Me.tabpageStatistics.Text = "Statistics"
		Me.tabpageStatistics.UseVisualStyleBackColor = true
		'
		'tabpageInventory
		'
		Me.tabpageInventory.Controls.Add(Me.groupboxDetails)
		Me.tabpageInventory.Controls.Add(Me.groupboxSelection)
		Me.tabpageInventory.Location = New System.Drawing.Point(4, 22)
		Me.tabpageInventory.Name = "tabpageInventory"
		Me.tabpageInventory.Padding = New System.Windows.Forms.Padding(3)
		Me.tabpageInventory.Size = New System.Drawing.Size(449, 377)
		Me.tabpageInventory.TabIndex = 2
		Me.tabpageInventory.Text = "Inventory"
		Me.tabpageInventory.UseVisualStyleBackColor = true
		'
		'groupboxDetails
		'
		Me.groupboxDetails.Controls.Add(Me.labelAmount)
		Me.groupboxDetails.Controls.Add(Me.textboxLastBuying)
		Me.groupboxDetails.Controls.Add(Me.textboxLastSelling)
		Me.groupboxDetails.Controls.Add(Me.labelLastBuying)
		Me.groupboxDetails.Controls.Add(Me.labelLastSelling)
		Me.groupboxDetails.Controls.Add(Me.textboxAmount)
		Me.groupboxDetails.Location = New System.Drawing.Point(6, 201)
		Me.groupboxDetails.Name = "groupboxDetails"
		Me.groupboxDetails.Size = New System.Drawing.Size(437, 169)
		Me.groupboxDetails.TabIndex = 0
		Me.groupboxDetails.TabStop = false
		Me.groupboxDetails.Text = "Details"
		'
		'labelAmount
		'
		Me.labelAmount.AutoSize = true
		Me.labelAmount.Location = New System.Drawing.Point(6, 16)
		Me.labelAmount.Name = "labelAmount"
		Me.labelAmount.Size = New System.Drawing.Size(43, 13)
		Me.labelAmount.TabIndex = 0
		Me.labelAmount.Text = "Amount"
		'
		'textboxLastBuying
		'
		Me.textboxLastBuying.Location = New System.Drawing.Point(9, 110)
		Me.textboxLastBuying.Name = "textboxLastBuying"
		Me.textboxLastBuying.ReadOnly = true
		Me.textboxLastBuying.Size = New System.Drawing.Size(135, 20)
		Me.textboxLastBuying.TabIndex = 1
		'
		'textboxLastSelling
		'
		Me.textboxLastSelling.Location = New System.Drawing.Point(9, 71)
		Me.textboxLastSelling.Name = "textboxLastSelling"
		Me.textboxLastSelling.ReadOnly = true
		Me.textboxLastSelling.Size = New System.Drawing.Size(135, 20)
		Me.textboxLastSelling.TabIndex = 1
		'
		'labelLastBuying
		'
		Me.labelLastBuying.AutoSize = true
		Me.labelLastBuying.Location = New System.Drawing.Point(6, 94)
		Me.labelLastBuying.Name = "labelLastBuying"
		Me.labelLastBuying.Size = New System.Drawing.Size(89, 13)
		Me.labelLastBuying.TabIndex = 0
		Me.labelLastBuying.Text = "Last Buying Price"
		'
		'labelLastSelling
		'
		Me.labelLastSelling.AutoSize = true
		Me.labelLastSelling.Location = New System.Drawing.Point(6, 55)
		Me.labelLastSelling.Name = "labelLastSelling"
		Me.labelLastSelling.Size = New System.Drawing.Size(88, 13)
		Me.labelLastSelling.TabIndex = 0
		Me.labelLastSelling.Text = "Last Selling Price"
		'
		'textboxAmount
		'
		Me.textboxAmount.Location = New System.Drawing.Point(9, 32)
		Me.textboxAmount.Name = "textboxAmount"
		Me.textboxAmount.Size = New System.Drawing.Size(135, 20)
		Me.textboxAmount.TabIndex = 1
		'
		'groupboxSelection
		'
		Me.groupboxSelection.Controls.Add(Me.listboxInventory)
		Me.groupboxSelection.Controls.Add(Me.buttonExport)
		Me.groupboxSelection.Location = New System.Drawing.Point(6, 6)
		Me.groupboxSelection.Name = "groupboxSelection"
		Me.groupboxSelection.Size = New System.Drawing.Size(437, 189)
		Me.groupboxSelection.TabIndex = 0
		Me.groupboxSelection.TabStop = false
		Me.groupboxSelection.Text = "Selection"
		'
		'listboxInventory
		'
		Me.listboxInventory.FormattingEnabled = true
		Me.listboxInventory.Location = New System.Drawing.Point(6, 19)
		Me.listboxInventory.Name = "listboxInventory"
		Me.listboxInventory.Size = New System.Drawing.Size(425, 134)
		Me.listboxInventory.TabIndex = 3
		AddHandler Me.listboxInventory.SelectedIndexChanged, AddressOf Me.ListboxInventorySelectedIndexChanged
		'
		'buttonExport
		'
		Me.buttonExport.Location = New System.Drawing.Point(6, 160)
		Me.buttonExport.Name = "buttonExport"
		Me.buttonExport.Size = New System.Drawing.Size(425, 23)
		Me.buttonExport.TabIndex = 2
		Me.buttonExport.Text = "Export to Store"
		Me.buttonExport.UseVisualStyleBackColor = true
		AddHandler Me.buttonExport.Click, AddressOf Me.ButtonExportClick
		'
		'buttonExit
		'
		Me.buttonExit.Location = New System.Drawing.Point(12, 421)
		Me.buttonExit.Name = "buttonExit"
		Me.buttonExit.Size = New System.Drawing.Size(220, 23)
		Me.buttonExit.TabIndex = 6
		Me.buttonExit.Text = "Exit"
		Me.buttonExit.UseVisualStyleBackColor = true
		AddHandler Me.buttonExit.Click, AddressOf Me.ButtonExitClick
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
		Me.tabcontrolStatus.Controls.Add(Me.tabpageStatistics)
		Me.tabcontrolStatus.Controls.Add(Me.tabpageInventory)
		Me.tabcontrolStatus.Location = New System.Drawing.Point(12, 12)
		Me.tabcontrolStatus.Name = "tabcontrolStatus"
		Me.tabcontrolStatus.SelectedIndex = 0
		Me.tabcontrolStatus.Size = New System.Drawing.Size(457, 403)
		Me.tabcontrolStatus.TabIndex = 7
		'
		'tabpagePlayer
		'
		Me.tabpagePlayer.Controls.Add(Me.groupboxProfile)
		Me.tabpagePlayer.Location = New System.Drawing.Point(4, 22)
		Me.tabpagePlayer.Name = "tabpagePlayer"
		Me.tabpagePlayer.Padding = New System.Windows.Forms.Padding(3)
		Me.tabpagePlayer.Size = New System.Drawing.Size(449, 377)
		Me.tabpagePlayer.TabIndex = 3
		Me.tabpagePlayer.Text = "Player"
		Me.tabpagePlayer.UseVisualStyleBackColor = true
		'
		'groupboxProfile
		'
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
		Me.textboxBirthDay.Size = New System.Drawing.Size(24, 20)
		Me.textboxBirthDay.TabIndex = 1
		Me.textboxBirthDay.Text = "24"
		'
		'textboxGender
		'
		Me.textboxGender.Location = New System.Drawing.Point(181, 71)
		Me.textboxGender.Name = "textboxGender"
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
		Me.textboxNameLast.Size = New System.Drawing.Size(169, 20)
		Me.textboxNameLast.TabIndex = 1
		'
		'textboxBirthMonth
		'
		Me.textboxBirthMonth.Location = New System.Drawing.Point(226, 32)
		Me.textboxBirthMonth.Name = "textboxBirthMonth"
		Me.textboxBirthMonth.Size = New System.Drawing.Size(26, 20)
		Me.textboxBirthMonth.TabIndex = 1
		Me.textboxBirthMonth.Text = "09"
		'
		'textboxNameNick
		'
		Me.textboxNameNick.Location = New System.Drawing.Point(6, 71)
		Me.textboxNameNick.Name = "textboxNameNick"
		Me.textboxNameNick.Size = New System.Drawing.Size(169, 20)
		Me.textboxNameNick.TabIndex = 1
		'
		'tabpageCharacter
		'
		Me.tabpageCharacter.Controls.Add(Me.groupboxGrades)
		Me.tabpageCharacter.Location = New System.Drawing.Point(4, 22)
		Me.tabpageCharacter.Name = "tabpageCharacter"
		Me.tabpageCharacter.Padding = New System.Windows.Forms.Padding(3)
		Me.tabpageCharacter.Size = New System.Drawing.Size(449, 377)
		Me.tabpageCharacter.TabIndex = 0
		Me.tabpageCharacter.Text = "Character"
		Me.tabpageCharacter.UseVisualStyleBackColor = true
		'
		'groupboxGrades
		'
		Me.groupboxGrades.Controls.Add(Me.labelGradeInventory)
		Me.groupboxGrades.Controls.Add(Me.textboxGradeInventory)
		Me.groupboxGrades.Controls.Add(Me.textboxGradeShelf)
		Me.groupboxGrades.Controls.Add(Me.labelGradePopularity)
		Me.groupboxGrades.Controls.Add(Me.labelGradeShelf)
		Me.groupboxGrades.Controls.Add(Me.textboxGradePopularity)
		Me.groupboxGrades.Location = New System.Drawing.Point(6, 6)
		Me.groupboxGrades.Name = "groupboxGrades"
		Me.groupboxGrades.Size = New System.Drawing.Size(437, 365)
		Me.groupboxGrades.TabIndex = 3
		Me.groupboxGrades.TabStop = false
		Me.groupboxGrades.Text = "Grades"
		'
		'labelGradeInventory
		'
		Me.labelGradeInventory.AutoSize = true
		Me.labelGradeInventory.Location = New System.Drawing.Point(3, 16)
		Me.labelGradeInventory.Name = "labelGradeInventory"
		Me.labelGradeInventory.Size = New System.Drawing.Size(83, 13)
		Me.labelGradeInventory.TabIndex = 0
		Me.labelGradeInventory.Text = "Inventory Grade"
		'
		'textboxGradeInventory
		'
		Me.textboxGradeInventory.Location = New System.Drawing.Point(6, 32)
		Me.textboxGradeInventory.Name = "textboxGradeInventory"
		Me.textboxGradeInventory.Size = New System.Drawing.Size(169, 20)
		Me.textboxGradeInventory.TabIndex = 1
		'
		'textboxGradeShelf
		'
		Me.textboxGradeShelf.Location = New System.Drawing.Point(6, 71)
		Me.textboxGradeShelf.Name = "textboxGradeShelf"
		Me.textboxGradeShelf.Size = New System.Drawing.Size(169, 20)
		Me.textboxGradeShelf.TabIndex = 1
		'
		'labelGradePopularity
		'
		Me.labelGradePopularity.AutoSize = true
		Me.labelGradePopularity.Location = New System.Drawing.Point(3, 94)
		Me.labelGradePopularity.Name = "labelGradePopularity"
		Me.labelGradePopularity.Size = New System.Drawing.Size(85, 13)
		Me.labelGradePopularity.TabIndex = 0
		Me.labelGradePopularity.Text = "Popularity Grade"
		'
		'labelGradeShelf
		'
		Me.labelGradeShelf.AutoSize = true
		Me.labelGradeShelf.Location = New System.Drawing.Point(3, 55)
		Me.labelGradeShelf.Name = "labelGradeShelf"
		Me.labelGradeShelf.Size = New System.Drawing.Size(63, 13)
		Me.labelGradeShelf.TabIndex = 0
		Me.labelGradeShelf.Text = "Shelf Grade"
		'
		'textboxGradePopularity
		'
		Me.textboxGradePopularity.Location = New System.Drawing.Point(6, 110)
		Me.textboxGradePopularity.Name = "textboxGradePopularity"
		Me.textboxGradePopularity.Size = New System.Drawing.Size(169, 20)
		Me.textboxGradePopularity.TabIndex = 1
		'
		'formStatus
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(475, 456)
		Me.Controls.Add(Me.labelBalance)
		Me.Controls.Add(Me.textboxBalance)
		Me.Controls.Add(Me.buttonSave)
		Me.Controls.Add(Me.buttonExit)
		Me.Controls.Add(Me.tabcontrolStatus)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "formStatus"
		Me.Text = "Status"
		AddHandler Load, AddressOf Me.FormStatusLoad
		Me.groupboxDates.ResumeLayout(false)
		Me.groupboxDates.PerformLayout
		Me.groupboxFinances.ResumeLayout(false)
		Me.groupboxFinances.PerformLayout
		Me.tabpageStatistics.ResumeLayout(false)
		Me.tabpageInventory.ResumeLayout(false)
		Me.groupboxDetails.ResumeLayout(false)
		Me.groupboxDetails.PerformLayout
		Me.groupboxSelection.ResumeLayout(false)
		Me.tabcontrolStatus.ResumeLayout(false)
		Me.tabpagePlayer.ResumeLayout(false)
		Me.groupboxProfile.ResumeLayout(false)
		Me.groupboxProfile.PerformLayout
		Me.tabpageCharacter.ResumeLayout(false)
		Me.groupboxGrades.ResumeLayout(false)
		Me.groupboxGrades.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private buttonSave As System.Windows.Forms.Button
	Private groupboxDates As System.Windows.Forms.GroupBox
	Private labelPlaySaved As System.Windows.Forms.Label
	Private textboxPlaySaved As System.Windows.Forms.TextBox
	Private labelCreatedTime As System.Windows.Forms.Label
	Private labelPlayHours As System.Windows.Forms.Label
	Private textboxCreatedTime As System.Windows.Forms.TextBox
	Private textboxPlayHours As System.Windows.Forms.TextBox
	Private labelCreatedDate As System.Windows.Forms.Label
	Private textboxCreatedDate As System.Windows.Forms.TextBox
	Private labelPlaycycles As System.Windows.Forms.Label
	Private textboxPlaycycles As System.Windows.Forms.TextBox
	Private groupboxFinances As System.Windows.Forms.GroupBox
	Private labelItemsSold As System.Windows.Forms.Label
	Private labelMoneyEarned As System.Windows.Forms.Label
	Private textboxItemsSold As System.Windows.Forms.TextBox
	Private textboxMoneyEarned As System.Windows.Forms.TextBox
	Private textboxMoneySpent As System.Windows.Forms.TextBox
	Private labelMoneySpent As System.Windows.Forms.Label
	Private tabpageStatistics As System.Windows.Forms.TabPage
	Private tabpageInventory As System.Windows.Forms.TabPage
	Private groupboxDetails As System.Windows.Forms.GroupBox
	Private labelAmount As System.Windows.Forms.Label
	Private textboxLastBuying As System.Windows.Forms.TextBox
	Private textboxLastSelling As System.Windows.Forms.TextBox
	Private labelLastBuying As System.Windows.Forms.Label
	Private labelLastSelling As System.Windows.Forms.Label
	Private textboxAmount As System.Windows.Forms.TextBox
	Private groupboxSelection As System.Windows.Forms.GroupBox
	Private listboxInventory As System.Windows.Forms.ListBox
	Private buttonExport As System.Windows.Forms.Button
	Private buttonExit As System.Windows.Forms.Button
	Private labelBalance As System.Windows.Forms.Label
	Private textboxBalance As System.Windows.Forms.TextBox
	Private tabcontrolStatus As System.Windows.Forms.TabControl
	Private tabpageCharacter As System.Windows.Forms.TabPage
	Private groupboxGrades As System.Windows.Forms.GroupBox
	Private labelGradeInventory As System.Windows.Forms.Label
	Private textboxGradeInventory As System.Windows.Forms.TextBox
	Private textboxGradeShelf As System.Windows.Forms.TextBox
	Private labelGradePopularity As System.Windows.Forms.Label
	Private labelGradeShelf As System.Windows.Forms.Label
	Private textboxGradePopularity As System.Windows.Forms.TextBox
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