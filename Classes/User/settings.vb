''' <summary>
''' Global Settings for the game, most will be handled from the Main Menu.
''' </summary>
Public Class settings
	Private iniFilehandler As New iniHandler()
	Private stringSettings(,) As String
''' <summary>
''' Create new Profile Settings Class.
''' </summary>
	Sub New()
		
	End Sub
''' <summary>
''' Makes a new Settings.ini in the Save directory.
''' </summary>
	Public Sub NewSettings()
			stringSettings = New String(,) {{"[WarningMessages]", "<LastProfileID>", "0", "<ProgramQuit>", "False", "<NewGameOverwrite>", "False", "<OptionsApplyRestart>", "False"}}
			SaveState()
	End Sub
''' <summary>
''' Loads a Settings file.
''' </summary>
	Public Sub LoadSettings()
		stringSettings = iniFilehandler.Load(System.IO.Directory.GetCurrentDirectory & "\save\settings.ini")
	End Sub
''' <summary>
''' Searches in stringSettings for requested Setting and set/returns that value.
''' </summary>
''' <param name="SettingRequest">Requested Setting as String. And saves when Set.</param>
''' <returns></returns>
	Public Property ReturnValue(SettingRequest As String) As String
		Get
			Dim integerColumn As Integer = 0
			Dim integerRow As Integer = 0
			Do
				Do
					If stringSettings(integerColumn, integerRow).Contains(SettingRequest) Then
						Return stringSettings(integerColumn, integerRow + 1)
						Exit Property
					End If
					integerRow += 1
				Loop Until integerRow > stringSettings.GetUpperBound(1)
				integerColumn += 1
			Loop Until integerColumn > stringSettings.GetUpperBound(0)
			Return ""
		End Get
		
		Set(Value As String)
			Dim integerColumn As Integer = 0
			Dim integerRow As Integer = 0
			Do
				Do
					If stringSettings(integerColumn, integerRow).Contains(SettingRequest) Then
						stringSettings(integerColumn, integerRow + 1) = Value
						SaveState()
						Exit Property
					End If
					integerRow += 1
				Loop Until integerRow > stringSettings.GetUpperBound(1)
				integerColumn += 1
			Loop Until integerColumn > stringSettings.GetUpperBound(0)
		End Set
	End Property
''' <summary>
''' Saves all changes made to Global Settings.
''' </summary>
	Private Sub SaveState()
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\")
		iniFilehandler.Save(System.IO.Directory.GetCurrentDirectory & "\save\settings.ini", stringSettings)
	End Sub
''' <summary>
''' A String representing the last Profile that has played, it is corresponding with the number in the save directory.
''' </summary>
	Public Property LastProfile As String
		Get
			Return ReturnValue("LastProfileID")
		End Get
		Set(Value As String)
			ReturnValue("LastProfileID") = Value
			SaveState()
		End Set
	End Property
''' <summary>
''' The warning message when quitting the program.
''' </summary>
	Public Property MessagesProgramQuit As Boolean
		Get
			Return CType(ReturnValue("ProgramQuit"), Boolean)
		End Get
		Set(Value As Boolean)
			ReturnValue("ProgramQuit") = Value.ToString
			SaveState()
		End Set
	End Property
''' <summary>
''' Warning message that the last Profile ID will be overwritten, in Alpha stage this means you lose your prev. game.
''' </summary>
	Public Property MessagesNewgameOverwrite As Boolean
		Get
			Return CType(ReturnValue("NewGameOverwrite"), Boolean)
		End Get
		Set(Value As Boolean)
			ReturnValue("NewGameOverwrite") = Value.ToString
			SaveState()
		End Set
	End Property
''' <summary>
''' Message if there are options are choosen via the main menu, the program has to be restarted.
''' </summary>
	Public Property MessagesOptionsApplyRestart As Boolean
		Get
			Return CType(ReturnValue("OptionsApplyRestart"), Boolean)
		End Get
		Set(Value As Boolean)
			ReturnValue("OptionsApplyRestart") = Value.ToString
			SaveState()
		End Set
	End Property
End Class