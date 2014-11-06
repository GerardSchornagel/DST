''' <summary>
''' Handles the Selecting and get/set functions for the Store Inventory.
''' </summary>
Public Class store
	Dim arrayStoreCollection() As String 'Contains all Stores in given Location
	Dim arrayBinCollection() As String 'Containing Bin's shortcuts of current Store
	Dim arrayBin(,) As String 'Contains collected and sorted Bin data
	
	Private intID As Integer
	Private strLocationCurrent As String
	Private strStoreCurrent As String
	Private strBinaryFileData As String
	''' <summary>
	''' Retrieves and Sets the current Store array.
	''' </summary>
	''' <param name="PlayerID">Use "New" for creation, otherwise GlobalSettings.LastUser.</param>
	''' <param name="Location">Use "FirstLocation" for Alpha phase.</param>
	''' <param name="Template">2d ObjectArray filled with String. Name, Quantity, Price.</param>
	''' <param name="NewPlayerID">Use intCheck for new ID String.</param>
	Friend Sub New(ByVal PlayerID As String, ByVal Location As String, Optional ByVal NewPlayerID As String = Nothing)
		If PlayerID = "New" Then
			intID = CType(NewPlayerID, Integer)
			NewStore()
			Exit Sub
		End If
		intID = CType(PlayerID, Integer)
		strLocationCurrent = Location
		'Prepare by getting Store(s) from Location
		arrayStoreCollection = (System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\" & strLocationCurrent))
	End Sub 'New
	''' <summary>
	''' Creates a new first player store through Template.
	''' </summary>
	Public Sub NewStore()
		strLocationCurrent = "FirstLocation"
		'Create the directory(s)
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\" & strLocationCurrent)
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\" & strLocationCurrent & "\FirstStore")
		'Write first bin.
		strBinaryFileData = CType("0", String) & "<>" & CType("0", String) & "<>" & CType("0", String)
		'Fill Array for character per character progressing
		Dim arrayInt32(strBinaryFileData.Length) As Int32
		Dim intDimension As Integer = 0
		For Each character As Char In strBinaryFileData
			arrayInt32(intDimension) = Asc(character)
			intDimension += 1
		Next
		
		Using binWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\FirstLocation\FirstStore\0.prd", System.IO.FileMode.Create))
			For Each integer32 As Int32 In arrayInt32
				binWriter.Write(integer32)
			Next
		End Using
	End Sub
	''' <summary>
	''' Saves the current state of the Store Inventory.
	''' </summary>
	Public Sub SaveState()
		'Loop through arrayBin and save individual files
		For Each bin As String In arrayBinCollection
			strBinaryFileData = arrayBin(CType(System.Text.RegularExpressions.Regex.Split(bin,".")(0), Integer),0)
			strBinaryFileData += "<>" & arrayBin(CType(System.Text.RegularExpressions.Regex.Split(bin,".")(0), Integer),1)
			strBinaryFileData += "<>" & arrayBin(CType(System.Text.RegularExpressions.Regex.Split(bin,".")(0), Integer),2)
			'Fill Array for character per character progressing
			Dim arrayInt32(strBinaryFileData.Length) As Int32
			Dim intDimension As Integer = 0
			For Each character As Char In strBinaryFileData
				arrayInt32(intDimension) = Asc(character)
				intDimension += 1
			Next
			
			Using binWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\" & strLocationCurrent & "\" & strStoreCurrent & "\" & bin, System.IO.FileMode.Create))
				For Each integer32 As Int32 In arrayInt32
					binWriter.Write(integer32)
				Next
			End Using
		Next
	End Sub 'SaveState
	''' <summary>
	''' Creates the space for a new Store and create a zero-filled starting array.
	''' </summary>
	Public Sub makeStore(ByVal StoreName As String)
		'Make physical file
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\" & strLocationCurrent & "\" & StoreName)
		'Make dummy array
		ReDim arrayBin(0,2)
		arrayBin(0,0) = "0"
		arrayBin(0,1) = "0"
		arrayBin(0,2) = "0"
		'Link to new Store
		strStoreCurrent = StoreName
		setStore(strStoreCurrent)
	End Sub 'makeStore
	''' <summary>
	''' Loads the current store to memory and fills the 'bins'.
	''' </summary>	
	Public Sub setStore(ByVal StoreName As String)
		strStoreCurrent = StoreName
		'Load Shelf data
		arrayBinCollection = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\" & strLocationCurrent & "\" & strStoreCurrent)
		ReDim arrayBin(arrayBinCollection.GetUpperBound(0),2)
		Dim intBin As Integer = 0
		
		For Each file As String In arrayBinCollection
			'Read
			strBinaryFileData = ""
			Using binReader As New System.IO.BinaryReader(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\" & strLocationCurrent & "\" & strStoreCurrent & "\" & file, System.IO.FileMode.Open))
				Do
					strBinaryFileData += (Chr(binReader.ReadInt32))
				Loop Until binReader.PeekChar = Nothing
			End Using
			Dim arrayBinData As String() = strBinaryFileData.Split(New String() {"<>"}, StringSplitOptions.None)
			
			'Convert to arrayBin(,)
			arrayBin(intBin, 0) = arrayBinData(0)
			arrayBin(intBin, 1) = arrayBinData(1)
			arrayBin(intBin, 2) = arrayBinData(2)
			intBin += 1
		Next
	End Sub 'setStore
	''' <summary>
	''' This makes a new space for a new bin, saves the blank and reloads it to memory.
	''' </summary>
	Public Sub makeBin()
		'Look for biggest existing file
		Dim intBinNew As Integer = 0
		Do
			If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\" & strLocationCurrent & "\" & strStoreCurrent & "\" & intBinNew & ".pd") = False Then Exit Do
			intBinNew += 1
		Loop
		
		'Start binWriter with "empty" array
		ReDim arrayBin(0, 2)
		arrayBin(0, 0) = "0"
		arrayBin(0, 1) = "0"
		arrayBin(0, 2) = "0"

		strBinaryFileData = ""
		Dim intDimensionFirst As Integer = -1 'Negative for upcoming Loop
		Do
			intDimensionFirst  +=1
			Dim intDimensionSecond As Integer = -1 'Negative for upcoming Loop
			Do
				intDimensionSecond += 1
				strBinaryFileData += "<>" & CType(arrayBin(intDimensionFirst, intDimensionSecond), String)
			Loop Until intDimensionSecond = arrayBin.GetUpperBound(1)
		Loop Until intDimensionFirst = arrayBin.GetUpperBound(0)

		'Remove the first empty entry "<>"
		strBinaryFileData=strBinaryFileData.Remove(0, 2)
		'Fill Array for character per character progressing
		Dim arrayInt32(strBinaryFileData.Length) As Int32
		Dim intDimension As Integer = 0
		For Each character As Char In strBinaryFileData
			arrayInt32(intDimension) = Asc(character)
			intDimension += 1
		Next
		
		' Create the BinaryWriter and use File.Create to create the file.
		Using binWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\" & strLocationCurrent & "\" & strStoreCurrent & "\" & intBinNew & ".pd", System.IO.FileMode.Create))
			For Each integer32 As Int32 In arrayInt32
				binWriter.Write(integer32)
			Next
		End Using
		
		setStore(strStoreCurrent)
	End Sub 'makeBin
	''' <summary>
	''' Get or Sets the requested Bin to array.
	''' </summary>
	Public Property getsetBin(Dimension As Integer) As object
		Get
			If Dimension > arrayBin.GetUpperBound(0) Then
				Return Nothing
				Exit Property
			End If
			Dim ReturnValue(2) As String
			ReturnValue(0) = CType(arrayBin(Dimension, 0), String)
			ReturnValue(1) = CType(arrayBin(Dimension, 1), String)
			ReturnValue(2) = CType(arrayBin(Dimension, 2), String)
			Return ReturnValue
		End Get
		Set(value As Object)
			If value is nothing Then value = New string() {"0","0","0"}
			arrayBin(Dimension, 0) = Ctype(value(0), String)
			arrayBin(Dimension, 1) = Ctype(value(1), String)
			arrayBin(Dimension, 2) = CType(value(2), String)
			SaveState()
		End Set
	End Property 'getsetBin
End Class
