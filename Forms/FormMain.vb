''' <summary>
''' Main Menu.
''' </summary>
Public Partial Class formMain
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub formMainLoad(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub buttonNewGameClick(sender As Object, e As EventArgs)
		gamecache.NewGame()
	End Sub
	
	Sub buttonResumeGameClick(sender As Object, e As EventArgs)
		Dim StatusForm As New formStatus
		StatusForm.Show()
	End Sub
	
	Sub buttonLoadClick(sender As Object, e As EventArgs)
		'add filedialog and change lastuser
		Dim folderdialogLoadGame As New System.Windows.Forms.FolderBrowserDialog()
		folderdialogLoadGame.ShowNewFolderButton = False
		folderdialogLoadGame.SelectedPath = System.IO.Directory.GetCurrentDirectory & "\save"
		folderdialogLoadGame.Description = "Please select one of the numbered directory's"
		folderdialogLoadGame.ShowDialog()
		gamecache.settingsGlobal.LastUser = CType(folderdialogLoadGame.SelectedPath.Substring(folderdialogLoadGame.SelectedPath.Length - 1, 1), String)
		'Load Game
		buttonResumeGame.Enabled = False
		buttonResumeGameClick(Nothing, Nothing)
	End Sub
	
	Sub buttonOptionsClick(sender As Object, e As EventArgs)
		Dim OptionsForm as New formOptions
		OptionsForm.Show()
	End Sub
	
	Sub buttonQuitClick(sender As Object, e As EventArgs)
		'Check for WarningMessage Setting and show the warning with Yes/No, else just End
		If gamecache.settingsGlobal.MessagesProgramQuit = False Then If MsgBox("This will end the game, are you sure?", MsgBoxStyle.YesNo, "Quit") = MsgBoxResult.No Then Exit Sub Else End Else End
	End Sub
	
	Sub buttonEditorClick(sender As Object, e As EventArgs)
		gamecache.EditorForm = New formEditor
		gamecache.EditorForm.Show()
	End Sub
End Class