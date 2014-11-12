''' <summary>
''' Handles the Player Inventory array's.
''' </summary>
Public Class inventory
	Private intID As Integer
	Dim arrayInventory(,) As Object
	
	Private strBinaryFileData As String = ""
	''' <summary>
	''' Retrieves Inventory Array.
	''' </summary>
	''' <param name="PlayerID">Use "New" for creation, otherwise GlobalSettings.LastUser.</param>
	''' <param name="Template">2d ObjectArray filled with String. Name, Quantity, LastBuy, LastSell.</param>
	''' <param name="NewPlayerID">Use intCheck for new ID String.</param>
	Friend Sub New(ByVal PlayerID As String, Optional ByVal Template(,) As Object = Nothing, Optional ByVal NewPlayerID As String = Nothing)
		If PlayerID = "New" Then
			intID = CType(NewPlayerID, Integer)
			NewInventory(Template)
			Exit Sub
		End If
		intID = CType(PlayerID, Integer)
		'See if a new file has to be created with defaults
		If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\inventory.pd") = False Then SaveState()
		strBinaryFileData = ""
		'Get all info from File
		Using binReader As New System.IO.BinaryReader(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\inventory.pd", System.IO.FileMode.Open))
			Do
				strBinaryFileData += (Chr(binReader.ReadInt32))
			Loop Until binReader.PeekChar = Nothing
		End Using
		'Split info into string-array
		Dim rawInventory() As String = strBinaryFileData.Split(New String() {"<>"}, StringSplitOptions.None)
		'Each entry in arrayInventory has 4 sub-dimensions, so the rawInventory(single dimension) is divided by 4 to count for the UpperBound of arrayInventory
		ReDim arrayInventory(CType((((rawInventory.GetUpperBound(0) + 1) / 4) - 1),Integer), 3)
		
		'Split Raw data into Inventory
		Dim temp As Integer = rawInventory.GetUpperBound(0)
		Dim intDimensionArray As Integer = -1 'Negative for upcoming Loop
		Dim intDimensionRaw As Integer = -1 'Negative for upcoming Loop
		Do
			intDimensionArray += 1
			intDimensionRaw += 1
			arrayInventory(intDimensionArray, 0) = rawInventory(intDimensionRaw) 'Item
			intDimensionRaw += 1
			arrayInventory(intDimensionArray, 1) = rawInventory(intDimensionRaw) 'Quantity
			intDimensionRaw += 1
			arrayInventory(intDimensionArray, 2) = rawInventory(intDimensionRaw) 'Last Buying Price
			intDimensionRaw += 1
			arrayInventory(intDimensionArray, 3) = rawInventory(intDimensionRaw) 'Selling Price
		Loop Until intDimensionArray = CType((((rawInventory.GetUpperBound(0) + 1) / 4) - 1),integer) 
	End Sub 'Sub New
	''' <summary>
	''' Creates a new player inventory through Template.
	''' </summary>
	Public Sub NewInventory(ByVal InventoryData(,) As Object)
		ReDim arrayInventory(0, 3)
		arrayInventory(0, 0) = InventoryData(0, 0)
		arrayInventory(0, 1) = InventoryData(0, 1)
		arrayInventory(0, 2) = InventoryData(0, 2)
		arrayInventory(0, 3) = InventoryData(0, 3)
		'Create the directory(s)
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save\" & intID)
		'Start Writing New Player
		SaveState()
	End Sub
''' <summary>
''' Saves the current state of the Player Inventory array.
''' </summary>
	Public Sub SaveState()
		'Make Raw data String
		strBinaryFileData = ""
		Dim intDimensionFirst As Integer = -1 'Negative for upcoming Loop
		Do
			intDimensionFirst  +=1
			Dim intDimensionSecond As Integer = -1 'Negative for upcoming Loop
			Do
				intDimensionSecond += 1
				strBinaryFileData += "<>" & CType(arrayInventory(intDimensionFirst, intDimensionSecond), String)
			Loop Until intDimensionSecond = arrayInventory.GetUpperBound(1)
		Loop Until intDimensionFirst = arrayInventory.GetUpperBound(0)

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
		Using binWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\inventory.pd", System.IO.FileMode.Create))
			For Each integer32 As Int32 In arrayInt32
				binWriter.Write(integer32)
			Next
		End Using
	End Sub
''' <summary>
''' Gets or sets the appointed InventorySpace or sets it to 0.
''' </summary>
	Public Property GetInventorySpace(Dimension As Integer) As object
		Get
			If Dimension = -1 Then 
				Return Nothing
				Exit Property
			End If
			If Dimension > arrayInventory.GetUpperBound(0) Then
				Return Nothing
				Exit Property
			End If
			Dim ReturnValue(3) As String
			ReturnValue(0) = CType(arrayInventory(Dimension, 0), String)
			ReturnValue(1) = CType(arrayInventory(Dimension, 1), String)
			ReturnValue(2) = CType(arrayInventory(Dimension, 2), String)
			ReturnValue(3) = CType(arrayInventory(Dimension, 3), String)
			Return ReturnValue
		End Get
		Set(value As Object)
			If value is nothing Then value = New string() {"0","0","0","0"}
			arrayInventory(Dimension, 0) = value(0)
			arrayInventory(Dimension, 1) = value(1)
			arrayInventory(Dimension, 2) = value(2)
			arrayInventory(Dimension, 3) = value(3)
		End Set
	End Property 'GetInventorySpace
End Class