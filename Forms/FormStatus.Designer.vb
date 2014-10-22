<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStatus
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
    Me.labelPlayerID = New System.Windows.Forms.Label()
    Me.textboxPlayerID = New System.Windows.Forms.TextBox()
    Me.labelBalance = New System.Windows.Forms.Label()
    Me.textboxBalance = New System.Windows.Forms.TextBox()
    Me.textboxGender = New System.Windows.Forms.TextBox()
    Me.tabcontrolStatus = New System.Windows.Forms.TabControl()
    Me.tabpageCharacter = New System.Windows.Forms.TabPage()
    Me.groupboxGrades = New System.Windows.Forms.GroupBox()
    Me.labelGradeInventory = New System.Windows.Forms.Label()
    Me.textboxGradeInventory = New System.Windows.Forms.TextBox()
    Me.textboxGradeShelf = New System.Windows.Forms.TextBox()
    Me.labelGradePopularity = New System.Windows.Forms.Label()
    Me.labelGradeShelf = New System.Windows.Forms.Label()
    Me.textboxGradePopularity = New System.Windows.Forms.TextBox()
    Me.groupboxProfile = New System.Windows.Forms.GroupBox()
    Me.labelGender = New System.Windows.Forms.Label()
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
    Me.groupboxDates.SuspendLayout()
    Me.groupboxFinances.SuspendLayout()
    Me.tabpageStatistics.SuspendLayout()
    Me.tabpageInventory.SuspendLayout()
    Me.groupboxDetails.SuspendLayout()
    Me.groupboxSelection.SuspendLayout()
    Me.tabcontrolStatus.SuspendLayout()
    Me.tabpageCharacter.SuspendLayout()
    Me.groupboxGrades.SuspendLayout()
    Me.groupboxProfile.SuspendLayout()
    Me.SuspendLayout()
    '
    'buttonSave
    '
    Me.buttonSave.Location = New System.Drawing.Point(238, 421)
    Me.buttonSave.Name = "buttonSave"
    Me.buttonSave.Size = New System.Drawing.Size(227, 23)
    Me.buttonSave.TabIndex = 5
    Me.buttonSave.Text = "Save"
    Me.buttonSave.UseVisualStyleBackColor = True
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
    Me.groupboxDates.TabStop = False
    Me.groupboxDates.Text = "Time and Dates"
    '
    'labelPlaySaved
    '
    Me.labelPlaySaved.AutoSize = True
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
    Me.textboxPlaySaved.ReadOnly = True
    Me.textboxPlaySaved.Size = New System.Drawing.Size(169, 20)
    Me.textboxPlaySaved.TabIndex = 1
    '
    'labelCreatedTime
    '
    Me.labelCreatedTime.AutoSize = True
    Me.labelCreatedTime.Location = New System.Drawing.Point(184, 55)
    Me.labelCreatedTime.Name = "labelCreatedTime"
    Me.labelCreatedTime.Size = New System.Drawing.Size(70, 13)
    Me.labelCreatedTime.TabIndex = 0
    Me.labelCreatedTime.Text = "Time Created"
    '
    'labelPlayHours
    '
    Me.labelPlayHours.AutoSize = True
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
    Me.textboxCreatedTime.ReadOnly = True
    Me.textboxCreatedTime.Size = New System.Drawing.Size(169, 20)
    Me.textboxCreatedTime.TabIndex = 1
    '
    'textboxPlayHours
    '
    Me.textboxPlayHours.Location = New System.Drawing.Point(9, 71)
    Me.textboxPlayHours.Name = "textboxPlayHours"
    Me.textboxPlayHours.ReadOnly = True
    Me.textboxPlayHours.Size = New System.Drawing.Size(169, 20)
    Me.textboxPlayHours.TabIndex = 1
    '
    'labelCreatedDate
    '
    Me.labelCreatedDate.AutoSize = True
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
    Me.textboxCreatedDate.ReadOnly = True
    Me.textboxCreatedDate.Size = New System.Drawing.Size(169, 20)
    Me.textboxCreatedDate.TabIndex = 1
    '
    'labelPlaycycles
    '
    Me.labelPlaycycles.AutoSize = True
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
    Me.textboxPlaycycles.ReadOnly = True
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
    Me.groupboxFinances.TabStop = False
    Me.groupboxFinances.Text = "Finances and Items"
    '
    'labelItemsSold
    '
    Me.labelItemsSold.AutoSize = True
    Me.labelItemsSold.Location = New System.Drawing.Point(6, 102)
    Me.labelItemsSold.Name = "labelItemsSold"
    Me.labelItemsSold.Size = New System.Drawing.Size(56, 13)
    Me.labelItemsSold.TabIndex = 0
    Me.labelItemsSold.Text = "Items Sold"
    '
    'labelMoneyEarned
    '
    Me.labelMoneyEarned.AutoSize = True
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
    Me.textboxItemsSold.ReadOnly = True
    Me.textboxItemsSold.Size = New System.Drawing.Size(169, 20)
    Me.textboxItemsSold.TabIndex = 1
    '
    'textboxMoneyEarned
    '
    Me.textboxMoneyEarned.Location = New System.Drawing.Point(9, 40)
    Me.textboxMoneyEarned.Name = "textboxMoneyEarned"
    Me.textboxMoneyEarned.ReadOnly = True
    Me.textboxMoneyEarned.Size = New System.Drawing.Size(169, 20)
    Me.textboxMoneyEarned.TabIndex = 1
    '
    'textboxMoneySpent
    '
    Me.textboxMoneySpent.Location = New System.Drawing.Point(9, 79)
    Me.textboxMoneySpent.Name = "textboxMoneySpent"
    Me.textboxMoneySpent.ReadOnly = True
    Me.textboxMoneySpent.Size = New System.Drawing.Size(169, 20)
    Me.textboxMoneySpent.TabIndex = 1
    '
    'labelMoneySpent
    '
    Me.labelMoneySpent.AutoSize = True
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
    Me.tabpageStatistics.UseVisualStyleBackColor = True
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
    Me.tabpageInventory.UseVisualStyleBackColor = True
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
    Me.groupboxDetails.TabStop = False
    Me.groupboxDetails.Text = "Details"
    '
    'labelAmount
    '
    Me.labelAmount.AutoSize = True
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
    Me.textboxLastBuying.ReadOnly = True
    Me.textboxLastBuying.Size = New System.Drawing.Size(135, 20)
    Me.textboxLastBuying.TabIndex = 1
    '
    'textboxLastSelling
    '
    Me.textboxLastSelling.Location = New System.Drawing.Point(9, 71)
    Me.textboxLastSelling.Name = "textboxLastSelling"
    Me.textboxLastSelling.ReadOnly = True
    Me.textboxLastSelling.Size = New System.Drawing.Size(135, 20)
    Me.textboxLastSelling.TabIndex = 1
    '
    'labelLastBuying
    '
    Me.labelLastBuying.AutoSize = True
    Me.labelLastBuying.Location = New System.Drawing.Point(6, 94)
    Me.labelLastBuying.Name = "labelLastBuying"
    Me.labelLastBuying.Size = New System.Drawing.Size(89, 13)
    Me.labelLastBuying.TabIndex = 0
    Me.labelLastBuying.Text = "Last Buying Price"
    '
    'labelLastSelling
    '
    Me.labelLastSelling.AutoSize = True
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
    Me.groupboxSelection.TabStop = False
    Me.groupboxSelection.Text = "Selection"
    '
    'listboxInventory
    '
    Me.listboxInventory.FormattingEnabled = True
    Me.listboxInventory.Location = New System.Drawing.Point(6, 19)
    Me.listboxInventory.Name = "listboxInventory"
    Me.listboxInventory.Size = New System.Drawing.Size(425, 134)
    Me.listboxInventory.TabIndex = 3
    '
    'buttonExport
    '
    Me.buttonExport.Location = New System.Drawing.Point(6, 160)
    Me.buttonExport.Name = "buttonExport"
    Me.buttonExport.Size = New System.Drawing.Size(425, 23)
    Me.buttonExport.TabIndex = 2
    Me.buttonExport.Text = "Export to Store"
    Me.buttonExport.UseVisualStyleBackColor = True
    '
    'buttonExit
    '
    Me.buttonExit.Location = New System.Drawing.Point(12, 421)
    Me.buttonExit.Name = "buttonExit"
    Me.buttonExit.Size = New System.Drawing.Size(220, 23)
    Me.buttonExit.TabIndex = 6
    Me.buttonExit.Text = "Exit"
    Me.buttonExit.UseVisualStyleBackColor = True
    '
    'labelPlayerID
    '
    Me.labelPlayerID.AutoSize = True
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
    Me.textboxPlayerID.ReadOnly = True
    Me.textboxPlayerID.Size = New System.Drawing.Size(169, 20)
    Me.textboxPlayerID.TabIndex = 1
    '
    'labelBalance
    '
    Me.labelBalance.AutoSize = True
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
    Me.textboxBalance.ReadOnly = True
    Me.textboxBalance.Size = New System.Drawing.Size(169, 20)
    Me.textboxBalance.TabIndex = 1
    '
    'textboxGender
    '
    Me.textboxGender.Location = New System.Drawing.Point(181, 71)
    Me.textboxGender.Name = "textboxGender"
    Me.textboxGender.Size = New System.Drawing.Size(169, 20)
    Me.textboxGender.TabIndex = 1
    '
    'tabcontrolStatus
    '
    Me.tabcontrolStatus.Controls.Add(Me.tabpageCharacter)
    Me.tabcontrolStatus.Controls.Add(Me.tabpageStatistics)
    Me.tabcontrolStatus.Controls.Add(Me.tabpageInventory)
    Me.tabcontrolStatus.Location = New System.Drawing.Point(12, 12)
    Me.tabcontrolStatus.Name = "tabcontrolStatus"
    Me.tabcontrolStatus.SelectedIndex = 0
    Me.tabcontrolStatus.Size = New System.Drawing.Size(457, 403)
    Me.tabcontrolStatus.TabIndex = 7
    '
    'tabpageCharacter
    '
    Me.tabpageCharacter.Controls.Add(Me.groupboxGrades)
    Me.tabpageCharacter.Controls.Add(Me.groupboxProfile)
    Me.tabpageCharacter.Location = New System.Drawing.Point(4, 22)
    Me.tabpageCharacter.Name = "tabpageCharacter"
    Me.tabpageCharacter.Padding = New System.Windows.Forms.Padding(3)
    Me.tabpageCharacter.Size = New System.Drawing.Size(449, 377)
    Me.tabpageCharacter.TabIndex = 0
    Me.tabpageCharacter.Text = "Character"
    Me.tabpageCharacter.UseVisualStyleBackColor = True
    '
    'groupboxGrades
    '
    Me.groupboxGrades.Controls.Add(Me.labelGradeInventory)
    Me.groupboxGrades.Controls.Add(Me.textboxGradeInventory)
    Me.groupboxGrades.Controls.Add(Me.textboxGradeShelf)
    Me.groupboxGrades.Controls.Add(Me.labelGradePopularity)
    Me.groupboxGrades.Controls.Add(Me.labelGradeShelf)
    Me.groupboxGrades.Controls.Add(Me.textboxGradePopularity)
    Me.groupboxGrades.Location = New System.Drawing.Point(6, 225)
    Me.groupboxGrades.Name = "groupboxGrades"
    Me.groupboxGrades.Size = New System.Drawing.Size(437, 145)
    Me.groupboxGrades.TabIndex = 3
    Me.groupboxGrades.TabStop = False
    Me.groupboxGrades.Text = "Grades"
    '
    'labelGradeInventory
    '
    Me.labelGradeInventory.AutoSize = True
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
    Me.labelGradePopularity.AutoSize = True
    Me.labelGradePopularity.Location = New System.Drawing.Point(3, 94)
    Me.labelGradePopularity.Name = "labelGradePopularity"
    Me.labelGradePopularity.Size = New System.Drawing.Size(85, 13)
    Me.labelGradePopularity.TabIndex = 0
    Me.labelGradePopularity.Text = "Popularity Grade"
    '
    'labelGradeShelf
    '
    Me.labelGradeShelf.AutoSize = True
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
    Me.groupboxProfile.Size = New System.Drawing.Size(437, 213)
    Me.groupboxProfile.TabIndex = 2
    Me.groupboxProfile.TabStop = False
    Me.groupboxProfile.Text = "Profile"
    '
    'labelGender
    '
    Me.labelGender.AutoSize = True
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
    Me.labelNameLast.AutoSize = True
    Me.labelNameLast.Location = New System.Drawing.Point(3, 133)
    Me.labelNameLast.Name = "labelNameLast"
    Me.labelNameLast.Size = New System.Drawing.Size(75, 13)
    Me.labelNameLast.TabIndex = 0
    Me.labelNameLast.Text = "RL Last Name"
    '
    'labelBirthDate
    '
    Me.labelBirthDate.AutoSize = True
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
    Me.labelNameNick.AutoSize = True
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
    'labelNameFirst
    '
    Me.labelNameFirst.AutoSize = True
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
    'formStatus
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(475, 456)
    Me.Controls.Add(Me.labelBalance)
    Me.Controls.Add(Me.textboxBalance)
    Me.Controls.Add(Me.buttonSave)
    Me.Controls.Add(Me.buttonExit)
    Me.Controls.Add(Me.tabcontrolStatus)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "formStatus"
    Me.Text = "Status"
    Me.groupboxDates.ResumeLayout(False)
    Me.groupboxDates.PerformLayout()
    Me.groupboxFinances.ResumeLayout(False)
    Me.groupboxFinances.PerformLayout()
    Me.tabpageStatistics.ResumeLayout(False)
    Me.tabpageInventory.ResumeLayout(False)
    Me.groupboxDetails.ResumeLayout(False)
    Me.groupboxDetails.PerformLayout()
    Me.groupboxSelection.ResumeLayout(False)
    Me.tabcontrolStatus.ResumeLayout(False)
    Me.tabpageCharacter.ResumeLayout(False)
    Me.groupboxGrades.ResumeLayout(False)
    Me.groupboxGrades.PerformLayout()
    Me.groupboxProfile.ResumeLayout(False)
    Me.groupboxProfile.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents buttonSave As System.Windows.Forms.Button
  Friend WithEvents groupboxDates As System.Windows.Forms.GroupBox
  Friend WithEvents labelPlaySaved As System.Windows.Forms.Label
  Friend WithEvents textboxPlaySaved As System.Windows.Forms.TextBox
  Friend WithEvents labelCreatedTime As System.Windows.Forms.Label
  Friend WithEvents labelPlayHours As System.Windows.Forms.Label
  Friend WithEvents textboxCreatedTime As System.Windows.Forms.TextBox
  Friend WithEvents textboxPlayHours As System.Windows.Forms.TextBox
  Friend WithEvents labelCreatedDate As System.Windows.Forms.Label
  Friend WithEvents textboxCreatedDate As System.Windows.Forms.TextBox
  Friend WithEvents labelPlaycycles As System.Windows.Forms.Label
  Friend WithEvents textboxPlaycycles As System.Windows.Forms.TextBox
  Friend WithEvents groupboxFinances As System.Windows.Forms.GroupBox
  Friend WithEvents labelItemsSold As System.Windows.Forms.Label
  Friend WithEvents labelMoneyEarned As System.Windows.Forms.Label
  Friend WithEvents textboxItemsSold As System.Windows.Forms.TextBox
  Friend WithEvents textboxMoneyEarned As System.Windows.Forms.TextBox
  Friend WithEvents textboxMoneySpent As System.Windows.Forms.TextBox
  Friend WithEvents labelMoneySpent As System.Windows.Forms.Label
  Friend WithEvents tabpageStatistics As System.Windows.Forms.TabPage
  Friend WithEvents tabpageInventory As System.Windows.Forms.TabPage
  Friend WithEvents groupboxDetails As System.Windows.Forms.GroupBox
  Friend WithEvents labelAmount As System.Windows.Forms.Label
  Friend WithEvents textboxLastBuying As System.Windows.Forms.TextBox
  Friend WithEvents textboxLastSelling As System.Windows.Forms.TextBox
  Friend WithEvents labelLastBuying As System.Windows.Forms.Label
  Friend WithEvents labelLastSelling As System.Windows.Forms.Label
  Friend WithEvents textboxAmount As System.Windows.Forms.TextBox
  Friend WithEvents groupboxSelection As System.Windows.Forms.GroupBox
  Friend WithEvents listboxInventory As System.Windows.Forms.ListBox
  Friend WithEvents buttonExport As System.Windows.Forms.Button
  Friend WithEvents buttonExit As System.Windows.Forms.Button
  Friend WithEvents labelPlayerID As System.Windows.Forms.Label
  Friend WithEvents textboxPlayerID As System.Windows.Forms.TextBox
  Friend WithEvents labelBalance As System.Windows.Forms.Label
  Friend WithEvents textboxBalance As System.Windows.Forms.TextBox
  Friend WithEvents textboxGender As System.Windows.Forms.TextBox
  Friend WithEvents tabcontrolStatus As System.Windows.Forms.TabControl
  Friend WithEvents tabpageCharacter As System.Windows.Forms.TabPage
  Friend WithEvents groupboxGrades As System.Windows.Forms.GroupBox
  Friend WithEvents labelGradeInventory As System.Windows.Forms.Label
  Friend WithEvents textboxGradeInventory As System.Windows.Forms.TextBox
  Friend WithEvents textboxGradeShelf As System.Windows.Forms.TextBox
  Friend WithEvents labelGradePopularity As System.Windows.Forms.Label
  Friend WithEvents labelGradeShelf As System.Windows.Forms.Label
  Friend WithEvents textboxGradePopularity As System.Windows.Forms.TextBox
  Friend WithEvents groupboxProfile As System.Windows.Forms.GroupBox
  Friend WithEvents labelGender As System.Windows.Forms.Label
  Friend WithEvents textboxBirthYear As System.Windows.Forms.TextBox
  Friend WithEvents labelNameLast As System.Windows.Forms.Label
  Friend WithEvents labelBirthDate As System.Windows.Forms.Label
  Friend WithEvents textboxNameFirst As System.Windows.Forms.TextBox
  Friend WithEvents labelNameNick As System.Windows.Forms.Label
  Friend WithEvents textboxBirthDay As System.Windows.Forms.TextBox
  Friend WithEvents labelNameFirst As System.Windows.Forms.Label
  Friend WithEvents textboxNameLast As System.Windows.Forms.TextBox
  Friend WithEvents textboxBirthMonth As System.Windows.Forms.TextBox
  Friend WithEvents textboxNameNick As System.Windows.Forms.TextBox
End Class
