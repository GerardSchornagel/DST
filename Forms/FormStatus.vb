Public Partial Class formStatus
	Friend Shared classPlayer As New player(formMain.GlobalSettings.LastUser)
	Friend Shared classCharacter As New character(formMain.GlobalSettings.LastUser)
	Friend Shared classInventory As New inventory(formMain.GlobalSettings.LastUser)
	Friend Shared classStatistics As New statistics(formMain.GlobalSettings.LastUser)
	
	Friend Shared GameForm As New formGame()
	Friend Shared InventoryForm As New formInventory()
	Friend Shared MapForm As New formMap()
	Friend Shared StoreForm As New formStore()
	
	Private arrayInventorySelected As Object
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub FormStatusLoad(sender As Object, e As EventArgs)
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
		textboxBalance.Text = CType(classCharacter.Balance, String)
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
		Dim intInventoryMax As Integer = classCharacter.GradeInventory + 4 'Adding 4 Standard Inventory slots
		Dim intDimension As Integer = 0
		Do
			If classInventory.GetInventorySpace(intDimension) Is Nothing Then
				Exit Do
			End If
			'load through classInventory with incrementing Dimension adding the first sub-dimension to the listbox.
			listboxInventory.Items.Add((classInventory.GetInventorySpace(intDimension))(0))
			intInventoryMax -= 1
			intDimension += 1
		Loop Until intInventoryMax = 0
		GameForm.Show()
	End Sub
	
	Sub buttonSaveClick(sender As Object, e As EventArgs)
		MsgBox("Inventory Export function is immediate, no need to save for this.", MsgBoxStyle.Information, "Inventory doesn't need save.")
		
		'Player Tab
		classPlayer.NickName = textboxNameNick.Text
		classPlayer.FirstName = textboxNameFirst.Text
		classPlayer.LastName = textboxNameLast.Text
		classPlayer.BirthYear = CType(textboxBirthYear.Text,Integer)
		classPlayer.BirthMonth = CType(textboxBirthMonth.Text,Integer)
		classPlayer.BirthDay = CType(textboxBirthDay.Text,Integer)
		classPlayer.Gender = CType(textboxGender.Text,Integer)
		'Character Tab
		classCharacter.Balance = CType(textboxBalance.Text, Integer)
		classCharacter.GradeInventory = CType(textboxGradeInventory.Text, Integer)
		classCharacter.GradeShelf = CType(textboxGradeShelf.Text, Integer)
		classCharacter.GradePopularity = CType(textboxGradePopularity.Text, Integer)
		'Statistics Tab
		classStatistics.CreationDate = textboxCreatedDate.Text
		classStatistics.CreationTime = textboxCreatedTime.Text
		classStatistics.TotalHoursPlayed = CType(textboxPlayHours.Text, Integer)
		classStatistics.TotalDayCycles = CType(textboxPlaycycles.Text, Integer)
		classStatistics.TotalSaveTimes = CType(textboxPlaySaved.Text, Integer)
		classStatistics.TotalEarnings = CType(textboxMoneyEarned.Text, Integer)
		classStatistics.TotalSpent = CType(textboxMoneySpent.Text, Integer)
		classStatistics.TotalItemsSold = CType(textboxItemsSold.Text, Integer)
	End Sub
	
	Sub buttonExitClick(sender As Object, e As EventArgs)
		'Add code for closing formGame, formMap, formInventory, formStore & Me(formStatus)
	End Sub
	
	Sub buttonExportClick(sender As Object, e As EventArgs)
		'This will send the article and amount to the qeue, so next cycle the goods arrive.
	End Sub
	
	Sub ListboxInventorySelectedIndexChanged(sender As Object, e As EventArgs)
		arrayInventorySelected = classInventory.GetInventorySpace(listboxInventory.SelectedIndex)
		textboxAmount.Text = CType(arrayInventorySelected(1), String)
		textboxLastBuying.Text = CType(arrayInventorySelected(2), String)
		textboxLastSelling.Text = CType(arrayInventorySelected(3), String)
	End Sub
End Class
