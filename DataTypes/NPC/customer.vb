Public Class customer
	Private cRandom As Random
	Private cEthnic As String
	Private cName As String
	Private cGender As String
	Private cDesire As Integer
	Private cAge As Integer
	Private cMoney As Integer
	
	Private ArrayEthnic As String()
	
	Sub New()
		newCustomer()
	End Sub
	
	Public Sub newCustomer()
		cRandom = New Random()
		'DeFine ArrayEthnic
		Dim pathCustomer As String = System.IO.Directory.GetCurrentDirectory & "\Data\Customer"
		ArrayEthnic = System.IO.Directory.GetDirectories(pathCustomer, "*", IO.SearchOption.TopDirectoryOnly)
		Dim pos As Integer = 0
		For Each line In ArrayEthnic
			ArrayEthnic(pos) = line.Remove(0, pathCustomer.Length + 1)
			pos += 1
		Next
		'Choose Ethnic group
		cEthnic = ArrayEthnic(cRandom.Next(0, ArrayEthnic.GetUpperBound(0)))
		
		'Choose Gender
	If cRandom.Next(2010) <= 1000 Then cGender = "F" Else cGender = "M" 'Based on WikiPedia (101M on 100F)
		
		'Read & Random Name
		Dim StringNameList As String = ""
		Dim StringNameListPath As String = pathCustomer & "\" & cEthnic & "\Namelist" & cGender & ".nld"
		Using bReader As New System.IO.BinaryReader(System.IO.File.Open(StringNameListPath, System.IO.FileMode.Open))
			Do
				StringNameList += (Chr(bReader.ReadInt32))
			Loop Until bReader.PeekChar = Nothing
		End Using
		
		Dim ArrayNameList As String() = StringNameList.Split(New String() {Chr(13)}, StringSplitOptions.None)
		cName = ArrayNameList(cRandom.Next(ArrayNameList.GetUpperBound(0)))
		
		'Read AgeMin/AgeMax/MoneyMin/MoneyMax/Desire
		Dim StringProductDataFile As String = pathCustomer & "\" & cEthnic & "\Customer.cd"
		Dim StringProductData As String = ""
		Using bReader As New System.IO.BinaryReader(System.IO.File.Open(StringProductDataFile, System.IO.FileMode.Open))
			Do
				StringProductData += (Chr(bReader.ReadInt32))
			Loop Until bReader.PeekChar = Nothing
		End Using
		Dim ArrayProductData As String() = StringProductData.Split(New String() {"<>"}, StringSplitOptions.None)
		
		'Random Age/Money/Desire
		cAge = cRandom.Next(CType(ArrayProductData(1), Integer), CType(ArrayProductData(2), Integer))
		cMoney = cRandom.Next(CType(ArrayProductData(3), Integer), CType(ArrayProductData(4), Integer))
		cDesire = cRandom.Next(CType(ArrayProductData(5), Integer))
	End Sub
	
	Public ReadOnly Property Ethnic() As String
		Get
			Return cEthnic
		End Get
	End Property
	
	Public ReadOnly Property Name() As String
		Get
			Return cName
		End Get
	End Property
	
	Public ReadOnly Property Age() As Integer
		Get
			Return cAge
		End Get
	End Property
	
	Public ReadOnly Property Money() As Integer
		Get
			Return cMoney
		End Get
	End Property
	
	Public ReadOnly Property Desire() As Integer
		Get
			Return cDesire
		End Get
	End Property
End Class
