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
		Me.buttonNewGame = New System.Windows.Forms.Button()
		Me.buttonResumeGame = New System.Windows.Forms.Button()
		Me.buttonOptions = New System.Windows.Forms.Button()
		Me.buttonQuit = New System.Windows.Forms.Button()
		Me.buttonLoad = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'buttonNewGame
		'
		Me.buttonNewGame.Location = New System.Drawing.Point(12, 12)
		Me.buttonNewGame.Name = "buttonNewGame"
		Me.buttonNewGame.Size = New System.Drawing.Size(157, 23)
		Me.buttonNewGame.TabIndex = 0
		Me.buttonNewGame.Text = "New Game"
		Me.buttonNewGame.UseVisualStyleBackColor = true
		AddHandler Me.buttonNewGame.Click, AddressOf Me.buttonNewGameClick
		'
		'buttonResumeGame
		'
		Me.buttonResumeGame.Location = New System.Drawing.Point(12, 41)
		Me.buttonResumeGame.Name = "buttonResumeGame"
		Me.buttonResumeGame.Size = New System.Drawing.Size(157, 23)
		Me.buttonResumeGame.TabIndex = 0
		Me.buttonResumeGame.Text = "Load Last Game"
		Me.buttonResumeGame.UseVisualStyleBackColor = true
		AddHandler Me.buttonResumeGame.Click, AddressOf Me.buttonResumeGameClick
		'
		'buttonOptions
		'
		Me.buttonOptions.Location = New System.Drawing.Point(12, 99)
		Me.buttonOptions.Name = "buttonOptions"
		Me.buttonOptions.Size = New System.Drawing.Size(157, 23)
		Me.buttonOptions.TabIndex = 0
		Me.buttonOptions.Text = "Options..."
		Me.buttonOptions.UseVisualStyleBackColor = true
		AddHandler Me.buttonOptions.Click, AddressOf Me.buttonOptionsClick
		'
		'buttonQuit
		'
		Me.buttonQuit.Location = New System.Drawing.Point(12, 128)
		Me.buttonQuit.Name = "buttonQuit"
		Me.buttonQuit.Size = New System.Drawing.Size(157, 23)
		Me.buttonQuit.TabIndex = 0
		Me.buttonQuit.Text = "Quit"
		Me.buttonQuit.UseVisualStyleBackColor = true
		AddHandler Me.buttonQuit.Click, AddressOf Me.buttonQuitClick
		'
		'buttonLoad
		'
		Me.buttonLoad.Location = New System.Drawing.Point(11, 70)
		Me.buttonLoad.Name = "buttonLoad"
		Me.buttonLoad.Size = New System.Drawing.Size(157, 23)
		Me.buttonLoad.TabIndex = 0
		Me.buttonLoad.Text = "Load Game..."
		Me.buttonLoad.UseVisualStyleBackColor = true
		AddHandler Me.buttonLoad.Click, AddressOf Me.buttonLoadClick
		'
		'formMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(182, 161)
		Me.Controls.Add(Me.buttonNewGame)
		Me.Controls.Add(Me.buttonResumeGame)
		Me.Controls.Add(Me.buttonLoad)
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
	Private buttonNewGame As System.Windows.Forms.Button
	Private buttonResumeGame As System.Windows.Forms.Button
	Private buttonLoad As System.Windows.Forms.Button
	Private buttonOptions As System.Windows.Forms.Button
	Private buttonQuit As System.Windows.Forms.Button
End Class