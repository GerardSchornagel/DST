''' <summary>
''' Used for creating new Profiles and characters.
''' </summary>
Public Partial Class formProfileManagement
	Private stringProfile(,) As String
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub formProfileManagementLoad(sender As Object, e As EventArgs)
		listboxProfile.Items.Clear()
		If gamecache.settingsGlobal.LastProfile = "0" Then
			MsgBox("Please create a first Player Profile to enter the MainMenu.", MsgBoxStyle.OkOnly)
			
		Else
			For Each file As String In System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory & "\save\")
				Dim profileID() As String = file.Split(Chr(92))
				listboxProfile.Items.Add(profileID(profileID.GetUpperBound(0)))
			Next
		End If
	End Sub
	
	Sub ButtonCreateClick(sender As Object, e As EventArgs)
		Dim ProfileInfo(9) As String
		ProfileInfo(0) = textboxProfileID.Text
		ProfileInfo(1) = textboxNameFirst.Text
		ProfileInfo(2) = textboxNameLast.Text
		ProfileInfo(3) = textboxBirthYear.Text
		ProfileInfo(4) = textboxBirthMonth.Text
		ProfileInfo(5) = textboxBirthDay.Text
		ProfileInfo(6) = checkboxGender.Text
		ProfileInfo(7) = textboxEMail.Text
		ProfileInfo(8) = CType(checkboxNotification.Checked.ToString, String)
		gamecache.profileInformation.NewProfile(ProfileInfo)
		gamecache.profileStats.NewStatistics(New String() {CType((System.DateTime.Now.Day & "-" & System.DateTime.Now.Month & "-" & System.DateTime.Now.Year), String), CType(System.DateTime.Now.Hour & ":" & System.DateTime.Now.Minute, String)})
		gamecache.playerCharacter.NewCharacter(New String() {CType((System.DateTime.Now.Day & "-" & System.DateTime.Now.Month & "-" & System.DateTime.Now.Year), String), CType(System.DateTime.Now.Hour & ":" & System.DateTime.Now.Minute, String)})
		gamecache.NewProfile()
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
	
	Sub TextboxNameFirstTextChanged(sender As Object, e As EventArgs)
		textboxProfileID.Text = textboxNameLast.Text & "_" & textboxNameFirst.Text
	End Sub
	
	Sub TextboxNameLastTextChanged(sender As Object, e As EventArgs)
		textboxProfileID.Text = textboxNameLast.Text & "_" & textboxNameFirst.Text
	End Sub
	
	Sub ButtonLoadClick(sender As Object, e As EventArgs)
		gamecache.settingsGlobal.LastProfile = listboxProfile.SelectedItem.ToString
		gamecache.ResumeGame()
	End Sub
End Class