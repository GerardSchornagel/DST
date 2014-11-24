Public Partial Class formMain
	Friend Shared GlobalSettings As New Settings()
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub formMainLoad(sender As Object, e As EventArgs)
		If GlobalSettings.LastUser = 99 Then buttonResumeGame.Enabled = False
	End Sub
	
	Sub buttonNewGameClick(sender As Object, e As EventArgs)
		'Look for nearest free number in save directory
		Dim intCheck As Integer = 0
		Do
			If System.IO.Directory.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & intCheck) = False Then
				Exit Do
			End If
			intCheck += 1
		Loop
		'Make templates for all classes
		'Update LastUser
		GlobalSettings.LastUser = intCheck
		GlobalSettings.SaveState()
		'Player
		Dim stringNewPlayer() As String
		stringNewPlayer = New String() {CType(intCheck, String), "Nick Name", "First Name", "Last Name", "1985", "09", "24", "1", "FirstLocation", "FirstStore", "0", "0", "0"}
		Dim newPlayer As New player("New", stringNewPlayer)
		'Character
		Dim stringNewCharacter() As String
		stringNewCharacter = New String() {CType(intCheck, String), "0", "0", "0", "0"}
		Dim newCharacter As New character("New", stringNewCharacter)
		'Statistics
		Dim stringNewStatistics() As String
		stringNewStatistics = New String() {CType(intCheck, String), "0", System.DateTime.Now.Date.ToShortDateString, (System.DateTime.Now.TimeOfDay.ToString).Split(CType(".", Char))(0), "0", "0", "0"}
		Dim newStatistics As New statistics("New", stringNewStatistics)
		'Inventory
		Dim newInventory As New inventory("New", intCheck)
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
		GlobalSettings.LastUser = CType(folderdialogLoadGame.SelectedPath.Substring(folderdialogLoadGame.SelectedPath.Length - 1, 1),Integer)
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
		If GlobalSettings.MessagesProgramQuit = False Then If MsgBox("This will end the game, are you sure?", MsgBoxStyle.YesNo, "Quit") = MsgBoxResult.No Then Exit Sub Else End Else End
	End Sub
End Class