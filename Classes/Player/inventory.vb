''' <summary>
''' Handles the Player Inventory array's.
''' </summary>
Public Class inventory
	Private filehandler As New binaryFileHandler()
	Dim	 stringInventory(,) As String
	
	Private integerPlayerID As Integer
''' <summary>
''' Retrieves Inventory Array.
''' </summary>
	Friend Sub New()
		
	End Sub
	''' <summary>
	''' Loads or create a (blank) Profile.
	''' </summary>
	Public Sub Load()
		'Check for if file exists, if not create; else load.
		If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & cache.settingsGlobal.LastUser & "\inventory.pd") = False Then
			NewInventory()
			
		Else
			integerPlayerID = CType(cache.settingsGlobal.LastUser, Integer)
			stringInventory = filehandler.LoadTable(System.IO.Directory.GetCurrentDirectory & "\save\" & integerPlayerID & "\", "inventory.pd", 3)
		End If
	End Sub
''' <summary>
''' Creates a new player inventory through Template.
''' </summary>
	Public Sub NewInventory()
		'Make new Inventory with template.
		ReDim stringInventory(0, 3)
		stringInventory(0, 0) = "Freebie Pen's"
		stringInventory(0, 1) = "0"
		stringInventory(0, 2) = "0"
		stringInventory(0, 3) = "0"
		'Start Writing New Inventory
		SaveState()
	End Sub
''' <summary>
''' Saves the current state of the Player Inventory array.
''' </summary>
	Public Sub SaveState()
		filehandler.Save(System.IO.Directory.GetCurrentDirectory & "\save\" & integerPlayerID & "\", "inventory.pd", , , stringInventory, 3)
	End Sub
''' <summary>
''' Returns an integer with the upperbound of the inventory with 0-index.
''' </summary>
	Public Function GetUpperbound As Integer
		Return stringInventory.GetUpperBound(0)
	End Function
''' <summary>
''' Makes a new slot on smallest free index. And saves.
''' </summary>
''' <param name="Template">New String() {Name, Amount, LastSelling, LastBuying}</param>
	Public Sub NewSlot(Template As String())
		Dim integerSlotNumber = stringInventory.GetUpperBound(0) + 1
		Dim arrayInventoryBuild(integerSlotNumber, 3) As String
		Array.Copy(stringInventory, arrayInventoryBuild, stringInventory.Length)
		arrayInventoryBuild(integerSlotNumber, 0) = Template(0)
		arrayInventoryBuild(integerSlotNumber, 1) = Template(1)
		arrayInventoryBuild(integerSlotNumber, 2) = Template(2)
		arrayInventoryBuild(integerSlotNumber, 3) = Template(3)
		stringInventory = arrayInventoryBuild
		SaveState()
	End Sub
''' <summary>
''' Gets or sets the appointed InventorySpace or sets it to 0. And Saves.
''' </summary>
''' <param name="Dimension">Needed for converting 2D to 3D Array.</param>
	Public Property GetInventorySpace(Dimension As Integer) As String()
		Get
			If Dimension = -1 Then 'Non-selected return from the listbox.
				Return Nothing
				Exit Property
			End If
			If Dimension > stringInventory.GetUpperBound(0) Then 'Just in case error-catch.
				Return Nothing
				Exit Property
			End If

			Dim ReturnValue(3) As String
			ReturnValue(0) = stringInventory(Dimension, 0)
			ReturnValue(1) = stringInventory(Dimension, 1)
			ReturnValue(2) = stringInventory(Dimension, 2)
			ReturnValue(3) = stringInventory(Dimension, 3)
			Return ReturnValue
		End Get
		
		Set(Value() As String)
			If Value Is Nothing Then 'Just in case error catching.
				Exit Property
			End If
			stringInventory(Dimension, 0) = Value(0)
			stringInventory(Dimension, 1) = Value(1)
			stringInventory(Dimension, 2) = Value(2)
			stringInventory(Dimension, 3) = Value(3)
			SaveState()
		End Set
	End Property
End Class