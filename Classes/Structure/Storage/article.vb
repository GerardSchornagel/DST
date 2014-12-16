''' <summary>
''' DataType representing 1 item with 1 article through string().
''' </summary>
Public Class article	
	Private stringArticlePath As String = "Nothing"
	Private stringArticleFile As String = "Nothing"
	Private stringItemPath As String = "Nothing"
	Private stringItemFile As String = "Nothing"
	Private integerArticleQuantity As Integer = 0
	Private integerArticleLastSell As Integer = 0
	Private integerArticleLastBuy As Integer = 0
	Private stringItemName As String = "Nothing"
	
	Private fileHandler As New binaryFileHandler
	Private stringDataItem() As String
	Public stringDataArticle() As String = New String() {"Nothing", "Nothing", "0", "0", "0"}
''' <summary>
''' Resizes stringDataArticle to 4 (PathItem, FileItem, Quantity, LastSell, LastBuy).
''' </summary>
	Public Sub New()
		ReDim stringDataArticle(4)
	End Sub
''' <summary>
''' Loads Article and Item Data.
''' </summary>
''' <param name="PathShelf">Needed for path and file seperation.</param>
	Public Sub ArticleLoad(PathShelf As String)
		stringDataArticle = fileHandler.LoadRow(PathShelf, stringArticleFile)
		stringItemPath = stringDataArticle(0)
		stringItemFile = stringDataArticle(1)
		integerArticleQuantity = CType(stringDataArticle(2), Integer)
		integerArticleLastSell = CType(stringDataArticle(3), Integer)
		integerArticleLastBuy = CType(stringDataArticle(4), Integer)
		
		If stringItemPath = "Nothing" then Exit Sub
		stringDataItem = fileHandler.LoadRow(stringItemPath, stringItemFile)
		stringItemName = stringDataItem(5)
	End Sub
''' <summary>
''' Saves the item and loads the linked Item Data.
''' </summary>
''' <param name="PathShelf">Needed for path and file seperation.</param>
	Public Sub ArticleSave(PathShelf As String)
		stringDataArticle(0) = stringItemPath
		stringDataArticle(1) = stringItemFile
		stringDataArticle(2) = CType(integerArticleQuantity, String)
		stringDataArticle(3) = CType(integerArticleLastSell, String)
		stringDataArticle(4) = CType(integerArticleLastBuy, String)
		fileHandler.Save(PathShelf, stringArticleFile, , stringDataArticle)
		
		If stringItemPath = "Nothing" then Exit Sub
		stringDataItem = fileHandler.LoadRow(stringItemPath, stringItemFile)
		stringItemName = stringDataItem(5)
	End Sub
''' <summary>
''' Get/Adjust the path of the article in storage without ItemLoad().
''' </summary>
	Public Property ArticlePath As String
		Get
			Return stringArticlePath
		End Get
		Set (Value As String)
			stringArticlePath = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the filename of the article in storage without ItemLoad().
''' </summary>
	Public Property ArticleFile As String
		Get
			Return stringArticleFile
		End Get
		Set (Value As String)
			stringArticleFile = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the path of the Item Data without ItemLoad() or itemSave().
''' </summary>
	Public Property ItemPath As String
		Get
			Return stringItemPath
		End Get
		Set (Value As String)
			stringItemPath = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the Filename of the Item Data without ItemLoad() or itemSave().
''' </summary>
	Public Property ItemFile As String
		Get
			Return stringItemFile
		End Get
		Set (Value As String)
			stringItemFile = Value
		End Set
	End Property
''' <summary>
''' Get the Name of the Item Data.
''' </summary>
	Public Property ItemName As String
		Get
			Return stringItemName
		End Get
		Set (Value As String)
			stringItemName = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the Quantity without itemSave().
''' </summary>
	Public Property Quantity As Integer
		Get
			Return integerArticleQuantity
		End Get
		Set (Value As Integer)
			integerArticleQuantity = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the Last Sell without itemSave().
''' </summary>
	Public Property LastSell As Integer
		Get
			Return integerArticleLastSell
		End Get
		Set (Value As Integer)
			integerArticleLastSell = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the Last Buy without itemSave().
''' </summary>
	Public Property LastBuy As Integer
		Get
			Return integerArticleLastBuy
		End Get
		Set (Value As Integer)
			integerArticleLastBuy = Value
		End Set
	End Property
End Class