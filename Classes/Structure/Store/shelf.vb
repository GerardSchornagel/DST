''' <summary>
''' DataType representing any number of Bin's as a Shelf().
''' </summary>
Public Class shelf
	Public Shared arrayBin() As Bin
	Private stringPathShelf As String
	Private integerBinCounter As Integer
''' <summary>
''' Empty Sub.
''' </summary>
	Public Sub New()
		
	End Sub
''' <summary>
''' Get/Adjust the path of the Shelf without Initialize() and Load().
''' </summary>
	Public Property ShelfPath As String
		Get
			Return stringPathShelf
		End Get
		Set (Value As String)
			stringPathShelf = Value
		End Set
	End Property
''' <summary>
''' Resize arrayBin and fill with New Bin's.
''' </summary>
	Public Sub ShelfInitialize()
		integerBinCounter = 0
		ReDim arrayBin(System.IO.Directory.GetFiles(stringPathShelf, "*.ini", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0))
		For Each file As String In System.IO.Directory.GetFiles(stringPathShelf, "*.ini", System.IO.SearchOption.TopDirectoryOnly)
			arrayBin(integerBinCounter) = New Bin
			arrayBin(integerBinCounter).BinPath = file
			integerBinCounter += 1
		Next
	End Sub
''' <summary>
''' Loads all Bin's with Item Info.
''' </summary>
	Public Sub ShelfLoad()
		For Each item As Bin In arrayBin
			item.BinLoad(stringPathShelf)
		Next
	End Sub
''' <summary>
''' Makes new Bin with the given template.
''' </summary>
''' <param name="ArticleInfo">New String() {LinkStorage, LinkSection, LinkArticle, Quantity}</param>
	Public Sub BinAdd(ArticleInfo() As String)
		Dim intCheck As Integer = 0
		Do
			If System.IO.File.Exists(stringPathShelf & "\" & intCheck & ".ini") = False Then
				Exit Do
			End If
			intCheck += 1
		Loop
		ReDim Preserve arrayBin(intCheck)
		arrayBin(arrayBin.GetUpperBound(0)) = New Bin
		arrayBin(arrayBin.GetUpperBound(0)).BinPath = stringPathShelf & "\"
		arrayBin(arrayBin.GetUpperBound(0)).BinFile = intCheck & ".ini"
		arrayBin(arrayBin.GetUpperBound(0)).LinkStorage = CType(ArticleInfo(0), Integer)
		arrayBin(arrayBin.GetUpperBound(0)).LinkSection = CType(ArticleInfo(1), Integer)
		arrayBin(arrayBin.GetUpperBound(0)).LinkArticle = CType(ArticleInfo(2), Integer)
		arrayBin(arrayBin.GetUpperBound(0)).BinQuantity = CType(ArticleInfo(3), Integer)
		
		arrayBin(arrayBin.GetUpperBound(0)).BinSave(stringPathShelf)
	End Sub
End Class
