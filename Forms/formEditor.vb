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
		ReDim stringExport(11, 1)
		stringExport(0, 0) = textboxSetting0.Text
		stringExport(0, 1) = textboxValue0.Text
		stringExport(1, 0) = textboxSetting1.Text
		stringExport(1, 1) = textboxValue1.Text
		stringExport(2, 0) = textboxSetting2.Text
		stringExport(2, 1) = textboxValue2.Text
		stringExport(3, 0) = textboxSetting3.Text
		stringExport(3, 1) = textboxValue3.Text
		stringExport(4, 0) = textboxSetting4.Text
		stringExport(4, 1) = textboxValue4.Text
		stringExport(5, 0) = textboxSetting5.Text
		stringExport(5, 1) = textboxValue5.Text
		stringExport(6, 0) = textboxSetting6.Text
		stringExport(6, 1) = textboxValue6.Text
		stringExport(7, 0) = textboxSetting7.Text
		stringExport(7, 1) = textboxValue7.Text
		stringExport(8, 0) = textboxSetting8.Text
		stringExport(8, 1) = textboxValue8.Text
		stringExport(9, 0) = textboxSetting9.Text
		stringExport(9, 1) = textboxValue9.Text
		stringExport(10, 0) = textboxSetting10.Text
		stringExport(10, 1) = textboxValue10.Text
		stringExport(11, 0) = textboxSetting11.Text
		stringExport(11, 1) = textboxValue11.Text
		iniFilehandler.Save(textboxFilename.Text, stringExport)
	End Sub
	
	Sub ButtonLoadClick(sender As Object, e As EventArgs)
		stringExport = iniFilehandler.Load(textboxFilename.Text)
		textboxSetting0.Text = stringExport(0 ,0)
		textboxValue0.Text = stringExport(0, 1)
		textboxSetting1.Text = stringExport(1, 0)
		textboxValue1.Text = stringExport(1, 1)
		textboxSetting2.Text = stringExport(2, 0)
		textboxValue2.Text = stringExport(2, 1)
		textboxSetting3.Text = stringExport(3, 0)
		textboxValue3.Text = stringExport(3, 1)
		textboxSetting4.Text = stringExport(4, 0)
		textboxValue4.Text = stringExport(4, 1)
		textboxSetting5.Text = stringExport(5, 0)
		textboxValue5.Text = stringExport(5, 1)
		textboxSetting6.Text = stringExport(6, 0)
		textboxValue6.Text = stringExport(6, 1)
		textboxSetting7.Text = stringExport(7, 0)
		textboxValue7.Text = stringExport(7, 1)
		textboxSetting8.Text = stringExport(8, 0)
		textboxValue8.Text = stringExport(8, 1)
		textboxSetting9.Text = stringExport(9, 0)
		textboxValue9.Text = stringExport(9, 1)
		textboxSetting10.Text = stringExport(10, 0)
		textboxValue10.Text = stringExport(10, 1)
		textboxSetting11.Text = stringExport(11, 0)
		textboxValue11.Text = stringExport(11, 1)
	End Sub
	
	Sub ButtonBrowseClick(sender As Object, e As EventArgs)
		Dim filebrowser As New System.Windows.Forms.SaveFileDialog
		filebrowser.AddExtension = False
		filebrowser.DefaultExt = "pd"
		filebrowser.InitialDirectory = System.IO.Directory.GetCurrentDirectory & "\data\"
		filebrowser.Title = "Choose new name or edit existing one."
		filebrowser.ShowDialog()
		textboxFilename.Text = filebrowser.FileName
	End Sub
End Class
