''' <summary>
''' Get or Set the current Player Statistics.
''' </summary>
Public Class statistics
	Private filehandler As New binaryFileHandler()
	Dim stringStatisticsData() As String
	
	Private integerPlayerID As Integer
	Private integerGlobalCycles As Integer
	Private stringDatesCreateDate As String
	Private stringDatesCreateTime As String
	Private integerFinanceTotalEarned As Integer
	Private integerFinanceTotalSpent As Integer
	Private integerItemsTotalSold As Integer
''' <summary>
''' Retrieves Statistics Variables.
''' </summary>
''' <param name="PlayerID">Use "New" for creation, otherwise GlobalSettings.LastUser.</param>
''' <param name="Template">New String() {PlayerID, TotalCycles, CreateDate, CreateTime, TotalEarned, TotalSpent, TotalSold}.</param>
	Friend Sub New(PlayerID As String, Optional Template() As String = Nothing)
		'Check for New parameter.
		If PlayerID = "New" Then
			NewStatistics(Template)
			
		Else
			integerPlayerID = CType(PlayerID, Integer)
			ReDim stringStatisticsData(5)
			stringStatisticsData = filehandler.LoadRow(System.IO.Directory.GetCurrentDirectory & "\save\" & integerPlayerID & "\", "statistics.pd")
			'Write Private's
			integerGlobalCycles = CType(stringStatisticsData(0), Integer)
			stringDatesCreateDate = stringStatisticsData(1)
			stringDatesCreateTime = stringStatisticsData(2)
			integerFinanceTotalEarned = CType(stringStatisticsData(3), Integer)
			integerFinanceTotalSpent = CType(stringStatisticsData(4), Integer)
			integerItemsTotalSold = CType(stringStatisticsData(5), Integer)
	End If
End Sub
''' <summary>
''' Creates new Statistics Data and SaveState()
''' </summary>
''' <param name="Template">Pass through from Sub New()</param>
	Public Sub NewStatistics(ByVal Template() As String)
		integerPlayerID = CType(Template(0), Integer)
		ReDim stringStatisticsData(5)
		Array.ConstrainedCopy(Template, 1, stringStatisticsData, 0, Template.GetUpperBound(0))
		integerGlobalCycles = CType(stringStatisticsData(0), Integer)
		stringDatesCreateDate = stringStatisticsData(1)
		stringDatesCreateTime = stringStatisticsData(2)
		integerFinanceTotalEarned = CType(stringStatisticsData(3), Integer)
		integerFinanceTotalSpent = CType(stringStatisticsData(4), Integer)
		integerItemsTotalSold = CType(stringStatisticsData(5), Integer)
		'Start Writing New Statistics
		SaveState()
	End Sub
''' <summary>
''' Saves the current state of the Player Statistics Variables.
''' </summary>
	Private Sub SaveState()
		filehandler.Save(System.IO.Directory.GetCurrentDirectory & "\Save\" & integerPlayerID & "\", "statistics.pd", , stringStatisticsData)
	End Sub
''' <summary>
''' Returns an Integer with the current Player ID.
''' </summary>
	Public Property PlayerID As Integer
		Get
			Return integerPlayerID
		End Get
		Set(Value As Integer)
			integerPlayerID = Value
		End Set
	End Property
''' <summary>
''' Returns an Integer with the total Day Cycles.
''' </summary>
	Public Property TotalDayCycles As Integer
		Get
			Return integerGlobalCycles
		End Get
		Set(Value As Integer)
			integerGlobalCycles = Value
			stringStatisticsData(0) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns a String with the Creation Date "24-09-1985"
''' </summary>
	Public Property CreationDate As String
		Get
			Return stringDatesCreateDate
		End Get
		Set(Value As String)
			stringDatesCreateDate = Value
			stringStatisticsData(1) = Value
		End Set
	End Property
''' <summary>
''' Returns a String with the Creation Time "20:15:29".
''' </summary>
	Public Property CreationTime As String
		Get
			Return stringDatesCreateTime
		End Get
		Set(Value As String)
			stringDatesCreateTime = Value
			stringStatisticsData(2) = Value
		End Set
	End Property
''' <summary>
''' Returns an Integer with the total lifetime earnings.
''' </summary>
	Public Property TotalEarnings As Integer
		Get
			Return integerFinanceTotalEarned
		End Get
		Set(Value As Integer)
			integerFinanceTotalEarned = Value
			stringStatisticsData(3) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns an Integer with the total lifetime Spending.
''' </summary>
	Public Property TotalSpent As Integer
		Get
			Return integerFinanceTotalSpent
		End Get
		Set(Value As Integer)
			integerFinanceTotalSpent = Value
			stringStatisticsData(4) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns an Integer with the total lifetime Items Sold.
''' </summary>
	Public Property TotalItemsSold As Integer
		Get
			Return integerItemsTotalSold
		End Get
		Set(Value As Integer)
			integerItemsTotalSold = Value
			stringStatisticsData(5) = CType(Value, String)
		End Set
	End Property
End Class
