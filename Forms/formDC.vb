Public Partial Class formDC
	Private RandomInteger As New Random
	Private stringItemSelected(,) As String
	Private stringItemOrder() As String
	
	Private integerCounterArticle As Integer
	Private integerCounterSearch As Integer
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
		
	Sub formItemManagementLoad(sender As Object, e As EventArgs)
		'Fill the first dropdown with the Store preset.
		comboboxFamily.Items.Clear()
		
		Dim stringDirectories() As String
		Dim stringMediator() As String
		stringDirectories = System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory & "\data\items\store\", "*", System.IO.SearchOption.TopDirectoryOnly)
		For Each directory As String In stringDirectories
			stringMediator = directory.Split(Chr(92))
			comboboxFamily.Items.Add(stringMediator(stringMediator.GetUpperBound(0)))
		Next
	End Sub
	
	Sub ComboboxFamilySelectedIndexChanged(sender As Object, e As EventArgs)
		'Loop through every file in the correspondending folder and add to listbox.
		comboboxCategory.Items.Clear()
		
		Dim stringDirectories() As String
		Dim stringMediator() As String
		stringDirectories = System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory & "\data\items\store\" & comboboxFamily.SelectedItem.ToString, "*", System.IO.SearchOption.TopDirectoryOnly)
		For Each directory As String In stringDirectories
			stringMediator = directory.Split(Chr(92))
			comboboxCategory.Items.Add(stringMediator(stringMediator.GetUpperBound(0)))
		Next
	End Sub
	
	Sub ComboboxCategorySelectedIndexChanged(sender As Object, e As EventArgs)
		'Loop through every file in the correspondending folder and add to listbox.
		comboboxGenre.Items.Clear()
		
		Dim stringDirectories() As String
		Dim stringMediator() As String
		stringDirectories = System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory & "\data\items\store\" & comboboxFamily.SelectedItem.ToString & "\" & comboboxCategory.SelectedItem.ToString, "*", System.IO.SearchOption.TopDirectoryOnly)
		For Each directory As String In stringDirectories
			stringMediator = directory.Split(Chr(92))
			comboboxGenre.Items.Add(stringMediator(stringMediator.GetUpperBound(0)))
		Next
	End Sub
	
	Sub ComboboxGenreSelectedIndexChanged(sender As Object, e As EventArgs)
		comboboxName.Items.Clear()
		
		Dim stringFiles() As String
		Dim stringMediator() As String
		stringFiles = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory & "\data\items\store\" & comboboxFamily.SelectedItem.ToString & "\" & comboboxCategory.SelectedItem.ToString & "\" & comboboxGenre.SelectedItem.ToString, "*", System.IO.SearchOption.TopDirectoryOnly)
		For Each file As String In stringFiles
			stringMediator = file.Split(Chr(92))
			comboboxName.Items.Add((stringMediator(stringMediator.GetUpperBound(0))).Remove(stringMediator(stringMediator.GetUpperBound(0)).Length - 4, 4))
		Next
	End Sub
	
	Sub ComboboxNameSelectedIndexChanged(sender As Object, e As EventArgs)
		'Check for miss-click
		If comboboxName.Text = "" Then Exit Sub
		Dim itemSelected As New item(System.IO.Directory.GetCurrentDirectory & "\data\items\store\" & comboboxFamily.SelectedItem.ToString & "\" & comboboxCategory.SelectedItem.ToString & "\" & comboboxGenre.Text & "\" & comboboxName.Text & ".ini")
		
		labelItemFamilyDisplay.Text = itemSelected.Family
		labelItemCategoryDisplay.Text = itemSelected.Category
		labelItemGenreDisplay.Text = itemSelected.Genre
		labelItemCompanyDisplay.Text = itemSelected.Company_Publisher
		labelItemBrandDisplay.Text = itemSelected.Brand_Author
		labelItemItemNameDisplay.Text = itemSelected.Name_Title
		
		labelStatisticsQualityDisplay.Text = itemSelected.Quality
		labelStatisticsPopularityDisplay.Text = itemSelected.Popularity
		labelStatisticsRarityDisplay.Text = itemSelected.Rarity
		labelStatisticsBaseWorthDisplay.Text = itemSelected.BaseWorth
		labelStatisticsItemTierDisplay.Text = itemSelected.ItemTier
		
		labelVariousPicturePathDisplay.Text = itemSelected.PictureFilename
		labelVariousDescriptionDisplay.Text = itemSelected.Description
		
		textboxBuyPrice.Text = CType(RandomInteger.Next(CType(CType(labelStatisticsBaseWorthDisplay.Text, Double) - (CType(labelStatisticsBaseWorthDisplay.Text, Double) * 0.50), Integer), CType(CType(labelStatisticsBaseWorthDisplay.Text, Double) + (CType(labelStatisticsBaseWorthDisplay.Text, Double) * 0.25), Integer)), String)
	End Sub
	
	Sub ButtonCloseClick(sender As Object, e As EventArgs)
		Me.Hide()
	End Sub
	
	Sub ButtonBuyClick(sender As Object, e As EventArgs)
		If textboxBuyAmount.Text = "" Then Exit Sub
		
		If gamecache.currentCharacterStatistics.Balance < CType(textboxPriceTotal.Text, Integer) Then MsgBox("Not enough balance.")
		
		If gamecache.currentCharacterStatistics.Balance >= CType(textboxPriceTotal.Text, Integer) Then
			MsgBox("You bought goods.")
			
			gamecache.currentCharacterStatistics.Balance -= CType(textboxPriceTotal.Text, Integer)
			gamecache.currentCharacterStatistics.TotalSpendings += CType(textboxPriceTotal.Text, Integer)
			'[Department]\[Genre]\[SubGenre]\[Itemname].ini
			'Get product-order into temponary String Array.
			ReDim stringItemOrder(4)
			stringItemOrder(0) = System.IO.Directory.GetCurrentDirectory & "\Data\Items\Store\" & labelItemFamilyDisplay.Text & "\" &  labelItemCategoryDisplay.Text & "\" & labelItemGenreDisplay.Text & "\" 'ItemPath
			stringItemOrder(1) = labelItemItemNameDisplay.Text & ".ini" 'ItemFile
			stringItemOrder(2) = textboxBuyAmount.Text 'Quantity
			stringItemOrder(3) = "0"'Last Selling Price
			stringItemOrder(4) = textboxBuyPrice.Text 'Last Buying Price
			
			integerCounterSearch = 0
			integerCounterArticle = 0
			Do
				If gamecache.currentCharacterStorage.arraySection(integerCounterSearch).arrayArticle Is Nothing Then Exit Do
				For Each Article As Article In gamecache.currentCharacterStorage.arraySection(integerCounterSearch).arrayArticle
					If Article.ItemLink.Name_Title = labelItemItemNameDisplay.Text Then
						gamecache.currentCharacterStorage.arraySection(integerCounterSearch).arrayArticle(integerCounterArticle).Quantity += CType(stringItemOrder(2), Integer)
						gamecache.currentCharacterStorage.arraySection(integerCounterSearch).arrayArticle(integerCounterArticle).LastBuy = CType(stringItemOrder(4), Integer)
						gamecache.currentCharacterStorage.arraySection(integerCounterSearch).arrayArticle(integerCounterArticle).ArticleSave(gamecache.currentCharacterStorage.arraySection(integerCounterSearch).SectionPath)
						Exit Sub
					End If
					integerCounterArticle += 1
				Next
				integerCounterArticle = 0
				integerCounterSearch += 1
			Loop Until integerCounterSearch >= gamecache.currentCharacterStorage.arraySection.GetUpperBound(0)
			
			gamecache.currentCharacterStorage.arraySection(0).ArticleAdd(stringItemOrder)
		End If
	End Sub
	
	Sub TextBoxBuyAmountTextChanged(sender As Object, e As EventArgs)
		If textboxBuyAmount.Text = "" Then Exit Sub
		textboxPriceTotal.Text = CType(CType(textboxBuyAmount.Text, Integer) * CType(textboxBuyPrice.Text, Integer), String)
	End Sub
End Class