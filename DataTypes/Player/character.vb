''' <summary>
''' All Character Variables are retrieved/stored here.
''' </summary>
Public Class character
	Private filehandler As New binaryFileHandler()
	Dim stringCharacterData() As String
	
	Private integerPlayerID As Integer
	Private integerBalance As Integer
	Private integerGradeInventory As Integer
	Private integerGradeShelf As Integer
	Private integerGradePopularity As Integer
''' <summary>
''' Retrieves Character Variables.
''' </summary>
''' <param name="PlayerID">Use "New" for creation, otherwise GlobalSettings.LastUser.</param>
''' <param name="Template">New String() {PlayerID, Balance, GradeInventory, GradeShelf, GradePopularity}</param>
	Friend Sub New(PlayerID As String, Optional Template() As String = Nothing)
		'Check for New parameter.
		If PlayerID = "New" Then
			NewCharacter(Template)
			
		Else
			integerPlayerID = CType(PlayerID, Integer)
			ReDim stringCharacterData(3)
			stringCharacterData = filehandler.LoadRow(System.IO.Directory.GetCurrentDirectory & "\save\" & integerPlayerID & "\", "character.pd")
			'Write Private's
			integerBalance = CType(stringCharacterData(0), Integer)
			integerGradeInventory = CType(stringCharacterData(1), Integer)
			integerGradeShelf = CType(stringCharacterData(2), Integer)
			integerGradePopularity = CType(stringCharacterData(3), Integer)
		End If
	End Sub
''' <summary>
''' Creates new Character Data and SaveState()
''' </summary>
''' <param name="Template">Pass through from Sub New()</param>
	Public Sub NewCharacter(ByVal Template() As String)
		ReDim stringCharacterData(3)
		Array.ConstrainedCopy(Template, 1, stringCharacterData, 0, Template.GetUpperBound(0))
		integerPlayerID = CType(Template(0), Integer)
		integerBalance = CType(stringCharacterData(0), Integer)
		integerGradeInventory = CType(stringCharacterData(1), Integer)
		integerGradeShelf = CType(stringCharacterData(2), Integer)
		integerGradePopularity = CType(stringCharacterData(3), Integer)
		'Start Writing New Player
		SaveState()
	End Sub
''' <summary>
''' Saves the current state of character.vb Variables to file.
''' </summary>
	Public Sub SaveState()
		filehandler.Save(System.IO.Directory.GetCurrentDirectory & "\Save\" & integerPlayerID & "\", "character.pd", , stringCharacterData)
	End Sub
''' <summary>
''' Returns an Integer with the Player ID.
''' </summary>
	Public Property PlayerID As Integer
		Get
			Return integerPlayerID
		End Get
		Set(Value As Integer)
			integerPlayerID = Value
		End Set
	End Property
''' <summary>
''' Returns an Integer with the current balance.
''' </summary>
	Public Property Balance As Integer
		Get
			Return integerBalance
		End Get
		Set(Value As Integer)
			integerBalance = Value
			stringCharacterData(0) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Inventory Grade.
''' </summary>
	Public Property GradeInventory As Integer
		Get
			Return integerGradeInventory
		End Get
		Set(Value As Integer)
			integerGradeInventory = Value
			stringCharacterData(1) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Shelf Grade.
''' </summary>
	Public Property GradeShelf As Integer
		Get
			Return integerGradeShelf
		End Get
		Set(Value As Integer)
			integerGradeShelf = Value
			stringCharacterData(2) = CType(Value, String)
		End Set
	End Property
''' <summary>
''' Returns an Integer with the Popularity Grade.
''' </summary>
	Public Property GradePopularity As Integer
		Get
			Return integerGradePopularity
		End Get
		Set(Value As Integer)
			integerGradePopularity = Value
			stringCharacterData(3) = CType(Value, String)
		End Set
	End Property
End Class
