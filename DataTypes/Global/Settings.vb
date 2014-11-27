''' <summary>
''' Global Settings for the game, most will be handled from the Main Menu.
''' </summary>
Public Class settings
	Private filehandler As New binaryFileHandler()
	Private stringSettings() As String
	
	Private stringLastUser As String
	Private booleanMessagesProgramQuit As Boolean = False 'Asks if Exiting the Program is true
	Private booleanMessagesNewgameOverwrite As Boolean = False 'Inform about overwrite of Load Last Game
	Private booleanMessagesOptionsApplyrestart As Boolean = False 'Inform about restart of Game
''' <summary>
''' If exists it loads the GlobalSetting, else it create default.
''' </summary>
	Sub New()
		If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\settings.pd") = False Then
			stringSettings = New String() {"0", "False", "False", "False"}
			SaveState()
		Else
			stringSettings = filehandler.LoadRow(System.IO.Directory.GetCurrentDirectory & "\save\", "settings.pd")
		End If
		'Write Private's
		stringLastUser = stringSettings(0)
		booleanMessagesProgramQuit = CType(stringSettings(1), Boolean)
		booleanMessagesNewgameOverwrite = CType(stringSettings(2), Boolean)
		booleanMessagesOptionsApplyrestart = CType(stringSettings(3), Boolean)
	End Sub
''' <summary>
''' Saves all changes made to Global Settings.
''' </summary>
	Public Sub SaveState()
		filehandler.Save(System.IO.Directory.GetCurrentDirectory & "\save\", "settings.pd", , stringSettings)
	End Sub
''' <summary>
''' Updates LastUserID to nearest free number in save directory.
''' </summary>
	Public Sub NewPlayer()
	'Look for nearest free number in save directory
		Dim intCheck As Integer = 0
		Do
			If System.IO.Directory.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & intCheck) = False Then
				Exit Do
			End If
			intCheck += 1
		Loop
		stringLastUser = CType(intCheck, String)
		SaveState()
	End Sub
''' <summary>
''' An Integer representing the last player that has played, it is corresponding with the number in the save directory.
''' </summary>
	Public Property LastUser As String
		Get
			Return stringLastUser
		End Get
		Set(Value As String)
			stringLastUser = CType(Value, String)
			stringSettings(0) = Value
		End Set
	End Property
''' <summary>
''' The warning message when quitting the program.
''' </summary>
	Public Property MessagesProgramQuit As Boolean
		Get
			Return booleanMessagesProgramQuit
		End Get
		Set(Value As Boolean)
			booleanMessagesProgramQuit = Value
			stringSettings(1) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Warning message that the last player ID will be overwritten, in Alpha stage this means you lose your prev. game.
''' </summary>
	Public Property MessagesNewgameOverwrite As Boolean
		Get
			Return booleanMessagesNewgameOverwrite
		End Get
		Set(Value As Boolean)
			booleanMessagesNewgameOverwrite = Value
			stringSettings(2) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Message if there are options are choosen via the main menu, the program has to be restarted.
''' </summary>
	Public Property MessagesOptionsApplyrestart As Boolean
		Get
			Return booleanMessagesOptionsApplyrestart
		End Get
		Set(Value As Boolean)
			booleanMessagesOptionsApplyrestart = Value
			stringSettings(3) = CType(Value, String)
		End Set
	End Property
End Class