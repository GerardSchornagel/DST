''' <summary>
''' Creates a Customer database with individuals for storing all Ehtnics.
''' </summary>
Public Class customer
	Private individualDatabase() As individual
	Private individualCurrent As individual
	Private stringCurrent As String
	Sub New()
		'Check for quantity data\customer-Folder.
		Dim stringEthnics() As String = System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory & "\data\customer\", "*", System.IO.SearchOption.TopDirectoryOnly)
		'ReDim individualDatabase accordingly.
		ReDim individualDatabase(stringEthnics.GetUpperBound(0))
		'Load all individual's
		Dim integerCounter As integer = 0
		For Each line As String In stringEthnics
			individualDatabase(integerCounter) = New individual()
			individualDatabase(integerCounter).Load(line)
			integerCounter += 1
		Next
	End Sub
	
	'Make Function for choosing Random & Specified Ethic-individual.
''' <summary>
''' Gets the current Individual. Empty Parameters will be random.
''' (Ethnic, Name, Gender, Age, Money, Desire) as String(5)
''' </summary>
	Public Property GetCurrentCustomer() As String()
		Get
			Return New String() {stringCurrent, individualCurrent.ToStrings(0), individualCurrent.ToStrings(1), individualCurrent.ToStrings(2), individualCurrent.ToStrings(3), individualCurrent.ToStrings(4)} 'test for correct output.
		End Get
		Set (Value As String())
			Dim stringCurrentCustomer(4) As String
			Dim randomGenerator As New Random()
			Dim stringEthnic As String
			If Value(0) <> Nothing Then stringEthnic = individualDatabase(randomGenerator.Next(individualDatabase.GetUpperBound(0))).Ethnic Else stringEthnic = Value(0)
			individualCurrent= New individual()
			individualCurrent.Load(System.IO.Directory.GetCurrentDirectory & "\data\customer\" & stringEthnic)
			stringCurrentCustomer(0) = Value(1)
			stringCurrentCustomer(1) = Value(2)
			stringCurrentCustomer(2) = Value(3)
			stringCurrentCustomer(3) = Value(4)
			stringCurrentCustomer(4) = Value(5)
			individualCurrent.ToStrings = stringCurrentCustomer
		End Set
	End Property
	
	Public Function ReturnValue(Ethnic As String, SettingRequest As String) As String
		For Each guest As individual In individualDatabase
			If guest.Ethnic.ToLower = Ethnic.ToLower Then
				Return guest.ReturnValue(SettingRequest)
				Exit Function
			End If
		Next
		Return Nothing
	End Function
End Class
