'Make this the Main Menu form
Public Class formMain
  Friend Shared GlobalSettings As New Settings()

  Private OptionsForm As New formOptions

  Friend Shared Sub Main(ByVal args() As String)
    System.Windows.Forms.Application.Run(New formMain())
  End Sub 'Sub Main

  Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
    If GlobalSettings.LastUser = 99 Then buttonResumeGame.Enabled = False
  End Sub

  Private Sub buttonNewGame_Click(sender As Object, e As EventArgs) Handles buttonNewGame.Click
    'Look for nearest free number in save directory
    'Call all Player\DataTypes for creating new user
    'Replace ResumeGame Integer
    'Call buttonResumeGame_Click(nothing,nothing)
  End Sub

  Private Sub buttonResumeGame_Click(sender As Object, e As EventArgs) Handles buttonResumeGame.Click
    'Get LastGame Integer from \AutoResume. file
    'Pass LGint to FormPlayer.vb
    'Open FormGame.vb
    'set me to invisible
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