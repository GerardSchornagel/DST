Partial Class formDC
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
		Me.textboxBuyAmount = New System.Windows.Forms.TextBox()
		Me.textboxBuyPrice = New System.Windows.Forms.TextBox()
		Me.buttonClose = New System.Windows.Forms.Button()
		Me.buttonBuy = New System.Windows.Forms.Button()
		Me.labelBuyAmount = New System.Windows.Forms.Label()
		Me.labelWorthBaseName = New System.Windows.Forms.Label()
		Me.labelBuyPrice = New System.Windows.Forms.Label()
		Me.labelQualityName = New System.Windows.Forms.Label()
		Me.comboboxDepartment = New System.Windows.Forms.ComboBox()
		Me.comboboxName = New System.Windows.Forms.ComboBox()
		Me.comboboxGenre = New System.Windows.Forms.ComboBox()
		Me.comboboxCategory = New System.Windows.Forms.ComboBox()
		Me.labelCategory = New System.Windows.Forms.Label()
		Me.labelDepartment = New System.Windows.Forms.Label()
		Me.labelGenre = New System.Windows.Forms.Label()
		Me.labelName = New System.Windows.Forms.Label()
		Me.groupboxItemInfo = New System.Windows.Forms.GroupBox()
		Me.labelManufactorerDisplay = New System.Windows.Forms.Label()
		Me.labelManufactorerName = New System.Windows.Forms.Label()
		Me.labelGenreDisplay = New System.Windows.Forms.Label()
		Me.labelGenreName = New System.Windows.Forms.Label()
		Me.labelItemDisplay = New System.Windows.Forms.Label()
		Me.labelItemName = New System.Windows.Forms.Label()
		Me.labelWorthBaseDisplay = New System.Windows.Forms.Label()
		Me.labelCategoryDisplay = New System.Windows.Forms.Label()
		Me.labelCategoryName = New System.Windows.Forms.Label()
		Me.labelGenreSubDisplay = New System.Windows.Forms.Label()
		Me.labelGenreSubName = New System.Windows.Forms.Label()
		Me.labelDepartmentDisplay = New System.Windows.Forms.Label()
		Me.labelDepartmentName = New System.Windows.Forms.Label()
		Me.labelQualityDisplay = New System.Windows.Forms.Label()
		Me.textboxPriceTotal = New System.Windows.Forms.TextBox()
		Me.labelPriceTotal = New System.Windows.Forms.Label()
		Me.groupboxItemInfo.SuspendLayout
		Me.SuspendLayout
		'
		'textboxBuyAmount
		'
		Me.textboxBuyAmount.Location = New System.Drawing.Point(181, 313)
		Me.textboxBuyAmount.Name = "textboxBuyAmount"
		Me.textboxBuyAmount.Size = New System.Drawing.Size(95, 20)
		Me.textboxBuyAmount.TabIndex = 72
		AddHandler Me.textboxBuyAmount.TextChanged, AddressOf Me.TextboxBuyAmountTextChanged
		'
		'textboxBuyPrice
		'
		Me.textboxBuyPrice.Location = New System.Drawing.Point(12, 313)
		Me.textboxBuyPrice.Name = "textboxBuyPrice"
		Me.textboxBuyPrice.ReadOnly = true
		Me.textboxBuyPrice.Size = New System.Drawing.Size(163, 20)
		Me.textboxBuyPrice.TabIndex = 71
		'
		'buttonClose
		'
		Me.buttonClose.Location = New System.Drawing.Point(199, 339)
		Me.buttonClose.Name = "buttonClose"
		Me.buttonClose.Size = New System.Drawing.Size(178, 25)
		Me.buttonClose.TabIndex = 67
		Me.buttonClose.Text = "Close"
		Me.buttonClose.UseVisualStyleBackColor = true
		AddHandler Me.buttonClose.Click, AddressOf Me.ButtonCloseClick
		'
		'buttonBuy
		'
		Me.buttonBuy.Location = New System.Drawing.Point(12, 339)
		Me.buttonBuy.Name = "buttonBuy"
		Me.buttonBuy.Size = New System.Drawing.Size(181, 25)
		Me.buttonBuy.TabIndex = 66
		Me.buttonBuy.Text = "Buy"
		Me.buttonBuy.UseVisualStyleBackColor = true
		AddHandler Me.buttonBuy.Click, AddressOf Me.ButtonBuyClick
		'
		'labelBuyAmount
		'
		Me.labelBuyAmount.AutoSize = true
		Me.labelBuyAmount.Location = New System.Drawing.Point(181, 297)
		Me.labelBuyAmount.Name = "labelBuyAmount"
		Me.labelBuyAmount.Size = New System.Drawing.Size(75, 13)
		Me.labelBuyAmount.TabIndex = 65
		Me.labelBuyAmount.Text = "Amount to buy"
		'
		'labelWorthBaseName
		'
		Me.labelWorthBaseName.AutoSize = true
		Me.labelWorthBaseName.Location = New System.Drawing.Point(6, 118)
		Me.labelWorthBaseName.Name = "labelWorthBaseName"
		Me.labelWorthBaseName.Size = New System.Drawing.Size(66, 13)
		Me.labelWorthBaseName.TabIndex = 64
		Me.labelWorthBaseName.Text = "Base Worth:"
		'
		'labelBuyPrice
		'
		Me.labelBuyPrice.AutoSize = true
		Me.labelBuyPrice.Location = New System.Drawing.Point(12, 297)
		Me.labelBuyPrice.Name = "labelBuyPrice"
		Me.labelBuyPrice.Size = New System.Drawing.Size(146, 13)
		Me.labelBuyPrice.TabIndex = 62
		Me.labelBuyPrice.Text = "Current Buy Price -50%\+25%"
		'
		'labelQualityName
		'
		Me.labelQualityName.AutoSize = true
		Me.labelQualityName.Location = New System.Drawing.Point(6, 135)
		Me.labelQualityName.Name = "labelQualityName"
		Me.labelQualityName.Size = New System.Drawing.Size(100, 13)
		Me.labelQualityName.TabIndex = 63
		Me.labelQualityName.Text = "Quality Percentage:"
		'
		'comboboxDepartment
		'
		Me.comboboxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboboxDepartment.FormattingEnabled = true
		Me.comboboxDepartment.Location = New System.Drawing.Point(12, 25)
		Me.comboboxDepartment.Name = "comboboxDepartment"
		Me.comboboxDepartment.Size = New System.Drawing.Size(365, 21)
		Me.comboboxDepartment.TabIndex = 49
		AddHandler Me.comboboxDepartment.SelectedIndexChanged, AddressOf Me.ComboboxDepartmentSelectedIndexChanged
		'
		'comboboxName
		'
		Me.comboboxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
		Me.comboboxName.FormattingEnabled = true
		Me.comboboxName.Location = New System.Drawing.Point(383, 25)
		Me.comboboxName.Name = "comboboxName"
		Me.comboboxName.Size = New System.Drawing.Size(365, 346)
		Me.comboboxName.TabIndex = 54
		AddHandler Me.comboboxName.SelectedIndexChanged, AddressOf Me.ComboboxNameSelectedIndexChanged
		'
		'comboboxGenre
		'
		Me.comboboxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboboxGenre.FormattingEnabled = true
		Me.comboboxGenre.Location = New System.Drawing.Point(12, 65)
		Me.comboboxGenre.Name = "comboboxGenre"
		Me.comboboxGenre.Size = New System.Drawing.Size(365, 21)
		Me.comboboxGenre.TabIndex = 50
		AddHandler Me.comboboxGenre.SelectedIndexChanged, AddressOf Me.ComboboxGenreSelectedIndexChanged
		'
		'comboboxCategory
		'
		Me.comboboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboboxCategory.FormattingEnabled = true
		Me.comboboxCategory.Location = New System.Drawing.Point(12, 105)
		Me.comboboxCategory.Name = "comboboxCategory"
		Me.comboboxCategory.Size = New System.Drawing.Size(365, 21)
		Me.comboboxCategory.TabIndex = 52
		AddHandler Me.comboboxCategory.SelectedIndexChanged, AddressOf Me.ComboboxCategorySelectedIndexChanged
		'
		'labelCategory
		'
		Me.labelCategory.AutoSize = true
		Me.labelCategory.Location = New System.Drawing.Point(12, 89)
		Me.labelCategory.Name = "labelCategory"
		Me.labelCategory.Size = New System.Drawing.Size(81, 13)
		Me.labelCategory.TabIndex = 60
		Me.labelCategory.Text = "Article Category"
		'
		'labelDepartment
		'
		Me.labelDepartment.AutoSize = true
		Me.labelDepartment.Location = New System.Drawing.Point(12, 9)
		Me.labelDepartment.Name = "labelDepartment"
		Me.labelDepartment.Size = New System.Drawing.Size(62, 13)
		Me.labelDepartment.TabIndex = 59
		Me.labelDepartment.Text = "Department"
		'
		'labelGenre
		'
		Me.labelGenre.AutoSize = true
		Me.labelGenre.Location = New System.Drawing.Point(12, 49)
		Me.labelGenre.Name = "labelGenre"
		Me.labelGenre.Size = New System.Drawing.Size(36, 13)
		Me.labelGenre.TabIndex = 57
		Me.labelGenre.Text = "Genre"
		'
		'labelName
		'
		Me.labelName.AutoSize = true
		Me.labelName.Location = New System.Drawing.Point(380, 9)
		Me.labelName.Name = "labelName"
		Me.labelName.Size = New System.Drawing.Size(75, 13)
		Me.labelName.TabIndex = 55
		Me.labelName.Text = "Product Name"
		'
		'groupboxItemInfo
		'
		Me.groupboxItemInfo.Controls.Add(Me.labelManufactorerDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelManufactorerName)
		Me.groupboxItemInfo.Controls.Add(Me.labelGenreDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelGenreName)
		Me.groupboxItemInfo.Controls.Add(Me.labelItemDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelItemName)
		Me.groupboxItemInfo.Controls.Add(Me.labelWorthBaseDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelWorthBaseName)
		Me.groupboxItemInfo.Controls.Add(Me.labelCategoryDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelCategoryName)
		Me.groupboxItemInfo.Controls.Add(Me.labelGenreSubDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelGenreSubName)
		Me.groupboxItemInfo.Controls.Add(Me.labelDepartmentDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelDepartmentName)
		Me.groupboxItemInfo.Controls.Add(Me.labelQualityDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelQualityName)
		Me.groupboxItemInfo.Location = New System.Drawing.Point(12, 132)
		Me.groupboxItemInfo.Name = "groupboxItemInfo"
		Me.groupboxItemInfo.Size = New System.Drawing.Size(365, 162)
		Me.groupboxItemInfo.TabIndex = 73
		Me.groupboxItemInfo.TabStop = false
		'
		'labelManufactorerDisplay
		'
		Me.labelManufactorerDisplay.AutoSize = true
		Me.labelManufactorerDisplay.Location = New System.Drawing.Point(112, 84)
		Me.labelManufactorerDisplay.Name = "labelManufactorerDisplay"
		Me.labelManufactorerDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelManufactorerDisplay.TabIndex = 64
		'
		'labelManufactorerName
		'
		Me.labelManufactorerName.AutoSize = true
		Me.labelManufactorerName.Location = New System.Drawing.Point(6, 84)
		Me.labelManufactorerName.Name = "labelManufactorerName"
		Me.labelManufactorerName.Size = New System.Drawing.Size(73, 13)
		Me.labelManufactorerName.TabIndex = 64
		Me.labelManufactorerName.Text = "Manufactorer:"
		'
		'labelGenreDisplay
		'
		Me.labelGenreDisplay.AutoSize = true
		Me.labelGenreDisplay.Location = New System.Drawing.Point(112, 33)
		Me.labelGenreDisplay.Name = "labelGenreDisplay"
		Me.labelGenreDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelGenreDisplay.TabIndex = 64
		'
		'labelGenreName
		'
		Me.labelGenreName.AutoSize = true
		Me.labelGenreName.Location = New System.Drawing.Point(6, 33)
		Me.labelGenreName.Name = "labelGenreName"
		Me.labelGenreName.Size = New System.Drawing.Size(39, 13)
		Me.labelGenreName.TabIndex = 64
		Me.labelGenreName.Text = "Genre:"
		'
		'labelItemDisplay
		'
		Me.labelItemDisplay.AutoSize = true
		Me.labelItemDisplay.Location = New System.Drawing.Point(112, 101)
		Me.labelItemDisplay.Name = "labelItemDisplay"
		Me.labelItemDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelItemDisplay.TabIndex = 63
		'
		'labelItemName
		'
		Me.labelItemName.AutoSize = true
		Me.labelItemName.Location = New System.Drawing.Point(6, 101)
		Me.labelItemName.Name = "labelItemName"
		Me.labelItemName.Size = New System.Drawing.Size(61, 13)
		Me.labelItemName.TabIndex = 63
		Me.labelItemName.Text = "Item Name:"
		'
		'labelWorthBaseDisplay
		'
		Me.labelWorthBaseDisplay.AutoSize = true
		Me.labelWorthBaseDisplay.Location = New System.Drawing.Point(112, 118)
		Me.labelWorthBaseDisplay.Name = "labelWorthBaseDisplay"
		Me.labelWorthBaseDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelWorthBaseDisplay.TabIndex = 64
		'
		'labelCategoryDisplay
		'
		Me.labelCategoryDisplay.AutoSize = true
		Me.labelCategoryDisplay.Location = New System.Drawing.Point(112, 67)
		Me.labelCategoryDisplay.Name = "labelCategoryDisplay"
		Me.labelCategoryDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelCategoryDisplay.TabIndex = 61
		'
		'labelCategoryName
		'
		Me.labelCategoryName.AutoSize = true
		Me.labelCategoryName.Location = New System.Drawing.Point(6, 67)
		Me.labelCategoryName.Name = "labelCategoryName"
		Me.labelCategoryName.Size = New System.Drawing.Size(52, 13)
		Me.labelCategoryName.TabIndex = 61
		Me.labelCategoryName.Text = "Category:"
		'
		'labelGenreSubDisplay
		'
		Me.labelGenreSubDisplay.AutoSize = true
		Me.labelGenreSubDisplay.Location = New System.Drawing.Point(112, 50)
		Me.labelGenreSubDisplay.Name = "labelGenreSubDisplay"
		Me.labelGenreSubDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelGenreSubDisplay.TabIndex = 63
		'
		'labelGenreSubName
		'
		Me.labelGenreSubName.AutoSize = true
		Me.labelGenreSubName.Location = New System.Drawing.Point(6, 50)
		Me.labelGenreSubName.Name = "labelGenreSubName"
		Me.labelGenreSubName.Size = New System.Drawing.Size(58, 13)
		Me.labelGenreSubName.TabIndex = 63
		Me.labelGenreSubName.Text = "SubGenre:"
		'
		'labelDepartmentDisplay
		'
		Me.labelDepartmentDisplay.AutoSize = true
		Me.labelDepartmentDisplay.Location = New System.Drawing.Point(112, 16)
		Me.labelDepartmentDisplay.Name = "labelDepartmentDisplay"
		Me.labelDepartmentDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelDepartmentDisplay.TabIndex = 61
		'
		'labelDepartmentName
		'
		Me.labelDepartmentName.AutoSize = true
		Me.labelDepartmentName.Location = New System.Drawing.Point(6, 16)
		Me.labelDepartmentName.Name = "labelDepartmentName"
		Me.labelDepartmentName.Size = New System.Drawing.Size(65, 13)
		Me.labelDepartmentName.TabIndex = 61
		Me.labelDepartmentName.Text = "Department:"
		'
		'labelQualityDisplay
		'
		Me.labelQualityDisplay.AutoSize = true
		Me.labelQualityDisplay.Location = New System.Drawing.Point(112, 135)
		Me.labelQualityDisplay.Name = "labelQualityDisplay"
		Me.labelQualityDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelQualityDisplay.TabIndex = 63
		'
		'textboxPriceTotal
		'
		Me.textboxPriceTotal.Location = New System.Drawing.Point(282, 313)
		Me.textboxPriceTotal.Name = "textboxPriceTotal"
		Me.textboxPriceTotal.ReadOnly = true
		Me.textboxPriceTotal.Size = New System.Drawing.Size(95, 20)
		Me.textboxPriceTotal.TabIndex = 72
		'
		'labelPriceTotal
		'
		Me.labelPriceTotal.AutoSize = true
		Me.labelPriceTotal.Location = New System.Drawing.Point(282, 297)
		Me.labelPriceTotal.Name = "labelPriceTotal"
		Me.labelPriceTotal.Size = New System.Drawing.Size(58, 13)
		Me.labelPriceTotal.TabIndex = 65
		Me.labelPriceTotal.Text = "Total Price"
		'
		'formDC
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(760, 378)
		Me.Controls.Add(Me.groupboxItemInfo)
		Me.Controls.Add(Me.textboxPriceTotal)
		Me.Controls.Add(Me.comboboxDepartment)
		Me.Controls.Add(Me.textboxBuyAmount)
		Me.Controls.Add(Me.comboboxName)
		Me.Controls.Add(Me.comboboxGenre)
		Me.Controls.Add(Me.textboxBuyPrice)
		Me.Controls.Add(Me.comboboxCategory)
		Me.Controls.Add(Me.buttonClose)
		Me.Controls.Add(Me.labelCategory)
		Me.Controls.Add(Me.labelPriceTotal)
		Me.Controls.Add(Me.labelBuyAmount)
		Me.Controls.Add(Me.labelDepartment)
		Me.Controls.Add(Me.buttonBuy)
		Me.Controls.Add(Me.labelBuyPrice)
		Me.Controls.Add(Me.labelGenre)
		Me.Controls.Add(Me.labelName)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "formDC"
		Me.Text = "Buying Goods"
		AddHandler Load, AddressOf Me.formItemManagementLoad
		Me.groupboxItemInfo.ResumeLayout(false)
		Me.groupboxItemInfo.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
  End Sub
	Private labelQualityDisplay As System.Windows.Forms.Label
	Private labelDepartmentDisplay As System.Windows.Forms.Label
	Private labelGenreSubDisplay As System.Windows.Forms.Label
	Private labelCategoryDisplay As System.Windows.Forms.Label
	Private labelWorthBaseDisplay As System.Windows.Forms.Label
	Private labelItemDisplay As System.Windows.Forms.Label
	Private labelGenreDisplay As System.Windows.Forms.Label
	Private labelManufactorerDisplay As System.Windows.Forms.Label
	Private labelDepartmentName As System.Windows.Forms.Label
	Private labelGenreSubName As System.Windows.Forms.Label
	Private labelCategoryName As System.Windows.Forms.Label
	Private labelItemName As System.Windows.Forms.Label
	Private labelGenreName As System.Windows.Forms.Label
	Private labelManufactorerName As System.Windows.Forms.Label
	Private labelPriceTotal As System.Windows.Forms.Label
	Private textboxPriceTotal As System.Windows.Forms.TextBox
	Private groupboxItemInfo As System.Windows.Forms.GroupBox
	Private textboxBuyAmount As System.Windows.Forms.TextBox
	Private textboxBuyPrice As System.Windows.Forms.TextBox
	Private buttonClose As System.Windows.Forms.Button
	Private buttonBuy As System.Windows.Forms.Button
	Private labelBuyAmount As System.Windows.Forms.Label
	Private labelWorthBaseName As System.Windows.Forms.Label
	Private labelBuyPrice As System.Windows.Forms.Label
	Private labelQualityName As System.Windows.Forms.Label
	Private comboboxDepartment As System.Windows.Forms.ComboBox
	Private comboboxName As System.Windows.Forms.ComboBox
	Private comboboxGenre As System.Windows.Forms.ComboBox
	Private comboboxCategory As System.Windows.Forms.ComboBox
	Private labelCategory As System.Windows.Forms.Label
	Private labelDepartment As System.Windows.Forms.Label
	Private labelGenre As System.Windows.Forms.Label
	Private labelName As System.Windows.Forms.Label
End Class