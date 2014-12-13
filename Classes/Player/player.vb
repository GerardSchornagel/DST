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
	Private stringGender As String
	Private stringCreateDate As String
	Private stringCreateTime As String
	
''' <summary>
''' Initializes player class.
''' </summary>
	Friend Sub New()
		
	End Sub
''' <summary>
''' Loads or create a (blank) Profile.
''' </summary>
	Friend Sub Load(Template() As String)
		'Check for if file exists, if not create; else load.
		If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & cache.settingsGlobal.LastUser & "\player.pd") = False Then
			NewPlayer(Template)
			
		Else
			integerPlayerID = CType(cache.settingsGlobal.LastUser, Integer)
			ReDim stringPlayerData(9)
			stringPlayerData = filehandler.LoadRow(System.IO.Directory.GetCurrentDirectory & "\save\" & integerPlayerID & "\", "player.pd")
			
			'Write Private's
			stringNameNick = stringPlayerData(1)
			stringNameFirst = stringPlayerData(2)
			stringNameLast = stringPlayerData(3)
			integerBirthYear = CType(stringPlayerData(4), Integer)
			integerBirthMonth = CType(stringPlayerData(5), Integer)
			integerBirthDay = CType(stringPlayerData(6), Integer)
			stringGender = stringPlayerData(7)
			stringCreateDate = stringPlayerData(8)
			stringCreateTime = stringPlayerData(9)
		End If
	End Sub
''' <summary>
''' Creates a new player.
''' </summary>
	Public Sub NewPlayer(Template() As String)
		integerPlayerID = CType(cache.settingsGlobal.LastUser, Integer)
		ReDim stringPlayerData(9)
		stringPlayerData(0) = CType(integerPlayerID, String)
		stringPlayerData(1) = Template(1)
		stringPlayerData(2) = Template(2)
		stringPlayerData(3) = Template(3)
		stringPlayerData(4) = Template(4)
		stringPlayerData(5) = Template(5)
		stringPlayerData(6) = Template(6)
		stringPlayerData(7) = Template(7)
		stringPlayerData(8) = Template(8)
		stringPlayerData(9) = Template(9)
		'Start Writing New Player
		SaveState()
		'Write Private's
		stringNameNick = stringPlayerData(1)
		stringNameFirst = stringPlayerData(2)
		stringNameLast = stringPlayerData(3)
		integerBirthYear = CType(stringPlayerData(4), Integer)
		integerBirthMonth = CType(stringPlayerData(5), Integer)
		integerBirthDay = CType(stringPlayerData(6), Integer)
		stringGender = stringPlayerData(7)
		stringCreateDate = stringPlayerData(8)
		stringCreateTime = stringPlayerData(9)
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
''' Returns an String with the Gender
''' </summary>
	Public Property Gender As String
		Get
			Return stringGender
		End Get
		Set(Value As String)
			stringGender = Value
			stringPlayerData(7) = Value
		End Set
	End Property
''' <summary>
''' Returns a String with the profile creation date.
''' </summary>
	Public Property CreateDate As String
		Get
			Return stringCreateDate
		End Get
		Set(Value As String)
			stringCreateDate = Value
			stringPlayerData(8) = Value
		End Set
	End Property
''' <summary>
''' Returns a String with the profile creation time.
''' </summary>
	Public Property CreateTime As String
		Get
			Return stringCreateTime
		End Get
		Set(Value As String)
			stringCreateTime = Value
			stringPlayerData(9) = Value
		End Set
	End Property
End Class
