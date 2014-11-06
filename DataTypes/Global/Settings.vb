	''' <summary>
	''' Global Settings for the game, most will be handled from the Main Menu.
	''' </summary>
Public Class settings
	Private intLastUser As Integer = 0

	Private bolMessagesProgramQuit As Boolean = False 'Asks if Exiting the Program is true
	Private bolMessagesNewgameOverwrite As Boolean = False 'Inform about overwrite of Load Last Game
	Private bolMessagesOptionsApplyrestart As Boolean = False 'Inform about restart of Game

	Private strBinaryFileData As String = "" 'Used as temponary string-storage
	Sub New()
		'Check for existing settings.prd
		if System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\settings.prd") = False Then SaveState()
		'Get all info from File
		strBinaryFileData = ""
		Using binReader As New System.IO.BinaryReader(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\settings.prd", System.IO.FileMode.Open))
			Do
				strBinaryFileData += (Chr(binReader.ReadInt32))
			Loop Until binReader.PeekChar = Nothing
		End Using
		'Split raw data in String-Array
		Dim arraySettings As String() = strBinaryFileData.Split(New String() {"<>"}, StringSplitOptions.None)
		'Write Private's
		intLastUser = CType(arraySettings(0), Integer)
		bolMessagesProgramQuit = CType(arraySettings(1), Boolean)
		bolMessagesNewgameOverwrite = CType(arraySettings(2), Boolean)
		bolMessagesOptionsApplyrestart = CType(arraySettings(3), Boolean)
	End Sub 'Sub New
	''' <summary>
	''' Saves all changes made to Global Settings.
	''' </summary>
	Private Sub SaveState()
		'Check for directory and create if false.
		if System.IO.Directory.Exists(System.IO.Directory.GetCurrentDirectory & "\save") = False Then System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save")
		'Make Raw data String
		strBinaryFileData = CType(intLastUser, String)
		strBinaryFileData += "<>" & bolMessagesProgramQuit
		strBinaryFileData += "<>" & bolMessagesNewgameOverwrite
		strBinaryFileData += "<>" & bolMessagesOptionsApplyrestart

		'Fill Array for character per character progressing
		Dim arrayInt32(strBinaryFileData.Length) As Int32
		Dim intDimension As Integer = 0
		For Each character As Char In strBinaryFileData
			arrayInt32(intDimension) = Asc(character)
			intDimension += 1
		Next
		
		Using binWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\settings.prd", System.IO.FileMode.Create))
			For Each integer32 As Int32 In arrayInt32
				binWriter.Write(integer32)
			Next
		End Using
	End Sub 'Sub SaveState

'--------PROPERTY'S---------
''' <summary>
''' An Integer representing the last player that has played, it is corresponding with the number in the save directory.
''' </summary>
	Public Property LastUser As Integer
		Get
			Return intLastUser
		End Get
		Set(Value As Integer)
			intLastUser = Value
			SaveState()
		End Set
	End Property 'Property LastUser
''' <summary>
''' The warning message when quitting the program.
''' </summary>
	Public Property MessagesProgramQuit As Boolean
		Get
			Return bolMessagesProgramQuit
		End Get
		Set(Value As Boolean)
			bolMessagesProgramQuit = Value
			SaveState()
		End Set
	End Property 'Property MessagesProgramQuit
''' <summary>
''' Warning message that the last player ID will be overwritten, in Alpha stage this means you lose your prev. game.
''' </summary>
	Public Property MessagesNewgameOverwrite As Boolean
		Get
			Return bolMessagesNewgameOverwrite
		End Get
		Set(Value As Boolean)
			bolMessagesNewgameOverwrite = Value
			SaveState()
		End Set
	End Property 'Property MessagesNewgameOverwrite
''' <summary>
''' Message if there are options are choosen via the main menu, the program has to be restarted.
''' </summary>
	Public Property MessagesOptionsApplyrestart As Boolean
		Get
			Return bolMessagesOptionsApplyrestart
		End Get
		Set(Value As Boolean)
			bolMessagesOptionsApplyrestart = Value
			SaveState()
		End Set
	End Property 'Property MessagesOptionsApplyrestart
End Class