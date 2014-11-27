Public Partial Class formStatus	
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
		
		textboxBalance.Text = CType(formMain.cache.playerCharacter.Balance, String)
		'Profile Tab
		textboxPlayerID.Text = CType(formMain.cache.playerCharacter.PlayerID, String)
		textboxNameNick.Text = formMain.cache.playerProfile.NickName
		textboxNameFirst.Text = formMain.cache.playerProfile.FirstName
		textboxNameLast.Text = formMain.cache.playerProfile.LastName
		textboxBirthYear.Text = CType(formMain.cache.playerProfile.BirthYear, String)
		textboxBirthMonth.Text = CType(formMain.cache.playerProfile.BirthMonth, String)
		textboxBirthDay.Text = CType(formMain.cache.playerProfile.BirthDay, String)
		textboxGender.Text = CType(formMain.cache.playerProfile.Gender, String)
		textboxCreatedDate.Text = formMain.cache.playerProfile.CreateDate
		textboxCreatedTime.Text = formMain.cache.playerProfile.CreateTime
		textboxTotalBalance.Text = CType(formMain.cache.playerProfile.BalanceTotal, String)
		'Character Tab
		textboxLocation.Text = formMain.cache.playerCharacter.CurrentLocation
		textboxStore.Text = formMain.cache.playerCharacter.CurrentStore
		textboxLevel.Text = CType(formMain.cache.playerCharacter.CurrentLevel, String)
		textboxShelf.Text = CType(formMain.cache.playerCharacter.CurrentShelf, String)
		textboxMoneyEarned.Text = CType(formMain.cache.playerCharacter.TotalEarnings, String)
		textboxMoneySpent.Text = CType(formMain.cache.playerCharacter.TotalSpendings, String)
		textboxItemsSold.Text = CType(formMain.cache.playerCharacter.TotalItemsSold, String)
		textboxPlaycycles.Text = CType(formMain.cache.playerCharacter.TotalDayCycles, String)
		textboxCreatedDate.Text = formMain.cache.playerCharacter.CreateDate
		textboxCreatedTime.Text = formMain.cache.playerCharacter.CreateTime
		'Inventory Tab
		Dim intDimension As Integer = 0
		listboxInventory.Items.Clear()
		Do
			If formMain.cache.playerInventory.GetInventorySpace(intDimension) Is Nothing Then
				Exit Do
			End If
			'load through classInventory with incrementing Dimension adding the first sub-dimension to the listbox.
			listboxInventory.Items.Add((formMain.cache.playerInventory.GetInventorySpace(intDimension))(0))
			intDimension += 1
		Loop
		
		GameForm.Show()
	End Sub
	
	Sub buttonRefreshClick(sender As Object, e As EventArgs)
		Dim intDimension As Integer = 0
		listboxInventory.Items.Clear()
		Do
			If formMain.cache.playerInventory.GetInventorySpace(intDimension) Is Nothing Then
				Exit Do
			End If
			'load through classInventory with incrementing Dimension adding the first sub-dimension to the listbox.
			listboxInventory.Items.Add((formMain.cache.playerInventory.GetInventorySpace(intDimension))(0))
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
			stringSlot = formMain.cache.playerInventory.GetInventorySpace(integerCounterSearch)
			'If true then add InventorySlot with StoreBin amount and Save
			If stringBin(0) = stringSlot(0) Then
				stringSlot(1) = CType(CType(stringSlot(1), Integer) + CType(stringBin(1), Integer), String)
				formMain.cache.playerInventory.GetInventorySpace(integerCounterSearch) = stringSlot
				formMain.cache.playerInventory.SaveState()
				Exit Do
			End If
			integerCounterSearch += 1
		Loop Until integerCounterSearch > formMain.cache.playerInventory.GetUpperbound()
		'Get InventorySlot and paste Data to StoreBin and Save
		stringBin = stringSlot
		formGame.StoreCurrent.getsetBin(comboboxBins.SelectedIndex) = stringBin
		formGame.StoreCurrent.SaveState()
		'Set InventorySlot Amount to 0 and Save
		stringSlot(1) = "0"
		formMain.cache.playerInventory.GetInventorySpace(integerCounterSearch - 1) = stringSlot
		formGame.StoreCurrent.SaveState()
		'Refresh formStatus				
		textboxAmount.Text = formMain.cache.playerInventory.GetInventorySpace(listboxInventory.SelectedIndex)(1)
		textboxLastBuying.Text = formMain.cache.playerInventory.GetInventorySpace(listboxInventory.SelectedIndex)(2)
		textboxLastSelling.Text = formMain.cache.playerInventory.GetInventorySpace(listboxInventory.SelectedIndex)(3)
		
		'Inventory Tab
		Dim intDimension As Integer = 0
		listboxInventory.Items.Clear()
		Do
			If formMain.cache.playerInventory.GetInventorySpace(intDimension) Is Nothing Then
				Exit Do
			End If
			'load through classInventory with incrementing Dimension adding the first sub-dimension to the listbox.
			listboxInventory.Items.Add((formMain.cache.playerInventory.GetInventorySpace(intDimension))(0))
			intDimension += 1
		Loop
	End Sub
	
	Sub ListboxInventorySelectedIndexChanged(sender As Object, e As EventArgs)
		If listboxInventory.SelectedIndex = -1 Then Exit Sub
		stringInventorySelected = formMain.cache.playerInventory.GetInventorySpace(listboxInventory.SelectedIndex)
		textboxAmount.Text = formMain.cache.playerInventory.GetInventorySpace(listboxInventory.SelectedIndex)(1)
		textboxLastBuying.Text = formMain.cache.playerInventory.GetInventorySpace(listboxInventory.SelectedIndex)(2)
		textboxLastSelling.Text = formMain.cache.playerInventory.GetInventorySpace(listboxInventory.SelectedIndex)(3)
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
		textboxBalance.Text = CType(formMain.cache.playerCharacter.Balance, String)
		textboxPlaycycles.Text = CType(formMain.cache.playerCharacter.TotalDayCycles, String)
		textboxMoneyEarned.Text = CType(formMain.cache.playerCharacter.TotalEarnings, String)
		textboxMoneySpent.Text = CType(formMain.cache.playerCharacter.TotalSpendings, String)
		textboxItemsSold.Text = CType(formMain.cache.playerCharacter.TotalItemsSold, String)
	End Sub
End Class
