'Make this the Main Menu form
Public Class FormMain

  Friend Shared Sub Main(ByVal args() As String)
    System.Windows.Forms.Application.Run(New FormMain())
  End Sub 'Sub Main

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
    'open FormOptions
  End Sub

  Private Sub buttonQuit_Click(sender As Object, e As EventArgs) Handles buttonQuit.Click
    'ask for confirmation (add uncheck in FormOptions.vb>Messages
    'End
  End Sub

  Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
    'Load settings (LastGame, FormOptions)
  End Sub
End Class