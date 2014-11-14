''' <summary>
''' Handles the Player Inventory array's.
''' </summary>
Public Class inventory
	Private integerID As Integer
	Dim arrayInventory(,) As Object
	
	Private stringBinaryFileData As String = ""
	''' <summary>
	''' Retrieves Inventory Array.
	''' </summary>
	''' <param name="PlayerID">Use "New" for creation, otherwise GlobalSettings.LastUser.</param>
	''' <param name="Template">2d ObjectArray filled with String. Name, Quantity, LastBuy, LastSell.</param>
	''' <param name="NewPlayerID">Use intCheck for new ID String.</param>
	
	Friend Sub New(ByVal PlayerID As String, Optional ByVal Template(,) As Object = Nothing, Optional ByVal NewPlayerID As String = Nothing)
		'Check for new parameter and re-direct.
		If PlayerID = "New" Then
			integerID = CType(NewPlayerID, Integer)
			NewInventory(Template)
			Exit Sub
		End If
		
		integerID = CType(PlayerID, Integer)
		
		'Get all info from File
		stringBinaryFileData = ""
		Using binReader As New System.IO.BinaryReader(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\" & integerID & "\inventory.pd", System.IO.FileMode.Open))
			Do
				stringBinaryFileData += (Chr(binReader.ReadInt32))
			Loop Until binReader.PeekChar = Nothing
		End Using
		
		'Split info into string-array
		Dim rawInventory() As String = stringBinaryFileData.Split(New String() {"<>"}, StringSplitOptions.None)
		
		'Split Raw data into Inventory
		Dim integerDimensionArray As Integer = 0
		Dim integerDimensionRaw As Integer = 0
		ReDim arrayInventory((((rawInventory.GetUpperBound(0) + 1) / 4) - 1), 3)
		Do
			arrayInventory(integerDimensionArray, 0) = rawInventory(integerDimensionRaw) 'Item
			integerDimensionRaw += 1
			arrayInventory(integerDimensionArray, 1) = rawInventory(integerDimensionRaw) 'Quantity
			integerDimensionRaw += 1
			arrayInventory(integerDimensionArray, 2) = rawInventory(integerDimensionRaw) 'Last Buying Price
			integerDimensionRaw += 1
			arrayInventory(integerDimensionArray, 3) = rawInventory(integerDimensionRaw) 'Last Selling Price
			integerDimensionRaw += 1
			integerDimensionArray += 1
		Loop Until integerDimensionRaw > rawInventory.GetUpperBound(0)
	End Sub
	
	''' <summary>
	''' Creates a new player inventory through Template.
	''' </summary>
	Public Sub NewInventory(ByVal InventoryData(,) As Object)
		'Make new Inventory with template.
		arrayInventory = InventoryData.Clone()
		'Start Writing New Inventory
		SaveState()
	End Sub

''' <summary>
''' Saves the current state of the Player Inventory array.
''' </summary>
	Public Sub SaveState()
		'Make Raw data String
		stringBinaryFileData = ""
		Dim integerDimensionRow As Integer = 0
		Do
			Dim integerDimensionColumn As Integer = 0
			Do
				stringBinaryFileData += "<>" & CType(arrayInventory(integerDimensionRow, integerDimensionColumn), String)
				integerDimensionColumn += 1
			Loop Until integerDimensionColumn > 3
			integerDimensionRow += 1
		Loop Until integerDimensionRow > arrayInventory.GetUpperBound(0)
		'Remove the first Empty entry "<>"
		stringBinaryFileData=stringBinaryFileData.Remove(0, 2)
		
		'Fill Array for character per character progressing
		Dim arrayInt32(stringBinaryFileData.Length) As Int32
		Dim integerDimension As Integer = 0
		For Each character As Char In stringBinaryFileData
			arrayInt32(integerDimension) = Asc(character)
			integerDimension += 1
		Next
		
		' Create the BinaryWriter and use File.Create to create the file.
		Using binWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\" & integerID & "\inventory.pd", System.IO.FileMode.Create))
			For Each integer32 As Int32 In arrayInt32
				binWriter.Write(integer32)
			Next
		End Using
	End Sub
	
	''' <summary>
	''' Returns an integer with the upperbound of the inventory with 0-index.
	''' </summary>
	Public Property GetUpperbound As Integer
		Get
			Return arrayInventory.GetUpperBound(0)
		End Get
		Set
		End Set
		End Property
		
	''' <summary>
	''' Makes a new slot on smallest free index. And saves.
	''' </summary>
	''' <param name="Template">New String() {Name, Amount, LastSelling, LastBuying}</param>
	Public Sub NewSlot(Template As String())
		Dim integerSlotNumber = arrayInventory.GetUpperBound(0) + 1
		Dim arrayInventoryBuild(integerSlotNumber, 3) As Object
		arrayInventory.Copy(arrayInventory, arrayInventoryBuild, arrayInventory.Length)
		arrayInventoryBuild(integerSlotNumber, 0) = Template(0)
		arrayInventoryBuild(integerSlotNumber, 1) = Template(1)
		arrayInventoryBuild(integerSlotNumber, 2) = Template(2)
		arrayInventoryBuild(integerSlotNumber, 3) = Template(3)
		arrayInventory = arrayInventoryBuild
		SaveState()
	End Sub
	
	''' <summary>
	''' Gets or sets the appointed InventorySpace or sets it to 0. And Saves.
	''' </summary>
	Public Property GetInventorySpace(Dimension As Integer) As object
		Get
			If Dimension = -1 Then 'Return from an Empty control that calls this sub.
				Return Nothing
				Exit Property
			End If
			If Dimension > arrayInventory.GetUpperBound(0) Then 'Just in case error-catch.
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
			If value Is Nothing Then 'Just in case error catching.
				Exit Property
			End If
			arrayInventory(Dimension, 0) = value(0)
			arrayInventory(Dimension, 1) = value(1)
			arrayInventory(Dimension, 2) = value(2)
			arrayInventory(Dimension, 3) = value(3)
			SaveState()
		End Set
	End Property
End Class