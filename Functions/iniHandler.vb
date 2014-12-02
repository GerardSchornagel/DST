''' <summary>
''' Will write/read 2D string-array's to/from read-able .ini files.
''' </summary>
Public Class iniHandler
	Private stringIO As String
	Dim stringMediator() As String
	Dim stringOutput(,) As String
	
	Private integerColumn As Integer
	Private integerRow As Integer
	Private integerMediator As Integer
	''' <summary>
	''' Saves a 2d string-array to directory and file.
	''' </summary>
	''' <param name="Pathname">Complete Path and File.</param>
	''' <param name="SavingFile">Input 2D string-array.</param>
	Public Sub Save(Pathname As String, SavingFile(,) As String)
		'Prepare variable's for new content.
		ReDim stringMediator((((SavingFile.GetUpperBound(0) + 1) * (SavingFile.GetUpperBound(1) + 1)) - 1) * 2)
		stringIO = ""
		integerColumn = 0
		integerRow = 0
		integerMediator = 0
		
		Do 'Loops all the Columns of the table.
			Do 'Loops all the Row Items.
				If SavingFile(integerColumn, integerRow) = "" Then 'Just continue next row.
				Else 'Save the row item to the stringMediator
					stringMediator(integerMediator) = SavingFile(integerColumn, integerRow)
					integerMediator += 1
				End If
					integerRow += 1
			Loop Until integerRow > SavingFile.GetUpperBound(1)
			'Prepare variable's for next Do for next Column.
			integerRow = 0
			integerColumn += 1
			stringMediator(integerMediator) = ""
			integerMediator += 1
		Loop Until integerColumn > SavingFile.GetUpperBound(0)
		
		'Add the Column max. bound to the file.
		If SavingFile.GetUpperBound(0) > 9 Then
			stringIO &= SavingFile.GetUpperBound(0)
		Else
			stringIO &= "0" & SavingFile.GetUpperBound(0)
		End If
		'Add the Row max. bound to the file.
		If SavingFile.GetUpperBound(1) > 9 Then
			stringIO &= SavingFile.GetUpperBound(1)
		Else
			stringIO &= "0" & SavingFile.GetUpperBound(1)
		End If
		'Loop through all stringMediator items and write as 1 string.
		integerMediator = 0
		Do
			stringIO &= stringMediator(integerMediator) & Chr(13) & Chr(10)
			integerMediator += 1
		Loop Until integerMediator > stringMediator.GetUpperBound(0)
		stringIO.Remove(stringIO.Length - 2, 2) 'Remove last two Chr's
		'Use StringBuilder for writing
		Dim stringbuilderIO As New System.Text.StringBuilder()
		Using streamreaderIO As New System.IO.StringReader(stringIO)
			stringbuilderIO.Append(streamreaderIO.ReadToEnd())
		End Using
        Using streamWriter As New System.IO.StreamWriter(Pathname, False, System.Text.Encoding.Default)
            streamWriter.Write(stringbuilderIO.ToString())
        End Using
	End Sub
	
	''' <summary>
	''' Load an 2d string-array from a .ini file.
	''' </summary>
	''' <param name="Pathname">Complete Path and File.</param>
	''' <returns>Returns a 2D string-array.</returns>
	Public Function Load(Pathname As String) As String(,)
		stringIO = ""
		Using streamReader As New System.IO.StreamReader(Pathname)
			stringIO = streamReader.ReadToEnd()
		End Using
		
		ReDim stringOutput(CType(stringIO.Substring(0, 2), Integer), CType(stringIO.Substring(2, 2), Integer))
		stringIO = stringIO.Remove(0, 4)
		
		stringMediator = stringIO.Split(Chr(10))
		integerMediator = 0
		For Each line In stringMediator
			If stringMediator(integerMediator) = "" Then
				integerMediator += 1
				Continue For
			End If
			stringMediator(integerMediator) = line.Remove(line.Length - 1, 1)
			integerMediator += 1
		Next
		integerColumn = -1
		integerRow = 0
		integerMediator = 0
		
		Do
			If stringMediator(integerMediator) = "" Then
				integerMediator += 1
				Continue Do
			ElseIf stringMediator(integerMediator).Substring(0, 1) = "[" Then
				integerColumn += 1
				integerRow = 0
				stringOutput(integerColumn, integerRow) = stringMediator(integerMediator)
				integerRow += 1
				integerMediator += 1
			Else
				stringOutput(integerColumn, integerRow) = stringMediator(integerMediator)
				integerMediator += 1
				integerRow += 1
			End If
			
		Loop Until integerMediator > stringMediator.GetUpperBound(0)
		Return stringOutput
	End Function
End Class
