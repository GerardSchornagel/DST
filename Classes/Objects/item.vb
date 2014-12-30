''' <summary>
''' Item information handler
''' </summary>
Public Class item
	Private iniFilehandler As New iniHandler()
	Private stringFileName As String
	Private stringItem(,) As String	
	
''' <summary>
''' Loads the Item into the memory as String(,)
''' </summary>
	Sub New(FileName As String)
		stringFileName = FileName
		stringItem = iniFilehandler.Load(stringFileName)
	End Sub
''' <summary>
''' Searches in stringItem(,) for requested Setting and returns that value.
''' </summary>
''' <param name="SettingRequest">Requested Setting as String. And saves when Set.</param>
''' <returns></returns>
	Private ReadOnly Property ReturnValue(SettingRequest As String) As String
		Get
			Dim integerColumn As Integer = 0
			Dim integerRow As Integer = 0
			Do
				Do
					If stringItem(integerColumn, integerRow) = Nothing Then
					ElseIf stringItem(integerColumn, integerRow).Contains(SettingRequest) Then
						Return stringItem(integerColumn, integerRow + 1)
						Exit Property
					End If
					integerRow += 1
				Loop Until integerRow > stringItem.GetUpperBound(1)
				integerColumn += 1
				integerRow = 0
			Loop Until integerColumn > stringItem.GetUpperBound(0)
			Return ""
		End Get
	End Property
''' <summary>
''' A String representing the Description of the item. 1-Line String.
''' </summary>
	Public ReadOnly Property Description As String
		Get
			Return ReturnValue("Description")
		End Get
	End Property
''' <summary>
''' A String representing the Picture Path & Filename of the item.
''' </summary>
	Public ReadOnly Property PictureFileName As String
		Get
			Return ReturnValue("PictureFilename")
		End Get
	End Property
''' <summary>
''' A String representing the ItemTier of the item.
''' </summary>
	Public ReadOnly Property ItemTier As String
		Get
			Return ReturnValue("ItemTier")
		End Get
	End Property
''' <summary>
''' A String representing the BaseWorth of the item.
''' </summary>
	Public ReadOnly Property BaseWorth As String
		Get
			Return ReturnValue("BaseWorth")
		End Get
	End Property
''' <summary>
''' A String representing the Rarity of the item.
''' </summary>
	Public ReadOnly Property Rarity As String
		Get
			Return ReturnValue("Rarity")
		End Get
	End Property
''' <summary>
''' A String representing the Popularity of the item.
''' </summary>
	Public ReadOnly Property Popularity As String
		Get
			Return ReturnValue("Popularity")
		End Get
	End Property
''' <summary>
''' A String representing the Quality of the item.
''' </summary>
	Public ReadOnly Property Quality As String
		Get
			Return ReturnValue("Quality")
		End Get
	End Property
''' <summary>
''' A String representing the Family of the item.
''' </summary>
	Public ReadOnly Property Family As String
		Get
			Return ReturnValue("Family")
		End Get
	End Property
''' <summary>
''' A String representing the Category of the item.
''' </summary>
	Public ReadOnly Property Category As String
		Get
			Return ReturnValue("Category")
		End Get
	End Property
''' <summary>
''' A String representing the Genre of the item.
''' </summary>
	Public ReadOnly Property Genre As String
		Get
			Return ReturnValue("Genre")
		End Get
	End Property
''' <summary>
''' A String representing the Company/Publisher of the item.
''' </summary>
	Public ReadOnly Property Company_Publisher As String
		Get
			Return ReturnValue("Company/Publisher")
		End Get
	End Property
''' <summary>
''' A String representing the Brand/Author of the item.
''' </summary>
	Public ReadOnly Property Brand_Author As String
		Get
			Return ReturnValue("Brand/Author")
		End Get
	End Property
''' <summary>
''' A String representing the Name/Title of the item.
''' </summary>
	Public ReadOnly Property Name_Title As String
		Get
			Return ReturnValue("Name/Title")
		End Get
	End Property
End Class
