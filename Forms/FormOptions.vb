Public Partial Class formOptions
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub formOptionsLoad(sender As Object, e As EventArgs)
		checkboxlistMessages.SetItemChecked(0, cache.settingsGlobal.MessagesProgramQuit)
		checkboxlistMessages.SetItemChecked(1, cache.settingsGlobal.MessagesNewgameOverwrite)
		checkboxlistMessages.SetItemChecked(2, cache.settingsGlobal.MessagesOptionsApplyrestart)
	End Sub

	Sub buttonOKClick(sender As Object, e As EventArgs)
		'Save all options to save\setting.pd
		cache.settingsGlobal.MessagesProgramQuit = CType(checkboxlistMessages.GetItemCheckState(0), Boolean)
		cache.settingsGlobal.MessagesNewgameOverwrite = CType(checkboxlistMessages.GetItemCheckState(1), Boolean)
		cache.settingsGlobal.MessagesOptionsApplyrestart = CType(checkboxlistMessages.GetItemCheckState(2), Boolean)
		'Warn before restarting
		If cache.settingsGlobal.MessagesOptionsApplyrestart = False Then MsgBox("The program has to be restarted to take full effect.", MsgBoxStyle.Exclamation,"Please restart.")
		Me.Dispose()
	End Sub
	
	Sub buttonCancelClick(sender As Object, e As EventArgs)
		Me.Dispose()
	End Sub
End Class