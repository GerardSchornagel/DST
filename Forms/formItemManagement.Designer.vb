Partial Class formItemManagement
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
		Me.labelStoreTotalLevel = New System.Windows.Forms.Label()
		Me.updownStoreLevel = New System.Windows.Forms.NumericUpDown()
		Me.labelStoreLevel = New System.Windows.Forms.Label()
		Me.labelStoreShelf = New System.Windows.Forms.Label()
		Me.updownStoreShelf = New System.Windows.Forms.NumericUpDown()
		Me.labelStoreTotalShelf = New System.Windows.Forms.Label()
		Me.labelStoreTotalBin = New System.Windows.Forms.Label()
		Me.updownStoreBin = New System.Windows.Forms.NumericUpDown()
		Me.labelStoreBin = New System.Windows.Forms.Label()
		Me.groupboxStoreNavigation = New System.Windows.Forms.GroupBox()
		Me.groupboxStoreSelected = New System.Windows.Forms.GroupBox()
		Me.updownStorePrice = New System.Windows.Forms.NumericUpDown()
		Me.textboxStoreQuantity = New System.Windows.Forms.TextBox()
		Me.labelStorePrice = New System.Windows.Forms.Label()
		Me.textboxStoreName = New System.Windows.Forms.TextBox()
		Me.labelStoreQuantity = New System.Windows.Forms.Label()
		Me.textboxStorePhItem = New System.Windows.Forms.TextBox()
		Me.labelStoreName = New System.Windows.Forms.Label()
		Me.labelStorePhItem = New System.Windows.Forms.Label()
		Me.textboxStoragePhItem = New System.Windows.Forms.TextBox()
		Me.labelStoragePhItem = New System.Windows.Forms.Label()
		Me.buttonToStore = New System.Windows.Forms.Button()
		Me.buttonToStorage = New System.Windows.Forms.Button()
		Me.buttonClose = New System.Windows.Forms.Button()
		Me.groupboxStore = New System.Windows.Forms.GroupBox()
		Me.labelStorageQuantity = New System.Windows.Forms.Label()
		Me.labelStorageLastBuy = New System.Windows.Forms.Label()
		Me.labelStorageLastSell = New System.Windows.Forms.Label()
		Me.groupboxStorage = New System.Windows.Forms.GroupBox()
		Me.groupboxStorageNavigation = New System.Windows.Forms.GroupBox()
		Me.labelStorageArticle = New System.Windows.Forms.Label()
		Me.labelStorageSection = New System.Windows.Forms.Label()
		Me.updownStorageArticle = New System.Windows.Forms.NumericUpDown()
		Me.labelStorageTotalSection = New System.Windows.Forms.Label()
		Me.labelStorageTotalArticle = New System.Windows.Forms.Label()
		Me.updownStorageSection = New System.Windows.Forms.NumericUpDown()
		Me.groupboxStorageSelected = New System.Windows.Forms.GroupBox()
		Me.textboxStorageLastBuy = New System.Windows.Forms.TextBox()
		Me.textboxStorageName = New System.Windows.Forms.TextBox()
		Me.textboxStorageLastSell = New System.Windows.Forms.TextBox()
		Me.textboxStorageQuantity = New System.Windows.Forms.TextBox()
		Me.labelStorageName = New System.Windows.Forms.Label()
		CType(Me.updownStoreLevel,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updownStoreShelf,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updownStoreBin,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupboxStoreNavigation.SuspendLayout
		Me.groupboxStoreSelected.SuspendLayout
		CType(Me.updownStorePrice,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupboxStore.SuspendLayout
		Me.groupboxStorage.SuspendLayout
		Me.groupboxStorageNavigation.SuspendLayout
		CType(Me.updownStorageArticle,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.updownStorageSection,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupboxStorageSelected.SuspendLayout
		Me.SuspendLayout
		'
		'labelStoreTotalLevel
		'
		Me.labelStoreTotalLevel.AutoSize = true
		Me.labelStoreTotalLevel.Location = New System.Drawing.Point(46, 34)
		Me.labelStoreTotalLevel.Name = "labelStoreTotalLevel"
		Me.labelStoreTotalLevel.Size = New System.Drawing.Size(21, 13)
		Me.labelStoreTotalLevel.TabIndex = 1
		Me.labelStoreTotalLevel.Text = "\ 0"
		'
		'updownStoreLevel
		'
		Me.updownStoreLevel.Location = New System.Drawing.Point(6, 32)
		Me.updownStoreLevel.Name = "updownStoreLevel"
		Me.updownStoreLevel.Size = New System.Drawing.Size(34, 20)
		Me.updownStoreLevel.TabIndex = 2
		AddHandler Me.updownStoreLevel.ValueChanged, AddressOf Me.updownStoreLevelValueChanged
		'
		'labelStoreLevel
		'
		Me.labelStoreLevel.AutoSize = true
		Me.labelStoreLevel.Location = New System.Drawing.Point(6, 16)
		Me.labelStoreLevel.Name = "labelStoreLevel"
		Me.labelStoreLevel.Size = New System.Drawing.Size(36, 13)
		Me.labelStoreLevel.TabIndex = 3
		Me.labelStoreLevel.Text = "Level:"
		'
		'labelStoreShelf
		'
		Me.labelStoreShelf.AutoSize = true
		Me.labelStoreShelf.Location = New System.Drawing.Point(98, 16)
		Me.labelStoreShelf.Name = "labelStoreShelf"
		Me.labelStoreShelf.Size = New System.Drawing.Size(34, 13)
		Me.labelStoreShelf.TabIndex = 6
		Me.labelStoreShelf.Text = "Shelf:"
		'
		'updownStoreShelf
		'
		Me.updownStoreShelf.Location = New System.Drawing.Point(98, 32)
		Me.updownStoreShelf.Name = "updownStoreShelf"
		Me.updownStoreShelf.Size = New System.Drawing.Size(34, 20)
		Me.updownStoreShelf.TabIndex = 5
		AddHandler Me.updownStoreShelf.ValueChanged, AddressOf Me.updownStoreShelfValueChanged
		'
		'labelStoreTotalShelf
		'
		Me.labelStoreTotalShelf.AutoSize = true
		Me.labelStoreTotalShelf.Location = New System.Drawing.Point(138, 34)
		Me.labelStoreTotalShelf.Name = "labelStoreTotalShelf"
		Me.labelStoreTotalShelf.Size = New System.Drawing.Size(21, 13)
		Me.labelStoreTotalShelf.TabIndex = 4
		Me.labelStoreTotalShelf.Text = "\ 0"
		'
		'labelStoreTotalBin
		'
		Me.labelStoreTotalBin.AutoSize = true
		Me.labelStoreTotalBin.Location = New System.Drawing.Point(233, 34)
		Me.labelStoreTotalBin.Name = "labelStoreTotalBin"
		Me.labelStoreTotalBin.Size = New System.Drawing.Size(21, 13)
		Me.labelStoreTotalBin.TabIndex = 4
		Me.labelStoreTotalBin.Text = "\ 0"
		'
		'updownStoreBin
		'
		Me.updownStoreBin.Location = New System.Drawing.Point(193, 32)
		Me.updownStoreBin.Name = "updownStoreBin"
		Me.updownStoreBin.Size = New System.Drawing.Size(34, 20)
		Me.updownStoreBin.TabIndex = 5
		AddHandler Me.updownStoreBin.ValueChanged, AddressOf Me.updownStoreBinValueChanged
		'
		'labelStoreBin
		'
		Me.labelStoreBin.AutoSize = true
		Me.labelStoreBin.Location = New System.Drawing.Point(193, 16)
		Me.labelStoreBin.Name = "labelStoreBin"
		Me.labelStoreBin.Size = New System.Drawing.Size(25, 13)
		Me.labelStoreBin.TabIndex = 6
		Me.labelStoreBin.Text = "Bin:"
		'
		'groupboxStoreNavigation
		'
		Me.groupboxStoreNavigation.Controls.Add(Me.labelStoreLevel)
		Me.groupboxStoreNavigation.Controls.Add(Me.labelStoreBin)
		Me.groupboxStoreNavigation.Controls.Add(Me.labelStoreTotalLevel)
		Me.groupboxStoreNavigation.Controls.Add(Me.labelStoreShelf)
		Me.groupboxStoreNavigation.Controls.Add(Me.updownStoreLevel)
		Me.groupboxStoreNavigation.Controls.Add(Me.updownStoreBin)
		Me.groupboxStoreNavigation.Controls.Add(Me.labelStoreTotalShelf)
		Me.groupboxStoreNavigation.Controls.Add(Me.labelStoreTotalBin)
		Me.groupboxStoreNavigation.Controls.Add(Me.updownStoreShelf)
		Me.groupboxStoreNavigation.Location = New System.Drawing.Point(6, 19)
		Me.groupboxStoreNavigation.Name = "groupboxStoreNavigation"
		Me.groupboxStoreNavigation.Size = New System.Drawing.Size(260, 57)
		Me.groupboxStoreNavigation.TabIndex = 7
		Me.groupboxStoreNavigation.TabStop = false
		Me.groupboxStoreNavigation.Text = "Navigation"
		'
		'groupboxStoreSelected
		'
		Me.groupboxStoreSelected.Controls.Add(Me.updownStorePrice)
		Me.groupboxStoreSelected.Controls.Add(Me.textboxStoreQuantity)
		Me.groupboxStoreSelected.Controls.Add(Me.labelStorePrice)
		Me.groupboxStoreSelected.Controls.Add(Me.textboxStoreName)
		Me.groupboxStoreSelected.Controls.Add(Me.labelStoreQuantity)
		Me.groupboxStoreSelected.Controls.Add(Me.textboxStorePhItem)
		Me.groupboxStoreSelected.Controls.Add(Me.labelStoreName)
		Me.groupboxStoreSelected.Controls.Add(Me.labelStorePhItem)
		Me.groupboxStoreSelected.Location = New System.Drawing.Point(6, 82)
		Me.groupboxStoreSelected.Name = "groupboxStoreSelected"
		Me.groupboxStoreSelected.Size = New System.Drawing.Size(260, 142)
		Me.groupboxStoreSelected.TabIndex = 8
		Me.groupboxStoreSelected.TabStop = false
		Me.groupboxStoreSelected.Text = "Selected Bin"
		'
		'updownStorePrice
		'
		Me.updownStorePrice.Location = New System.Drawing.Point(112, 97)
		Me.updownStorePrice.Name = "updownStorePrice"
		Me.updownStorePrice.Size = New System.Drawing.Size(141, 20)
		Me.updownStorePrice.TabIndex = 4
		AddHandler Me.updownStorePrice.LostFocus, AddressOf Me.updownStorePriceLostFocus
		'
		'textboxStoreQuantity
		'
		Me.textboxStoreQuantity.Location = New System.Drawing.Point(112, 71)
		Me.textboxStoreQuantity.Name = "textboxStoreQuantity"
		Me.textboxStoreQuantity.Size = New System.Drawing.Size(141, 20)
		Me.textboxStoreQuantity.TabIndex = 3
		'
		'labelStorePrice
		'
		Me.labelStorePrice.AutoSize = true
		Me.labelStorePrice.Location = New System.Drawing.Point(5, 100)
		Me.labelStorePrice.Name = "labelStorePrice"
		Me.labelStorePrice.Size = New System.Drawing.Size(68, 13)
		Me.labelStorePrice.TabIndex = 2
		Me.labelStorePrice.Text = "Selling Price:"
		'
		'textboxStoreName
		'
		Me.textboxStoreName.Location = New System.Drawing.Point(112, 45)
		Me.textboxStoreName.Name = "textboxStoreName"
		Me.textboxStoreName.Size = New System.Drawing.Size(141, 20)
		Me.textboxStoreName.TabIndex = 3
		'
		'labelStoreQuantity
		'
		Me.labelStoreQuantity.AutoSize = true
		Me.labelStoreQuantity.Location = New System.Drawing.Point(5, 74)
		Me.labelStoreQuantity.Name = "labelStoreQuantity"
		Me.labelStoreQuantity.Size = New System.Drawing.Size(49, 13)
		Me.labelStoreQuantity.TabIndex = 2
		Me.labelStoreQuantity.Text = "Quantity:"
		'
		'textboxStorePhItem
		'
		Me.textboxStorePhItem.Location = New System.Drawing.Point(112, 19)
		Me.textboxStorePhItem.Name = "textboxStorePhItem"
		Me.textboxStorePhItem.Size = New System.Drawing.Size(141, 20)
		Me.textboxStorePhItem.TabIndex = 3
		'
		'labelStoreName
		'
		Me.labelStoreName.AutoSize = true
		Me.labelStoreName.Location = New System.Drawing.Point(5, 48)
		Me.labelStoreName.Name = "labelStoreName"
		Me.labelStoreName.Size = New System.Drawing.Size(61, 13)
		Me.labelStoreName.TabIndex = 2
		Me.labelStoreName.Text = "Item Name:"
		'
		'labelStorePhItem
		'
		Me.labelStorePhItem.AutoSize = true
		Me.labelStorePhItem.Location = New System.Drawing.Point(5, 22)
		Me.labelStorePhItem.Name = "labelStorePhItem"
		Me.labelStorePhItem.Size = New System.Drawing.Size(49, 13)
		Me.labelStorePhItem.TabIndex = 2
		Me.labelStorePhItem.Text = "Ph. Item:"
		'
		'textboxStoragePhItem
		'
		Me.textboxStoragePhItem.Location = New System.Drawing.Point(113, 13)
		Me.textboxStoragePhItem.Name = "textboxStoragePhItem"
		Me.textboxStoragePhItem.Size = New System.Drawing.Size(146, 20)
		Me.textboxStoragePhItem.TabIndex = 3
		'
		'labelStoragePhItem
		'
		Me.labelStoragePhItem.AutoSize = true
		Me.labelStoragePhItem.Location = New System.Drawing.Point(6, 16)
		Me.labelStoragePhItem.Name = "labelStoragePhItem"
		Me.labelStoragePhItem.Size = New System.Drawing.Size(49, 13)
		Me.labelStoragePhItem.TabIndex = 2
		Me.labelStoragePhItem.Text = "Ph. Item:"
		'
		'buttonToStore
		'
		Me.buttonToStore.Location = New System.Drawing.Point(295, 77)
		Me.buttonToStore.Name = "buttonToStore"
		Me.buttonToStore.Size = New System.Drawing.Size(74, 65)
		Me.buttonToStore.TabIndex = 1
		Me.buttonToStore.Text = "Bin >>"
		Me.buttonToStore.UseVisualStyleBackColor = true
		AddHandler Me.buttonToStore.Click, AddressOf Me.buttonToStoreClick
		'
		'buttonToStorage
		'
		Me.buttonToStorage.Location = New System.Drawing.Point(295, 12)
		Me.buttonToStorage.Name = "buttonToStorage"
		Me.buttonToStorage.Size = New System.Drawing.Size(74, 59)
		Me.buttonToStorage.TabIndex = 0
		Me.buttonToStorage.Text = "<< Storage"
		Me.buttonToStorage.UseVisualStyleBackColor = true
		AddHandler Me.buttonToStorage.Click, AddressOf Me.buttonToStorageClick
		'
		'buttonClose
		'
		Me.buttonClose.Location = New System.Drawing.Point(295, 148)
		Me.buttonClose.Name = "buttonClose"
		Me.buttonClose.Size = New System.Drawing.Size(74, 94)
		Me.buttonClose.TabIndex = 0
		Me.buttonClose.Text = "Close"
		Me.buttonClose.UseVisualStyleBackColor = true
		AddHandler Me.buttonClose.Click, AddressOf Me.buttonCloseClick
		'
		'groupboxStore
		'
		Me.groupboxStore.Controls.Add(Me.groupboxStoreNavigation)
		Me.groupboxStore.Controls.Add(Me.groupboxStoreSelected)
		Me.groupboxStore.Location = New System.Drawing.Point(375, 12)
		Me.groupboxStore.Name = "groupboxStore"
		Me.groupboxStore.Size = New System.Drawing.Size(272, 230)
		Me.groupboxStore.TabIndex = 10
		Me.groupboxStore.TabStop = false
		Me.groupboxStore.Text = "Store"
		'
		'labelStorageQuantity
		'
		Me.labelStorageQuantity.AutoSize = true
		Me.labelStorageQuantity.Location = New System.Drawing.Point(6, 68)
		Me.labelStorageQuantity.Name = "labelStorageQuantity"
		Me.labelStorageQuantity.Size = New System.Drawing.Size(46, 13)
		Me.labelStorageQuantity.TabIndex = 0
		Me.labelStorageQuantity.Text = "Quantity"
		'
		'labelStorageLastBuy
		'
		Me.labelStorageLastBuy.AutoSize = true
		Me.labelStorageLastBuy.Location = New System.Drawing.Point(6, 120)
		Me.labelStorageLastBuy.Name = "labelStorageLastBuy"
		Me.labelStorageLastBuy.Size = New System.Drawing.Size(89, 13)
		Me.labelStorageLastBuy.TabIndex = 0
		Me.labelStorageLastBuy.Text = "Last Buying Price"
		'
		'labelStorageLastSell
		'
		Me.labelStorageLastSell.AutoSize = true
		Me.labelStorageLastSell.Location = New System.Drawing.Point(6, 94)
		Me.labelStorageLastSell.Name = "labelStorageLastSell"
		Me.labelStorageLastSell.Size = New System.Drawing.Size(88, 13)
		Me.labelStorageLastSell.TabIndex = 0
		Me.labelStorageLastSell.Text = "Last Selling Price"
		'
		'groupboxStorage
		'
		Me.groupboxStorage.Controls.Add(Me.groupboxStorageNavigation)
		Me.groupboxStorage.Controls.Add(Me.groupboxStorageSelected)
		Me.groupboxStorage.Location = New System.Drawing.Point(12, 12)
		Me.groupboxStorage.Name = "groupboxStorage"
		Me.groupboxStorage.Size = New System.Drawing.Size(277, 230)
		Me.groupboxStorage.TabIndex = 9
		Me.groupboxStorage.TabStop = false
		Me.groupboxStorage.Text = "Storage"
		'
		'groupboxStorageNavigation
		'
		Me.groupboxStorageNavigation.Controls.Add(Me.labelStorageArticle)
		Me.groupboxStorageNavigation.Controls.Add(Me.labelStorageSection)
		Me.groupboxStorageNavigation.Controls.Add(Me.updownStorageArticle)
		Me.groupboxStorageNavigation.Controls.Add(Me.labelStorageTotalSection)
		Me.groupboxStorageNavigation.Controls.Add(Me.labelStorageTotalArticle)
		Me.groupboxStorageNavigation.Controls.Add(Me.updownStorageSection)
		Me.groupboxStorageNavigation.Location = New System.Drawing.Point(6, 19)
		Me.groupboxStorageNavigation.Name = "groupboxStorageNavigation"
		Me.groupboxStorageNavigation.Size = New System.Drawing.Size(265, 57)
		Me.groupboxStorageNavigation.TabIndex = 7
		Me.groupboxStorageNavigation.TabStop = false
		Me.groupboxStorageNavigation.Text = "Navigation"
		'
		'labelStorageArticle
		'
		Me.labelStorageArticle.AutoSize = true
		Me.labelStorageArticle.Location = New System.Drawing.Point(198, 16)
		Me.labelStorageArticle.Name = "labelStorageArticle"
		Me.labelStorageArticle.Size = New System.Drawing.Size(39, 13)
		Me.labelStorageArticle.TabIndex = 6
		Me.labelStorageArticle.Text = "Article:"
		'
		'labelStorageSection
		'
		Me.labelStorageSection.AutoSize = true
		Me.labelStorageSection.Location = New System.Drawing.Point(12, 16)
		Me.labelStorageSection.Name = "labelStorageSection"
		Me.labelStorageSection.Size = New System.Drawing.Size(46, 13)
		Me.labelStorageSection.TabIndex = 6
		Me.labelStorageSection.Text = "Section:"
		'
		'updownStorageArticle
		'
		Me.updownStorageArticle.Location = New System.Drawing.Point(198, 32)
		Me.updownStorageArticle.Name = "updownStorageArticle"
		Me.updownStorageArticle.Size = New System.Drawing.Size(34, 20)
		Me.updownStorageArticle.TabIndex = 5
		AddHandler Me.updownStorageArticle.ValueChanged, AddressOf Me.UpdownStorageArticleValueChanged
		'
		'labelStorageTotalSection
		'
		Me.labelStorageTotalSection.AutoSize = true
		Me.labelStorageTotalSection.Location = New System.Drawing.Point(52, 34)
		Me.labelStorageTotalSection.Name = "labelStorageTotalSection"
		Me.labelStorageTotalSection.Size = New System.Drawing.Size(21, 13)
		Me.labelStorageTotalSection.TabIndex = 4
		Me.labelStorageTotalSection.Text = "\ 0"
		'
		'labelStorageTotalArticle
		'
		Me.labelStorageTotalArticle.AutoSize = true
		Me.labelStorageTotalArticle.Location = New System.Drawing.Point(238, 34)
		Me.labelStorageTotalArticle.Name = "labelStorageTotalArticle"
		Me.labelStorageTotalArticle.Size = New System.Drawing.Size(21, 13)
		Me.labelStorageTotalArticle.TabIndex = 4
		Me.labelStorageTotalArticle.Text = "\ 0"
		'
		'updownStorageSection
		'
		Me.updownStorageSection.Location = New System.Drawing.Point(12, 32)
		Me.updownStorageSection.Name = "updownStorageSection"
		Me.updownStorageSection.Size = New System.Drawing.Size(34, 20)
		Me.updownStorageSection.TabIndex = 5
		AddHandler Me.updownStorageSection.ValueChanged, AddressOf Me.UpdownStorageSectionValueChanged
		'
		'groupboxStorageSelected
		'
		Me.groupboxStorageSelected.Controls.Add(Me.labelStorageQuantity)
		Me.groupboxStorageSelected.Controls.Add(Me.textboxStorageLastBuy)
		Me.groupboxStorageSelected.Controls.Add(Me.textboxStorageName)
		Me.groupboxStorageSelected.Controls.Add(Me.textboxStoragePhItem)
		Me.groupboxStorageSelected.Controls.Add(Me.textboxStorageLastSell)
		Me.groupboxStorageSelected.Controls.Add(Me.labelStorageLastBuy)
		Me.groupboxStorageSelected.Controls.Add(Me.labelStorageLastSell)
		Me.groupboxStorageSelected.Controls.Add(Me.textboxStorageQuantity)
		Me.groupboxStorageSelected.Controls.Add(Me.labelStoragePhItem)
		Me.groupboxStorageSelected.Controls.Add(Me.labelStorageName)
		Me.groupboxStorageSelected.Location = New System.Drawing.Point(6, 82)
		Me.groupboxStorageSelected.Name = "groupboxStorageSelected"
		Me.groupboxStorageSelected.Size = New System.Drawing.Size(265, 142)
		Me.groupboxStorageSelected.TabIndex = 8
		Me.groupboxStorageSelected.TabStop = false
		Me.groupboxStorageSelected.Text = "Selected Article"
		'
		'textboxStorageLastBuy
		'
		Me.textboxStorageLastBuy.Location = New System.Drawing.Point(113, 117)
		Me.textboxStorageLastBuy.Name = "textboxStorageLastBuy"
		Me.textboxStorageLastBuy.Size = New System.Drawing.Size(146, 20)
		Me.textboxStorageLastBuy.TabIndex = 3
		'
		'textboxStorageName
		'
		Me.textboxStorageName.Location = New System.Drawing.Point(113, 39)
		Me.textboxStorageName.Name = "textboxStorageName"
		Me.textboxStorageName.Size = New System.Drawing.Size(146, 20)
		Me.textboxStorageName.TabIndex = 3
		'
		'textboxStorageLastSell
		'
		Me.textboxStorageLastSell.Location = New System.Drawing.Point(113, 91)
		Me.textboxStorageLastSell.Name = "textboxStorageLastSell"
		Me.textboxStorageLastSell.Size = New System.Drawing.Size(146, 20)
		Me.textboxStorageLastSell.TabIndex = 3
		'
		'textboxStorageQuantity
		'
		Me.textboxStorageQuantity.Location = New System.Drawing.Point(113, 65)
		Me.textboxStorageQuantity.Name = "textboxStorageQuantity"
		Me.textboxStorageQuantity.Size = New System.Drawing.Size(146, 20)
		Me.textboxStorageQuantity.TabIndex = 3
		'
		'labelStorageName
		'
		Me.labelStorageName.AutoSize = true
		Me.labelStorageName.Location = New System.Drawing.Point(6, 42)
		Me.labelStorageName.Name = "labelStorageName"
		Me.labelStorageName.Size = New System.Drawing.Size(61, 13)
		Me.labelStorageName.TabIndex = 2
		Me.labelStorageName.Text = "Item Name:"
		'
		'formItemManagement
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(660, 254)
		Me.Controls.Add(Me.groupboxStore)
		Me.Controls.Add(Me.groupboxStorage)
		Me.Controls.Add(Me.buttonClose)
		Me.Controls.Add(Me.buttonToStorage)
		Me.Controls.Add(Me.buttonToStore)
		Me.Name = "formItemManagement"
		Me.Text = "My First Store"
		AddHandler Load, AddressOf Me.formItemManagementLoad
		CType(Me.updownStoreLevel,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updownStoreShelf,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updownStoreBin,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupboxStoreNavigation.ResumeLayout(false)
		Me.groupboxStoreNavigation.PerformLayout
		Me.groupboxStoreSelected.ResumeLayout(false)
		Me.groupboxStoreSelected.PerformLayout
		CType(Me.updownStorePrice,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupboxStore.ResumeLayout(false)
		Me.groupboxStorage.ResumeLayout(false)
		Me.groupboxStorageNavigation.ResumeLayout(false)
		Me.groupboxStorageNavigation.PerformLayout
		CType(Me.updownStorageArticle,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.updownStorageSection,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupboxStorageSelected.ResumeLayout(false)
		Me.groupboxStorageSelected.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private labelStorageName As System.Windows.Forms.Label
	Private textboxStorageLastSell As System.Windows.Forms.TextBox
	Private textboxStorageName As System.Windows.Forms.TextBox
	Private textboxStorageLastBuy As System.Windows.Forms.TextBox
	Private labelStorePhItem As System.Windows.Forms.Label
	Private textboxStorePhItem As System.Windows.Forms.TextBox
	Private groupboxStorageSelected As System.Windows.Forms.GroupBox
	Private updownStorageSection As System.Windows.Forms.NumericUpDown
	Private labelStorageTotalArticle As System.Windows.Forms.Label
	Private labelStorageTotalSection As System.Windows.Forms.Label
	Private updownStorageArticle As System.Windows.Forms.NumericUpDown
	Private labelStorageSection As System.Windows.Forms.Label
	Private labelStorageArticle As System.Windows.Forms.Label
	Private groupboxStorageNavigation As System.Windows.Forms.GroupBox
	Private groupboxStorage As System.Windows.Forms.GroupBox
	Private textboxStorageQuantity As System.Windows.Forms.TextBox
	Private labelStorageLastSell As System.Windows.Forms.Label
	Private labelStorageLastBuy As System.Windows.Forms.Label
	Private labelStorageQuantity As System.Windows.Forms.Label
	Private groupboxStore As System.Windows.Forms.GroupBox
	Private updownStorePrice As System.Windows.Forms.NumericUpDown
	Private buttonClose As System.Windows.Forms.Button
	Private buttonToStorage As System.Windows.Forms.Button
	Private buttonToStore As System.Windows.Forms.Button
	Private labelStoragePhItem As System.Windows.Forms.Label
	Private labelStoreName As System.Windows.Forms.Label
	Private textboxStoragePhItem As System.Windows.Forms.TextBox
	Private labelStoreQuantity As System.Windows.Forms.Label
	Private textboxStoreName As System.Windows.Forms.TextBox
	Private labelStorePrice As System.Windows.Forms.Label
	Private textboxStoreQuantity As System.Windows.Forms.TextBox
	Private groupboxStoreSelected As System.Windows.Forms.GroupBox
	Private groupboxStoreNavigation As System.Windows.Forms.GroupBox
	Private labelStoreBin As System.Windows.Forms.Label
	Private updownStoreBin As System.Windows.Forms.NumericUpDown
	Private labelStoreTotalBin As System.Windows.Forms.Label
	Private labelStoreTotalShelf As System.Windows.Forms.Label
	Private updownStoreShelf As System.Windows.Forms.NumericUpDown
	Private labelStoreShelf As System.Windows.Forms.Label
	Private labelStoreLevel As System.Windows.Forms.Label
	Private updownStoreLevel As System.Windows.Forms.NumericUpDown
	Private labelStoreTotalLevel As System.Windows.Forms.Label
End Class