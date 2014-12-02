''' <summary>
''' For data to file Conversion.
''' </summary>
Public Class binaryFileHandler
	Private stringLine As String
	Private stringRow() As String
	Private stringTable(,) As String
	
	Private stringStream As String
	Private integerRawCounter As Integer
	Private integerRowCounter As Integer
	Private integerColumnCounter As Integer
''' <summary>
''' Initialize class.
''' </summary>
	Sub New()
		
	End Sub
''' <summary>
''' Save input to file on given location.
''' </summary>
''' <param name="path">Complete path with ending slash.</param>
''' <param name="file">Complete with extension.</param>
''' <param name="line">Use with one-liners.</param>
''' <param name="row">Simple array's.</param>
''' <param name="table">2D array's.</param>
''' <param name="bound">Bound index for 2D array's.</param>
	Public Sub Save(ByVal path As String, ByVal file As String, Optional ByVal line As String = Nothing, Optional byval row() As String = Nothing, optional byval table(,) As String = Nothing, Optional ByVal bound As Integer = Nothing)
		'Make directory
		System.IO.Directory.CreateDirectory(path)
		'Preparing input for binaryWriter
			stringStream = "" 
		If line IsNot Nothing Then
			stringStream = line
			
		ElseIf row IsNot Nothing Then
			Do
				stringStream &= "<>" & CType(row(integerRowCounter), String)
				integerRowCounter += 1
			Loop until integerRowCounter > row.GetUpperBound(0)
			stringStream = stringStream.Remove(0,2)
			
		ElseIf table IsNot Nothing Then
			integerRowCounter = 0
			integerColumnCounter = 0
			integerRawCounter = 0
			Do
				Do
					stringStream &= "<>" & CType(table(integerColumnCounter, integerRowCounter), String)
					integerRowCounter += 1
				Loop until integerRowCounter > bound
				integerRowCounter = 0
				integerColumnCounter += 1
			Loop until integerColumnCounter > table.GetUpperBound(0)
			stringStream = stringStream.Remove(0,2)
		End If
		
		'Fill Array for character per character progressing
		Dim int32Stream(stringStream.Length) As Int32
		integerRowCounter = 0
		For Each character As Char In stringStream
			int32Stream(integerRowCounter) = Asc(character)
			integerRowCounter += 1
		Next
		'Use BinaryWriter with the int32Stream to write to path & file.
		Using binWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(System.IO.File.Open(path & file, System.IO.FileMode.Create))
			For Each integer32 As Int32 In int32Stream
				binWriter.Write(integer32)
			Next
		End Using
		'Resetting variables
		stringLine = Nothing
		stringRow = Nothing
		stringTable = Nothing
		stringStream = ""
		integerRowCounter = 0
		integerColumnCounter = 0
		int32Stream = Nothing
	End Sub
	''' <summary>
	''' Load given file to String.
	''' </summary>
	''' <param name="path">Complete path with ending slash.</param>
	''' <param name="file">Complete with extension.</param>
	''' <returns>One-line String.</returns>
	Public Function LoadLine(byval path As String, byval file As String) As String
		'Check for existing file.
		If System.IO.File.Exists(path & file) = False Then
			MsgBox(path & file & " doesn't exist..." & Chr(10) & "Aborting current load, going to next command.")
			Return Nothing
			Exit Function
		End If
		'Get all info from File to String.
		Using binReader As New System.IO.BinaryReader(System.IO.File.Open(path & file, System.IO.FileMode.Open))
			Do
				stringStream += (Chr(binReader.ReadInt32))
			Loop Until binReader.PeekChar = Nothing
		End Using
		
		Return stringStream
		'Resetting variable
		stringStream = ""
	End Function
	''' <summary>
	''' Load given file to String().
	''' </summary>
	''' <param name="path">Complete path with ending slash.</param>
	''' <param name="file">Complete with extension.</param>
	''' <returns>1D String array.</returns>
	Public Function LoadRow(byval path As String, byval file As String) As String()
		stringStream = ""
		stringRow = Nothing
		'Check for existing file.
		If System.IO.File.Exists(path & file) = False Then
			MsgBox(path & file & " doesn't exist..." & Chr(10) & "Aborting current load, going to next command.")
			Return Nothing
			Exit Function
		End If
		'Get all info from File to String.
		Using binReader As New System.IO.BinaryReader(System.IO.File.Open(path & file, System.IO.FileMode.Open))
			Do
				stringStream += (Chr(binReader.ReadInt32))
			Loop Until binReader.PeekChar = Nothing
		End Using
		'Split raw data in String-Array
		stringRow = stringStream.Split(New String() {"<>"}, StringSplitOptions.None)
		
		Return stringRow
		'Resetting variable
		stringStream = ""
		stringRow = Nothing
	End Function
	''' <summary>
	''' Load given file to String(,)
	''' </summary>
	''' <param name="path">Complete path with ending slash.</param>
	''' <param name="file">Complete with extension.</param>
	''' <param name="bound">Used to determine second bound.</param>
	''' <returns>2D String array.</returns>
	Public Function LoadTable(ByVal path As String, ByVal file As String, ByVal bound As Integer) As String(,)
		'Check for existing file.
		If System.IO.File.Exists(path & file) = False Then
			MsgBox(path & file & " doesn't exist..." & Chr(10) & "Aborting current load, going to next command.")
			Return Nothing
			Exit Function
		End If
		'Get all info from File to String.
		Using binReader As New System.IO.BinaryReader(System.IO.File.Open(path & file, System.IO.FileMode.Open))
			Do
				stringStream += (Chr(binReader.ReadInt32))
			Loop Until binReader.PeekChar = Nothing
		End Using
		'Split raw data in String-Array
		stringRow = stringStream.Split(New String() {"<>"}, StringSplitOptions.None)
		ReDim stringTable(CType(((stringRow.GetUpperBound(0) + 1) / (bound + 1)) - 1, Integer), bound)
		Do
			Do
				stringTable(integerColumnCounter, integerRowCounter) = stringRow(integerRawCounter)
				integerRawCounter += 1
				integerRowCounter += 1
			Loop Until integerRowCounter > bound
			integerColumnCounter += 1
			integerRowCounter = 0
		Loop Until integerColumnCounter > stringTable.GetUpperBound(0)
		
		Return stringTable
		'Resetting variable
		stringStream = ""
		stringRow = Nothing
		stringTable = Nothing
		integerRowCounter = 0
		integerColumnCounter = 0
		integerRawCounter = 0
	End Function
End Class