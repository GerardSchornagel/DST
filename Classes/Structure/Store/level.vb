''' <summary>
''' DataType representing any number of Shelf's as a Level().
''' </summary>
Public Class level
	Public Shared arrayShelf() As Shelf
	Private stringPathLevel As String
	Private integerShelfCounter As Integer
''' <summary>
''' Empty Sub.
''' </summary>
	Public Sub New()
		
	End Sub
''' <summary>
''' Get/Adjust the path of the Level without Initialize() and Load().
''' </summary>
	Public Property LevelPath As String
		Get
			Return stringPathLevel
		End Get
		Set (Value As String)
			stringPathLevel = Value
		End Set
	End Property
''' <summary>
''' Resizes arrayShelf() and fill with New Shelf's.
''' </summary>
	Public Sub ShelfInitialize()
		integerShelfCounter = 0
		ReDim arrayShelf(System.IO.Directory.GetDirectories(stringPathLevel, "*", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0))
		For Each folder As String In System.IO.Directory.GetDirectories(stringPathLevel, "*", System.IO.SearchOption.TopDirectoryOnly)
			arrayShelf(integerShelfCounter) = New Shelf
			arrayShelf(integerShelfCounter).ShelfPath = folder & "\"
			integerShelfCounter += 1
		Next
	End Sub
''' <summary>
''' Loads all Shelves with all Bin's with all Items.
''' </summary>
	Public Shared Sub ShelfLoad()
		For Each item As Shelf In arrayShelf
			item.ShelfInitialize()
			item.ShelfLoad()
		Next
	End Sub
''' <summary>
''' Adds a empty Level with 1 Shelf and 1 Bin containing 'Nothing'.
''' </summary>
	Public Sub ShelfAdd()
		Dim intCheck As Integer = 0
		Do
			If System.IO.Directory.Exists(stringPathLevel & "\" & intCheck) = False Then
				Exit Do
			End If
			intCheck += 1
		Loop
		ReDim Preserve arrayShelf(intCheck)
		System.IO.Directory.CreateDirectory(stringPathLevel & "\" & intCheck)
		arrayShelf(arrayShelf.GetUpperBound(0)) = New Shelf
		arrayShelf(arrayShelf.GetUpperBound(0)).ShelfPath = stringPathLevel & "\" & intCheck
	End Sub
End Class
