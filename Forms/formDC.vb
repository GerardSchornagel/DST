Public Partial Class formDC
	Private filehandler As New binaryFileHandler()
	Private stringPathItem As String = System.IO.Directory.GetCurrentDirectory & "\Data\Items\"
	Private arrayDataFile As String
	Private arrayItemSelected() As String
	Private stringItemOrder() As String
	Private integerCounterArticle As Integer
	Private integerCounterSearch As Integer
	
	Private RandomInteger As New Random
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	' filename = [Department]\[Genre]\[Category]\[Itemname].pd
	' filedata = Department<>Genre<>GenreSub<>Article<>Manufactor<>Itemname<>WorthBase<>Quality
	
	Sub formItemManagementLoad(sender As Object, e As EventArgs)
		'Fill the dropdown's with the standard template (for now hard-coded, later through a *.pd with it's own class for communications.)
		'	'For this function make a cache with all data loaded into it, this should make it more searchable too.
		
		' Restaurant; Services
		comboboxDepartment.Items.Add("Store")
		
		' AnimalCare; AudioVisual; Bathroom; Bedroom; Candy; Clothing; Cosmetics; Decorative; Kitchenware; MajorDomesticAppliances; Media; SmallDomesticAppliances; Toy
		comboboxGenre.Items.Add("Office")
		
		comboboxCategory.Items.Add("Supplies")
	End Sub
	
	Sub ComboboxDepartmentSelectedIndexChanged(sender As Object, e As EventArgs)
		'ComboboxProductName.Items.Clear()		
		'Loop through every file in the correspondending folder and add to listbox.
		'StringPathProducts & Department
	End Sub
	
	Sub ComboboxGenreSelectedIndexChanged(sender As Object, e As EventArgs)
		'ComboboxProductName.Items.Clear()		
		'Loop through every file in the correspondending folder and add to listbox.
		'StringPathProducts & Department & "\" & Genre
	End Sub
	
	Sub ComboboxCategorySelectedIndexChanged(sender As Object, e As EventArgs)
		comboboxName.Items.Clear()
		
		'Loop through every file in the correspondending folder and add to listbox.
		For Each file In System.IO.Directory.GetFiles(stringPathItem & "Store\Office\" & comboboxCategory.Text & "\", "*", System.IO.SearchOption.TopDirectoryOnly)
			comboboxName.Items.Add(CType((file.Remove(file.Length - 3, 3)).Remove(0, stringPathItem.Length + (CType("Store\Office\Supplies\", String).Length)), String))
		Next
	End Sub
	
	Sub ComboboxNameSelectedIndexChanged(sender As Object, e As EventArgs)
		'Check for mis-click
		If comboboxName.Text = "" Then Exit Sub
		arrayItemSelected = filehandler.LoadRow(stringPathItem & "Store\Office\Supplies\", comboboxName.Text & ".pd")
				
		labelDepartmentDisplay.Text = arrayItemSelected(0)
		labelGenreDisplay.Text = arrayItemSelected(1)
		labelGenreSubDisplay.Text = arrayItemSelected(2)
		labelCategoryDisplay.Text = arrayItemSelected(3)
		labelManufactorerDisplay.Text = arrayItemSelected(4)
		labelItemDisplay.Text = arrayItemSelected(5)
		labelWorthBaseDisplay.Text = arrayItemSelected(6)
		labelQualityDisplay.Text = arrayItemSelected(7)
		
		textboxBuyPrice.Text = CType(RandomInteger.Next(CType(CType(labelWorthBaseDisplay.Text, Double) - (CType(labelWorthBaseDisplay.Text, Double) * 0.50), Integer), CType(CType(labelWorthBaseDisplay.Text, Double) + (CType(labelWorthBaseDisplay.Text, Double) * 0.25), Integer)
		), String)
	End Sub
	
	Sub ButtonCloseClick(sender As Object, e As EventArgs)
		Me.Hide()
	End Sub
	
	Sub ButtonBuyClick(sender As Object, e As EventArgs)
		If textboxBuyAmount.Text = "" Then Exit Sub
		
		If cache.playerCharacter.Balance < CType(textboxPriceTotal.Text, Integer) Then MsgBox("Not enough balance.")
		
		If cache.playerCharacter.Balance >= CType(textboxPriceTotal.Text, Integer) Then
			MsgBox("Your bought goods.")
			
			cache.playerCharacter.Balance -= CType(textboxPriceTotal.Text, Integer)
			
			'[Department]\[Genre]\[SubGenre]\[Itemname].pd
			'Get product-order into temponary String Array.
			ReDim stringItemOrder(4)
			stringItemOrder(0) = System.IO.Directory.GetCurrentDirectory & "\Data\Items\" & labelDepartmentDisplay.Text & "\" &  labelGenreDisplay.Text & "\" & labelGenreSubDisplay.Text & "\" 'ItemPath
			stringItemOrder(1) = labelItemDisplay.Text & ".pd" 'ItemFile
			stringItemOrder(2) = textboxBuyAmount.Text 'Quantity
			stringItemOrder(3) = "0"'Last Selling Price
			stringItemOrder(4) = textboxBuyPrice.Text 'Last Buying Price
			
			integerCounterSearch = 0
			integerCounterArticle = 0
			Do
				If cache.playerStorage.arraySection(integerCounterSearch).arrayArticle Is Nothing Then Exit Do
				For Each Article As article In cache.playerStorage.arraySection(integerCounterSearch).arrayArticle
					If Article.ItemName = labelItemDisplay.Text Then
						cache.playerStorage.arraySection(integerCounterSearch).arrayArticle(integerCounterArticle).Quantity += CType(stringItemOrder(2), Integer)
						cache.playerStorage.arraySection(integerCounterSearch).arrayArticle(integerCounterArticle).LastBuy = CType(stringItemOrder(4), Integer)
						cache.playerStorage.arraySection(integerCounterSearch).arrayArticle(integerCounterArticle).ArticleSave(cache.playerStorage.arraySection(integerCounterSearch).SectionPath)
						Exit Sub
					End If
					integerCounterArticle += 1
				Next
				integerCounterArticle = 0
				integerCounterSearch += 1
			Loop Until integerCounterSearch >= cache.playerStorage.arraySection.GetUpperBound(0)
			
			cache.playerStorage.arraySection(0).ArticleAdd(stringItemOrder)
		End If
	End Sub
	
	Sub TextboxBuyAmountTextChanged(sender As Object, e As EventArgs)
		If textboxBuyAmount.Text = "" Then Exit Sub
		textboxPriceTotal.Text = CType(CType(textboxBuyAmount.Text, Integer) * CType(textboxBuyPrice.Text, Integer), String)
	End Sub
End Class