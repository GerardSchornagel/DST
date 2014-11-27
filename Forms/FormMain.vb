Public Partial Class formMain
	Friend Shared cache As New cacheGlobal()
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub formMainLoad(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub buttonNewGameClick(sender As Object, e As EventArgs)
		'Resetting cache's
		cache.settingsGlobal.NewPlayer()
		cache.initializePlayerProfile()
		'>'Get an Player creation sheet inbetween.
		cache.initializePlayerCharacter()
		'Store
		Dim newStore As New store()
		newStore.NewStore()
		newStore.SaveState()
		'Call ResumeGame to continue starting.
		buttonResumeGame.Enabled = False
		buttonResumeGameClick(nothing, nothing)
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
		cache.settingsGlobal.LastUser = CType(folderdialogLoadGame.SelectedPath.Substring(folderdialogLoadGame.SelectedPath.Length - 1, 1), String)
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
		If cache.settingsGlobal.MessagesProgramQuit = False Then If MsgBox("This will end the game, are you sure?", MsgBoxStyle.YesNo, "Quit") = MsgBoxResult.No Then Exit Sub Else End Else End
	End Sub
End Class