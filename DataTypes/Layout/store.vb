''' <summary>
''' Handles the Selecting and get/set functions for the Store Inventory.
''' </summary>
Public Class store
	Private filehandler As New binaryFileHandler()
	
	Private integerPlayerID As Integer
	Private stringCurrentLocation As String
	Private stringCurrentStore As String
	Private integerCurrentLevel As Integer
	Private integerCurrentShelf As Integer
	
	Private stringBuildPath As String
	Private stringCurrentBin() As String
	Private stringBuildShelf(,) As String
	Private integerCounterLoop As Integer
''' <summary>
''' Retrieves and Sets the current Store array.
''' </summary>
	Friend Sub New()
		integerPlayerID = cache.playerProfile.PlayerID
	End Sub
''' <summary>
''' Creates a new first player store.
''' </summary>
	Public Sub NewStore()
		'Make shelf with 9 bin's
		integerCounterLoop = 1
		ReDim stringCurrentBin(2)
		ReDim stringBuildShelf(8, 2)
		stringCurrentBin(0) = "Freebie Pen's"
		stringBuildShelf(0, 0) = stringCurrentBin(0)
		stringCurrentBin(1) = "25"
		stringBuildShelf(0, 1) = stringCurrentBin(1)
		stringCurrentBin(2) = "0"
		stringBuildShelf(0, 2) = stringCurrentBin(2)
		filehandler.Save(WorkingDir, 0 & ".bd", , stringCurrentBin)

		Do
			stringCurrentBin(0) = "Empty"
			stringBuildShelf(integerCounterLoop, 0) = stringCurrentBin(0)
			stringCurrentBin(1) = "0"
			stringBuildShelf(integerCounterLoop, 1) = stringCurrentBin(1)
			stringCurrentBin(2) = "0"
			stringBuildShelf(integerCounterLoop, 2) = stringCurrentBin(2)
			filehandler.Save(WorkingDir, integerCounterLoop & ".bd", , stringCurrentBin)
			integerCounterLoop += 1
		Loop Until integerCounterLoop > 8
	End Sub
	''' <summary>
	''' Loads the store corresponding to classPlayer.Current* Variable's.
	''' </summary>
	Public Sub LoadStore()
		'Get per Bin from Loop to stringBuildShelf
		ReDim stringBuildShelf(8, 2)
		integerCounterLoop = 0
		Do
			ReDim stringCurrentBin(2)
			stringCurrentBin = filehandler.LoadRow(WorkingDir, CType(integerCounterLoop, String) & ".bd")
			stringBuildShelf(integerCounterLoop, 0) = stringCurrentBin(0)
			stringBuildShelf(integerCounterLoop, 1) = stringCurrentBin(1)
			stringBuildShelf(integerCounterLoop, 2) = stringCurrentBin(2)
			integerCounterLoop += 1
		Loop Until integerCounterLoop > 8
	End Sub
''' <summary>
''' Saves the current state of the Store Inventory.
''' </summary>
	Public Sub SaveState()
		'Send per Bin from stringBuildShelf to filehandler.Save(Row)
		ReDim stringCurrentBin(2)
		integerCounterLoop = 0
		Do
			stringCurrentBin(0) = stringBuildShelf(integerCounterLoop, 0)
			stringCurrentBin(1) = stringBuildShelf(integerCounterLoop, 1)
			stringCurrentBin(2) = stringBuildShelf(integerCounterLoop, 2)
			
			filehandler.Save(WorkingDir, CType(integerCounterLoop, String) & ".bd", , stringCurrentBin)
			integerCounterLoop += 1
		Loop Until integerCounterLoop > 8
	End Sub
''' <summary>
''' Get or Sets the requested Bin to array.
''' </summary>
	Public Property getsetBin(Bin As Integer) As String()
		Get
			ReDim stringCurrentBin(2)
			stringCurrentBin(0) = stringBuildShelf(Bin, 0)
			stringCurrentBin(1) = stringBuildShelf(Bin, 1)
			stringCurrentBin(2) = stringBuildShelf(Bin, 2)
			Return stringCurrentBin
		End Get
		Set(Value() As String)
			stringBuildShelf(Bin, 0) = value(0)
			stringBuildShelf(Bin, 1) = value(1)
			stringBuildShelf(Bin, 2) = value(2)
		End Set
	End Property
	''' <summary>
	''' Gets the current Working directory.
	''' </summary>
	''' <returns>String</returns>
	Private Function WorkingDir() As String
		stringCurrentLocation = cache.playerCharacter.CurrentLocation
		stringCurrentStore = cache.playerCharacter.CurrentStore
		integerCurrentLevel = cache.playerCharacter.CurrentLevel
		integerCurrentShelf = cache.playerCharacter.CurrentShelf
		'ex.:C:\Users\Administrator\Saved Games\DST\save\PlayerID\Location\Store\Level\Shelf\
		Return System.IO.Directory.GetCurrentDirectory & "\save\" & integerPlayerID & "\" & stringCurrentLocation & "\" & stringCurrentStore & "\" & integerCurrentLevel & "\" & integerCurrentShelf & "\"
	End Function
End Class