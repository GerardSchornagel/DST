''' <summary>
''' Get or Set the current Player data.
''' </summary>
Public Class playerProfile
	Private iniFileHandler As New iniHandler()
	Dim stringProfileData(,) As String
''' <summary>
''' Initializes Profile class.
''' </summary>
	Friend Sub New()
		
	End Sub
''' <summary>
''' Creates a new Profile.
''' </summary>
	Public Sub NewPlayerProfile(ProfileInfo() As String)
		stringProfileData = New String(,) {{"[Player Profile]", "<ProfileID>", ProfileInfo(0), "<NameFirst>", ProfileInfo(1), "<NameLast>", ProfileInfo(2), "<BirthYear>", ProfileInfo(3), "<BirthMonth>", ProfileInfo(4), "<BirthDay>", ProfileInfo(5), "<Gender>", ProfileInfo(6), "<E-Mail>", ProfileInfo(7), "<E-Mail Notification>", ProfileInfo(8)}}
		gamecache.currentSettings.LastProfile = ProfileInfo(0)
		'Start Writing New Profile
		SaveState()
	End Sub
''' <summary>
''' Loads a Profile file.
''' </summary>
	Friend Sub LoadPlayerProfile()
		stringProfileData = iniFilehandler.Load(System.IO.Directory.GetCurrentDirectory & "\save\" & gamecache.currentSettings.LastProfile & "\player\profile.ini")
	End Sub
''' <summary>
''' Searches in stringProfileData for requested Setting and set/returns that value.
''' </summary>
''' <param name="InformationRequest">Requested information as String. And saves when Set.</param>
''' <returns></returns>
	Public Property ReturnValue(InformationRequest As String) As String
		Get
			Dim integerColumn As Integer = 0
			Dim integerRow As Integer = 0
			Do
				Do
					If stringProfileData(integerColumn, integerRow).Contains(InformationRequest) Then
						Return stringProfileData(integerColumn, integerRow + 1)
						Exit Property
					End If
					integerRow += 1
				Loop Until integerRow > stringProfileData.GetUpperBound(1)
				integerColumn += 1
			Loop Until integerColumn > stringProfileData.GetUpperBound(0)
			Return ""
		End Get
		
		Set(Value As String)
			Dim integerColumn As Integer = 0
			Dim integerRow As Integer = 0
			Do
				Do
					If stringProfileData(integerColumn, integerRow).Contains(InformationRequest) Then
						stringProfileData(integerColumn, integerRow + 1) = Value
						SaveState()
						Exit Property
					End If
					integerRow += 1
				Loop Until integerRow > stringProfileData.GetUpperBound(1)
				integerColumn += 1
			Loop Until integerColumn > stringProfileData.GetUpperBound(0)
		End Set
	End Property
''' <summary>
''' Saves all changes made to the Profile data.
''' </summary>
	Private Sub SaveState()
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\" & gamecache.currentSettings.LastProfile & "\player")
		iniFilehandler.Save(System.IO.Directory.GetCurrentDirectory & "\save\" & gamecache.currentSettings.LastProfile & "\player\profile.ini", stringProfileData)
	End Sub
''' <summary>
''' Returns a String with the ProfileID.
''' </summary>
	Public Property ProfileID As String
		Get
			Return ReturnValue("ProfileID")
		End Get
		Set(Value As String)
			ReturnValue("ProfileID") = Value
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns a String with the First name.
''' </summary>
	Public Property FirstName As String
		Get
			Return ReturnValue("NameFirst")
		End Get
		Set(Value As String)
			ReturnValue("NameFirst") = Value
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns a String with the Last name.
''' </summary>
	Public Property LastName As String
		Get
			Return ReturnValue("NameLast")
		End Get
		Set(Value As String)
			ReturnValue("NameLast") = Value
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Birth Year.
''' </summary>
	Public Property BirthYear As Integer
		Get
			Return CType(ReturnValue("BirthYear"), Integer)
		End Get
		Set(Value As Integer)
			ReturnValue("BirthYear") = Value.ToString
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Birth Month.
''' </summary>
	Public Property BirthMonth As Integer
		Get
			Return CType(ReturnValue("BirthMonth"), Integer)
		End Get
		Set(Value As Integer)
			ReturnValue("BirthMonth") = Value.ToString
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Birth Day.
''' </summary>
	Public Property BirthDay As Integer
		Get
			Return CType(ReturnValue("BirthDay"), Integer)
		End Get
		Set(Value As Integer)
			ReturnValue("BirthDay") = Value.ToString
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns/Sets an String with the Gender
''' </summary>
	Public Property Gender As String
		Get
			Return ReturnValue("Gender")
		End Get
		Set(Value As String)
			ReturnValue("Gender") = Value
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns/Sets a String with the stringEMail.
''' </summary>
	Public Property EMail As String
		Get
			Return ReturnValue("EMail")
		End Get
		Set(Value As String)
			ReturnValue("EMail") = Value
			SaveState()
		End Set
	End Property
''' <summary>
''' Returns/Sets a True/False if subscribed to EMail Notification.
''' </summary>
	Public Property Notification As Boolean
		Get
			Return CType(ReturnValue("Notification"), Boolean)
		End Get
		Set(Value As Boolean)
			ReturnValue("Notification") = Value.ToString
			SaveState()
		End Set
	End Property
End Class
