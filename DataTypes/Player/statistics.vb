''' <summary>
''' Get or Sets the current Player Statistics.
''' </summary>
Public Class statistics
	Private intID As Integer
	Private intGlobalSaved As Integer
	Private intGlobalHours As Integer
	Private intGlobalCycles As Integer
	Private strDatesCreateDate As String
	Private strDatesCreateTime As String
	Private intFinanceTotalEarned As Integer
	Private intFinanceTotalSpent As Integer
	Private intItemsTotalSold As Integer

	Private strBinaryFileData As String = ""
	''' <summary>
	''' Retrieves Statistics Variables.
	''' </summary>
	''' <param name="PlayerID">Use "New" for creation, otherwise GlobalSettings.LastUser.</param>
	''' <param name="Template">New String() {PlayerID, TotalSaves, TotalHours, TotalCycles, CreateDate, CreateTime, TotalEarned, TotalSpent, TotalSold}.</param>
	Friend Sub New(PlayerID As String, Optional Template As String() = Nothing)
		If PlayerID="New" Then
			NewStatistics(Template)
			Exit Sub
		End If
	intID = CType(PlayerID, Integer)
	'See if a new file has to be created with defaults
	If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\statistics.pd") = False Then SaveState()
	'Get all info from File
	Using binReader As New System.IO.BinaryReader(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\statistics.pd", System.IO.FileMode.Open))
		Do
			strBinaryFileData += (Chr(binReader.ReadInt32))
		Loop Until binReader.PeekChar = Nothing
	End Using
	'Split info into string-array
	Dim arrayStatisticsData As String() = strBinaryFileData.Split(New String() {"<>"}, StringSplitOptions.None)
	'Write Private's
	intGlobalSaved = CType(arrayStatisticsData(0), Integer)
	intGlobalHours = CType(arrayStatisticsData(1), Integer)
	intGlobalCycles = CType(arrayStatisticsData(2), Integer)
	strDatesCreateDate = arrayStatisticsData(3)
	strDatesCreateTime = arrayStatisticsData(4)
	intFinanceTotalEarned = CType(arrayStatisticsData(5), Integer)
	intFinanceTotalSpent = CType(arrayStatisticsData(6), Integer)
	intItemsTotalSold = CType(arrayStatisticsData(7), Integer)
End Sub 'Sub New
	''' <summary>
	''' Creates new Statistics Data and SaveState()
	''' </summary>
	Public Sub NewStatistics(ByVal StatisticsData() As String)
		intID = CType(StatisticsData(0), Integer)
		intGlobalSaved = CType(StatisticsData(1), Integer)
		intGlobalHours = CType(StatisticsData(2), Integer)
		intGlobalCycles = CType(StatisticsData(3), Integer)
		strDatesCreateDate = StatisticsData(4)
		strDatesCreateTime = StatisticsData(5)
		intFinanceTotalEarned = CType(StatisticsData(6), Integer)
		intFinanceTotalSpent = CType(StatisticsData(7), Integer)
		intItemsTotalSold = CType(StatisticsData(8), Integer)
		'Create the directory(s)
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\" & intID)
		'Start Writing New Statistics
		SaveState()
	End Sub
''' <summary>
''' Saves the current state of the Player Statistics Variables.
''' </summary>
	Private Sub SaveState()
		'Make Raw data String
		strBinaryFileData = CType(intGlobalSaved, String)
		strBinaryFileData += "<>" & intGlobalHours
		strBinaryFileData += "<>" & intGlobalCycles
		strBinaryFileData += "<>" & strDatesCreateDate
		strBinaryFileData += "<>" & strDatesCreateTime
		strBinaryFileData += "<>" & intFinanceTotalEarned
		strBinaryFileData += "<>" & intFinanceTotalSpent
		strBinaryFileData += "<>" & intItemsTotalSold

		'Fill Array for character per character progressing
		Dim arrayInt32(strBinaryFileData.Length) As Int32
		Dim intDimension As Integer = 0
		For Each character As Char In strBinaryFileData
			arrayInt32(intDimension) = Asc(character)
			intDimension += 1
		Next
		' Create the BinaryWriter and use File.Create to create the file.
		Using binWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\Save\" & intID & "\statistics.pd", System.IO.FileMode.Create))
			For Each integer32 As Int32 In arrayInt32
				binWriter.Write(integer32)
			Next
		End Using
	End Sub 'Sub SaveState
''' <summary>
''' Returns an Integer with the current Player ID.
''' </summary>
	Public Property PlayerID As Integer
		Get
			Return intID
		End Get
		Set(Value As Integer)
			intID = Value
			SaveState()
		End Set
	End Property 'Property PlayerID
''' <summary>
''' Returns an Integer with the total amount of saves.
''' </summary>
	Public Property TotalSaveTimes As Integer
		Get
			Return intGlobalSaved
		End Get
		Set(Value As Integer)
			intGlobalSaved = Value
			SaveState()
		End Set
	End Property 'Property TotalSaveTimes
''' <summary>
''' Returns an Integer with the total play hours.
''' </summary>
	Public Property TotalHoursPlayed As Integer
		Get
			Return intGlobalHours
		End Get
		Set(Value As Integer)
			intGlobalHours = Value
			SaveState()
		End Set
	End Property 'Property TotalHoursPlayed
''' <summary>
''' Returns an Integer with the total Day Cycles.
''' </summary>
	Public Property TotalDayCycles As Integer
		Get
			Return intGlobalCycles
		End Get
		Set(Value As Integer)
			intGlobalCycles = Value
			SaveState()
		End Set
	End Property 'Property TotalDayCycles
''' <summary>
''' Returns a String with the Creation Date "1985-09-24".
''' </summary>
	Public Property CreationDate As String
		Get
			Return strDatesCreateDate
		End Get
		Set(Value As String)
			strDatesCreateDate = Value
			SaveState()
		End Set
	End Property 'Property CreationDate
''' <summary>
''' Returns a String with the Creation Time "20:15".
''' </summary>
	Public Property CreationTime As String
		Get
			Return strDatesCreateTime
		End Get
		Set(Value As String)
			strDatesCreateTime = Value
			SaveState()
		End Set
	End Property 'Property CreationTime
''' <summary>
''' Returns an Integer with the total lifetime earnings.
''' </summary>
	Public Property TotalEarnings As Integer
		Get
			Return intFinanceTotalEarned
		End Get
		Set(Value As Integer)
			intFinanceTotalEarned = Value
			SaveState()
		End Set
	End Property 'Property TotalEarnings
''' <summary>
''' Returns an Integer with the total lifetime Spending.
''' </summary>
	Public Property TotalSpent As Integer
		Get
			Return intFinanceTotalSpent
		End Get
		Set(Value As Integer)
			intFinanceTotalSpent = Value
			SaveState()
		End Set
	End Property 'Property TotalSpent
''' <summary>
''' Returns an Integer with the total lifetime Items Sold.
''' </summary>
	Public Property TotalItemsSold As Integer
		Get
			Return intItemsTotalSold
		End Get
		Set(Value As Integer)
			intItemsTotalSold = Value
			SaveState()
		End Set
	End Property 'Property TotalItemsSold
End Class
