''' <summary>
''' All Character Variables are retrieved/stored here.
''' </summary>
Public Class character
	Private iniFileHandler As New iniHandler()
	Dim stringCharacterData(,) As String
''' <summary>
''' Retrieves Character Variables.
''' </summary>
	Friend Sub New()
		
	End Sub
''' <summary>
''' Creates a new Character file.
''' </summary>
	Friend Sub NewCharacter(CharacterInfo() As String)
		stringCharacterData = New String(,) {{"[Character Information]", "<World>", "0", "<Country>", "0", "<Place>", "0", "<Store>", "0", "<Balance>", "25", "<TotalSpendings>", "0", "<TotalEarnings>", "0", "<TotalItemsSold>", "0", "<TotalItemsBought>", "0", "<TotalDayCycles>", "0", "<TotalPlayTime>", "0", "<CreateDate>", CharacterInfo(0), "<CreateTime>", CharacterInfo(1)}}
		'Start Writing New Profile
		SaveState()
	End Sub
''' <summary>
''' Loads a Profile Statistics.
''' </summary>
	Friend Sub LoadCharacter()
		stringCharacterData = iniFilehandler.Load(System.IO.Directory.GetCurrentDirectory & "\save\" & gamecache.settingsGlobal.LastProfile & "\character.pd")
	End Sub
''' <summary>
''' Searches in stringCharacterData for requested Setting and set/returns that value.
''' </summary>
''' <param name="InformationRequest">Requested information as String. And saves when Set.</param>
''' <returns></returns>
	Private Property ReturnValue(InformationRequest As String) As String
		Get
			Dim integerColumn As Integer = 0
			Dim integerRow As Integer = 0
			Do
				Do
					If stringCharacterData(integerColumn, integerRow).Contains(InformationRequest) Then
						Return stringCharacterData(integerColumn, integerRow + 1)
						Exit Property
					End If
					integerRow += 1
				Loop Until integerRow > stringCharacterData.GetUpperBound(1)
				integerColumn += 1
			Loop Until integerColumn > stringCharacterData.GetUpperBound(0)
			Return ""
		End Get
		
		Set(Value As String)
			Dim integerColumn As Integer = 0
			Dim integerRow As Integer = 0
			Do
				Do
					If stringCharacterData(integerColumn, integerRow).Contains(InformationRequest) Then
						stringCharacterData(integerColumn, integerRow + 1) = Value
						SaveState()
						Exit Property
					End If
					integerRow += 1
				Loop Until integerRow > stringCharacterData.GetUpperBound(1)
				integerColumn += 1
			Loop Until integerColumn > stringCharacterData.GetUpperBound(0)
		End Set
	End Property
''' <summary>
''' Saves the current state of the Profile Statistics data.
''' </summary>
	Public Sub SaveState()
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\" & gamecache.settingsGlobal.LastProfile)
		iniFilehandler.Save(System.IO.Directory.GetCurrentDirectory & "\save\" & gamecache.settingsGlobal.LastProfile & "\character.pd", stringCharacterData)
	End Sub
''' <summary>
''' Returns a String with the current World.
''' </summary>
	Public Property CurrentWorld As String
		Get
			Return ReturnValue("World")
		End Get
		Set(Value As String)
			ReturnValue("World") = Value
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns a String with the current Country.
''' </summary>
	Public Property CurrentCountry As String
		Get
			Return ReturnValue("Country")
		End Get
		Set(Value As String)
			ReturnValue("Country") = Value
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns a String with the current Place.
''' </summary>
	Public Property CurrentPlace As String
		Get
			Return ReturnValue("Place")
		End Get
		Set(Value As String)
			ReturnValue("Place") = Value
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns a String with the current Store.
''' </summary>
	Public Property CurrentStore As String
		Get
			Return ReturnValue("Store")
		End Get
		Set(Value As String)
			ReturnValue("Store") = Value
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns an Integer with the current balance.
''' </summary>
	Public Property Balance As Integer
		Get
			Return CType(ReturnValue("Balance"), Integer)
		End Get
		Set(Value As Integer)
			ReturnValue("Balance") = Value.ToString
			SaveState()
		End Set
	End Property
	''' <summary>
''' Returns an Integer with the Total Spendings.
''' </summary>
	Public Property TotalSpendings As Integer
		Get
			Return CType(ReturnValue("TotalSpendings"), Integer)
		End Get
		Set(Value As Integer)
			ReturnValue("TotalSpendings") = Value.ToString
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Total Earnings.
''' </summary>
	Public Property TotalEarnings As Integer
		Get
			Return CType(ReturnValue("TotalEarnings"), Integer)
		End Get
		Set(Value As Integer)
			ReturnValue("TotalEarnings") = Value.ToString
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Total Items Sold.
''' </summary>
	Public Property TotalItemsSold As Integer
		Get
			Return CType(ReturnValue("TotalItemsSold"), Integer)
		End Get
		Set(Value As Integer)
			ReturnValue("TotalItemsSold") = Value.ToString
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Total Items Bought.
''' </summary>
	Public Property TotalItemsBought As Integer
		Get
			Return CType(ReturnValue("TotalItemsBought"), Integer)
		End Get
		Set(Value As Integer)
			ReturnValue("TotalItemsBought") = Value.ToString
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns an Integer with the current Total Day-Cycles.
''' </summary>
	Public Property TotalDayCycles As Integer
		Get
			Return CType(ReturnValue("TotalDayCycles"), Integer)
		End Get
		Set(Value As Integer)
			ReturnValue("TotalDayCycles") = Value.ToString
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Total Play-Time.
''' </summary>
	Public Property TotalPlayTime As Integer
		Get
			Return CType(ReturnValue("TotalPlayTime"), Integer)
		End Get
		Set(Value As Integer)
			ReturnValue("TotalPlayTime") = Value.ToString
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns a String with the Created Date.
''' </summary>
	Public Property CreateDate As String
		Get
			Return ReturnValue("CreateDate")
		End Get
		Set(Value As String)
			ReturnValue("CreateDate") = Value
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns a String with the Created Time.
''' </summary>
	Public Property CreateTime As String
		Get
			Return ReturnValue("CreateTime")
		End Get
		Set(Value As String)
			ReturnValue("CreateTime") = Value
			SaveState()
		End Set
	End Property
End Class
