Public Partial Class formStatus	
	Private timerUpdate As New System.Windows.Forms.Timer
	Private algebraic As New solverAlgebraic()
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
		
	Sub FormStatusLoad(sender As Object, e As EventArgs)
		AddHandler timerUpdate.Tick, AddressOf timerUpdateTick
		'Make a minium Interval value based on pc time to process random data equal to a medium big Savegame-size.
		timerUpdate.Interval = 2500
		timerUpdate.Start()
		
		textboxBalance.Text = CType(gamecache.currentCharacterStatistics.Balance, String)
		'Profile Tab
		textboxProfileID.Text = CType(gamecache.currentPlayerProfile.ProfileID, String)
		textboxNameFirst.Text = gamecache.currentPlayerProfile.FirstName
		textboxNameLast.Text = gamecache.currentPlayerProfile.LastName
		textboxBirthYear.Text = CType(gamecache.currentPlayerProfile.BirthYear, String)
		textboxBirthMonth.Text = CType(gamecache.currentPlayerProfile.BirthMonth, String)
		textboxBirthDay.Text = CType(gamecache.currentPlayerProfile.BirthDay, String)
		textboxGender.Text = gamecache.currentPlayerProfile.Gender
		textboxCreateDate.Text = gamecache.currentPlayerStatistics.CreateDate
		textboxCreateTime.Text = gamecache.currentPlayerStatistics.CreateTime
		'Character Tab
		textboxWorld.Text = gamecache.currentCharacterProfile.CurrentWorld
		textboxCountry.Text = gamecache.currentCharacterProfile.CurrentCountry
		textboxPlace.Text = gamecache.currentCharacterProfile.CurrentPlace
		textboxStore.Text = gamecache.currentCharacterProfile.CurrentStore
		textboxMoneyEarned.Text = CType(gamecache.currentCharacterStatistics.TotalEarnings, String)
		textboxMoneySpent.Text = CType(gamecache.currentCharacterStatistics.TotalSpendings, String)
		textboxItemsSold.Text = CType(gamecache.currentCharacterStatistics.TotalItemsSold, String)
		textboxPlaycycles.Text = CType(gamecache.currentCharacterStatistics.TotalDayCycles, String)
	End Sub
	
	Sub buttonExitClick(sender As Object, e As EventArgs)
		'Add code for clearing and 'Resetting' the gamecache.
		Application.Exit()
	End Sub
	
	Sub ButtonMapClick(sender As Object, e As EventArgs)
		gamecache.MapForm.Show()
		gamecache.MapForm.ShowInTaskbar = True
		gamecache.MapForm.WindowState = System.Windows.Forms.FormWindowState.Normal
	End Sub
	
	Sub buttonDCClick(sender As Object, e As EventArgs)
		gamecache.DCForm.Show()
		gamecache.DCForm.ShowInTaskbar = True
		gamecache.DCForm.WindowState = System.Windows.Forms.FormWindowState.Normal
	End Sub
	
	Sub buttonItemManagementClick(sender As Object, e As EventArgs)
		gamecache.ItemManagementForm.Show()
		gamecache.ItemManagementForm.ShowInTaskbar = True
		gamecache.ItemManagementForm.WindowState = System.Windows.Forms.FormWindowState.Normal
	End Sub
	
	Private Sub timerUpdateTick(sender As Object, e As system.EventArgs)
		Reload()
	End Sub
	
	Private Sub Reload()
		textboxBalance.Text = CType(gamecache.currentCharacterStatistics.Balance, String)
		textboxWorld.Text = gamecache.currentCharacterProfile.CurrentWorld
		textboxCountry.Text = gamecache.currentCharacterProfile.CurrentCountry
		textboxPlace.Text = gamecache.currentCharacterProfile.CurrentPlace
		textboxStore.Text = gamecache.currentCharacterProfile.CurrentStore
		textboxMoneyEarned.Text = CType(gamecache.currentCharacterStatistics.TotalEarnings, String)
		textboxMoneySpent.Text = CType(gamecache.currentCharacterStatistics.TotalSpendings, String)
		textboxItemsSold.Text = CType(gamecache.currentCharacterStatistics.TotalItemsSold, String)
		textboxPlaycycles.Text = CType(gamecache.currentCharacterStatistics.TotalDayCycles, String)
	End Sub
End Class
