''' <summary>
''' Get or Set the current Player Statistics data.
''' </summary>
Public Class playerStatistics
	Private iniFileHandler As New iniHandler()
	Dim stringStatisticsData(,) As String
''' <summary>
''' Initializes Profile Statistics class.
''' </summary>
	Friend Sub New()
		
	End Sub
''' <summary>
''' Creates a new Profile Statistics file.
''' </summary>
	Friend Sub NewPlayerStatistics(StatisticsInfo() As String)
		stringStatisticsData = New String(,) {{"[Player Statistics]", "<TotalCharacters>", "0", "<TotalSpendings>", "0", "<TotalEarnings>", "0", "<TotalPlayTime>", "0", "<CreateDate>", StatisticsInfo(0), "<CreateTime>", StatisticsInfo(1)}}
		'Start Writing New Profile
		SaveState()
	End Sub
''' <summary>
''' Loads a Profile Statistics.
''' </summary>
	Friend Sub LoadPlayerStatistics()
		stringStatisticsData = iniFilehandler.Load(System.IO.Directory.GetCurrentDirectory & "\save\" & gamecache.currentSettings.LastProfile & "\player\statistics.ini")
	End Sub
''' <summary>
''' Searches in stringStatisticsData for requested Setting and set/returns that value.
''' </summary>
''' <param name="InformationRequest">Requested information as String. And saves when Set.</param>
''' <returns></returns>
	Private Property ReturnValue(InformationRequest As String) As String
		Get
			Dim integerColumn As Integer = 0
			Dim integerRow As Integer = 0
			Do
				Do
					If stringStatisticsData(integerColumn, integerRow).Contains(InformationRequest) Then
						Return stringStatisticsData(integerColumn, integerRow + 1)
						Exit Property
					End If
					integerRow += 1
				Loop Until integerRow > stringStatisticsData.GetUpperBound(1)
				integerColumn += 1
			Loop Until integerColumn > stringStatisticsData.GetUpperBound(0)
			Return ""
		End Get
		
		Set(Value As String)
			Dim integerColumn As Integer = 0
			Dim integerRow As Integer = 0
			Do
				Do
					If stringStatisticsData(integerColumn, integerRow).Contains(InformationRequest) Then
						stringStatisticsData(integerColumn, integerRow + 1) = Value
						SaveState()
						Exit Property
					End If
					integerRow += 1
				Loop Until integerRow > stringStatisticsData.GetUpperBound(1)
				integerColumn += 1
			Loop Until integerColumn > stringStatisticsData.GetUpperBound(0)
		End Set
	End Property
''' <summary>
''' Saves the current state of the Profile Statistics data.
''' </summary>
	Public Sub SaveState()
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\" & gamecache.currentSettings.LastProfile & "\player")
		iniFilehandler.Save(System.IO.Directory.GetCurrentDirectory & "\save\" & gamecache.currentSettings.LastProfile & "\player\statistics.ini", stringStatisticsData)
	End Sub
''' <summary>
''' Returns/Sets an Integer with the Total Characters.
''' </summary>
	Public Property TotalCharacters As Integer
		Get
			Return CType(ReturnValue("TotalCharacters"), Integer)
		End Get
		Set(Value As Integer)
			ReturnValue("TotalCharacters") = Value.ToString
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns/Sets an Integer with the Total Spendings.
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
''' Returns/Sets an Integer with the Total Earnings.
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
''' Returns/Sets an Integer with the Total Play Time in Minutes.
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
''' Returns/Sets a String with the profile creation date.
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
''' Returns/Sets a String with the profile creation time.
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
