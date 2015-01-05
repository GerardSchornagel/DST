''' <summary>
''' Creates a individual with Ethnic, Gender, Name, Age, Money & Desire.
''' First load Ethnic into it sand then use through ReturnRandom()
''' </summary>
Public Class individual
	Private iniFilehandler As New iniHandler()
	Private randomGenerator As New Random()
	
	Private stringDetails(,) as String
	Private stringNamelistM() as String
	Private stringNamelistF() as String
	Private stringEthnic As String
	Private stringRandom(4) As String
''' <summary>
''' Creates an empty Customer Class.
''' </summary>
	Sub New()
		
	End Sub
''' <summary>
''' Loads all the data of the specified Ethnic.
''' </summary>
''' <param name="pathEthnic">Full path of chosen Ethnic.</param>
	Public Sub Load(pathEthnic As String)
		'Set current Ethnic Variable to memory
		Dim stringConversion() As String = pathEthnic.Split(Chr(92))
		stringEthnic = stringConversion(stringConversion.GetUpperBound(0))
		'Fill stringDetails with pathEthnic
		stringDetails = iniFilehandler.Load(pathEthnic & "\details.ini")
		'Fill stringNamelistM with pathEthnic
		stringNamelistM = LoadNamelist(pathEthnic & "\NamelistM.nld")
		'Fill stringNamelistF with pathEthnic
		stringNamelistF = LoadNamelist(pathEthnic & "\NamelistF.nld")
	End Sub
	''' <summary>
	''' Loads a namelist according to set Ethnic and Gender.
	''' </summary>
	''' <param name="pathNamelist">complete path with file.</param>
	''' <returns>String() with single name per dimension.</returns>
	Private Function LoadNamelist(pathNamelist As String) As String()
		Dim stringMediator() As String
		Dim stringStream As String = ""
		Using streamReader As New System.IO.StreamReader(pathNamelist)
			stringStream = streamReader.ReadToEnd()
		End Using
		
		stringMediator = stringStream.Split(Chr(10))
		Dim integerMediator As Integer = 0
		For Each line In stringMediator
			If stringMediator(integerMediator) = "" Then
				integerMediator += 1
				Continue For
			End If
			stringMediator(integerMediator) = line.Remove(line.Length - 1, 1)
			integerMediator += 1
		Next
		Return stringMediator
	End Function
''' <summary>
''' Gets or Sets an Individual, empty variable's will be random according to [Ethnic]\details.ini.
''' (Name, Gender, Age, Money, Desire) as String(4)
''' </summary>
	Public Property ToStrings() As String()
		Get
			If stringRandom(1) = "" Then If randomGenerator.Next(2010) <= 1000 Then stringRandom(1) = "F" Else stringRandom(1) = "M" 'Gender based on WikiPedia (101M on 100F)
			If stringRandom(2) = "" Then stringRandom(2) = CType(randomGenerator.Next(CType(ReturnValue("AgeMinimum"), Integer), CType(ReturnValue("AgeMaximum"), Integer)), String) 'Age
			If stringRandom(3) = "" Then stringRandom(3) = CType(randomGenerator.Next(CType(ReturnValue("MoneyMinimum"), Integer), CType(ReturnValue("MoneyMaximum"), Integer)),String) 'Money
			If stringRandom(4) = "" Then stringRandom(4) = CType(randomGenerator.Next(CType(ReturnValue("DesireMinimum"), Integer), CType(ReturnValue("DesireMaximum"), Integer)), String) 'Desire
			If stringRandom(0) = "" Then If stringRandom(1) = "M" Then stringRandom(0) = stringNamelistM(randomGenerator.Next(stringNamelistM.GetUpperBound(0))) Else stringRandom(0) = stringNamelistF(randomGenerator.Next(stringNamelistF.GetUpperBound(0))) 'Name
			
			Return stringRandom
		End Get
		Set(Value As String())
			'Set all info from Value()
			stringRandom = Value
		End Set
	End Property
''' <summary>
''' Searches in stringDetails for requested Setting and set/returns that value.
''' </summary>
''' <param name="SettingRequest">Requested Setting as String..</param>
''' <returns></returns>
	Public ReadOnly Property ReturnValue(SettingRequest As String) As String
		Get
			Dim integerColumn As Integer = 0
			Dim integerRow As Integer = 0
			Do
				Do
					If stringDetails(integerColumn, integerRow).Contains(SettingRequest) Then
						Return stringDetails(integerColumn, integerRow + 1)
						Exit Property
					End If
					integerRow += 1
				Loop Until integerRow > stringDetails.GetUpperBound(1)
				integerColumn += 1
			Loop Until integerColumn > stringDetails.GetUpperBound(0)
			Return ""
		End Get
	End Property
	
	Public ReadOnly Property Ethnic As String
		Get
			Return stringEthnic
		End Get
	End Property
End Class
