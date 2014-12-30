Partial Class formMain
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.buttonProfileManagement = New System.Windows.Forms.Button()
		Me.buttonCharacterManagement = New System.Windows.Forms.Button()
		Me.buttonLastCharacter = New System.Windows.Forms.Button()
		Me.buttonEditor = New System.Windows.Forms.Button()
		Me.buttonOptions = New System.Windows.Forms.Button()
		Me.buttonQuit = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'buttonProfileManagement
		'
		Me.buttonProfileManagement.Location = New System.Drawing.Point(12, 12)
		Me.buttonProfileManagement.Name = "buttonProfileManagement"
		Me.buttonProfileManagement.Size = New System.Drawing.Size(157, 23)
		Me.buttonProfileManagement.TabIndex = 0
		Me.buttonProfileManagement.Text = "Profile Management..."
		Me.buttonProfileManagement.UseVisualStyleBackColor = true
		AddHandler Me.buttonProfileManagement.Click, AddressOf Me.buttonProfileManagementClick
		'
		'buttonCharacterManagement
		'
		Me.buttonCharacterManagement.Enabled = false
		Me.buttonCharacterManagement.Location = New System.Drawing.Point(12, 41)
		Me.buttonCharacterManagement.Name = "buttonCharacterManagement"
		Me.buttonCharacterManagement.Size = New System.Drawing.Size(157, 23)
		Me.buttonCharacterManagement.TabIndex = 3
		Me.buttonCharacterManagement.Text = "Character Management..."
		Me.buttonCharacterManagement.UseVisualStyleBackColor = true
		AddHandler Me.buttonCharacterManagement.Click, AddressOf Me.buttonCharacterManagementClick
		'
		'buttonLastCharacter
		'
		Me.buttonLastCharacter.Location = New System.Drawing.Point(12, 85)
		Me.buttonLastCharacter.Name = "buttonLastCharacter"
		Me.buttonLastCharacter.Size = New System.Drawing.Size(157, 23)
		Me.buttonLastCharacter.TabIndex = 2
		Me.buttonLastCharacter.Text = "Continue Character/Game"
		Me.buttonLastCharacter.UseVisualStyleBackColor = true
		AddHandler Me.buttonLastCharacter.Click, AddressOf Me.buttonLastCharacterClick
		'
		'buttonEditor
		'
		Me.buttonEditor.Location = New System.Drawing.Point(12, 178)
		Me.buttonEditor.Name = "buttonEditor"
		Me.buttonEditor.Size = New System.Drawing.Size(157, 23)
		Me.buttonEditor.TabIndex = 4
		Me.buttonEditor.Text = "Editor..."
		Me.buttonEditor.UseVisualStyleBackColor = true
		AddHandler Me.buttonEditor.Click, AddressOf Me.buttonEditorClick
		'
		'buttonOptions
		'
		Me.buttonOptions.Location = New System.Drawing.Point(12, 207)
		Me.buttonOptions.Name = "buttonOptions"
		Me.buttonOptions.Size = New System.Drawing.Size(157, 23)
		Me.buttonOptions.TabIndex = 5
		Me.buttonOptions.Text = "Options..."
		Me.buttonOptions.UseVisualStyleBackColor = true
		AddHandler Me.buttonOptions.Click, AddressOf Me.buttonOptionsClick
		'
		'buttonQuit
		'
		Me.buttonQuit.Location = New System.Drawing.Point(12, 236)
		Me.buttonQuit.Name = "buttonQuit"
		Me.buttonQuit.Size = New System.Drawing.Size(157, 23)
		Me.buttonQuit.TabIndex = 6
		Me.buttonQuit.Text = "Quit"
		Me.buttonQuit.UseVisualStyleBackColor = true
		AddHandler Me.buttonQuit.Click, AddressOf Me.buttonQuitClick
		'
		'formMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(182, 272)
		Me.Controls.Add(Me.buttonProfileManagement)
		Me.Controls.Add(Me.buttonLastCharacter)
		Me.Controls.Add(Me.buttonCharacterManagement)
		Me.Controls.Add(Me.buttonEditor)
		Me.Controls.Add(Me.buttonOptions)
		Me.Controls.Add(Me.buttonQuit)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "formMain"
		Me.Text = "Main Menu"
		AddHandler Load, AddressOf Me.formMainLoad
		Me.ResumeLayout(false)
	End Sub
	Private buttonProfileManagement As System.Windows.Forms.Button
	Private buttonLastCharacter As System.Windows.Forms.Button
	Private buttonCharacterManagement As System.Windows.Forms.Button
	Private buttonEditor As System.Windows.Forms.Button
	Private buttonOptions As System.Windows.Forms.Button
	Private buttonQuit As System.Windows.Forms.Button
End Class