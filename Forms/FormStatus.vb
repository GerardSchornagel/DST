Public Partial Class formStatus	
	Private stringStorageSelected() As String
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
		
		textboxBalance.Text = CType(cache.playerCharacter.Balance, String)
		'Profile Tab
		textboxPlayerID.Text = CType(cache.playerCharacter.PlayerID, String)
		textboxNameNick.Text = cache.playerProfile.NickName
		textboxNameFirst.Text = cache.playerProfile.FirstName
		textboxNameLast.Text = cache.playerProfile.LastName
		textboxBirthYear.Text = CType(cache.playerProfile.BirthYear, String)
		textboxBirthMonth.Text = CType(cache.playerProfile.BirthMonth, String)
		textboxBirthDay.Text = CType(cache.playerProfile.BirthDay, String)
		textboxGender.Text = CType(cache.playerProfile.Gender, String)
		textboxCreatedDate.Text = cache.playerProfile.CreateDate
		textboxCreatedTime.Text = cache.playerProfile.CreateTime
		textboxTotalBalance.Text = CType(cache.playerProfile.BalanceTotal, String)
		'Character Tab
		textboxLocation.Text = cache.playerCharacter.CurrentLocation
		textboxStore.Text = cache.playerCharacter.CurrentStore
		textboxMoneyEarned.Text = CType(cache.playerCharacter.TotalEarnings, String)
		textboxMoneySpent.Text = CType(cache.playerCharacter.TotalSpendings, String)
		textboxItemsSold.Text = CType(cache.playerCharacter.TotalItemsSold, String)
		textboxPlaycycles.Text = CType(cache.playerCharacter.TotalDayCycles, String)
		textboxCreatedDate.Text = cache.playerCharacter.CreateDate
		textboxCreatedTime.Text = cache.playerCharacter.CreateTime
	End Sub
	
	Sub buttonExitClick(sender As Object, e As EventArgs)
		'Add code for clearing and 'Resetting' the cache.
	End Sub
	
	Sub ButtonMapClick(sender As Object, e As EventArgs)
		cache.MapForm.Show()
		cache.MapForm.ShowInTaskbar = True
		cache.MapForm.WindowState = System.Windows.Forms.FormWindowState.Normal
	End Sub
	
	Sub buttonDCClick(sender As Object, e As EventArgs)
		cache.DCForm.Show()
		cache.DCForm.ShowInTaskbar = True
		cache.DCForm.WindowState = System.Windows.Forms.FormWindowState.Normal
	End Sub
	
	Sub buttonItemManagementClick(sender As Object, e As EventArgs)
		cache.ItemManagementForm.Show()
		cache.ItemManagementForm.ShowInTaskbar = True
		cache.ItemManagementForm.WindowState = System.Windows.Forms.FormWindowState.Normal
	End Sub
	
	Private Sub timerUpdateTick(sender As Object, e As system.EventArgs)
		Reload()
	End Sub
	
	Private Sub Reload()
		textboxBalance.Text = CType(cache.playerCharacter.Balance, String)
		textboxPlaycycles.Text = CType(cache.playerCharacter.TotalDayCycles, String)
		textboxMoneyEarned.Text = CType(cache.playerCharacter.TotalEarnings, String)
		textboxMoneySpent.Text = CType(cache.playerCharacter.TotalSpendings, String)
		textboxItemsSold.Text = CType(cache.playerCharacter.TotalItemsSold, String)
	End Sub
End Class
