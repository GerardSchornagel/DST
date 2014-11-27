''' <summary>
''' Description of form/class/etc.
''' </summary>
Public Class cacheGlobal
	Friend Shared settingsGlobal As New settings()
	Friend Shared playerProfile As New player()
	Friend Shared playerCharacter As New character()
	Friend Shared playerInventory As New inventory()
	

	Public Sub New()
		
	End Sub
	
	Public Sub initializePlayerProfile()
		playerProfile.Load()
	End Sub	
	
	Public Sub initializePlayerCharacter()
		playerCharacter.Load()
		playerInventory.Load()
	End Sub
	
	Public Sub initializeGameArea()
		'Store, etc.
	End Sub
	
End Class
