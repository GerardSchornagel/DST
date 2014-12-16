''' <summary>
''' Global Settings for the game, most will be handled from the Main Menu.
''' </summary>
Public Class settings
	Private iniFilehandler As New iniHandler()
	Private stringSettings(,) As String
''' <summary>
''' If exists it loads the GlobalSetting, else it create default.
''' </summary>
	Sub New()
		If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\settings.ini") = False Then
			stringSettings = New String(,) {{"[WarningMessages]", "<LastUserID>", "0", "<ProgramQuit>", "False", "<NewGameOverwrite>", "False", "<OptionsApplyRestart>", "False"}}
			SaveState()
		Else
			stringSettings = iniFilehandler.Load(System.IO.Directory.GetCurrentDirectory & "\save\settings.ini")
		End If
	End Sub
''' <summary>
''' Searches in stringSettings for requested Setting and set/returns that value.
''' </summary>
''' <param name="SettingRequest">Requested Setting as String. And saves when Set.</param>
''' <returns></returns>
	Private Property ReturnValue(SettingRequest As String) As String
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
				Loop Until integerRow >= stringSettings.GetUpperBound(1)
				integerColumn += 1
			Loop Until integerColumn >= stringSettings.GetUpperBound(0)
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
				Loop Until integerRow >= stringSettings.GetUpperBound(1)
				integerColumn += 1
			Loop Until integerColumn >= stringSettings.GetUpperBound(0)
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
		ReturnValue("LastUserID") = CType(intCheck, String)
		SaveState()
	End Sub
''' <summary>
''' A String representing the last player that has played, it is corresponding with the number in the save directory.
''' </summary>
	Public Property LastUser As String
		Get
			Return ReturnValue("LastUserID")
		End Get
		Set(Value As String)
			ReturnValue("LastUserID") = Value
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
''' Warning message that the last player ID will be overwritten, in Alpha stage this means you lose your prev. game.
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