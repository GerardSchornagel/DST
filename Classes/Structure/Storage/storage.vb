''' <summary>
''' DataType representing any number of Section's as a Storage().
''' </summary>
Public Class storage
	Public Shared arraySection() As Section
	Private stringPathStorage As String
	Private integerSectionCounter As Integer
''' <summary>
''' Empty Sub.
''' </summary>
	Public Sub New()
		
	End Sub
''' <summary>
''' Get/Adjust the path of the Storage without Initialize() and Load().
''' </summary>
	Public Property StoragePath As String
		Get
			Return stringPathStorage
		End Get
		Set (Value As String)
			stringPathStorage = Value
		End Set
	End Property
''' <summary>
''' Resizes arraySection() and fill with New Section's.
''' </summary>
	Public Sub StorageInitialize()
		integerSectionCounter = 0
		ReDim arraySection(System.IO.Directory.GetDirectories(stringPathStorage, "*", System.IO.SearchOption.TopDirectoryOnly).GetUpperBound(0))
		For Each folder As String In System.IO.Directory.GetDirectories(stringPathStorage, "*", System.IO.SearchOption.TopDirectoryOnly)
			arraySection(integerSectionCounter) = New Section
			arraySection(integerSectionCounter).SectionPath = folder
			integerSectionCounter += 1
		Next
	End Sub
''' <summary>
''' Loads all Shelves with all Bin's with all Items.
''' </summary>
	Public Shared Sub StorageLoad()
		For Each Section As section In arraySection
			Section.SectionInitialize()
			Section.SectionLoad()
		Next
	End Sub
''' <summary>
''' Adds a empty Storage with 1 Section and 1 Bin containing 'Nothing'.
''' </summary>
	Public Sub SectionAdd()
		Dim intCheck As Integer = 0
		Do
			If System.IO.Directory.Exists(stringPathStorage & "\" & intCheck) = False Then
				Exit Do
			End If
			intCheck += 1
		Loop
		ReDim Preserve arraySection(intCheck)
		System.IO.Directory.CreateDirectory(stringPathStorage & "\" & intCheck)
		arraySection(arraySection.GetUpperBound(0)) = New Section
		arraySection(arraySection.GetUpperBound(0)).SectionPath = stringPathStorage & "\" & intCheck
	End Sub
End Class
