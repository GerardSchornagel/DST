''' <summary>
''' DataType representing any number of Level's as a Store().
''' </summary>
Public Class store
	Public Shared arrayLevel() As Level
	Private stringPathStore As String
	Private integerLevelCounter As Integer
''' <summary>
''' Empty Sub.
''' </summary>
Public Sub New()
'		'Use this code for creating first Store.
'		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\MyFirstStore")
'		playerStore.StorePath = System.IO.Directory.GetCurrentDirectory & "\MyFirstStore"
'		playerStore.LevelInitialize()
'		playerStore.LevelLoad()
'		playerStore.LevelAdd()
	End Sub
''' <summary>
''' Get/Adjust the path of the Store without Initialize() and Load().
''' </summary>
	Public Property StorePath As String
		Get
			Return stringPathStore
		End Get
		Set (Value As String)
			stringPathStore = Value
		End Set
	End Property
''' <summary>
''' Resizes arrayLevel and fill with New Level(s).
''' </summary>
	Public Sub LevelInitialize()
		integerLevelCounter = 0
		ReDim arrayLevel(System.IO.Directory.GetDirectories(stringPathStore, "*", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0))
		For Each folder As String In System.IO.Directory.GetDirectories(stringPathStore, "*", System.IO.SearchOption.TopDirectoryOnly)
			arrayLevel(integerLevelCounter) = New Level
			arrayLevel(integerLevelCounter).LevelPath = folder
			integerLevelCounter += 1
		Next
	End Sub
''' <summary>
''' Loads all Levels with all Shelves with all Bin's and all Item's.
''' </summary>
	Public Sub LevelLoad()
		For Each item As Level In arrayLevel
			item.ShelfInitialize()
			item.ShelfLoad()
		Next
	End Sub
''' <summary>
''' Adds a blank Level with 1 Shelf and 1 Bin containing 'Nothing'.
''' </summary>
	Public Sub LevelAdd()
		Dim intCheck As Integer = 0
		Do
			If System.IO.Directory.Exists(stringPathStore & "\" & intCheck) = False Then
				Exit Do
			End If
			intCheck += 1
		Loop
		ReDim Preserve arrayLevel(intCheck)
		System.IO.Directory.CreateDirectory(stringPathStore & "\" & intCheck)
		arrayLevel(arrayLevel.GetUpperBound(0)) = New Level
		arrayLevel(arrayLevel.GetUpperBound(0)).LevelPath = stringPathStore & "\" & intCheck
		arrayLevel(arrayLevel.GetUpperBound(0)).ShelfAdd()
	End Sub
End Class
