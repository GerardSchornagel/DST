Public Partial Class formOptions
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub formOptionsLoad(sender As Object, e As EventArgs)
		checkboxlistMessages.SetItemChecked(0, gamecache.currentSettings.MessagesProgramQuit)
		checkboxlistMessages.SetItemChecked(1, gamecache.currentSettings.MessagesNewgameOverwrite)
		checkboxlistMessages.SetItemChecked(2, gamecache.currentSettings.MessagesOptionsApplyrestart)
	End Sub

	Sub buttonOKClick(sender As Object, e As EventArgs)
		'Save all options to save\setting.ini
		gamecache.currentSettings.MessagesProgramQuit = CType(checkboxlistMessages.GetItemCheckState(0), Boolean)
		gamecache.currentSettings.MessagesNewgameOverwrite = CType(checkboxlistMessages.GetItemCheckState(1), Boolean)
		gamecache.currentSettings.MessagesOptionsApplyrestart = CType(checkboxlistMessages.GetItemCheckState(2), Boolean)
		'Warn before restarting
		If gamecache.currentSettings.MessagesOptionsApplyrestart = False Then MsgBox("The program has to be restarted to take full effect.", MsgBoxStyle.Exclamation,"Please restart.")
		Me.Dispose()
	End Sub
	
	Sub buttonCancelClick(sender As Object, e As EventArgs)
		Me.Dispose()
	End Sub
End Class