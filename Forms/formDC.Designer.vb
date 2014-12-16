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
		Me.labelBuyPrice = New System.Windows.Forms.Label()
		Me.comboboxFamily = New System.Windows.Forms.ComboBox()
		Me.comboboxName = New System.Windows.Forms.ComboBox()
		Me.comboboxCategory = New System.Windows.Forms.ComboBox()
		Me.comboboxGenre = New System.Windows.Forms.ComboBox()
		Me.labelGenre = New System.Windows.Forms.Label()
		Me.labelFamily = New System.Windows.Forms.Label()
		Me.labelCategory = New System.Windows.Forms.Label()
		Me.labelName = New System.Windows.Forms.Label()
		Me.groupboxItemInfo = New System.Windows.Forms.GroupBox()
		Me.labelItemBrandDisplay = New System.Windows.Forms.Label()
		Me.labelItemBrand = New System.Windows.Forms.Label()
		Me.labelItemCategoryDisplay = New System.Windows.Forms.Label()
		Me.labelItemCategory = New System.Windows.Forms.Label()
		Me.labelItemItemNameDisplay = New System.Windows.Forms.Label()
		Me.labelItemItemName = New System.Windows.Forms.Label()
		Me.labelItemCompanyDisplay = New System.Windows.Forms.Label()
		Me.labelItemCompany = New System.Windows.Forms.Label()
		Me.labelItemGenreDisplay = New System.Windows.Forms.Label()
		Me.labelItemGenre = New System.Windows.Forms.Label()
		Me.labelItemFamilyDisplay = New System.Windows.Forms.Label()
		Me.labelInfoFamily = New System.Windows.Forms.Label()
		Me.textboxPriceTotal = New System.Windows.Forms.TextBox()
		Me.labelPriceTotal = New System.Windows.Forms.Label()
		Me.groupboxStatistics = New System.Windows.Forms.GroupBox()
		Me.labelStatisticsItemTierDisplay = New System.Windows.Forms.Label()
		Me.labelStatisticsItemTier = New System.Windows.Forms.Label()
		Me.labelStatisticsPopularityDisplay = New System.Windows.Forms.Label()
		Me.labelStatisticsPopularity = New System.Windows.Forms.Label()
		Me.labelStatisticsBaseWorthDisplay = New System.Windows.Forms.Label()
		Me.labelStatisticsBaseWorth = New System.Windows.Forms.Label()
		Me.labelStatisticsRarityDisplay = New System.Windows.Forms.Label()
		Me.labelStatisticsRarity = New System.Windows.Forms.Label()
		Me.labelStatisticsQualityDisplay = New System.Windows.Forms.Label()
		Me.labelStatisticsQuality = New System.Windows.Forms.Label()
		Me.groupboxVarious = New System.Windows.Forms.GroupBox()
		Me.labelVariousDescriptionDisplay = New System.Windows.Forms.Label()
		Me.labelVariousDescription = New System.Windows.Forms.Label()
		Me.labelVariousPicturePathDisplay = New System.Windows.Forms.Label()
		Me.labelVariousPicturePath = New System.Windows.Forms.Label()
		Me.groupboxItemInfo.SuspendLayout
		Me.groupboxStatistics.SuspendLayout
		Me.groupboxVarious.SuspendLayout
		Me.SuspendLayout
		'
		'textboxBuyAmount
		'
		Me.textboxBuyAmount.Location = New System.Drawing.Point(181, 325)
		Me.textboxBuyAmount.Name = "textboxBuyAmount"
		Me.textboxBuyAmount.Size = New System.Drawing.Size(95, 20)
		Me.textboxBuyAmount.TabIndex = 72
		AddHandler Me.textboxBuyAmount.TextChanged, AddressOf Me.TextboxBuyAmountTextChanged
		'
		'textboxBuyPrice
		'
		Me.textboxBuyPrice.Location = New System.Drawing.Point(12, 325)
		Me.textboxBuyPrice.Name = "textboxBuyPrice"
		Me.textboxBuyPrice.ReadOnly = true
		Me.textboxBuyPrice.Size = New System.Drawing.Size(163, 20)
		Me.textboxBuyPrice.TabIndex = 71
		'
		'buttonClose
		'
		Me.buttonClose.Location = New System.Drawing.Point(199, 351)
		Me.buttonClose.Name = "buttonClose"
		Me.buttonClose.Size = New System.Drawing.Size(178, 25)
		Me.buttonClose.TabIndex = 67
		Me.buttonClose.Text = "Close"
		Me.buttonClose.UseVisualStyleBackColor = true
		AddHandler Me.buttonClose.Click, AddressOf Me.ButtonCloseClick
		'
		'buttonBuy
		'
		Me.buttonBuy.Location = New System.Drawing.Point(12, 351)
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
		Me.labelBuyAmount.Location = New System.Drawing.Point(181, 309)
		Me.labelBuyAmount.Name = "labelBuyAmount"
		Me.labelBuyAmount.Size = New System.Drawing.Size(75, 13)
		Me.labelBuyAmount.TabIndex = 65
		Me.labelBuyAmount.Text = "Amount to buy"
		'
		'labelBuyPrice
		'
		Me.labelBuyPrice.AutoSize = true
		Me.labelBuyPrice.Location = New System.Drawing.Point(12, 309)
		Me.labelBuyPrice.Name = "labelBuyPrice"
		Me.labelBuyPrice.Size = New System.Drawing.Size(146, 13)
		Me.labelBuyPrice.TabIndex = 62
		Me.labelBuyPrice.Text = "Current Buy Price -50%\+25%"
		'
		'comboboxFamily
		'
		Me.comboboxFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboboxFamily.FormattingEnabled = true
		Me.comboboxFamily.Location = New System.Drawing.Point(12, 25)
		Me.comboboxFamily.Name = "comboboxFamily"
		Me.comboboxFamily.Size = New System.Drawing.Size(365, 21)
		Me.comboboxFamily.TabIndex = 49
		AddHandler Me.comboboxFamily.SelectedIndexChanged, AddressOf Me.comboboxFamilySelectedIndexChanged
		'
		'comboboxName
		'
		Me.comboboxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
		Me.comboboxName.FormattingEnabled = true
		Me.comboboxName.Location = New System.Drawing.Point(383, 25)
		Me.comboboxName.Name = "comboboxName"
		Me.comboboxName.Size = New System.Drawing.Size(365, 359)
		Me.comboboxName.TabIndex = 54
		AddHandler Me.comboboxName.SelectedIndexChanged, AddressOf Me.ComboboxNameSelectedIndexChanged
		'
		'comboboxCategory
		'
		Me.comboboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboboxCategory.FormattingEnabled = true
		Me.comboboxCategory.Location = New System.Drawing.Point(12, 65)
		Me.comboboxCategory.Name = "comboboxCategory"
		Me.comboboxCategory.Size = New System.Drawing.Size(365, 21)
		Me.comboboxCategory.TabIndex = 50
		AddHandler Me.comboboxCategory.SelectedIndexChanged, AddressOf Me.ComboboxCategorySelectedIndexChanged
		'
		'comboboxGenre
		'
		Me.comboboxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboboxGenre.FormattingEnabled = true
		Me.comboboxGenre.Location = New System.Drawing.Point(12, 105)
		Me.comboboxGenre.Name = "comboboxGenre"
		Me.comboboxGenre.Size = New System.Drawing.Size(365, 21)
		Me.comboboxGenre.TabIndex = 52
		AddHandler Me.comboboxGenre.SelectedIndexChanged, AddressOf Me.ComboboxGenreSelectedIndexChanged
		'
		'labelGenre
		'
		Me.labelGenre.AutoSize = true
		Me.labelGenre.Location = New System.Drawing.Point(12, 89)
		Me.labelGenre.Name = "labelGenre"
		Me.labelGenre.Size = New System.Drawing.Size(36, 13)
		Me.labelGenre.TabIndex = 60
		Me.labelGenre.Text = "Genre"
		'
		'labelFamily
		'
		Me.labelFamily.AutoSize = true
		Me.labelFamily.Location = New System.Drawing.Point(12, 9)
		Me.labelFamily.Name = "labelFamily"
		Me.labelFamily.Size = New System.Drawing.Size(36, 13)
		Me.labelFamily.TabIndex = 59
		Me.labelFamily.Text = "Family"
		'
		'labelCategory
		'
		Me.labelCategory.AutoSize = true
		Me.labelCategory.Location = New System.Drawing.Point(12, 49)
		Me.labelCategory.Name = "labelCategory"
		Me.labelCategory.Size = New System.Drawing.Size(49, 13)
		Me.labelCategory.TabIndex = 57
		Me.labelCategory.Text = "Category"
		'
		'labelName
		'
		Me.labelName.AutoSize = true
		Me.labelName.Location = New System.Drawing.Point(380, 9)
		Me.labelName.Name = "labelName"
		Me.labelName.Size = New System.Drawing.Size(100, 13)
		Me.labelName.TabIndex = 55
		Me.labelName.Text = "Product Name/Title"
		'
		'groupboxItemInfo
		'
		Me.groupboxItemInfo.Controls.Add(Me.labelItemBrandDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelItemBrand)
		Me.groupboxItemInfo.Controls.Add(Me.labelItemCategoryDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelItemCategory)
		Me.groupboxItemInfo.Controls.Add(Me.labelItemItemNameDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelItemItemName)
		Me.groupboxItemInfo.Controls.Add(Me.labelItemCompanyDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelItemCompany)
		Me.groupboxItemInfo.Controls.Add(Me.labelItemGenreDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelItemGenre)
		Me.groupboxItemInfo.Controls.Add(Me.labelItemFamilyDisplay)
		Me.groupboxItemInfo.Controls.Add(Me.labelInfoFamily)
		Me.groupboxItemInfo.Location = New System.Drawing.Point(12, 132)
		Me.groupboxItemInfo.Name = "groupboxItemInfo"
		Me.groupboxItemInfo.Size = New System.Drawing.Size(177, 118)
		Me.groupboxItemInfo.TabIndex = 73
		Me.groupboxItemInfo.TabStop = false
		Me.groupboxItemInfo.Text = "Item Information"
		'
		'labelItemBrandDisplay
		'
		Me.labelItemBrandDisplay.AutoSize = true
		Me.labelItemBrandDisplay.Location = New System.Drawing.Point(112, 84)
		Me.labelItemBrandDisplay.Name = "labelItemBrandDisplay"
		Me.labelItemBrandDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelItemBrandDisplay.TabIndex = 64
		'
		'labelItemBrand
		'
		Me.labelItemBrand.AutoSize = true
		Me.labelItemBrand.Location = New System.Drawing.Point(6, 84)
		Me.labelItemBrand.Name = "labelItemBrand"
		Me.labelItemBrand.Size = New System.Drawing.Size(38, 13)
		Me.labelItemBrand.TabIndex = 64
		Me.labelItemBrand.Text = "Brand:"
		'
		'labelItemCategoryDisplay
		'
		Me.labelItemCategoryDisplay.AutoSize = true
		Me.labelItemCategoryDisplay.Location = New System.Drawing.Point(112, 33)
		Me.labelItemCategoryDisplay.Name = "labelItemCategoryDisplay"
		Me.labelItemCategoryDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelItemCategoryDisplay.TabIndex = 64
		'
		'labelItemCategory
		'
		Me.labelItemCategory.AutoSize = true
		Me.labelItemCategory.Location = New System.Drawing.Point(6, 33)
		Me.labelItemCategory.Name = "labelItemCategory"
		Me.labelItemCategory.Size = New System.Drawing.Size(52, 13)
		Me.labelItemCategory.TabIndex = 64
		Me.labelItemCategory.Text = "Category:"
		'
		'labelItemItemNameDisplay
		'
		Me.labelItemItemNameDisplay.AutoSize = true
		Me.labelItemItemNameDisplay.Location = New System.Drawing.Point(112, 101)
		Me.labelItemItemNameDisplay.Name = "labelItemItemNameDisplay"
		Me.labelItemItemNameDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelItemItemNameDisplay.TabIndex = 63
		'
		'labelItemItemName
		'
		Me.labelItemItemName.AutoSize = true
		Me.labelItemItemName.Location = New System.Drawing.Point(6, 101)
		Me.labelItemItemName.Name = "labelItemItemName"
		Me.labelItemItemName.Size = New System.Drawing.Size(61, 13)
		Me.labelItemItemName.TabIndex = 63
		Me.labelItemItemName.Text = "Item Name:"
		'
		'labelItemCompanyDisplay
		'
		Me.labelItemCompanyDisplay.AutoSize = true
		Me.labelItemCompanyDisplay.Location = New System.Drawing.Point(112, 67)
		Me.labelItemCompanyDisplay.Name = "labelItemCompanyDisplay"
		Me.labelItemCompanyDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelItemCompanyDisplay.TabIndex = 61
		'
		'labelItemCompany
		'
		Me.labelItemCompany.AutoSize = true
		Me.labelItemCompany.Location = New System.Drawing.Point(6, 67)
		Me.labelItemCompany.Name = "labelItemCompany"
		Me.labelItemCompany.Size = New System.Drawing.Size(54, 13)
		Me.labelItemCompany.TabIndex = 61
		Me.labelItemCompany.Text = "Company:"
		'
		'labelItemGenreDisplay
		'
		Me.labelItemGenreDisplay.AutoSize = true
		Me.labelItemGenreDisplay.Location = New System.Drawing.Point(112, 50)
		Me.labelItemGenreDisplay.Name = "labelItemGenreDisplay"
		Me.labelItemGenreDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelItemGenreDisplay.TabIndex = 63
		'
		'labelItemGenre
		'
		Me.labelItemGenre.AutoSize = true
		Me.labelItemGenre.Location = New System.Drawing.Point(6, 50)
		Me.labelItemGenre.Name = "labelItemGenre"
		Me.labelItemGenre.Size = New System.Drawing.Size(39, 13)
		Me.labelItemGenre.TabIndex = 63
		Me.labelItemGenre.Text = "Genre:"
		'
		'labelItemFamilyDisplay
		'
		Me.labelItemFamilyDisplay.AutoSize = true
		Me.labelItemFamilyDisplay.Location = New System.Drawing.Point(112, 16)
		Me.labelItemFamilyDisplay.Name = "labelItemFamilyDisplay"
		Me.labelItemFamilyDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelItemFamilyDisplay.TabIndex = 61
		'
		'labelInfoFamily
		'
		Me.labelInfoFamily.AutoSize = true
		Me.labelInfoFamily.Location = New System.Drawing.Point(6, 16)
		Me.labelInfoFamily.Name = "labelInfoFamily"
		Me.labelInfoFamily.Size = New System.Drawing.Size(39, 13)
		Me.labelInfoFamily.TabIndex = 61
		Me.labelInfoFamily.Text = "Family:"
		'
		'textboxPriceTotal
		'
		Me.textboxPriceTotal.Location = New System.Drawing.Point(282, 325)
		Me.textboxPriceTotal.Name = "textboxPriceTotal"
		Me.textboxPriceTotal.ReadOnly = true
		Me.textboxPriceTotal.Size = New System.Drawing.Size(95, 20)
		Me.textboxPriceTotal.TabIndex = 72
		'
		'labelPriceTotal
		'
		Me.labelPriceTotal.AutoSize = true
		Me.labelPriceTotal.Location = New System.Drawing.Point(282, 309)
		Me.labelPriceTotal.Name = "labelPriceTotal"
		Me.labelPriceTotal.Size = New System.Drawing.Size(58, 13)
		Me.labelPriceTotal.TabIndex = 65
		Me.labelPriceTotal.Text = "Total Price"
		'
		'groupboxStatistics
		'
		Me.groupboxStatistics.Controls.Add(Me.labelStatisticsItemTierDisplay)
		Me.groupboxStatistics.Controls.Add(Me.labelStatisticsItemTier)
		Me.groupboxStatistics.Controls.Add(Me.labelStatisticsPopularityDisplay)
		Me.groupboxStatistics.Controls.Add(Me.labelStatisticsPopularity)
		Me.groupboxStatistics.Controls.Add(Me.labelStatisticsBaseWorthDisplay)
		Me.groupboxStatistics.Controls.Add(Me.labelStatisticsBaseWorth)
		Me.groupboxStatistics.Controls.Add(Me.labelStatisticsRarityDisplay)
		Me.groupboxStatistics.Controls.Add(Me.labelStatisticsRarity)
		Me.groupboxStatistics.Controls.Add(Me.labelStatisticsQualityDisplay)
		Me.groupboxStatistics.Controls.Add(Me.labelStatisticsQuality)
		Me.groupboxStatistics.Location = New System.Drawing.Point(196, 132)
		Me.groupboxStatistics.Name = "groupboxStatistics"
		Me.groupboxStatistics.Size = New System.Drawing.Size(181, 118)
		Me.groupboxStatistics.TabIndex = 74
		Me.groupboxStatistics.TabStop = false
		Me.groupboxStatistics.Text = "Statistics"
		'
		'labelStatisticsItemTierDisplay
		'
		Me.labelStatisticsItemTierDisplay.AutoSize = true
		Me.labelStatisticsItemTierDisplay.Location = New System.Drawing.Point(112, 84)
		Me.labelStatisticsItemTierDisplay.Name = "labelStatisticsItemTierDisplay"
		Me.labelStatisticsItemTierDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelStatisticsItemTierDisplay.TabIndex = 64
		'
		'labelStatisticsItemTier
		'
		Me.labelStatisticsItemTier.AutoSize = true
		Me.labelStatisticsItemTier.Location = New System.Drawing.Point(6, 84)
		Me.labelStatisticsItemTier.Name = "labelStatisticsItemTier"
		Me.labelStatisticsItemTier.Size = New System.Drawing.Size(51, 13)
		Me.labelStatisticsItemTier.TabIndex = 64
		Me.labelStatisticsItemTier.Text = "Item Tier:"
		'
		'labelStatisticsPopularityDisplay
		'
		Me.labelStatisticsPopularityDisplay.AutoSize = true
		Me.labelStatisticsPopularityDisplay.Location = New System.Drawing.Point(112, 33)
		Me.labelStatisticsPopularityDisplay.Name = "labelStatisticsPopularityDisplay"
		Me.labelStatisticsPopularityDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelStatisticsPopularityDisplay.TabIndex = 64
		'
		'labelStatisticsPopularity
		'
		Me.labelStatisticsPopularity.AutoSize = true
		Me.labelStatisticsPopularity.Location = New System.Drawing.Point(6, 33)
		Me.labelStatisticsPopularity.Name = "labelStatisticsPopularity"
		Me.labelStatisticsPopularity.Size = New System.Drawing.Size(56, 13)
		Me.labelStatisticsPopularity.TabIndex = 64
		Me.labelStatisticsPopularity.Text = "Popularity:"
		'
		'labelStatisticsBaseWorthDisplay
		'
		Me.labelStatisticsBaseWorthDisplay.AutoSize = true
		Me.labelStatisticsBaseWorthDisplay.Location = New System.Drawing.Point(112, 67)
		Me.labelStatisticsBaseWorthDisplay.Name = "labelStatisticsBaseWorthDisplay"
		Me.labelStatisticsBaseWorthDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelStatisticsBaseWorthDisplay.TabIndex = 61
		'
		'labelStatisticsBaseWorth
		'
		Me.labelStatisticsBaseWorth.AutoSize = true
		Me.labelStatisticsBaseWorth.Location = New System.Drawing.Point(6, 67)
		Me.labelStatisticsBaseWorth.Name = "labelStatisticsBaseWorth"
		Me.labelStatisticsBaseWorth.Size = New System.Drawing.Size(66, 13)
		Me.labelStatisticsBaseWorth.TabIndex = 61
		Me.labelStatisticsBaseWorth.Text = "Base Worth:"
		'
		'labelStatisticsRarityDisplay
		'
		Me.labelStatisticsRarityDisplay.AutoSize = true
		Me.labelStatisticsRarityDisplay.Location = New System.Drawing.Point(112, 50)
		Me.labelStatisticsRarityDisplay.Name = "labelStatisticsRarityDisplay"
		Me.labelStatisticsRarityDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelStatisticsRarityDisplay.TabIndex = 63
		'
		'labelStatisticsRarity
		'
		Me.labelStatisticsRarity.AutoSize = true
		Me.labelStatisticsRarity.Location = New System.Drawing.Point(6, 50)
		Me.labelStatisticsRarity.Name = "labelStatisticsRarity"
		Me.labelStatisticsRarity.Size = New System.Drawing.Size(37, 13)
		Me.labelStatisticsRarity.TabIndex = 63
		Me.labelStatisticsRarity.Text = "Rarity:"
		'
		'labelStatisticsQualityDisplay
		'
		Me.labelStatisticsQualityDisplay.AutoSize = true
		Me.labelStatisticsQualityDisplay.Location = New System.Drawing.Point(112, 16)
		Me.labelStatisticsQualityDisplay.Name = "labelStatisticsQualityDisplay"
		Me.labelStatisticsQualityDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelStatisticsQualityDisplay.TabIndex = 61
		'
		'labelStatisticsQuality
		'
		Me.labelStatisticsQuality.AutoSize = true
		Me.labelStatisticsQuality.Location = New System.Drawing.Point(6, 16)
		Me.labelStatisticsQuality.Name = "labelStatisticsQuality"
		Me.labelStatisticsQuality.Size = New System.Drawing.Size(42, 13)
		Me.labelStatisticsQuality.TabIndex = 61
		Me.labelStatisticsQuality.Text = "Quality:"
		'
		'groupboxVarious
		'
		Me.groupboxVarious.Controls.Add(Me.labelVariousDescriptionDisplay)
		Me.groupboxVarious.Controls.Add(Me.labelVariousDescription)
		Me.groupboxVarious.Controls.Add(Me.labelVariousPicturePathDisplay)
		Me.groupboxVarious.Controls.Add(Me.labelVariousPicturePath)
		Me.groupboxVarious.Location = New System.Drawing.Point(12, 256)
		Me.groupboxVarious.Name = "groupboxVarious"
		Me.groupboxVarious.Size = New System.Drawing.Size(365, 50)
		Me.groupboxVarious.TabIndex = 75
		Me.groupboxVarious.TabStop = false
		Me.groupboxVarious.Text = "Various"
		'
		'labelVariousDescriptionDisplay
		'
		Me.labelVariousDescriptionDisplay.AutoSize = true
		Me.labelVariousDescriptionDisplay.Location = New System.Drawing.Point(112, 33)
		Me.labelVariousDescriptionDisplay.Name = "labelVariousDescriptionDisplay"
		Me.labelVariousDescriptionDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelVariousDescriptionDisplay.TabIndex = 64
		'
		'labelVariousDescription
		'
		Me.labelVariousDescription.AutoSize = true
		Me.labelVariousDescription.Location = New System.Drawing.Point(6, 33)
		Me.labelVariousDescription.Name = "labelVariousDescription"
		Me.labelVariousDescription.Size = New System.Drawing.Size(63, 13)
		Me.labelVariousDescription.TabIndex = 64
		Me.labelVariousDescription.Text = "Description:"
		'
		'labelVariousPicturePathDisplay
		'
		Me.labelVariousPicturePathDisplay.AutoSize = true
		Me.labelVariousPicturePathDisplay.Location = New System.Drawing.Point(112, 16)
		Me.labelVariousPicturePathDisplay.Name = "labelVariousPicturePathDisplay"
		Me.labelVariousPicturePathDisplay.Size = New System.Drawing.Size(0, 13)
		Me.labelVariousPicturePathDisplay.TabIndex = 61
		'
		'labelVariousPicturePath
		'
		Me.labelVariousPicturePath.AutoSize = true
		Me.labelVariousPicturePath.Location = New System.Drawing.Point(6, 16)
		Me.labelVariousPicturePath.Name = "labelVariousPicturePath"
		Me.labelVariousPicturePath.Size = New System.Drawing.Size(93, 13)
		Me.labelVariousPicturePath.TabIndex = 61
		Me.labelVariousPicturePath.Text = "Picture Path && File"
		'
		'formDC
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(760, 386)
		Me.Controls.Add(Me.groupboxVarious)
		Me.Controls.Add(Me.groupboxStatistics)
		Me.Controls.Add(Me.groupboxItemInfo)
		Me.Controls.Add(Me.textboxPriceTotal)
		Me.Controls.Add(Me.comboboxFamily)
		Me.Controls.Add(Me.textboxBuyAmount)
		Me.Controls.Add(Me.comboboxName)
		Me.Controls.Add(Me.comboboxCategory)
		Me.Controls.Add(Me.textboxBuyPrice)
		Me.Controls.Add(Me.comboboxGenre)
		Me.Controls.Add(Me.buttonClose)
		Me.Controls.Add(Me.labelGenre)
		Me.Controls.Add(Me.labelPriceTotal)
		Me.Controls.Add(Me.labelBuyAmount)
		Me.Controls.Add(Me.labelFamily)
		Me.Controls.Add(Me.buttonBuy)
		Me.Controls.Add(Me.labelBuyPrice)
		Me.Controls.Add(Me.labelCategory)
		Me.Controls.Add(Me.labelName)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "formDC"
		Me.Text = "Buying Goods"
		AddHandler Load, AddressOf Me.formItemManagementLoad
		Me.groupboxItemInfo.ResumeLayout(false)
		Me.groupboxItemInfo.PerformLayout
		Me.groupboxStatistics.ResumeLayout(false)
		Me.groupboxStatistics.PerformLayout
		Me.groupboxVarious.ResumeLayout(false)
		Me.groupboxVarious.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
  End Sub
	Private labelVariousPicturePathDisplay As System.Windows.Forms.Label
	Private groupboxVarious As System.Windows.Forms.GroupBox
	Private labelVariousPicturePath As System.Windows.Forms.Label
	Private labelStatisticsQuality As System.Windows.Forms.Label
	Private labelStatisticsQualityDisplay As System.Windows.Forms.Label
	Private labelStatisticsRarity As System.Windows.Forms.Label
	Private labelStatisticsRarityDisplay As System.Windows.Forms.Label
	Private labelStatisticsBaseWorth As System.Windows.Forms.Label
	Private labelStatisticsBaseWorthDisplay As System.Windows.Forms.Label
	Private labelVariousDescription As System.Windows.Forms.Label
	Private labelVariousDescriptionDisplay As System.Windows.Forms.Label
	Private labelStatisticsPopularity As System.Windows.Forms.Label
	Private labelStatisticsPopularityDisplay As System.Windows.Forms.Label
	Private labelStatisticsItemTier As System.Windows.Forms.Label
	Private labelStatisticsItemTierDisplay As System.Windows.Forms.Label
	Private groupboxStatistics As System.Windows.Forms.GroupBox
	Private labelItemFamilyDisplay As System.Windows.Forms.Label
	Private labelItemGenreDisplay As System.Windows.Forms.Label
	Private labelItemCompanyDisplay As System.Windows.Forms.Label
	Private labelItemItemNameDisplay As System.Windows.Forms.Label
	Private labelItemCategoryDisplay As System.Windows.Forms.Label
	Private labelItemBrandDisplay As System.Windows.Forms.Label
	Private labelInfoFamily As System.Windows.Forms.Label
	Private labelItemGenre As System.Windows.Forms.Label
	Private labelItemCompany As System.Windows.Forms.Label
	Private labelItemItemName As System.Windows.Forms.Label
	Private labelItemCategory As System.Windows.Forms.Label
	Private labelItemBrand As System.Windows.Forms.Label
	Private labelPriceTotal As System.Windows.Forms.Label
	Private textboxPriceTotal As System.Windows.Forms.TextBox
	Private groupboxItemInfo As System.Windows.Forms.GroupBox
	Private textboxBuyAmount As System.Windows.Forms.TextBox
	Private textboxBuyPrice As System.Windows.Forms.TextBox
	Private buttonClose As System.Windows.Forms.Button
	Private buttonBuy As System.Windows.Forms.Button
	Private labelBuyAmount As System.Windows.Forms.Label
	Private labelBuyPrice As System.Windows.Forms.Label
	Private comboboxFamily As System.Windows.Forms.ComboBox
	Private comboboxName As System.Windows.Forms.ComboBox
	Private comboboxCategory As System.Windows.Forms.ComboBox
	Private comboboxGenre As System.Windows.Forms.ComboBox
	Private labelGenre As System.Windows.Forms.Label
	Private labelFamily As System.Windows.Forms.Label
	Private labelCategory As System.Windows.Forms.Label
	Private labelName As System.Windows.Forms.Label
End Class