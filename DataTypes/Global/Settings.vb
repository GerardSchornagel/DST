Public Class Settings
  Private intLastUser As Integer = 99 'If not overriden this is Create New

  Private bolMessagesProgramQuit As Boolean = False 'Asks if Exiting the Program is true
  Private bolMessagesNewgameOverwrite As Boolean = False 'Inform about overwrite of Load Last Game
  Private bolMessagesOptionsApplyrestart As Boolean = False 'Inform about restart of Game

  Private strBinaryFileData As String = "" 'Used as temponary string-storage

  Sub New()
    'Get all info from File
    Try
      Using binReader As New System.IO.BinaryReader(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\settings.prd", System.IO.FileMode.Open))
        Do
          strBinaryFileData += (Chr(binReader.ReadInt32))
        Loop Until binReader.PeekChar = Nothing
      End Using
      'Split raw data in String-Array
      Dim arraySettings As String() = strBinaryFileData.Split(New String() {"<>"}, StringSplitOptions.None)
      'Write Private's
      intLastUser = CType(arraySettings(0), Integer)
      bolMessagesProgramQuit = CType(arraySettings(1), Boolean)
      bolMessagesNewgameOverwrite = CType(arraySettings(2), Boolean)
      bolMessagesOptionsApplyrestart = CType(arraySettings(3), Boolean)

    Catch DnFException As IO.DirectoryNotFoundException 'If there is no directory create empty one from defaults.
      SaveState()
    Catch FnFException As IO.FileNotFoundException 'If there is no file create empty one from defaults.
      SaveState()
    End Try
  End Sub 'Sub New

  Private Sub SaveState()
    'Make Raw data String
    strBinaryFileData = intLastUser
    strBinaryFileData += "<>" & bolMessagesProgramQuit
    strBinaryFileData += "<>" & bolMessagesNewgameOverwrite
    strBinaryFileData += "<>" & bolMessagesOptionsApplyrestart

    'Fill Array for character per character progressing
    Dim arrayInt32(strBinaryFileData.Length) As Int32
    Dim intDimension As Integer = 0
    For Each character As Char In strBinaryFileData
      arrayInt32(intDimension) = Asc(character)
      intDimension += 1
    Next

    ' Create the BinaryWriter and use File.Create to create the file.
    If intLastUser = 99 Then System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\save")
    Using binWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(System.IO.File.Open(System.IO.Directory.GetCurrentDirectory & "\save\settings.prd", System.IO.FileMode.Create))
      For Each integer32 As Int32 In arrayInt32
        binWriter.Write(integer32)
      Next
    End Using
  End Sub 'Sub SaveState

    '--------PROPERTY'S---------
  Public Property LastUser As Integer
    Get
      Return intLastUser
    End Get
    Set(Value As Integer)
      intLastUser = Value
      SaveState()
    End Set
  End Property 'Property LastUser

  Public Property MessagesProgramQuit As Boolean
    Get
      Return bolMessagesProgramQuit
    End Get
    Set(Value As Boolean)
      bolMessagesProgramQuit = Value
      SaveState()
    End Set
  End Property 'Property MessagesProgramQuit

  Public Property MessagesNewgameOverwrite As Boolean
    Get
      Return bolMessagesNewgameOverwrite
    End Get
    Set(Value As Boolean)
      bolMessagesNewgameOverwrite = Value
      SaveState()
    End Set
  End Property 'Property MessagesNewgameOverwrite

  Public Property MessagesOptionsApplyrestart As Boolean
    Get
      Return bolMessagesOptionsApplyrestart
    End Get
    Set(Value As Boolean)
      bolMessagesOptionsApplyrestart = Value
      SaveState()
    End Set
  End Property 'Property MessagesOptionsApplyrestart
End Class
