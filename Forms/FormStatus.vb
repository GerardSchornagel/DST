Public Partial Class formStatus	
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
		
		textboxBalance.Text = CType(gamecache.playerCharacter.Balance, String)
		'Profile Tab
		textboxPlayerID.Text = CType(gamecache.playerCharacter.PlayerID, String)
		textboxNameNick.Text = gamecache.playerProfile.NickName
		textboxNameFirst.Text = gamecache.playerProfile.FirstName
		textboxNameLast.Text = gamecache.playerProfile.LastName
		textboxBirthYear.Text = CType(gamecache.playerProfile.BirthYear, String)
		textboxBirthMonth.Text = CType(gamecache.playerProfile.BirthMonth, String)
		textboxBirthDay.Text = CType(gamecache.playerProfile.BirthDay, String)
		textboxGender.Text = gamecache.playerProfile.Gender
		textboxCreateDate.Text = gamecache.playerProfile.CreateDate
		textboxCreateTime.Text = gamecache.playerProfile.CreateTime
		'Character Tab
		textboxLocation.Text = gamecache.playerCharacter.CurrentLocation
		textboxStore.Text = gamecache.playerCharacter.CurrentStore
		textboxMoneyEarned.Text = CType(gamecache.playerCharacter.TotalEarnings, String)
		textboxMoneySpent.Text = CType(gamecache.playerCharacter.TotalSpendings, String)
		textboxItemsSold.Text = CType(gamecache.playerCharacter.TotalItemsSold, String)
		textboxPlaycycles.Text = CType(gamecache.playerCharacter.TotalDayCycles, String)
	End Sub
	
	Sub buttonExitClick(sender As Object, e As EventArgs)
		'Add code for clearing and 'Resetting' the gamecache.
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
		textboxBalance.Text = CType(gamecache.playerCharacter.Balance, String)
		textboxPlaycycles.Text = CType(gamecache.playerCharacter.TotalDayCycles, String)
		textboxMoneyEarned.Text = CType(gamecache.playerCharacter.TotalEarnings, String)
		textboxMoneySpent.Text = CType(gamecache.playerCharacter.TotalSpendings, String)
		textboxItemsSold.Text = CType(gamecache.playerCharacter.TotalItemsSold, String)
	End Sub
End Class
