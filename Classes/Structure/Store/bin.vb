''' <summary>
''' DataType representing 1 bin with 1 article through string().
''' </summary>
Public Class bin
	Private stringBinPath As String = "Nothing"
	Private stringBinFile As String = "Nothing"
	Private stringLinkPath As String = "Nothing"
	Private stringLinkFile As String = "Nothing"
	Private integerLinkStorage As Integer = 0
	Private integerLinkSection As Integer = 0
	Private integerLinkArticle As Integer = 0
	Private integerBinQuantity As Integer = 0
	
	Private fileHandler As New binaryFileHandler
	Private stringBinData() As String
''' <summary>
''' Resizes stringDataBin to 3 (LinkStorage, LinkSection, LinkArticle, Quantity).
''' </summary>
	Public Sub New()
		ReDim stringBinData(3)
	End Sub
''' <summary>
''' Loads Bin and Item Data.
''' </summary>
''' <param name="PathShelf">Needed for path and file seperation.</param>
	Public Sub BinLoad(PathShelf As String)
		stringBinData = fileHandler.LoadRow(PathShelf, stringBinFile)
		integerLinkStorage = CType(stringBinData(0), Integer)
		integerLinkSection = CType(stringBinData(1), Integer)
		integerLinkArticle = CType(stringBinData(2), Integer)
		integerBinQuantity = CType(stringBinData(3), Integer)
		
		stringLinkPath = gamecache.playerStorage.arraySection(integerLinkSection).arrayArticle(integerLinkArticle).ArticlePath
		stringLinkFile = gamecache.playerStorage.arraySection(integerLinkSection).arrayArticle(integerLinkArticle).ArticleFile
	End Sub
''' <summary>
''' Saves the Bin and loads the linked Item Data.
''' </summary>
''' <param name="PathShelf">Needed for path and file seperation.</param>
	Public Sub BinSave(PathShelf As String)
		stringBinData(0) = CType(integerLinkStorage, String)
		stringBinData(1) = CType(integerLinkSection, String)
		stringBinData(2) = CType(integerLinkArticle, String)
		stringBinData(3) = CType(integerBinQuantity, String)
		fileHandler.Save(PathShelf, stringBinFile, , stringBinData)
		
		stringLinkPath = gamecache.playerStorage.arraySection(integerLinkSection).arrayArticle(integerLinkArticle).ArticlePath
		stringLinkFile = gamecache.playerStorage.arraySection(integerLinkSection).arrayArticle(integerLinkArticle).ArticleFile
	End Sub
''' <summary>
''' Get/Adjust the path of the Bin without ItemLoad().
''' </summary>
	Public Property BinPath As String
		Get
			Return stringBinPath
		End Get
		Set (Value As String)
			stringBinPath = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the filename of the Bin without ItemLoad().
''' </summary>
	Public Property BinFile As String
		Get
			Return stringBinFile
		End Get
		Set (Value As String)
			stringBinFile = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the Storage linked for this Bin.
''' </summary>
	Public Property LinkStorage As Integer
		Get
			Return integerLinkStorage
		End Get
		Set (Value As Integer)
			integerLinkStorage = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the Section linked for this Bin.
''' </summary>
	Public Property LinkSection As Integer
		Get
			Return integerLinkSection
		End Get
		Set (Value As Integer)
			integerLinkSection = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the Article linked for this Bin.
''' </summary>
	Public Property LinkArticle As Integer
		Get
			Return integerLinkArticle
		End Get
		Set (Value As Integer)
			integerLinkArticle = Value
		End Set
	End Property
''' <summary>
''' Get/Adjust the Quantity without BinSave().
''' </summary>
	Public Property BinQuantity As Integer
		Get
			Return integerBinQuantity
		End Get
		Set (Value As Integer)
			integerBinQuantity = Value
		End Set
	End Property
	''' <summary>
	''' Get the Item Name from Linked Article.
	''' </summary>
	ReadOnly Public Property ArticleName As String
		Get
			Return gamecache.playerStorage.arraySection(integerLinkSection).arrayArticle(integerLinkArticle).ItemLink.Name_Title
		End Get
	End Property
	''' <summary>
	''' Get the Last Selling price from Linked Article.
	''' </summary>
	ReadOnly Public Property ArticleLastSell As Integer
		Get
			Return gamecache.playerStorage.arraySection(integerLinkSection).arrayArticle(integerLinkArticle).LastSell
		End Get
	End Property
End Class