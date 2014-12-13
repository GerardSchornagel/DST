﻿''' <summary>
''' All Character Variables are retrieved/stored here.
''' </summary>
Public Class character
	Private filehandler As New binaryFileHandler()
	Dim stringCharacterData() As String
	
	Private integerPlayerID As Integer
	
	Private stringCurrentLocation As String
	Private stringCurrentStore As String
	
	Private integerBalance As Integer
	Private integerFinanceTotalEarned As Integer
	Private integerFinanceTotalSpent As Integer
	Private integerItemsTotalSold As Integer
	Private integerGlobalCycles As Integer
	Private stringDatesCreateDate As String
	Private stringDatesCreateTime As String
''' <summary>
''' Retrieves Character Variables.
''' </summary>
	Friend Sub New()
	
	End Sub
''' <summary>
''' Loads or create a (blank) Profile.
''' </summary>
	Public Sub Load()
		'Check for if file exists, if not create; else load.
		If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & cache.settingsGlobal.LastUser & "\character.pd") = False Then
		NewCharacter()
			
		Else
			integerPlayerID = CType(cache.settingsGlobal.LastUser, Integer)
			ReDim stringCharacterData(8)
			stringCharacterData = filehandler.LoadRow(System.IO.Directory.GetCurrentDirectory & "\save\" & integerPlayerID & "\", "character.pd")
			'Write Private's
			stringCurrentLocation = stringCharacterData(0)
			stringCurrentStore = stringCharacterData(1)
			
			integerBalance = CType(stringCharacterData(2), Integer)
			integerFinanceTotalEarned = CType(stringCharacterData(3), Integer)
			integerFinanceTotalSpent = CType(stringCharacterData(4), Integer)
			integerItemsTotalSold = CType(stringCharacterData(5), Integer)
			integerGlobalCycles = CType(stringCharacterData(6), Integer)
			stringDatesCreateDate = stringCharacterData(7)
			stringDatesCreateTime = stringCharacterData(8)
		End If
	End Sub
''' <summary>
''' Creates a new Character.
''' </summary>
	Public Sub NewCharacter()
		integerPlayerID = CType(cache.settingsGlobal.LastUser, Integer)
		ReDim stringCharacterData(8)
		stringCharacterData(0) = ""
		stringCharacterData(1) = ""
		stringCharacterData(2) = "100"
		stringCharacterData(3) = "0"
		stringCharacterData(4) = "0"
		stringCharacterData(5) = "0"
		stringCharacterData(6) = "0"
		stringCharacterData(7) = ""
		stringCharacterData(8) = ""
		'Start Writing New Player
		SaveState()
		Load()
	End Sub
''' <summary>
''' Saves the current state of character.vb Variables to file.
''' </summary>
	Public Sub SaveState()
		filehandler.Save(System.IO.Directory.GetCurrentDirectory & "\Save\" & integerPlayerID & "\", "character.pd", , stringCharacterData)
	End Sub
''' <summary>
''' Returns an Integer with the Player ID.
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
''' Returns a String with the current Location.
''' </summary>
	Public Property CurrentLocation As String
		Get
			Return stringCurrentLocation
		End Get
		Set(Value As String)
			stringCurrentLocation = Value
			stringCharacterData(0) = Value
		End Set
	End Property
''' <summary>
''' Returns a String with the current store.
''' </summary>
	Public Property CurrentStore As String
		Get
			Return stringCurrentStore
		End Get
		Set(Value As String)
			stringCurrentStore = Value
			stringCharacterData(1) = Value
		End Set
	End Property
''' <summary>
''' Returns an Integer with the current balance.
''' </summary>
	Public Property Balance As Integer
		Get
			Return integerBalance
		End Get
		Set(Value As Integer)
			integerBalance = Value
			stringCharacterData(2) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns an Integer with total character Earnings.
''' </summary>
	Public Property TotalEarnings As Integer
		Get
			Return integerFinanceTotalEarned
		End Get
		Set(Value As Integer)
			integerFinanceTotalEarned = Value
			stringCharacterData(3) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns an Integer with the total character Spendings.
''' </summary>
	Public Property TotalSpendings As Integer
		Get
			Return integerFinanceTotalSpent
		End Get
		Set(Value As Integer)
			integerFinanceTotalSpent = Value
			stringCharacterData(4) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns an Integer with the total character Item Sellings.
''' </summary>
	Public Property TotalItemsSold As Integer
		Get
			Return integerItemsTotalSold
		End Get
		Set(Value As Integer)
			integerItemsTotalSold = Value
			stringCharacterData(5) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns an Integer with total Day cycles.
''' </summary>
	Public Property TotalDayCycles As Integer
		Get
			Return integerGlobalCycles
		End Get
		Set(Value As Integer)
			integerGlobalCycles = Value
			stringCharacterData(6) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns a String with the creation date of the character.
''' </summary>
	Public Property CreateDate As String
		Get
			Return stringDatesCreateDate
		End Get
		Set(Value As String)
			stringDatesCreateDate = Value
			stringCharacterData(7) = Value
		End Set
	End Property
''' <summary>
''' Returns a String with the creation date of the character.
''' </summary>
	Public Property CreateTime As String
		Get
			Return stringDatesCreateTime
		End Get
		Set(Value As String)
			stringDatesCreateTime = Value
			stringCharacterData(8) = Value
		End Set
	End Property
End Class