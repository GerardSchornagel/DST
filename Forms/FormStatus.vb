Public Partial Class formStatus
	Friend Shared classPlayer As New player(CType(formMain.GlobalSettings.LastUser, String))
	Friend Shared classCharacter As New character(CType(formMain.GlobalSettings.LastUser, String))
	Friend Shared classInventory As New inventory(CType(formMain.GlobalSettings.LastUser, String))
	Friend Shared classStatistics As New statistics(CType(formMain.GlobalSettings.LastUser, String))
	
	Friend Shared GameForm As New formGame()
	Friend Shared InventoryForm As New formInventory()
	Friend Shared MapForm As New formMap()
	Friend Shared StoreForm As New formStore()
	
	Private stringInventorySelected() As String
	Private timerUpdate As New System.Windows.Forms.Timer
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
		
	Sub FormStatusLoad(sender As Object, e As EventArgs)
		AddHandler timerUpdate.Tick, AddressOf timerUpdateTick
		'Make a minium Interval value based on pc time to process random data equal to a medium big Savegame-size.
		timerUpdate.Interval = 2500
		timerUpdate.Start()
		
		textboxBalance.Text = CType(classCharacter.Balance, String)
		'Player Tab
		textboxPlayerID.Text = CType(classPlayer.PlayerID, String)
		textboxNameNick.Text = classPlayer.NickName
		textboxNameFirst.Text = classPlayer.FirstName
		textboxNameLast.Text = classPlayer.LastName
		textboxBirthYear.Text = CType(classPlayer.BirthYear, String)
		textboxBirthMonth.Text = CType(classPlayer.BirthMonth, String)
		textboxBirthDay.Text = CType(classPlayer.BirthDay, String)
		textboxGender.Text = CType(classPlayer.Gender, String)
		'Character Tab
		textboxGradeInventory.Text = CType(classCharacter.GradeInventory, String)
		textboxGradeShelf.Text = CType(classCharacter.GradeShelf, String)
		textboxGradePopularity.Text = CType(classCharacter.GradePopularity, String)
		'Statistics Tab
		textboxCreatedDate.Text = classStatistics.CreationDate
		textboxCreatedTime.Text = classStatistics.CreationTime
		textboxPlaycycles.Text = CType(classStatistics.TotalDayCycles, String)
		textboxMoneyEarned.Text = CType(classStatistics.TotalEarnings, String)
		textboxMoneySpent.Text = CType(classStatistics.TotalSpent, String)
		textboxItemsSold.Text = CType(classStatistics.TotalItemsSold, String)		
		'Inventory Tab
		Dim intDimension As Integer = 0
		listboxInventory.Items.Clear()
		Do
			If classInventory.GetInventorySpace(intDimension) Is Nothing Then
				Exit Do
			End If
			'load through classInventory with incrementing Dimension adding the first sub-dimension to the listbox.
			listboxInventory.Items.Add((classInventory.GetInventorySpace(intDimension))(0))
			intDimension += 1
		Loop
		
		GameForm.Show()
	End Sub
	
	Sub buttonRefreshClick(sender As Object, e As EventArgs)
		Dim intDimension As Integer = 0
		listboxInventory.Items.Clear()
		Do
			If classInventory.GetInventorySpace(intDimension) Is Nothing Then
				Exit Do
			End If
			'load through classInventory with incrementing Dimension adding the first sub-dimension to the listbox.
			listboxInventory.Items.Add((classInventory.GetInventorySpace(intDimension))(0))
			intDimension += 1
		Loop
	End Sub
	
	Sub buttonExitClick(sender As Object, e As EventArgs)
		'Add code for closing formGame, formMap, formInventory, formStore & Me(formStatus)
	End Sub
	
	Sub buttonExportClick(sender As Object, e As EventArgs)
		'Get selected StoreBin
		Dim stringBin() As String = formGame.StoreCurrent.getsetBin(comboboxBins.SelectedIndex)
		Dim stringSlot() As String
		ReDim stringSlot(3)
		'Compare StoreBin name to all InventorySlots
		Dim integerCounterSearch As Integer = 0
		Do
			stringSlot = classInventory.GetInventorySpace(integerCounterSearch)
			'If true then add InventorySlot with StoreBin amount and Save
			If stringBin(0) = stringSlot(0) Then
				stringSlot(1) = CType(CType(stringSlot(1), Integer) + CType(stringBin(1), Integer), String)
				classInventory.GetInventorySpace(integerCounterSearch) = stringSlot
				classInventory.SaveState()
				Exit Do
			End If
			integerCounterSearch += 1
		Loop Until integerCounterSearch > classInventory.GetUpperbound()
		'Get InventorySlot and paste Data to StoreBin and Save
		stringBin = stringSlot
		formGame.StoreCurrent.getsetBin(comboboxBins.SelectedIndex) = stringBin
		formGame.StoreCurrent.SaveState()
		'Set InventorySlot Amount to 0 and Save
		stringSlot(1) = "0"
		classInventory.GetInventorySpace(integerCounterSearch - 1) = stringSlot
		formGame.StoreCurrent.SaveState()
		'Refresh formStatus				
		textboxAmount.Text = classInventory.GetInventorySpace(listboxInventory.SelectedIndex)(1)
		textboxLastBuying.Text = classInventory.GetInventorySpace(listboxInventory.SelectedIndex)(2)
		textboxLastSelling.Text = classInventory.GetInventorySpace(listboxInventory.SelectedIndex)(3)
		
		'Inventory Tab
		Dim intDimension As Integer = 0
		listboxInventory.Items.Clear()
		Do
			If classInventory.GetInventorySpace(intDimension) Is Nothing Then
				Exit Do
			End If
			'load through classInventory with incrementing Dimension adding the first sub-dimension to the listbox.
			listboxInventory.Items.Add((classInventory.GetInventorySpace(intDimension))(0))
			intDimension += 1
		Loop
	End Sub
	
	Sub ListboxInventorySelectedIndexChanged(sender As Object, e As EventArgs)
		If listboxInventory.SelectedIndex = -1 Then Exit Sub
		stringInventorySelected = classInventory.GetInventorySpace(listboxInventory.SelectedIndex)
		textboxAmount.Text = classInventory.GetInventorySpace(listboxInventory.SelectedIndex)(1)
		textboxLastBuying.Text = classInventory.GetInventorySpace(listboxInventory.SelectedIndex)(2)
		textboxLastSelling.Text = classInventory.GetInventorySpace(listboxInventory.SelectedIndex)(3)
	End Sub
	
	Sub ButtonMapClick(sender As Object, e As EventArgs)
		MapForm.Show()
	End Sub
	
	Sub buttonStoreClick(sender As Object, e As EventArgs)
		StoreForm.Show()
	End Sub
	
	Sub ButtonInventoryClick(sender As Object, e As EventArgs)
		InventoryForm = New formInventory()
		InventoryForm.Show()
	End Sub
	
	Private Sub timerUpdateTick(sender As Object, e As system.EventArgs)
		Reload()
	End Sub
	
	Private Sub Reload()
		textboxBalance.Text = CType(classCharacter.Balance, String)
		textboxPlaycycles.Text = CType(classStatistics.TotalDayCycles, String)
		textboxMoneyEarned.Text = CType(classStatistics.TotalEarnings, String)
		textboxMoneySpent.Text = CType(classStatistics.TotalSpent, String)
		textboxItemsSold.Text = CType(classStatistics.TotalItemsSold, String)
	End Sub
End Class
