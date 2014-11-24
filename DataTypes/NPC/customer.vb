''' <summary>
''' Creates a Random customer via Ethnic>Gender=Name&Desire>Age>Money
''' Can be reused through newCustomer()
''' </summary>
Public Class customer
	Private cRandom As Random
	Private cEthnic As String
	Private cName As String
	Private cGender As String
	Private cDesire As Integer
	Private cAge As Integer
	Private cMoney As Integer
	Private stringBinaryReader As String
	Private stringNameListPath As String
	Private stringDetailsDataFile As String
	Private arrayNameListF As String()
	Private arrayNameListM As String()
	Private arrayDetailsData As String()	
	Private arrayEthnic As String()
	
	Private filehandler As New binaryFileHandler()
	Sub New()
		cRandom = New Random()
		'DeFine ArrayEthnic
		arrayEthnic = System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory & "\data\customer\", "*", IO.SearchOption.TopDirectoryOnly)
		Dim pos As Integer = 0
		For Each line In arrayEthnic
			arrayEthnic(pos) = line.Remove(0, (System.IO.Directory.GetCurrentDirectory & "\data\customer\").Length)
			pos += 1
		Next
		cEthnic = arrayEthnic(cRandom.Next(0, arrayEthnic.GetUpperBound(0)))
		'Define ArrayNameF and ArrayNameM
		arrayNameListM = filehandler.LoadLine(System.IO.Directory.GetCurrentDirectory & "\data\customer\" & cEthnic & "\", "NamelistM.nld").Split(New String() {Chr(13)}, StringSplitOptions.None)
		arrayNameListF = filehandler.LoadLine(System.IO.Directory.GetCurrentDirectory & "\data\customer\" & cEthnic & "\", "NamelistF.nld").Split(New String() {Chr(13)}, StringSplitOptions.None)
		'Read AgeMin/AgeMax/MoneyMin/MoneyMax/Desire
		arrayDetailsData = filehandler.LoadRow(System.IO.Directory.GetCurrentDirectory & "\data\customer\" & cEthnic & "\", "Customer.cd")
		
		newCustomer()
	End Sub
	''' <summary>
	''' Creates new Customer.
	''' </summary>
	Public Sub newCustomer()
		'Choose Ethnic group
		cEthnic = arrayEthnic(cRandom.Next(0, arrayEthnic.GetUpperBound(0)))
		
		'Choose Gender
		If cRandom.Next(2010) <= 1000 Then  'Based on WikiPedia (101M on 100F)
			cGender = "F"
			cName = arrayNameListF(cRandom.Next(arrayNameListF.GetUpperBound(0)))
		Else
			cGender = "M"
			cName = arrayNameListM(cRandom.Next(arrayNameListM.GetUpperBound(0)))
		End If
		
		'Random Age/Money/Desire
		cAge = cRandom.Next(CType(arrayDetailsData(1), Integer), CType(arrayDetailsData(2), Integer))
		cMoney = cRandom.Next(CType(arrayDetailsData(3), Integer), CType(arrayDetailsData(4), Integer))
		cDesire = cRandom.Next(CType(arrayDetailsData(5), Integer))
	End Sub
	''' <summary>
	''' Returns a String with the Ethnic variable.
	''' </summary>
	Public ReadOnly Property Ethnic() As String
		Get
			Return cEthnic
		End Get
	End Property
	''' <summary>
	''' Returns a String with the Name.
	''' </summary>
	Public ReadOnly Property Name() As String
		Get
			Return cName
		End Get
	End Property
	''' <summary>
	''' Returns an Integer with the Age.
	''' </summary>
	Public ReadOnly Property Age() As Integer
		Get
			Return cAge
		End Get
	End Property
	''' <summary>
	''' Returns an Integer with the Money on Customer.
	''' </summary>
	Public ReadOnly Property Money() As Integer
		Get
			Return cMoney
		End Get
	End Property
	''' <summary>
	''' Returns an Integer with the Desire rate.
	''' </summary>
	Public ReadOnly Property Desire() As Integer
		Get
			Return cDesire
		End Get
	End Property
End Class
