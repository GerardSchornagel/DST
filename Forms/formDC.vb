Public Partial Class formDC
	Private RandomInteger As New Random
	Private stringItemSelected(,) As String
	Private stringItemOrder() As String
	
	Private stringPathItem As String = System.IO.Directory.GetCurrentDirectory & "\Data\Items\"
	
	Private integerCounterArticle As Integer
	Private integerCounterSearch As Integer
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
		
	Sub formItemManagementLoad(sender As Object, e As EventArgs)
		'Fill the dropdown's with the standard template (for now hard-coded, later through a *.pd with it's own class for communications.)
		'	'For this function make a cache with all data loaded into it, this should make it more searchable too.
		
		' Restaurant; Services
		comboboxFamily.Items.Add("Office")
		
		' AnimalCare; AudioVisual; Bathroom; Bedroom; Candy; Clothing; Cosmetics; Decorative; Kitchenware; MajorDomesticAppliances; Media; SmallDomesticAppliances; Toy
		comboboxCategory.Items.Add("Supplies")
		
		comboboxGenre.Items.Add("Writing")
	End Sub
	
	Sub ComboboxFamilySelectedIndexChanged(sender As Object, e As EventArgs)
		'ComboboxProductName.Items.Clear()		
		'Loop through every file in the correspondending folder and add to listbox.
		'StringPathProducts & Department
	End Sub
	
	Sub ComboboxCategorySelectedIndexChanged(sender As Object, e As EventArgs)
		'ComboboxProductName.Items.Clear()		
		'Loop through every file in the correspondending folder and add to listbox.
		'StringPathProducts & Department & "\" & Genre
	End Sub
	
	Sub ComboboxGenreSelectedIndexChanged(sender As Object, e As EventArgs)
		comboboxName.Items.Clear()
		
		'Loop through every file in the correspondending folder and add to listbox.
		For Each file In System.IO.Directory.GetFiles(stringPathItem & "Store\Office\Supplies\" & comboboxGenre.Text & "\", "*.pd", System.IO.SearchOption.TopDirectoryOnly)
			comboboxName.Items.Add(CType((file.Remove(file.Length - 3, 3)).Remove(0, stringPathItem.Length + (CType("Store\Office\Supplies\Writing\", String).Length)), String))
		Next
	End Sub
	
	Sub ComboboxNameSelectedIndexChanged(sender As Object, e As EventArgs)
		'Check for miss-click
		If comboboxName.Text = "" Then Exit Sub
		Dim itemSelected As New item(stringPathItem & "Store\Office\Supplies\" & comboboxGenre.Text & "\" & comboboxName.Text & ".pd")
		
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
		
		If gamecache.playerCharacter.Balance < CType(textboxPriceTotal.Text, Integer) Then MsgBox("Not enough balance.")
		
		If gamecache.playerCharacter.Balance >= CType(textboxPriceTotal.Text, Integer) Then
			MsgBox("Your bought goods.")
			
			gamecache.playerCharacter.Balance -= CType(textboxPriceTotal.Text, Integer)
			
			'[Department]\[Genre]\[SubGenre]\[Itemname].pd
			'Get product-order into temponary String Array.
			ReDim stringItemOrder(4)
			stringItemOrder(0) = System.IO.Directory.GetCurrentDirectory & "\Data\Items\Store\" & labelItemFamilyDisplay.Text & "\" &  labelItemCategoryDisplay.Text & "\" & labelItemGenreDisplay.Text & "\" 'ItemPath
			stringItemOrder(1) = labelItemItemNameDisplay.Text & ".pd" 'ItemFile
			stringItemOrder(2) = textboxBuyAmount.Text 'Quantity
			stringItemOrder(3) = "0"'Last Selling Price
			stringItemOrder(4) = textboxBuyPrice.Text 'Last Buying Price
			
			integerCounterSearch = 0
			integerCounterArticle = 0
			Do
				If gamecache.playerStorage.arraySection(integerCounterSearch).arrayArticle Is Nothing Then Exit Do
				For Each Article As Article In gamecache.playerStorage.arraySection(integerCounterSearch).arrayArticle
					If Article.ItemLink.Name_Title = labelItemItemNameDisplay.Text Then
						gamecache.playerStorage.arraySection(integerCounterSearch).arrayArticle(integerCounterArticle).Quantity += CType(stringItemOrder(2), Integer)
						gamecache.playerStorage.arraySection(integerCounterSearch).arrayArticle(integerCounterArticle).LastBuy = CType(stringItemOrder(4), Integer)
						gamecache.playerStorage.arraySection(integerCounterSearch).arrayArticle(integerCounterArticle).ArticleSave(gamecache.playerStorage.arraySection(integerCounterSearch).SectionPath)
						Exit Sub
					End If
					integerCounterArticle += 1
				Next
				integerCounterArticle = 0
				integerCounterSearch += 1
			Loop Until integerCounterSearch >= gamecache.playerStorage.arraySection.GetUpperBound(0)
			
			gamecache.playerStorage.arraySection(0).ArticleAdd(stringItemOrder)
		End If
	End Sub
	
	Sub TextBoxBuyAmountTextChanged(sender As Object, e As EventArgs)
		If textboxBuyAmount.Text = "" Then Exit Sub
		textboxPriceTotal.Text = CType(CType(textboxBuyAmount.Text, Integer) * CType(textboxBuyPrice.Text, Integer), String)
	End Sub
End Class