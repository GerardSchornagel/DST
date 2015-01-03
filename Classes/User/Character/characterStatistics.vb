''' <summary>
''' All Character Statistics Variables are retrieved/stored here.
''' </summary>
Public Class characterStatistics
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
	Friend Sub NewCharacterStatistics()
		stringCharacterData = New String(,) {{"[Character Statistics]", "<Balance>", "25", "<TotalSpendings>", "0", "<TotalEarnings>", "0", "<TotalItemsSold>", "0", "<TotalItemsBought>", "0", "<TotalDayCycles>", "0", "<TotalPlayTime>", "0"}}
		'Start Writing New Profile
		SaveState()
	End Sub
''' <summary>
''' Loads a Profile Statistics.
''' </summary>
	Friend Sub LoadCharacterStatistics()
		stringCharacterData = iniFilehandler.Load(System.IO.Directory.GetCurrentDirectory & "\save\" & gamecache.currentSettings.LastProfile & "\character\statistics.ini")
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
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\" & gamecache.currentSettings.LastProfile & "\character")
		iniFilehandler.Save(System.IO.Directory.GetCurrentDirectory & "\save\" & gamecache.currentSettings.LastProfile & "\character\statistics.ini", stringCharacterData)
	End Sub
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
End Class
