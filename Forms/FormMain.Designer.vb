<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.buttonNewGame = New System.Windows.Forms.Button()
    Me.buttonResumeGame = New System.Windows.Forms.Button()
    Me.buttonOptions = New System.Windows.Forms.Button()
    Me.buttonQuit = New System.Windows.Forms.Button()
    Me.buttonLoad = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'buttonNewGame
    '
    Me.buttonNewGame.Location = New System.Drawing.Point(12, 12)
    Me.buttonNewGame.Name = "buttonNewGame"
    Me.buttonNewGame.Size = New System.Drawing.Size(157, 23)
    Me.buttonNewGame.TabIndex = 0
    Me.buttonNewGame.Text = "New Game"
    Me.buttonNewGame.UseVisualStyleBackColor = True
    '
    'buttonResumeGame
    '
    Me.buttonResumeGame.Location = New System.Drawing.Point(12, 41)
    Me.buttonResumeGame.Name = "buttonResumeGame"
    Me.buttonResumeGame.Size = New System.Drawing.Size(157, 23)
    Me.buttonResumeGame.TabIndex = 0
    Me.buttonResumeGame.Text = "Load Last Game"
    Me.buttonResumeGame.UseVisualStyleBackColor = True
    '
    'buttonOptions
    '
    Me.buttonOptions.Location = New System.Drawing.Point(12, 99)
    Me.buttonOptions.Name = "buttonOptions"
    Me.buttonOptions.Size = New System.Drawing.Size(157, 23)
    Me.buttonOptions.TabIndex = 0
    Me.buttonOptions.Text = "Options..."
    Me.buttonOptions.UseVisualStyleBackColor = True
    '
    'buttonQuit
    '
    Me.buttonQuit.Location = New System.Drawing.Point(12, 128)
    Me.buttonQuit.Name = "buttonQuit"
    Me.buttonQuit.Size = New System.Drawing.Size(157, 23)
    Me.buttonQuit.TabIndex = 0
    Me.buttonQuit.Text = "Quit"
    Me.buttonQuit.UseVisualStyleBackColor = True
    '
    'buttonLoad
    '
    Me.buttonLoad.Location = New System.Drawing.Point(11, 70)
    Me.buttonLoad.Name = "buttonLoad"
    Me.buttonLoad.Size = New System.Drawing.Size(157, 23)
    Me.buttonLoad.TabIndex = 0
    Me.buttonLoad.Text = "Load Game..."
    Me.buttonLoad.UseVisualStyleBackColor = True
    '
    'formMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(180, 164)
    Me.Controls.Add(Me.buttonQuit)
    Me.Controls.Add(Me.buttonOptions)
    Me.Controls.Add(Me.buttonLoad)
    Me.Controls.Add(Me.buttonResumeGame)
    Me.Controls.Add(Me.buttonNewGame)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "formMain"
    Me.Text = "Main Menu"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents buttonNewGame As System.Windows.Forms.Button
  Friend WithEvents buttonResumeGame As System.Windows.Forms.Button
  Friend WithEvents buttonOptions As System.Windows.Forms.Button
  Friend WithEvents buttonQuit As System.Windows.Forms.Button
  Friend WithEvents buttonLoad As System.Windows.Forms.Button
End Class
