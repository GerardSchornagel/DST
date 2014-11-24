''' <summary>
''' Get or Set the current Player data.
''' </summary>
Public Class player
	Private filehandler As New binaryFileHandler()
	Dim stringPlayerData() As String
	
	Private integerPlayerID As Integer
	Private stringNameNick As String
	Private stringNameFirst As String
	Private stringNameLast As String
	Private integerBirthYear As Integer
	Private integerBirthMonth As Integer
	Private integerBirthDay As Integer
	Private integerGender As Integer
	Private stringCurrentLocation As String
	Private stringCurrentStore As String
	Private integerCurrentLevel As Integer
	Private integerCurrentShelf As Integer
''' <summary>
''' Retrieves Player Variables.
''' </summary>
''' <param name="PlayerID">Use "New" for creation, otherwise GlobalSettings.LastUser.</param>
''' <param name="Template">New String() {PlayerID, NickName, FirstName, LastName, BirthYear, BirthMonth, BirthDay, Gender(0=F;1=M), Current Location, Current Store, CurrentLevel, CurrentShelf}</param>
	Friend Sub New(PlayerID As String, Optional Template() as String = Nothing)
		'Check for New parameter.
		If PlayerID = "New" Then
			NewPlayer(Template)
			
		Else
			integerPlayerID = CType(PlayerID, Integer)
			ReDim stringPlayerData(11)
			stringPlayerData = filehandler.LoadRow(System.IO.Directory.GetCurrentDirectory & "\save\" & integerPlayerID & "\", "player.pd")
			
			'Write Private's
			stringNameNick = stringPlayerData(1)
			stringNameFirst = stringPlayerData(2)
			stringNameLast = stringPlayerData(3)
			integerBirthYear = CType(stringPlayerData(4), Integer)
			integerBirthMonth = CType(stringPlayerData(5), Integer)
			integerBirthDay = CType(stringPlayerData(6), Integer)
			integerGender = CType(stringPlayerData(7), Integer)
			stringCurrentLocation = stringPlayerData(8)
			stringCurrentStore = stringPlayerData(9)
			integerCurrentLevel = CType(stringPlayerData(10), Integer)
			integerCurrentShelf = CType(stringPlayerData(11), Integer)
		End If
	End Sub
''' <summary>
''' Creates a new player through given template.
''' </summary>
''' <param name="Template">Pass through from Sub New()</param>
	Public Sub NewPlayer(ByVal Template() As String)
		ReDim stringPlayerData(11)
		Array.Copy(Template, stringPlayerData, Template.GetUpperBound(0))
		integerPlayerID = CType(stringPlayerData(0), Integer)
		stringNameNick = stringPlayerData(1)
		stringNameFirst = stringPlayerData(2)
		stringNameLast = stringPlayerData(3)
		integerBirthYear = CType(stringPlayerData(4), Integer)
		integerBirthMonth = CType(stringPlayerData(5), Integer)
		integerBirthDay = CType(stringPlayerData(6), Integer)
		integerGender = CType(stringPlayerData(7), Integer)
		stringCurrentLocation = stringPlayerData(8)
		stringCurrentStore = stringPlayerData(9)
		integerCurrentLevel = CType(stringPlayerData(10), Integer)
		integerCurrentShelf = CType(stringPlayerData(11), Integer)
		'Start Writing New Player
		SaveState()
	End Sub
''' <summary>
''' Saves the current state of the Player data.
''' </summary>
	Public Sub SaveState()
		filehandler.Save(System.IO.Directory.GetCurrentDirectory & "\Save\" & integerPlayerID & "\", "player.pd", , stringPlayerData)
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
			stringPlayerData(0) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns a String with the Nick name.
''' </summary>
	Public Property NickName As String
		Get
			Return stringNameNick
		End Get
		Set(Value As String)
			stringNameNick = Value
			stringPlayerData(1) = Value
		End Set
	End Property
''' <summary>
''' Returns a String with the First name.
''' </summary>
	Public Property FirstName As String
		Get
			Return stringNameFirst
		End Get
		Set(Value As String)
			stringNameFirst = Value
			stringPlayerData(2) = Value
		End Set
	End Property
''' <summary>
''' Returns a String with the Last name.
''' </summary>
	Public Property LastName As String
		Get
			Return stringNameLast
		End Get
		Set(Value As String)
			stringNameLast = Value
			stringPlayerData(3) = Value
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Birth Year.
''' </summary>
	Public Property BirthYear As Integer
		Get
			Return integerBirthYear
		End Get
		Set(Value As Integer)
			integerBirthYear = Value
			stringPlayerData(4) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Birth Month.
''' </summary>
	Public Property BirthMonth As Integer
		Get
			Return integerBirthMonth
		End Get
		Set(Value As Integer)
			integerBirthMonth = Value
			stringPlayerData(5) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Birth Day.
''' </summary>
	Public Property BirthDay As Integer
		Get
			Return integerBirthDay
		End Get
		Set(Value As Integer)
			integerBirthDay = Value
			stringPlayerData(6) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Gender (0=F 1=M)
''' </summary>
	Public Property Gender As Integer
		Get
			Return integerGender
		End Get
		Set(Value As Integer)
			integerGender = Value
			stringPlayerData(7) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns a String with the current location.
''' </summary>
	Public Property CurrentLocation As String
		Get
			Return stringCurrentLocation
		End Get
		Set(Value As String)
			stringCurrentLocation = Value
			stringPlayerData(8) = Value
		End Set
	End Property
''' <summary>
''' Returns an Integer with the current store.
''' </summary>
	Public Property CurrentStore As String
		Get
			Return stringCurrentStore
		End Get
		Set(Value As String)
			stringCurrentStore = Value
			stringPlayerData(9) = Value
		End Set
	End Property
''' <summary>
''' Returns an Integer with the current department level.
''' </summary>
	Public Property CurrentLevel As Integer
		Get
			Return integerCurrentLevel
		End Get
		Set(Value As Integer)
			integerCurrentLevel = Value
			stringPlayerData(10) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns an Integer with the current Shelf.
''' </summary>
	Public Property CurrentShelf As Integer
		Get
			Return integerCurrentShelf
		End Get
		Set(Value As Integer)
			integerCurrentShelf = Value
			stringPlayerData(11) = CType(Value, String)
		End Set
	End Property
End Class
