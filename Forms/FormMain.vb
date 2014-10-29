Public Partial Class formMain
	Friend Shared GlobalSettings As New Settings()
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub formMainLoad(sender As Object, e As EventArgs)
		If GlobalSettings.LastUser = 99 Then buttonResumeGame.Enabled = False
	End Sub
	
	Sub ButtonNewGameClick(sender As Object, e As EventArgs)
		'Look for nearest free number in save directory
		Dim intCheck As Integer = 0
		Do
			If System.IO.Directory.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & intCheck) = False Then
				Exit Do
			End If
			intCheck += 1
		Loop
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\" & intCheck)
		'Replace ResumeGame Integer
		GlobalSettings.LastUser = intCheck
		'Load Game
		ButtonResumeGameClick(Nothing, Nothing)
		
	End Sub
	
	Sub ButtonResumeGameClick(sender As Object, e As EventArgs)
		'set me to minimized
		Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
		Dim StatusForm As New formStatus
		StatusForm.Show()
	End Sub
	
	Sub ButtonLoadClick(sender As Object, e As EventArgs)
		'add filedialog and change lastuser
		Dim filedialogLoadGame As New System.Windows.Forms.OpenFileDialog()
		filedialogLoadGame.FileName = "player.pd"
		filedialogLoadGame.InitialDirectory = System.IO.Directory.GetCurrentDirectory & "\save"
		filedialogLoadGame.Title = "Please select one of the numbered directory's"
		filedialogLoadGame.ShowDialog()
		GlobalSettings.LastUser = CType(filedialogLoadGame.FileName.Substring(filedialogLoadGame.FileName.Length - 11, 1),Integer)
		'Load Game
		ButtonResumeGameClick(Nothing, Nothing)
	End Sub
	
	Sub ButtonOptionsClick(sender As Object, e As EventArgs)
		Dim OptionsForm as New formOptions
		OptionsForm.Show()
	End Sub
	
	Sub ButtonQuitClick(sender As Object, e As EventArgs)
		'Check for WarningMessage Setting and show the warning with Yes/No, else just End
	If GlobalSettings.MessagesProgramQuit = False Then If MsgBox("This will end the game, are you sure?", MsgBoxStyle.YesNo, "Quit") = MsgBoxResult.No Then Exit Sub Else End Else End
	End Sub
End Class