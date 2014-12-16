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
		Dim PlayerInfo(9) As String
		PlayerInfo(0) = ""
		PlayerInfo(1) = textboxNameNick.Text
		PlayerInfo(2) = textboxNameFirst.Text
		PlayerInfo(3) = textboxNameLast.Text
		PlayerInfo(4) = textboxBirthYear.Text
		PlayerInfo(5) = textboxBirthMonth.Text
		PlayerInfo(6) = textboxBirthDay.Text
		PlayerInfo(7) = checkboxGender.Text
		PlayerInfo(8) = textboxCreateDate.Text
		PlayerInfo(9) = textboxCreateTime.Text
		gamecache.NewPlayer(PlayerInfo)
	End Sub
	
	Sub TextBoxBirthYearLostFocus(sender As Object, e As EventArgs)
				Try
			textboxBirthYear.Text = CType(CType(textboxBirthYear.Text, Integer), String)
		Catch ex As System.FormatException
			textboxBirthYear.Text = ""
		End Try
	End Sub
	
	Sub TextBoxBirthMonthLostFocus(sender As Object, e As EventArgs)
				Try
			TextboxBirthMonth.Text = CType(CType(TextboxBirthMonth.Text, Integer), String)
		Catch ex As System.FormatException
			TextboxBirthMonth.Text = ""
		End Try
	End Sub
	
	Sub TextBoxBirthDayLostFocus(sender As Object, e As EventArgs)
				Try
			TextboxBirthDay.Text = CType(CType(TextboxBirthDay.Text, Integer), String)
		Catch ex As System.FormatException
			TextboxBirthDay.Text = ""
		End Try
	End Sub
	
	Sub CheckBoxGenderCheckedChanged(sender As Object, e As EventArgs)
		If checkboxGender.Checked = True Then
			checkboxGender.Text = "Female"
		Else
			checkboxGender.Text = "Male"
		End If
	End Sub
End Class
