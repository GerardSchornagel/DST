''' <summary>
''' Used for creating new players and characters.
''' </summary>
Public Partial Class formNewGame
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
		
		Sub FormNewGameLoad(sender As Object, e As EventArgs)
		textboxCreateDate.Text = CType((System.DateTime.Now.Day & "-" & System.DateTime.Now.Month & "-" & System.DateTime.Now.Year), String)
		textboxCreateTime.Text = System.DateTime.Now.Hour & ":" & System.DateTime.Now.Minute
	End Sub
	
	Sub ButtonCreateClick(sender As Object, e As EventArgs)
		Dim Template(9) As String
		Template(0) = ""
		Template(1) = textboxNameNick.Text
		Template(2) = textboxNameFirst.Text
		Template(3) = textboxNameLast.Text
		Template(4) = textboxBirthYear.Text
		Template(5) = textboxBirthMonth.Text
		Template(6) = textboxBirthDay.Text
		Template(7) = checkboxGender.Text
		Template(8) = textboxCreateDate.Text
		Template(9) = textboxCreateTime.Text
		cache.NewPlayer(Template)
	End Sub
	
	Sub TextboxBirthYearLostFocus(sender As Object, e As EventArgs)
				Try
			textboxBirthYear.Text = CType(CType(textboxBirthYear.Text, Integer), String)
		Catch ex As Exception
			textboxBirthYear.Text = ""
		End Try
	End Sub
	
	Sub TextboxBirthMonthLostFocus(sender As Object, e As EventArgs)
				Try
			TextboxBirthMonth.Text = CType(CType(TextboxBirthMonth.Text, Integer), String)
		Catch ex As Exception
			TextboxBirthMonth.Text = ""
		End Try
	End Sub
	
	Sub TextboxBirthDayLostFocus(sender As Object, e As EventArgs)
				Try
			TextboxBirthDay.Text = CType(CType(TextboxBirthDay.Text, Integer), String)
		Catch ex As Exception
			TextboxBirthDay.Text = ""
		End Try
	End Sub
	
	Sub CheckboxGenderCheckedChanged(sender As Object, e As EventArgs)
		If checkboxGender.Checked = True Then
			checkboxGender.Text = "Female"
		Else
			checkboxGender.Text = "Male"
		End If
	End Sub
End Class
