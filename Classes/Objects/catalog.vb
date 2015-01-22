''' <summary>
''' Description of form/class/etc.
''' </summary>
Public Class catalog
	Private itemDatabase() As item
	Private itemCurrent As item
	Public Sub New()
		
	End Sub
	
	'Conains an array all items.
	Public Sub LoadDatabase()
		Dim stringItemPaths() As String
		stringItemPaths = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory & "\data\items\store", "*.ini",  System.IO.SearchOption.AllDirectories)
		ReDim itemDatabase(stringItemPaths.GetUpperBound(0))
		
		Dim integerEntry As Integer = 0
		For Each itempath As String In stringItemPaths
			itemDatabase(integerEntry) = New item(itempath)
			integerEntry += 1
		Next
	End Sub
	
	'Get return with Family,Category,Genre,Name
	Public Function GetItem(Family As String, Category As String, Genre As String, Name As String) As item
		For Each article As item In itemDatabase
			If article.Family = Family AndAlso article.Category = Category AndAlso article.Genre = Genre AndAlso article.Name_Title = Name Then
				'Get article to itemCurrent & Return.
				itemCurrent = article
				Return article
				Exit Function
			End If
		Next
		MsgBox("No such item in database." & Chr(13) & Family & " - " & Category & " - " & Genre & " - " & Name)
		Return Nothing
	End Function
End Class
