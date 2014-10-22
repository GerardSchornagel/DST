Public Class inventory
  Private intID As Integer = 99 'Passed on from parent

  Dim arrayInventory(,)

  Private strBinaryFileData As String = ""

  Friend Sub New(PlayerID As Integer)
    intID = PlayerID
    'See if a new file has to be created with defaults
    If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\inventory.pd") = False Then SaveState()

    'Get all info from File
    Using binReader As New System.IO.BinaryReader(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\" & intID & "\inventory.pd", System.IO.FileMode.Open))
      Do
        strBinaryFileData += (Chr(binReader.ReadInt32))
      Loop Until binReader.PeekChar = Nothing
    End Using
    'Split info into string-array
    Dim rawInventory() As String = strBinaryFileData.Split(New String() {"<>"}, StringSplitOptions.None)
    'Each entry in arrayInventory has 4 sub-dimensions, so the rawInventory(single dimension) is divided by 4 to count for the UpperBound of arrayInventory
    ReDim arrayInventory(((rawInventory.GetUpperBound(0)) / 4) + 1, 4)

    'Split Raw data into Inventory
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
    Loop Until intDimensionRaw = rawInventory.GetUpperBound(0)
  End Sub 'Sub New

  Private Sub SaveState()
    'Make Raw data String
    'Check for empty arrayInventory for creating new one
    If arrayInventory.GetLength(0) = 0 Then
      ReDim arrayInventory(1, 4)
      arrayInventory(0, 0) = "Freebie Pen's"
      arrayInventory(0, 1) = 25
      arrayInventory(0, 2) = 1
      arrayInventory(0, 3) = 5
    End If

    strBinaryFileData = ""
    Dim intDimensionFirst As Integer = -1 'Negative for upcoming Loop
    Do
      intDimensionFirst = +1
      Dim intDimensionSecond As Integer = -1 'Negative for upcoming Loop
      Do
        intDimensionSecond = +1
        strBinaryFileData += "<>" & arrayInventory(intDimensionFirst, intDimensionSecond)
      Loop Until intDimensionSecond = arrayInventory.GetUpperBound(1)
    Loop Until intDimensionFirst = arrayInventory.GetUpperBound(0)

    'Remove the first empty entry "<>"
    strBinaryFileData.Remove(0, 2)
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

  Public Property GetInventorySpace(Dimension As Integer)
    Get
      Dim ReturnValue(4) As String
      Try
        ReturnValue(0) = arrayInventory(Dimension, 0)
        ReturnValue(1) = arrayInventory(Dimension, 1)
        ReturnValue(2) = arrayInventory(Dimension, 2)
        ReturnValue(3) = arrayInventory(Dimension, 3)
        Return ReturnValue
      Catch ex As Exception
        Return Nothing
      End Try
    End Get
    Set(value)
      arrayInventory(Dimension, 0) = value(0)
      arrayInventory(Dimension, 1) = value(1)
      arrayInventory(Dimension, 2) = value(2)
      arrayInventory(Dimension, 3) = value(3)
    End Set
  End Property 'GetInventorySpace
End Class