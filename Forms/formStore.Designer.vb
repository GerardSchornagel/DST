<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStore
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
    Me.textboxBuyAmount = New System.Windows.Forms.TextBox()
    Me.textboxBuyPrice = New System.Windows.Forms.TextBox()
    Me.textboxQuality = New System.Windows.Forms.TextBox()
    Me.textboxWorthMaximum = New System.Windows.Forms.TextBox()
    Me.textboxWorthMinimum = New System.Windows.Forms.TextBox()
    Me.buttonClose = New System.Windows.Forms.Button()
    Me.buttonBuy = New System.Windows.Forms.Button()
    Me.labelBuyAmount = New System.Windows.Forms.Label()
    Me.labelWorthMaximum = New System.Windows.Forms.Label()
    Me.labelBuyPrice = New System.Windows.Forms.Label()
    Me.labelQuality = New System.Windows.Forms.Label()
    Me.labelWorthMinimum = New System.Windows.Forms.Label()
    Me.comboboxDepartment = New System.Windows.Forms.ComboBox()
    Me.comboboxSubGenre = New System.Windows.Forms.ComboBox()
    Me.comboboxName = New System.Windows.Forms.ComboBox()
    Me.comboboxGenre = New System.Windows.Forms.ComboBox()
    Me.combobocManufactor = New System.Windows.Forms.ComboBox()
    Me.comboboxCategory = New System.Windows.Forms.ComboBox()
    Me.labelCategory = New System.Windows.Forms.Label()
    Me.labelDepartment = New System.Windows.Forms.Label()
    Me.labelSubGenre = New System.Windows.Forms.Label()
    Me.labelGenre = New System.Windows.Forms.Label()
    Me.labelManufactor = New System.Windows.Forms.Label()
    Me.labelName = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'textboxBuyAmount
    '
    Me.textboxBuyAmount.Location = New System.Drawing.Point(572, 522)
    Me.textboxBuyAmount.Name = "textboxBuyAmount"
    Me.textboxBuyAmount.Size = New System.Drawing.Size(177, 20)
    Me.textboxBuyAmount.TabIndex = 72
    '
    'textboxBuyPrice
    '
    Me.textboxBuyPrice.Location = New System.Drawing.Point(386, 522)
    Me.textboxBuyPrice.Name = "textboxBuyPrice"
    Me.textboxBuyPrice.ReadOnly = True
    Me.textboxBuyPrice.Size = New System.Drawing.Size(180, 20)
    Me.textboxBuyPrice.TabIndex = 71
    '
    'textboxQuality
    '
    Me.textboxQuality.Location = New System.Drawing.Point(633, 483)
    Me.textboxQuality.Name = "textboxQuality"
    Me.textboxQuality.ReadOnly = True
    Me.textboxQuality.Size = New System.Drawing.Size(118, 20)
    Me.textboxQuality.TabIndex = 70
    '
    'textboxWorthMaximum
    '
    Me.textboxWorthMaximum.Location = New System.Drawing.Point(510, 483)
    Me.textboxWorthMaximum.Name = "textboxWorthMaximum"
    Me.textboxWorthMaximum.ReadOnly = True
    Me.textboxWorthMaximum.Size = New System.Drawing.Size(118, 20)
    Me.textboxWorthMaximum.TabIndex = 69
    '
    'textboxWorthMinimum
    '
    Me.textboxWorthMinimum.Location = New System.Drawing.Point(386, 483)
    Me.textboxWorthMinimum.Name = "textboxWorthMinimum"
    Me.textboxWorthMinimum.ReadOnly = True
    Me.textboxWorthMinimum.Size = New System.Drawing.Size(118, 20)
    Me.textboxWorthMinimum.TabIndex = 68
    '
    'buttonClose
    '
    Me.buttonClose.Location = New System.Drawing.Point(635, 574)
    Me.buttonClose.Name = "buttonClose"
    Me.buttonClose.Size = New System.Drawing.Size(116, 23)
    Me.buttonClose.TabIndex = 67
    Me.buttonClose.Text = "Close"
    Me.buttonClose.UseVisualStyleBackColor = True
    '
    'buttonBuy
    '
    Me.buttonBuy.Location = New System.Drawing.Point(386, 574)
    Me.buttonBuy.Name = "buttonBuy"
    Me.buttonBuy.Size = New System.Drawing.Size(241, 23)
    Me.buttonBuy.TabIndex = 66
    Me.buttonBuy.Text = "Buy"
    Me.buttonBuy.UseVisualStyleBackColor = True
    '
    'labelBuyAmount
    '
    Me.labelBuyAmount.AutoSize = True
    Me.labelBuyAmount.Location = New System.Drawing.Point(569, 506)
    Me.labelBuyAmount.Name = "labelBuyAmount"
    Me.labelBuyAmount.Size = New System.Drawing.Size(75, 13)
    Me.labelBuyAmount.TabIndex = 65
    Me.labelBuyAmount.Text = "Amount to buy"
    '
    'labelWorthMaximum
    '
    Me.labelWorthMaximum.AutoSize = True
    Me.labelWorthMaximum.Location = New System.Drawing.Point(507, 467)
    Me.labelWorthMaximum.Name = "labelWorthMaximum"
    Me.labelWorthMaximum.Size = New System.Drawing.Size(83, 13)
    Me.labelWorthMaximum.TabIndex = 64
    Me.labelWorthMaximum.Text = "Maximum Worth"
    '
    'labelBuyPrice
    '
    Me.labelBuyPrice.AutoSize = True
    Me.labelBuyPrice.Location = New System.Drawing.Point(386, 506)
    Me.labelBuyPrice.Name = "labelBuyPrice"
    Me.labelBuyPrice.Size = New System.Drawing.Size(89, 13)
    Me.labelBuyPrice.TabIndex = 62
    Me.labelBuyPrice.Text = "Current Buy Price"
    '
    'labelQuality
    '
    Me.labelQuality.AutoSize = True
    Me.labelQuality.Location = New System.Drawing.Point(630, 467)
    Me.labelQuality.Name = "labelQuality"
    Me.labelQuality.Size = New System.Drawing.Size(109, 13)
    Me.labelQuality.TabIndex = 63
    Me.labelQuality.Text = "Quality Rating (0-100)"
    '
    'labelWorthMinimum
    '
    Me.labelWorthMinimum.AutoSize = True
    Me.labelWorthMinimum.Location = New System.Drawing.Point(386, 467)
    Me.labelWorthMinimum.Name = "labelWorthMinimum"
    Me.labelWorthMinimum.Size = New System.Drawing.Size(80, 13)
    Me.labelWorthMinimum.TabIndex = 61
    Me.labelWorthMinimum.Text = "Minimum Worth"
    '
    'comboboxDepartment
    '
    Me.comboboxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
    Me.comboboxDepartment.FormattingEnabled = True
    Me.comboboxDepartment.Location = New System.Drawing.Point(15, 25)
    Me.comboboxDepartment.Name = "comboboxDepartment"
    Me.comboboxDepartment.Size = New System.Drawing.Size(365, 99)
    Me.comboboxDepartment.TabIndex = 49
    '
    'comboboxSubGenre
    '
    Me.comboboxSubGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
    Me.comboboxSubGenre.FormattingEnabled = True
    Me.comboboxSubGenre.Location = New System.Drawing.Point(15, 337)
    Me.comboboxSubGenre.Name = "comboboxSubGenre"
    Me.comboboxSubGenre.Size = New System.Drawing.Size(365, 268)
    Me.comboboxSubGenre.TabIndex = 51
    '
    'comboboxName
    '
    Me.comboboxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
    Me.comboboxName.FormattingEnabled = True
    Me.comboboxName.Location = New System.Drawing.Point(386, 326)
    Me.comboboxName.Name = "comboboxName"
    Me.comboboxName.Size = New System.Drawing.Size(365, 138)
    Me.comboboxName.TabIndex = 54
    '
    'comboboxGenre
    '
    Me.comboboxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
    Me.comboboxGenre.FormattingEnabled = True
    Me.comboboxGenre.Location = New System.Drawing.Point(15, 143)
    Me.comboboxGenre.Name = "comboboxGenre"
    Me.comboboxGenre.Size = New System.Drawing.Size(365, 175)
    Me.comboboxGenre.TabIndex = 50
    '
    'combobocManufactor
    '
    Me.combobocManufactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
    Me.combobocManufactor.FormattingEnabled = True
    Me.combobocManufactor.Location = New System.Drawing.Point(386, 208)
    Me.combobocManufactor.Name = "combobocManufactor"
    Me.combobocManufactor.Size = New System.Drawing.Size(365, 99)
    Me.combobocManufactor.TabIndex = 53
    '
    'comboboxCategory
    '
    Me.comboboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
    Me.comboboxCategory.FormattingEnabled = True
    Me.comboboxCategory.Location = New System.Drawing.Point(386, 25)
    Me.comboboxCategory.Name = "comboboxCategory"
    Me.comboboxCategory.Size = New System.Drawing.Size(365, 164)
    Me.comboboxCategory.TabIndex = 52
    '
    'labelCategory
    '
    Me.labelCategory.AutoSize = True
    Me.labelCategory.Location = New System.Drawing.Point(383, 9)
    Me.labelCategory.Name = "labelCategory"
    Me.labelCategory.Size = New System.Drawing.Size(81, 13)
    Me.labelCategory.TabIndex = 60
    Me.labelCategory.Text = "Article Category"
    '
    'labelDepartment
    '
    Me.labelDepartment.AutoSize = True
    Me.labelDepartment.Location = New System.Drawing.Point(12, 9)
    Me.labelDepartment.Name = "labelDepartment"
    Me.labelDepartment.Size = New System.Drawing.Size(62, 13)
    Me.labelDepartment.TabIndex = 59
    Me.labelDepartment.Text = "Department"
    '
    'labelSubGenre
    '
    Me.labelSubGenre.AutoSize = True
    Me.labelSubGenre.Location = New System.Drawing.Point(12, 321)
    Me.labelSubGenre.Name = "labelSubGenre"
    Me.labelSubGenre.Size = New System.Drawing.Size(55, 13)
    Me.labelSubGenre.TabIndex = 58
    Me.labelSubGenre.Text = "SubGenre"
    '
    'labelGenre
    '
    Me.labelGenre.AutoSize = True
    Me.labelGenre.Location = New System.Drawing.Point(15, 127)
    Me.labelGenre.Name = "labelGenre"
    Me.labelGenre.Size = New System.Drawing.Size(36, 13)
    Me.labelGenre.TabIndex = 57
    Me.labelGenre.Text = "Genre"
    '
    'labelManufactor
    '
    Me.labelManufactor.AutoSize = True
    Me.labelManufactor.Location = New System.Drawing.Point(383, 192)
    Me.labelManufactor.Name = "labelManufactor"
    Me.labelManufactor.Size = New System.Drawing.Size(61, 13)
    Me.labelManufactor.TabIndex = 56
    Me.labelManufactor.Text = "Manufactor"
    '
    'labelName
    '
    Me.labelName.AutoSize = True
    Me.labelName.Location = New System.Drawing.Point(383, 310)
    Me.labelName.Name = "labelName"
    Me.labelName.Size = New System.Drawing.Size(75, 13)
    Me.labelName.TabIndex = 55
    Me.labelName.Text = "Product Name"
    '
    'formStore
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(762, 610)
    Me.Controls.Add(Me.textboxBuyAmount)
    Me.Controls.Add(Me.textboxBuyPrice)
    Me.Controls.Add(Me.textboxQuality)
    Me.Controls.Add(Me.textboxWorthMaximum)
    Me.Controls.Add(Me.textboxWorthMinimum)
    Me.Controls.Add(Me.buttonClose)
    Me.Controls.Add(Me.buttonBuy)
    Me.Controls.Add(Me.labelBuyAmount)
    Me.Controls.Add(Me.labelWorthMaximum)
    Me.Controls.Add(Me.labelBuyPrice)
    Me.Controls.Add(Me.labelQuality)
    Me.Controls.Add(Me.labelWorthMinimum)
    Me.Controls.Add(Me.comboboxDepartment)
    Me.Controls.Add(Me.comboboxSubGenre)
    Me.Controls.Add(Me.comboboxName)
    Me.Controls.Add(Me.comboboxGenre)
    Me.Controls.Add(Me.combobocManufactor)
    Me.Controls.Add(Me.comboboxCategory)
    Me.Controls.Add(Me.labelCategory)
    Me.Controls.Add(Me.labelDepartment)
    Me.Controls.Add(Me.labelSubGenre)
    Me.Controls.Add(Me.labelGenre)
    Me.Controls.Add(Me.labelManufactor)
    Me.Controls.Add(Me.labelName)
    Me.Name = "formStore"
    Me.Text = "Buying Goods"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents textboxBuyAmount As System.Windows.Forms.TextBox
  Friend WithEvents textboxBuyPrice As System.Windows.Forms.TextBox
  Friend WithEvents textboxQuality As System.Windows.Forms.TextBox
  Friend WithEvents textboxWorthMaximum As System.Windows.Forms.TextBox
  Friend WithEvents textboxWorthMinimum As System.Windows.Forms.TextBox
  Friend WithEvents buttonClose As System.Windows.Forms.Button
  Friend WithEvents buttonBuy As System.Windows.Forms.Button
  Friend WithEvents labelBuyAmount As System.Windows.Forms.Label
  Friend WithEvents labelWorthMaximum As System.Windows.Forms.Label
  Friend WithEvents labelBuyPrice As System.Windows.Forms.Label
  Friend WithEvents labelQuality As System.Windows.Forms.Label
  Friend WithEvents labelWorthMinimum As System.Windows.Forms.Label
  Friend WithEvents comboboxDepartment As System.Windows.Forms.ComboBox
  Friend WithEvents comboboxSubGenre As System.Windows.Forms.ComboBox
  Friend WithEvents comboboxName As System.Windows.Forms.ComboBox
  Friend WithEvents comboboxGenre As System.Windows.Forms.ComboBox
  Friend WithEvents combobocManufactor As System.Windows.Forms.ComboBox
  Friend WithEvents comboboxCategory As System.Windows.Forms.ComboBox
  Friend WithEvents labelCategory As System.Windows.Forms.Label
  Friend WithEvents labelDepartment As System.Windows.Forms.Label
  Friend WithEvents labelSubGenre As System.Windows.Forms.Label
  Friend WithEvents labelGenre As System.Windows.Forms.Label
  Friend WithEvents labelManufactor As System.Windows.Forms.Label
  Friend WithEvents labelName As System.Windows.Forms.Label
End Class
