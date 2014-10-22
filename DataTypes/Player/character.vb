Public Class character
  Private intID As Integer = 99 'Passed on from parent
  Private intBalance As Integer = 250 'Self adjusting through game
  Private intGradeInventory As Integer = 0 'Self adjusting through game
  Private intGradeShelf As Integer = 0 'Self adjusting through game
  Private intGradePopularity As Integer = 0 'Self adjusting through game

  Private strBinaryFileData As String = ""
  Friend Sub New(PlayerID As Integer)
    intID = PlayerID
    'See if a new file has to be created with defaults
    If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\character.pd") = False Then SaveState()

    'Get all info from File
    Using binReader As New System.IO.BinaryReader(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\character.pd", System.IO.FileMode.Open))
      Do
        strBinaryFileData += (Chr(binReader.ReadInt32))
      Loop Until binReader.PeekChar = Nothing
    End Using
    'Split info into string-array
    Dim arrayCharacterData As String() = strBinaryFileData.Split(New String() {"<>"}, StringSplitOptions.None)
    'Write Private's
    intBalance = CType(arrayCharacterData(0), Integer)
    intGradeInventory = CType(arrayCharacterData(1), Integer)
    intGradeShelf = CType(arrayCharacterData(2), Integer)
    intGradePopularity = CType(arrayCharacterData(3), Integer)
  End Sub

  Private Sub SaveState()
    'Make Raw data String
    strBinaryFileData = intBalance
    strBinaryFileData += "<>" & intGradeInventory
    strBinaryFileData += "<>" & intGradeShelf
    strBinaryFileData += "<>" & intGradePopularity

    'Fill Array for character per character progressing
    Dim arrayInt32(strBinaryFileData.Length) As Int32
    Dim intDimension As Integer = 0
    For Each character As Char In strBinaryFileData
      arrayInt32(intDimension) = Asc(character)
      intDimension += 1
    Next
    ' Create the BinaryWriter and use File.Create to create the file.
    Using binWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\Save\" & intID & "\character.pd", System.IO.FileMode.Create))
      For Each integer32 As Int32 In arrayInt32
        binWriter.Write(integer32)
      Next
    End Using
  End Sub 'Sub SaveState

  Public Property PlayerID As Integer
    Get
      Return intID
    End Get
    Set(Value As Integer)
      intID = Value
      SaveState()
    End Set
  End Property 'Property PlayerID

  Public Property Balance As Integer
    Get
      Return intBalance
    End Get
    Set(Value As Integer)
      intBalance = Value
      SaveState()
    End Set
  End Property 'Property Balance

  Public Property GradeInventory As Integer
    Get
      Return intGradeInventory
    End Get
    Set(Value As Integer)
      intGradeInventory = Value
      SaveState()
    End Set
  End Property 'Property GradeInventory

  Public Property GradeShelf As Integer
    Get
      Return intGradeShelf
    End Get
    Set(Value As Integer)
      intGradeShelf = Value
      SaveState()
    End Set
  End Property 'Property GradeShelf

  Public Property GradePopularity As Integer
    Get
      Return intGradePopularity
    End Get
    Set(Value As Integer)
      intGradePopularity = Value
      SaveState()
    End Set
  End Property 'Property GradePopularity
End Class
