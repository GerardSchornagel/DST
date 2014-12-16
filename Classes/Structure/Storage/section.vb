''' <summary>
''' DataType representing any number of Item's as a section().
''' </summary>
Public Class section
	Public Shared arrayArticle() As Article
	Private stringPathSection As String
	Private integerArticleCounter As Integer
''' <summary>
''' Empty Sub.
''' </summary>
	Public Sub New()
		
	End Sub
''' <summary>
''' Get/Adjust the path of the section without Initialize() and Load().
''' </summary>
	Public Property SectionPath As String
		Get
			Return stringPathSection
		End Get
		Set (Value As String)
			stringPathSection = Value
		End Set
	End Property
''' <summary>
''' Resize arrayItem and fill with New Item's.
''' </summary>
	Public Sub SectionInitialize()
		integerArticleCounter = 0
		ReDim arrayArticle(System.IO.Directory.GetFiles(stringPathSection, "*.pd", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0))
		For Each file As String In System.IO.Directory.GetFiles(stringPathSection, "*.pd", System.IO.SearchOption.TopDirectoryOnly)
			arrayArticle(integerArticleCounter) = New Article
			arrayArticle(integerArticleCounter).ItemPath = file
			integerArticleCounter += 1
		Next
	End Sub
''' <summary>
''' Loads all Item's with Item Info.
''' </summary>
	Public Sub SectionLoad()
		For Each Article As Article In arrayArticle
			Article.ArticleLoad(stringPathSection)
		Next
	End Sub
''' <summary>
''' Makes new Article with the given template. With ArticleSave().
''' </summary>
''' <param name="ArticleInfo">New String() {ItemPath, ItemFile, Quantity, LastSell, LastBuy}</param>
	Public Sub ArticleAdd(ArticleInfo() As String)
		Dim intCheck As Integer = 0
		Do
			If System.IO.File.Exists(stringPathSection & "\" & intCheck & ".pd") = False Then
				Exit Do
			End If
			intCheck += 1
		Loop
		ReDim Preserve arrayArticle(intCheck)
		arrayArticle(arrayArticle.GetUpperBound(0)) = New Article
		arrayArticle(arrayArticle.GetUpperBound(0)).ArticlePath = stringPathSection & "\"
		arrayArticle(arrayArticle.GetUpperBound(0)).ArticleFile = intCheck & ".pd"
		arrayArticle(arrayArticle.GetUpperBound(0)).ItemPath = ArticleInfo(0)
		arrayArticle(arrayArticle.GetUpperBound(0)).ItemFile = ArticleInfo(1)
		arrayArticle(arrayArticle.GetUpperBound(0)).Quantity = CType(ArticleInfo(2), Integer)
		arrayArticle(arrayArticle.GetUpperBound(0)).LastSell = CType(ArticleInfo(3), Integer)
		arrayArticle(arrayArticle.GetUpperBound(0)).LastBuy = CType(ArticleInfo(4), Integer)
		arrayArticle(arrayArticle.GetUpperBound(0)).ArticleSave(stringPathSection)
	End Sub
End Class
