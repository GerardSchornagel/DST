
Partial Class formGame
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
		Me.buttonActionStart = New System.Windows.Forms.Button()
		Me.labelActionHour = New System.Windows.Forms.Label()
		Me.textboxActionHour = New System.Windows.Forms.TextBox()
		Me.labelActionLog = New System.Windows.Forms.Label()
		Me.textboxActionLog = New System.Windows.Forms.TextBox()
		Me.SuspendLayout
		'
		'buttonActionStart
		'
		Me.buttonActionStart.AutoSize = true
		Me.buttonActionStart.Location = New System.Drawing.Point(93, 25)
		Me.buttonActionStart.Name = "buttonActionStart"
		Me.buttonActionStart.Size = New System.Drawing.Size(79, 23)
		Me.buttonActionStart.TabIndex = 17
		Me.buttonActionStart.Text = "Start Day"
		AddHandler Me.buttonActionStart.Click, AddressOf Me.ButtonActionStartClick
		'
		'labelActionHour
		'
		Me.labelActionHour.AutoSize = true
		Me.labelActionHour.Location = New System.Drawing.Point(12, 9)
		Me.labelActionHour.Name = "labelActionHour"
		Me.labelActionHour.Size = New System.Drawing.Size(142, 13)
		Me.labelActionHour.TabIndex = 18
		Me.labelActionHour.Text = "Opening hours [0900 - 1800]"
		'
		'textboxActionHour
		'
		Me.textboxActionHour.Location = New System.Drawing.Point(12, 25)
		Me.textboxActionHour.Name = "textboxActionHour"
		Me.textboxActionHour.ReadOnly = true
		Me.textboxActionHour.Size = New System.Drawing.Size(75, 20)
		Me.textboxActionHour.TabIndex = 19
		Me.textboxActionHour.Text = "9"
		'
		'labelActionLog
		'
		Me.labelActionLog.AutoSize = true
		Me.labelActionLog.Location = New System.Drawing.Point(178, 8)
		Me.labelActionLog.Name = "labelActionLog"
		Me.labelActionLog.Size = New System.Drawing.Size(80, 13)
		Me.labelActionLog.TabIndex = 20
		Me.labelActionLog.Text = "Transaction-log"
		'
		'textboxActionLog
		'
		Me.textboxActionLog.Location = New System.Drawing.Point(178, 24)
		Me.textboxActionLog.Multiline = true
		Me.textboxActionLog.Name = "textboxActionLog"
		Me.textboxActionLog.ReadOnly = true
		Me.textboxActionLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.textboxActionLog.Size = New System.Drawing.Size(310, 256)
		Me.textboxActionLog.TabIndex = 21
		'
		'formGame
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(500, 288)
		Me.Controls.Add(Me.buttonActionStart)
		Me.Controls.Add(Me.labelActionHour)
		Me.Controls.Add(Me.textboxActionHour)
		Me.Controls.Add(Me.labelActionLog)
		Me.Controls.Add(Me.textboxActionLog)
		Me.Name = "formGame"
		Me.Text = "formGame"
		AddHandler Load, AddressOf Me.formGameLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private textboxActionLog As System.Windows.Forms.TextBox
	Private labelActionLog As System.Windows.Forms.Label
	Private textboxActionHour As System.Windows.Forms.TextBox
	Private labelActionHour As System.Windows.Forms.Label
	Private buttonActionStart As System.Windows.Forms.Button
End Class
