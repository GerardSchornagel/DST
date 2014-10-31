Public Partial Class formOptions
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub formOptionsLoad(sender As Object, e As EventArgs)
		checkboxlistMessages.SetItemChecked(0, CType(formMain.GlobalSettings.MessagesProgramQuit, Boolean))
		checkboxlistMessages.SetItemChecked(1, CType(formMain.GlobalSettings.MessagesNewgameOverwrite, Boolean))
		checkboxlistMessages.SetItemChecked(2, CType(formMain.GlobalSettings.MessagesOptionsApplyrestart, Boolean))
	End Sub

	Sub buttonOKClick(sender As Object, e As EventArgs)
		'Save all options to save\setting.prd
		formMain.GlobalSettings.MessagesProgramQuit = CType(checkboxlistMessages.GetItemCheckState(0), Boolean)
		formMain.GlobalSettings.MessagesNewgameOverwrite = CType(checkboxlistMessages.GetItemCheckState(1), Boolean)
		formMain.GlobalSettings.MessagesOptionsApplyrestart = CType(checkboxlistMessages.GetItemCheckState(2), Boolean)
		'Warn before restarting
		If formMain.GlobalSettings.MessagesOptionsApplyrestart = False Then MsgBox("The program has to be restarted to take full effect.", MsgBoxStyle.Exclamation,"Please restart.")
		Me.Dispose()
	End Sub
	
	Sub buttonCancelClick(sender As Object, e As EventArgs)
		Me.Dispose()
	End Sub
End Class