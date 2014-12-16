''' <summary>
''' Description of form/class/etc.
''' </summary>
Public Partial Class formEditor
	Private stringExport(,) As String
	Private iniFilehandler As New iniHandler
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		textboxFilename.Text = System.IO.Directory.GetCurrentDirectory & "\data\"
	End Sub
	
	Sub ButtonCloseClick(sender As Object, e As EventArgs)
		Me.Hide()
	End Sub
	
	Sub ButtonSaveClick(sender As Object, e As EventArgs)
		textboxEdit.AppendText(Chr(13))
		Dim stringMediator() As String = textboxEdit.Text.Split(Chr(10))
		Dim integerCount As Integer = 0
		Do
			stringMediator(integerCount) = stringMediator(integerCount).Remove(stringMediator(integerCount).Length - 1, 1)
			integerCount += 1
		Loop Until integerCount > stringMediator.GetUpperBound(0)
		
		Dim integerColumn As Integer = -1
		Dim integerRow As Integer = 0
		
		Dim stringColumns As String()
		stringColumns = textboxEdit.Text.Split(Chr(91))
		For Each line As String In stringColumns
			Dim stringRow() As String = line.Split(Chr(60))
			If integerRow < stringRow.GetUpperBound(0) Then integerRow = stringRow.GetUpperBound(0)
		Next
		ReDim stringExport(stringColumns.GetUpperBound(0) - 1, (integerRow * 2))
		
		integerRow = 0
		For Each line As String In stringMediator
			If line.StartsWith("[") = True Then
				integerColumn += 1
				integerRow = 0
				stringExport(integerColumn, integerRow) = line
			ElseIf line = "" Then
				
			Else
				integerRow += 1
				stringExport(integerColumn, integerRow) = line
			End If
		Next
		iniFilehandler.Save(textboxFilename.Text, stringExport)
	End Sub
	
	Sub ButtonLoadClick(sender As Object, e As EventArgs)
		textboxEdit.Text = ""
		stringExport = iniFilehandler.Load(textboxFilename.Text)
		For Each line As String In stringExport
			textboxEdit.AppendText(line & Chr(13) & Chr(10))
		Next
	End Sub
	
	Sub ButtonBrowseClick(sender As Object, e As EventArgs)
		Dim filebrowser As New System.Windows.Forms.SaveFileDialog
		filebrowser.AddExtension = False
		filebrowser.DefaultExt = "pd"
		filebrowser.InitialDirectory = System.IO.Directory.GetCurrentDirectory & "\data"
		filebrowser.Title = "Choose new name or edit existing one."
		filebrowser.ShowDialog()
		textboxFilename.Text = filebrowser.FileName
	End Sub
	
	Sub FormEditorLoad(sender As Object, e As EventArgs)
		listboxDescription.Items.Add("Items")
		listboxDescription.Items.Add("Customers")
		listboxDescription.Items.Add("Settings")
	End Sub
	
	Sub ListboxDescriptionSelectedIndexChanged(sender As Object, e As EventArgs)
		If listboxDescription.SelectedIndex = 0 Then 'Items
			textboxDescription.Text = "[ItemInformation]" & Chr(13) & Chr(10) & "<Name/Title>" & Chr(13) & Chr(10) & "<Brand/Author>" & Chr(13) & Chr(10) & "<Company/Publisher>" & Chr(13) & Chr(10) & "<Genre>" & Chr(13) & Chr(10) & "<Category>" & Chr(13) & Chr(10) & "<Family>" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "[Statistics]" & Chr(13) & Chr(10) & "<Quality>" & Chr(13) & Chr(10) & "<Popularity>" & Chr(13) & Chr(10) & "<Rarity>" & Chr(13) & Chr(10) & "<BaseWorth>" & Chr(13) & Chr(10) & "<ItemTier>" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "[Various]" & Chr(13) & Chr(10) & "<PictureFilename>" & Chr(13) & Chr(10) & "<Description>"
		ElseIf listboxDescription.SelectedIndex = 1 Then 'Customers
			textboxDescription.Text = "[Age]" & Chr(13) & Chr(10) & "<Min>" & Chr(13) & Chr(10) & "<Max>" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "[Money]" & Chr(13) & Chr(10) & "<Min>" & Chr(13) & Chr(10) & "<Max>" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "[Desire]" & Chr(13) & Chr(10) & "<Min>" & Chr(13) & Chr(10) & "<Max>"
		ElseIf listboxDescription.SelectedIndex = 2 Then 'Settings
			textboxDescription.Text = "[WarningMessages]" & Chr(13) & Chr(10) & "<ProgramQuit>" & Chr(13) & Chr(10) & "<NewgameOverwrite>" & Chr(13) & Chr(10) & "<OptionsApplyRestart>"
		End If
	End Sub
End Class
