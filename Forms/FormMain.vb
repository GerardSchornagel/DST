'Make this the Main Menu form
Public Class formMain
  Friend Shared GlobalSettings As New Settings()

  Private OptionsForm As New formOptions
  Private StatusForm As New formStatus

  Friend Shared Sub Main(ByVal args() As String)
    System.Windows.Forms.Application.Run(New formMain())
  End Sub 'Sub Main

  Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
    If GlobalSettings.LastUser = 99 Then buttonResumeGame.Enabled = False
  End Sub

  Private Sub buttonNewGame_Click(sender As Object, e As EventArgs) Handles buttonNewGame.Click
    'Look for nearest free number in save directory
    Dim intCheck As Integer = 0
    Do
      If System.IO.Directory.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & intCheck) = False Then
        Exit Do
      End If
      intCheck += 1
    Loop
    '***Call all Player\DataTypes for creating new user

    'Replace ResumeGame Integer
    GlobalSettings.LastUser = intCheck
    'Load Game
    buttonResumeGame_Click(Nothing, Nothing)
  End Sub

  Private Sub buttonResumeGame_Click(sender As Object, e As EventArgs) Handles buttonResumeGame.Click
    '***Pass LastUser to FormPlayer.vb

    'set me to minimized
    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
  End Sub

  Private Sub buttonLoad_Click(sender As Object, e As EventArgs) Handles buttonLoad.Click
    'add filedialog and change lastuser
    Dim filedialogLoadGame As New System.Windows.Forms.OpenFileDialog()
    filedialogLoadGame.FileName = "player.pd"
    filedialogLoadGame.InitialDirectory = System.IO.Directory.GetCurrentDirectory & "\save"
    filedialogLoadGame.Title = "Please select one of the numbered directory's"
    filedialogLoadGame.ShowDialog()
    GlobalSettings.LastUser = filedialogLoadGame.FileName.Substring(filedialogLoadGame.FileName.Length - 11, 1)
    'Load Game
    buttonResumeGame_Click(Nothing, Nothing)
  End Sub

  Private Sub buttonOptions_Click(sender As Object, e As EventArgs) Handles buttonOptions.Click
    OptionsForm = New formOptions
    OptionsForm.Show()
  End Sub 'buttonOptions_Click

  Private Sub buttonQuit_Click(sender As Object, e As EventArgs) Handles buttonQuit.Click
    'Check for WarningMessage Setting and show the warning with Yes/No, else just End
    If GlobalSettings.MessagesProgramQuit = False Then If MsgBox("This will end the game, are you sure?", MsgBoxStyle.YesNo, "Quit") = MsgBoxResult.No Then Exit Sub Else End Else End
  End Sub 'buttonQuit
End Class