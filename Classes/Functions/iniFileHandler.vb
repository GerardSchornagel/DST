''' <summary>
''' Load and Save of ini-files.
''' </summary>
Public Class iniFileHandler
	Private stringAssembled(,) As String
	Private stringMediator() As String
	Private stringBody() As String
	Private stringIO As String
	Private integerMediator As Integer
	Private integerDimension1 As Integer
	Private integerDimension2 As Integer
	
	Public Function Load(Filepath As String) As String(,)
		'Take stringIO from file.
		Try
		Using binaryReader As New System.IO.BinaryReader(System.IO.File.Open(Filepath, System.IO.FileMode.Open))
			Do
				stringIO += binaryReader.ReadChar
			Loop
		End Using
		Catch ex As System.IO.EndOfStreamException
		End Try
		
		stringMediator = System.Text.RegularExpressions.Regex.Split(stringIO, (Chr(13) & Chr(10)))
		ReDim stringAssembled(stringMediator.GetUpperBound(0), 5)
		integerMediator = 0
		integerDimension1 = -1
		integerDimension2 = 0
		'*****ASSEMBLED FIRST BOUND TO BIG; MAYVBE COUNT "[" CHARS AND USE AS***
		Do
			'Check each entry for ""
			If stringMediator(integerMediator) = "" Then
				'Check each entry for "["
			ElseIf stringMediator(integerMediator).StartsWith("[") Then
				'TRUE=stringAssembled(#,) minus last "]"
				integerDimension1 += 1
				integerDimension2 = 0
				StringAssembled(integerDimension1, integerDimension2) = (stringMediator(integerMediator).remove(stringMediator(integerMediator).length - 1, 1)).Remove(0, 1)
				integerDimension2 = 1
			Else
				'FALSE=stringAssembled(,#)
				stringAssembled(integerDimension1, integerDimension2) = stringMediator(integerMediator)
				integerDimension2 += 1
			End If
			integerMediator += 1
		Loop Until integerMediator > stringMediator.GetUpperBound(0)
		'*****RETHINK STRATEGY: FIRST SPLIT IS BY RETURN AND LINE FEED****
		'Split stringIO to stringMediator() by opening bracket.
		'Split array1D(#) after closing bracket(1) = Split to arrayRow() by ";"
		'Get Upperbound of array1D and arrayRow = ReDim stringAssembled(,)
		'Split array1D(#) before closing bracket(0) = stringAssembled(#,) 'Maybe include "/r/n" [or just take next 4 Chr()]
		'Build from arrayRow() to stringAssembled(,#)
		'Rinse and repeat from step 3 and skip 4.
		Return stringAssembled
	End Function
	
	Public Sub Save(Filepath As String, SaveData(,) As String)
		'Get Upperbound(0&1) = ReDim arrayRow() & array1D()
		'Write open bracket to stringIO
		'Write 1st dimension from stringAssembled(#,) to stringIO
		'Write closing bracket to stringIO
		'Build from stringAssembled(,#) to arrayRow(#)
		'Write arrayRow() to stringIO glued by ";"
		'Rinse and repeat from step 2.
		'Start stringWriter
	End Sub
End Class