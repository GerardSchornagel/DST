Partial Class gamecache
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
		Me.progressbarLoading = New System.Windows.Forms.ProgressBar()
		Me.labelLoading = New System.Windows.Forms.Label()
		Me.labelDescription = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'progressbarLoading
		'
		Me.progressbarLoading.Location = New System.Drawing.Point(12, 38)
		Me.progressbarLoading.MarqueeAnimationSpeed = 25
		Me.progressbarLoading.Maximum = 10
		Me.progressbarLoading.Name = "progressbarLoading"
		Me.progressbarLoading.Size = New System.Drawing.Size(372, 30)
		Me.progressbarLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.progressbarLoading.TabIndex = 0
		'
		'labelLoading
		'
		Me.labelLoading.AutoSize = true
		Me.labelLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelLoading.Location = New System.Drawing.Point(153, 9)
		Me.labelLoading.Name = "labelLoading"
		Me.labelLoading.Size = New System.Drawing.Size(107, 26)
		Me.labelLoading.TabIndex = 1
		Me.labelLoading.Text = "Loading..."
		'
		'labelDescription
		'
		Me.labelDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelDescription.Location = New System.Drawing.Point(12, 71)
		Me.labelDescription.Name = "labelDescription"
		Me.labelDescription.Size = New System.Drawing.Size(372, 20)
		Me.labelDescription.TabIndex = 2
		Me.labelDescription.Text = "Description"
		'
		'gamecache
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(396, 101)
		Me.Controls.Add(Me.labelDescription)
		Me.Controls.Add(Me.labelLoading)
		Me.Controls.Add(Me.progressbarLoading)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "gamecache"
		Me.ShowIcon = false
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "cache"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private labelDescription As System.Windows.Forms.Label
	Private labelLoading As System.Windows.Forms.Label
	Private progressbarLoading As System.Windows.Forms.ProgressBar
End Class
