Public Partial Class formMain
	Friend Shared GlobalSettings As New Settings()
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub formMainLoad(sender As Object, e As EventArgs)
		
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
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\" & intCheck)
		'Make templates for all classes
		'Player
		Dim stringNewPlayer() As String
		stringNewPlayer = New String() {CType(intCheck, String), "Nick Name", "First Name", "Last Name", "1985", "09", "24", "1"}
		Dim newPlayer As New player("New", stringNewPlayer)
		'Character
		Dim stringNewCharacter() As String
		stringNewCharacter = New String() {CType(intCheck, String), "250", "0", "0", "0"}
		Dim newCharacter As New character("New", stringNewCharacter)
		'Statistics
		Dim stringNewStatistics() As String
		stringNewStatistics = New String() {CType(intCheck, String), "0", "0", "0", System.DateTime.Now.Date.ToString, System.DateTime.Now.TimeOfDay.ToString, "0", "0", "0"}
		Dim newStatistics As New statistics("New", stringNewStatistics)
		'Inventory
		Dim arrayNewInventory(0, 3) As Object
		arrayNewInventory(0, 0) = "Freebie Pen's"
		arrayNewInventory(0, 1) = "25"
		arrayNewInventory(0, 2) = "1"
		arrayNewInventory(0, 3) = "5"
		Dim newInventory As New inventory("New", arrayNewInventory, CType(intCheck, String))
		'Store
		Dim newStore As New store("New", "FirstLocation", CType(intCheck, String))
		'Update LastUser
		GlobalSettings.LastUser = intCheck
		'Call ResumeGame to continue starting.
		buttonResumeGameClick(nothing, nothing)
	End Sub
	
	Sub buttonResumeGameClick(sender As Object, e As EventArgs)
		Dim StatusForm As New formStatus
		StatusForm.Show()
	End Sub
	
	Sub buttonLoadClick(sender As Object, e As EventArgs)
		'add filedialog and change lastuser
		Dim filedialogLoadGame As New System.Windows.Forms.OpenFileDialog()
		filedialogLoadGame.FileName = "player.pd"
		filedialogLoadGame.InitialDirectory = System.IO.Directory.GetCurrentDirectory & "\save"
		filedialogLoadGame.Title = "Please select one of the numbered directory's"
		filedialogLoadGame.ShowDialog()
		GlobalSettings.LastUser = CType(filedialogLoadGame.FileName.Substring(filedialogLoadGame.FileName.Length - 11, 1),Integer)
		'Load Game
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