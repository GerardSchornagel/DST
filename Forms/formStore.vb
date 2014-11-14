Public Partial Class formStore
	Private stringPathItem As String = System.IO.Directory.GetCurrentDirectory & "\Data\Items\"
	Private arrayDataFile As String
	Private arrayItemSelected() As String
	Private arrayItemBought() As String
	
	Private RandomInteger As New Random
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	' filename = [Department]\[Genre]\[Category]\[Itemname].pd
	' filedata = Department<>Genre<>GenreSub<>Article<>Manufactor<>Itemname<>WorthBase<>Quality
	
	Sub FormStoreLoad(sender As Object, e As EventArgs)
		'Fill the dropdown's with the standard template (for now hard-coded, later through a *.prd with it's own class for communications.)
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
			comboboxName.Items.Add((New String(file.Remove(file.Length - 3, 3))).Remove(0, stringPathItem.Length + CType("Store\Office\Supplies\", String).Length))
		Next
	End Sub
	
	Sub ComboboxNameSelectedIndexChanged(sender As Object, e As EventArgs)
		'Check for mis-click
		If comboboxName.Text = "" Then Exit Sub
		
		arrayDataFile = ""
		Using binReader As New System.IO.BinaryReader(System.IO.File.Open(stringPathItem & "Store\Office\Supplies\" & comboboxName.Text & ".pd", System.IO.FileMode.Open))
			Do
				arrayDataFile += (Chr(binReader.ReadInt32))
			Loop Until binReader.PeekChar = Nothing
		End Using
		
		arrayItemSelected = arrayDataFile.Split(New String() {"<>"}, StringSplitOptions.None)
		
		labelDepartmentDisplay.Text = arrayItemSelected(0)
		labelGenreDisplay.Text = arrayItemSelected(1)
		labelGenreSubDisplay.Text = arrayItemSelected(2)
		labelCategoryDisplay.Text = arrayItemSelected(3)
		labelManufactorerDisplay.Text = arrayItemSelected(4)
		labelItemDisplay.Text = arrayItemSelected(5)
		labelWorthBaseDisplay.Text = arrayItemSelected(6)
		labelQualityDisplay.Text = arrayItemSelected(7)
		
		textboxBuyPrice.Text = CType(RandomInteger.Next(CType(CType(labelWorthBaseDisplay.Text, Double) - (CType(labelWorthBaseDisplay.Text, Double) * 0.25), Integer), CType(CType(labelWorthBaseDisplay.Text, Double) + (CType(labelWorthBaseDisplay.Text, Double) * 0.25), Integer)
		), String)
	End Sub
	
	Sub ButtonCloseClick(sender As Object, e As EventArgs)
		Me.Dispose()
	End Sub
	
	Sub ButtonBuyClick(sender As Object, e As EventArgs)
		If textboxBuyAmount.Text = "" Then Exit Sub
		
		If formStatus.classCharacter.Balance < CType(textboxPriceTotal.Text, Integer) Then MsgBox("Not enough balance.")
		
		If formStatus.classCharacter.Balance >= CType(textboxPriceTotal.Text, Integer) Then
			MsgBox("Your bought goods.")
			
			formStatus.classCharacter.Balance -= CType(textboxPriceTotal.Text, Integer)
			
			'Get product into order temponary String Array.
			ReDim arrayItemBought(3)
			arrayItemBought(0) = labelItemDisplay.Text 'Name
			arrayItemBought(1) = textboxBuyAmount.Text 'Amount
			arrayItemBought(2) = textboxBuyPrice.Text 'Last Buying Price
			arrayItemBought(3) = "0"'Last Selling Price
			
			Dim pos As Integer = 0
			Do Until formStatus.classInventory.GetInventorySpace(pos) Is Nothing
				'Add To existing record.
				If formStatus.classInventory.GetInventorySpace(pos)(0).Contains(comboboxName.Text) = True Then
					arrayItemBought(1) = CType((CType(formStatus.classInventory.GetInventorySpace(pos)(1), Integer) + CType(arrayItemBought(1), Integer)), String)
					formStatus.classInventory.GetInventorySpace(pos) = arrayItemBought
					Exit Sub
				End If
				pos += 1
			Loop
			'Make new record
			formStatus.classInventory.NewSlot(arrayItemBought)
		End If
	End Sub
	
	Sub TextboxBuyAmountTextChanged(sender As Object, e As EventArgs)
		textboxPriceTotal.Text = CType(CType(textboxBuyAmount.Text, Integer) * CType(textboxBuyPrice.Text, Integer), String)
	End Sub
End Class