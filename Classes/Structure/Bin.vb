''' <summary>
''' DataType representing 1 bin with 1 article through string().
''' </summary>
Public Class bin
	Private stringPathBin As String
	Private stringPathItem As String = "Nothing"
	Private stringFileItem As String = "Nothing"
	Private stringName As String
	Private integerQuantity As Integer = 0
	Private integerPrice As Integer = 0
	
	Private fileHandler As New binaryFileHandler
	Private stringDataBin() As String
	Private stringDataItem() As String
''' <summary>
''' Resizes stringDataBin to 3 (PathItem, FileItem, Quantity, Price).
''' </summary>
	Public Sub New()
		ReDim stringDataBin(3)
	End Sub
''' <summary>
''' Get/Adjust the path of the Bin without ItemLoad().
''' </summary>
	Public Property BinPath As String
		Get
			Return stringPathBin
		End Get
		Set (Value As String)
			stringPathBin = Value
		End Set
	End Property
''' <summary>
''' Loads Bin and Item Data.
''' </summary>
''' <param name="PathShelf">Needed for path and file seperation.</param>
	Public Sub ItemLoad(PathShelf As String)
		stringDataBin = fileHandler.LoadRow(PathShelf, stringPathBin.Remove(0, PathShelf.Length))
		stringPathItem = stringDataBin(0)
		stringFileItem = stringDataBin(1)
		integerQuantity = CType(stringDataBin(2), Integer)
		integerPrice = CType(stringDataBin(3), Integer)
		
		If stringPathItem = "Nothing" then Exit Sub
		stringDataItem = fileHandler.LoadRow(stringPathItem, stringFileItem)
		stringName = stringDataItem(1).Split(New String() {".bd"}, System.StringSplitOptions.None)(0)
	End Sub
''' <summary>
''' Saves the Bin and loads the linked Item Data.
''' </summary>
''' <param name="PathShelf">Needed for path and file seperation.</param>
	Public Sub BinSave(PathShelf As String)
		stringDataBin(0) = stringPathItem
		stringDataBin(1) = stringFileItem
		stringDataBin(2) = CType(integerQuantity, String)
		stringDataBin(3) = CType(integerPrice, String)
		fileHandler.Save(PathShelf, stringPathBin.Remove(0, PathShelf.Length), , stringDataBin)
		
		If stringFileItem = "Nothing" then Exit Sub
		stringDataItem = fileHandler.LoadRow(stringPathItem, stringFileItem)
		stringName = stringDataItem(1).Split(New String() {".bd"}, System.StringSplitOptions.None)(0)
	End Sub
''' <summary>
''' Get/Adjust the path of the Item Data without ItemLoad() or BinSave().
''' </summary>
	Public Property ItemPath As String
		Get
			Return stringPathItem
		End Get
		Set (Value As String)
			stringPathItem = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the Filename of the Item Data without ItemLoad() or BinSave().
''' </summary>
	Public Property ItemFile As String
		Get
			Return stringFileItem
		End Get
		Set (Value As String)
			stringFileItem = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the Quantity without BinSave().
''' </summary>
	Public Property Quantity As Integer
		Get
			Return integerQuantity
		End Get
		Set (Value As Integer)
			integerQuantity = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the Price without BinSave().
''' </summary>
	Public Property Price As Integer
		Get
			Return integerPrice
		End Get
		Set (Value As Integer)
			integerPrice = Value
		End Set
	End Property
End Class