''' <summary>
''' Get or Set the current Player data.
''' </summary>
Public Class player
	Private intID As Integer = 99 'Passed on from parent
	Private strNameNick As String = "Nick Name" 'User generated
	Private strNameFirst As String = "First Name" 'User generated
	Private strNameLast As String = "Last Name" 'User generated
	Private intBirthYear As Integer = 2000 'User generated
	Private intBirthMonth As Integer = 1 'User generated
	Private intBirthDay As Integer = 1 'User generated
	Private intGender As Integer = 1 'User generated (0=F 1=M)

	Private strBinaryFileData As String = ""

	Friend Sub New(PlayerID As Integer)
		intID = PlayerID
		'See if a new file has to be created with defaults
		If System.IO.Directory.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & intID) = False then System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\" & intID)
		If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\player.pd") = False Then SaveState()
		strBinaryFileData = ""
		'Get all info from File
		Using binReader As New System.IO.BinaryReader(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\player.pd", System.IO.FileMode.Open))
			Do
				strBinaryFileData += (Chr(binReader.ReadInt32))
			Loop Until binReader.PeekChar = Nothing
		End Using
		'Split info into string-array
		Dim arrayPlayerData As String() = strBinaryFileData.Split(New String() {"<>"}, StringSplitOptions.None)
		'Write Private's
		strNameNick = arrayPlayerData(0)
		strNameFirst = arrayPlayerData(1)
		strNameLast = arrayPlayerData(2)
		intBirthYear = CType(arrayPlayerData(3), Integer)
		intBirthMonth = CType(arrayPlayerData(4), Integer)
		intBirthDay = CType(arrayPlayerData(5), Integer)
		intGender = CType(arrayPlayerData(6), Integer)
	End Sub
''' <summary>
''' Saves the current state of the Player data.
''' </summary>
	Private Sub SaveState()
		'Make Raw data String
		strBinaryFileData = strNameNick
		strBinaryFileData += "<>" & strNameFirst
		strBinaryFileData += "<>" & strNameLast
		strBinaryFileData += "<>" & intBirthYear
		strBinaryFileData += "<>" & intBirthMonth
		strBinaryFileData += "<>" & intBirthDay
		strBinaryFileData += "<>" & intGender

		'Fill Array for character per character progressing
		Dim arrayInt32(strBinaryFileData.Length) As Int32
		Dim intDimension As Integer = 0
		For Each character As Char In strBinaryFileData
			arrayInt32(intDimension) = Asc(character)
			intDimension += 1
		Next
		' Create the BinaryWriter and use File.Create to create the file.
		Using binWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\Save\" & intID & "\player.pd", System.IO.FileMode.Create))
			For Each integer32 As Int32 In arrayInt32
				binWriter.Write(integer32)
			Next
		End Using
	End Sub 'Sub SaveState
''' <summary>
''' Returns an Integer with the Player ID.
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
''' Returns a String with the Nick name.
''' </summary>
	Public Property NickName As String
		Get
			Return strNameNick
		End Get
		Set(Value As String)
			strNameNick = Value
			SaveState()
		End Set
	End Property 'Property NickName
''' <summary>
''' Returns a String with the First name.
''' </summary>
	Public Property FirstName As String
		Get
			Return strNameFirst
		End Get
		Set(Value As String)
			strNameFirst = Value
			SaveState()
		End Set
	End Property 'Property FirstName
''' <summary>
''' Returns a String with the Last name.
''' </summary>
	Public Property LastName As String
		Get
			Return strNameLast
		End Get
		Set(Value As String)
			strNameLast = Value
			SaveState()
		End Set
	End Property 'Property LastName
''' <summary>
''' Returns an Integer with the Birth Year.
''' </summary>
	Public Property BirthYear As Integer
		Get
			Return intBirthYear
		End Get
		Set(Value As Integer)
			intBirthYear = Value
			SaveState()
		End Set
	End Property 'Property BirthYear
''' <summary>
''' Returns an Integer with the Birth Month.
''' </summary>
	Public Property BirthMonth As Integer
		Get
			Return intBirthMonth
		End Get
		Set(Value As Integer)
			intBirthMonth = Value
			SaveState()
		End Set
	End Property 'Property BirthMonth
''' <summary>
''' Returns an Integer with the Birth Day.
''' </summary>
	Public Property BirthDay As Integer
		Get
			Return intBirthDay
		End Get
		Set(Value As Integer)
			intBirthDay = Value
			SaveState()
		End Set
	End Property 'Property BirthDay
''' <summary>
''' Returns an Integer with the Gender (0=F 1=M)
''' </summary>
	Public Property Gender As Integer
		Get
			Return intGender
		End Get
		Set(Value As Integer)
			intGender = Value
			SaveState()
		End Set
	End Property 'Property Gender
End Class
