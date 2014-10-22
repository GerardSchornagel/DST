Public Class formStatus
  Friend Shared classPlayer As New player(formMain.GlobalSettings.LastUser)
  Friend Shared classCharacter As New character()
  Friend Shared classInventory As New inventory()
  Friend Shared classStatistics As New statistics()

  'Load Player(Main info), Character, Inventory, Statistics
  Dim strPathSave As String = System.IO.Directory.GetCurrentDirectory & "\save\" & classPlayer.PlayerID & "\"

  Private Sub formStatus_Load(sender As Object, e As EventArgs) Handles Me.Load
    'formMain.GlobalSettings.LastUser
  End Sub
End Class