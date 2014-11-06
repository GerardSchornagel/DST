''' <summary>
''' All Character Variables are retrieved/stored here.
''' Starting Variables are hard-coded here.
''' </summary>
Public Class character
	Private intID As Integer
	Private intBalance As Integer
	Private intGradeInventory As Integer
	Private intGradeShelf As Integer
	Private intGradePopularity As Integer

	Private strBinaryFileData As String = ""
	''' <summary>
	''' Retrieves Character Variables.
	''' </summary>
	''' <param name="PlayerID">Use "New" for creation, otherwise GlobalSettings.LastUser.</param>
	''' <param name="Template">New String() {PlayerID, Balance, GradeInventory, GradeShelf, GradePopularity}</param>
	Friend Sub New(PlayerID As String, Optional Template As String() = Nothing)
		If PlayerID="New" Then
			NewCharacter(Template)
			Exit Sub
		End If
		intID = CType(PlayerID, Integer)
		'See if a new file has to be created with defaults
		If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\character.pd") = False Then SaveState()

		'Get all info from File
		Using binReader As New System.IO.BinaryReader(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\character.pd", System.IO.FileMode.Open))
			Do
				strBinaryFileData += (Chr(binReader.ReadInt32))
			Loop Until binReader.PeekChar = Nothing
		End Using
		'Split info into string-array
		Dim arrayCharacterData As String() = strBinaryFileData.Split(New String() {"<>"}, StringSplitOptions.None)
		'Write Private's
		intBalance = CType(arrayCharacterData(0), Integer)
		intGradeInventory = CType(arrayCharacterData(1), Integer)
		intGradeShelf = CType(arrayCharacterData(2), Integer)
		intGradePopularity = CType(arrayCharacterData(3), Integer)
	End Sub
	''' <summary>
	''' Creates new Character Data and SaveState()
	''' </summary>
	Public Sub NewCharacter(ByVal CharacterData() As String)
		intID = CType(CharacterData(0), Integer)
		intBalance = CType(CharacterData(1), Integer)
		intGradeInventory = CType(CharacterData(2), Integer)
		intGradeShelf = CType(CharacterData(3), Integer)
		intGradePopularity = CType(CharacterData(4), Integer)
		'Create the directory(s)
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\" & intID)
		'Start Writing New Player
		SaveState()
	End Sub
	''' <summary>
	''' Saves the current state of character.vb Variables to file.
	''' </summary>
	Private Sub SaveState()
		'Make Raw data String
		strBinaryFileData = CType(intBalance, String)
		strBinaryFileData += "<>" & intGradeInventory
		strBinaryFileData += "<>" & intGradeShelf
		strBinaryFileData += "<>" & intGradePopularity

		'Fill Array for character per character progressing
		Dim arrayInt32(strBinaryFileData.Length) As Int32
		Dim intDimension As Integer = 0
		For Each character As Char In strBinaryFileData
			arrayInt32(intDimension) = Asc(character)
			intDimension += 1
		Next
		' Create the BinaryWriter and use File.Create to create the file.
		Using binWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\Save\" & intID & "\character.pd", System.IO.FileMode.Create))
			For Each integer32 As Int32 In arrayInt32
				binWriter.Write(integer32)
			Next
		End Using
	End Sub 'Sub SaveState
''' <summary>
''' Returns an Integer with the PlayerID.
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
''' Returns an Integer with the current balance.
''' </summary>
	Public Property Balance As Integer
		Get
			Return intBalance
		End Get
		Set(Value As Integer)
			intBalance = Value
			SaveState()
		End Set
	End Property 'Property Balance
''' <summary>
''' Returns an Integer with the Inventory Grade.
''' </summary>
	Public Property GradeInventory As Integer
		Get
			Return intGradeInventory
		End Get
		Set(Value As Integer)
			intGradeInventory = Value
			SaveState()
		End Set
	End Property 'Property GradeInventory
''' <summary>
''' Returns an Integer with the Shelf Grade.
''' </summary>
	Public Property GradeShelf As Integer
		Get
			Return intGradeShelf
		End Get
		Set(Value As Integer)
			intGradeShelf = Value
			SaveState()
		End Set
	End Property 'Property GradeShelf
''' <summary>
''' Returns an Integer with the Popularity Grade.
''' </summary>
	Public Property GradePopularity As Integer
		Get
			Return intGradePopularity
		End Get
		Set(Value As Integer)
			intGradePopularity = Value
			SaveState()
		End Set
	End Property 'Property GradePopularity
End Class
