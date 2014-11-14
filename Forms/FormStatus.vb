Public Partial Class formStatus
	Friend Shared classPlayer As New player(CType(formMain.GlobalSettings.LastUser, String))
	Friend Shared classCharacter As New character(CType(formMain.GlobalSettings.LastUser, String))
	Friend Shared classInventory As New inventory(CType(formMain.GlobalSettings.LastUser, String))
	Friend Shared classStatistics As New statistics(CType(formMain.GlobalSettings.LastUser, String))
	
	Friend Shared GameForm As New formGame()
	Friend Shared InventoryForm As New formInventory()
	Friend Shared MapForm As New formMap()
	Friend Shared StoreForm As New formStore()
	
	Private arrayInventorySelected As Object
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
		textboxPlayHours.Text = CType(classStatistics.TotalHoursPlayed, String)
		textboxPlaycycles.Text = CType(classStatistics.TotalDayCycles, String)
		textboxPlaySaved.Text = CType(classStatistics.TotalSaveTimes, String)
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
		'This will send the article and total amount to the user decided Bin
		Dim arrayPocket As Object = classInventory.GetInventorySpace(listboxInventory.SelectedIndex)
		Dim arrayBin As Object = formGame.StoreCurrent.getsetBin(comboboxBins.SelectedIndex)
		If listboxInventory.SelectedIndex = -1 then Exit Sub
		'Look for current item in Shelf
		If arrayBin(0) Is CType("Empty", String) Then
			formGame.StoreCurrent.makeBin()
			formGame.StoreCurrent.SaveState()
			arrayPocket = classInventory.GetInventorySpace(listboxInventory.SelectedIndex)		
			arrayBin = formGame.StoreCurrent.getsetBin(comboboxBins.SelectedIndex)
			'Copy info from classInventory to store(SpecifiedBin)
			arrayBin(0) = arrayPocket(0)
			arrayBin(1) = arrayPocket(1)
			arrayBin(2) = arrayPocket(3)
			formGame.StoreCurrent.getsetBin(comboboxBins.SelectedIndex) = arrayBin
			'set Amount in classInventory to zero
			arrayPocket(1) = "0"
			classInventory.GetInventorySpace(listboxInventory.SelectedIndex) = arrayPocket
			
		ElseIf CType((formGame.StoreCurrent.getsetBin(comboboxBins.SelectedIndex))(0), String) = "0" Then
			'Copy info from classInventory to store(SpecifiedBin)
			arrayBin(0) = arrayPocket(0)
			arrayBin(1) = arrayPocket(1)
			arrayBin(2) = arrayPocket(3)
			formGame.StoreCurrent.getsetBin(comboboxBins.SelectedIndex) = arrayBin
			'set Amount in classInventory to zero
			arrayPocket(1) = "0"
			classInventory.GetInventorySpace(listboxInventory.SelectedIndex) = arrayPocket
			
		Else 'Check where item exists in classInventory and add amount.
			Dim integerLoopCounter As integer = 0
			Do
				If (classInventory.GetInventorySpace(integerLoopCounter))(0) = arrayBin(0) Then Exit Do
				integerLoopCounter += 1
			Loop Until integerLoopCounter = 9
			classInventory.GetInventorySpace(integerLoopCounter) = arrayPocket
			arrayPocket(1) = CType(CType(arrayPocket(1), Integer) + CType(formGame.StoreCurrent.getsetBin(comboboxBins.SelectedIndex)(1), Integer), String)
			classInventory.GetInventorySpace(integerLoopCounter) = arrayPocket
			'Copy info from classInventory to store(SpecifiedBin)
			arrayBin(0) = arrayPocket(0)
			arrayBin(1) = arrayPocket(1)
			arrayBin(2) = arrayPocket(3)
			formGame.StoreCurrent.getsetBin(comboboxBins.SelectedIndex) = arrayBin
			'set Amount in classInventory to zero
			arrayPocket(1) = "0"
			classInventory.GetInventorySpace(listboxInventory.SelectedIndex) = arrayPocket
		End If
		classInventory.SaveState()
		formGame.StoreCurrent.SaveState()
		
		arrayInventorySelected = classInventory.GetInventorySpace(listboxInventory.SelectedIndex)
		textboxAmount.Text = CType(arrayInventorySelected(1), String)
		textboxLastBuying.Text = CType(arrayInventorySelected(2), String)
		textboxLastSelling.Text = CType(arrayInventorySelected(3), String)
		
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
		formGame.StoreCurrent.makeBin()
	End Sub
	
	Sub ListboxInventorySelectedIndexChanged(sender As Object, e As EventArgs)
		If listboxInventory.SelectedIndex = -1 Then Exit Sub
		arrayInventorySelected = classInventory.GetInventorySpace(listboxInventory.SelectedIndex)
		textboxAmount.Text = CType(arrayInventorySelected(1), String)
		textboxLastBuying.Text = CType(arrayInventorySelected(2), String)
		textboxLastSelling.Text = CType(arrayInventorySelected(3), String)
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
		textboxPlayHours.Text = CType(classStatistics.TotalHoursPlayed, String)
		textboxPlaycycles.Text = CType(classStatistics.TotalDayCycles, String)
		textboxPlaySaved.Text = CType(classStatistics.TotalSaveTimes, String)
		textboxMoneyEarned.Text = CType(classStatistics.TotalEarnings, String)
		textboxMoneySpent.Text = CType(classStatistics.TotalSpent, String)
		textboxItemsSold.Text = CType(classStatistics.TotalItemsSold, String)
	End Sub
End Class
