using System;

partial class formDC : System.Windows.Forms.Form
{
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components;

    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing) {
            if (components != null) {
                components.Dispose();
            }
        }
        base.Dispose(disposing);
    }

    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
        this.textboxBuyAmount = new System.Windows.Forms.TextBox();
        this.textboxBuyPrice = new System.Windows.Forms.TextBox();
        this.buttonClose = new System.Windows.Forms.Button();
        this.buttonBuy = new System.Windows.Forms.Button();
        this.labelBuyAmount = new System.Windows.Forms.Label();
        this.labelBuyPrice = new System.Windows.Forms.Label();
        this.comboboxFamily = new System.Windows.Forms.ComboBox();
        this.comboboxName = new System.Windows.Forms.ComboBox();
        this.comboboxCategory = new System.Windows.Forms.ComboBox();
        this.comboboxGenre = new System.Windows.Forms.ComboBox();
        this.labelGenre = new System.Windows.Forms.Label();
        this.labelFamily = new System.Windows.Forms.Label();
        this.labelCategory = new System.Windows.Forms.Label();
        this.labelName = new System.Windows.Forms.Label();
        this.groupboxItemInfo = new System.Windows.Forms.GroupBox();
        this.labelItemBrandDisplay = new System.Windows.Forms.Label();
        this.labelItemBrand = new System.Windows.Forms.Label();
        this.labelItemCategoryDisplay = new System.Windows.Forms.Label();
        this.labelItemCategory = new System.Windows.Forms.Label();
        this.labelItemItemNameDisplay = new System.Windows.Forms.Label();
        this.labelItemItemName = new System.Windows.Forms.Label();
        this.labelItemCompanyDisplay = new System.Windows.Forms.Label();
        this.labelItemCompany = new System.Windows.Forms.Label();
        this.labelItemGenreDisplay = new System.Windows.Forms.Label();
        this.labelItemGenre = new System.Windows.Forms.Label();
        this.labelItemFamilyDisplay = new System.Windows.Forms.Label();
        this.labelInfoFamily = new System.Windows.Forms.Label();
        this.textboxPriceTotal = new System.Windows.Forms.TextBox();
        this.labelPriceTotal = new System.Windows.Forms.Label();
        this.groupboxStatistics = new System.Windows.Forms.GroupBox();
        this.labelStatisticsItemTierDisplay = new System.Windows.Forms.Label();
        this.labelStatisticsItemTier = new System.Windows.Forms.Label();
        this.labelStatisticsPopularityDisplay = new System.Windows.Forms.Label();
        this.labelStatisticsPopularity = new System.Windows.Forms.Label();
        this.labelStatisticsBaseWorthDisplay = new System.Windows.Forms.Label();
        this.labelStatisticsBaseWorth = new System.Windows.Forms.Label();
        this.labelStatisticsRarityDisplay = new System.Windows.Forms.Label();
        this.labelStatisticsRarity = new System.Windows.Forms.Label();
        this.labelStatisticsQualityDisplay = new System.Windows.Forms.Label();
        this.labelStatisticsQuality = new System.Windows.Forms.Label();
        this.groupboxVarious = new System.Windows.Forms.GroupBox();
        this.labelVariousDescriptionDisplay = new System.Windows.Forms.Label();
        this.labelVariousDescription = new System.Windows.Forms.Label();
        this.labelVariousPicturePathDisplay = new System.Windows.Forms.Label();
        this.labelVariousPicturePath = new System.Windows.Forms.Label();
        this.groupboxItemInfo.SuspendLayout();
        this.groupboxStatistics.SuspendLayout();
        this.groupboxVarious.SuspendLayout();
        this.SuspendLayout();
        //
        //textboxBuyAmount
        //
        this.textboxBuyAmount.Location = new System.Drawing.Point(181, 325);
        this.textboxBuyAmount.Name = "textboxBuyAmount";
        this.textboxBuyAmount.Size = new System.Drawing.Size(95, 20);
        this.textboxBuyAmount.TabIndex = 72;
        this.textboxBuyAmount.TextChanged += this.textboxBuyAmount_TextChanged;
        //
        //textboxBuyPrice
        //
        this.textboxBuyPrice.Location = new System.Drawing.Point(12, 325);
        this.textboxBuyPrice.Name = "textboxBuyPrice";
        this.textboxBuyPrice.ReadOnly = true;
        this.textboxBuyPrice.Size = new System.Drawing.Size(163, 20);
        this.textboxBuyPrice.TabIndex = 71;
        //
        //buttonClose
        //
        this.buttonClose.Location = new System.Drawing.Point(199, 351);
        this.buttonClose.Name = "buttonClose";
        this.buttonClose.Size = new System.Drawing.Size(178, 25);
        this.buttonClose.TabIndex = 67;
        this.buttonClose.Text = "Close";
        this.buttonClose.UseVisualStyleBackColor = true;
        this.buttonClose.Click += this.buttonClose_Click;
        //
        //buttonBuy
        //
        this.buttonBuy.Location = new System.Drawing.Point(12, 351);
        this.buttonBuy.Name = "buttonBuy";
        this.buttonBuy.Size = new System.Drawing.Size(181, 25);
        this.buttonBuy.TabIndex = 66;
        this.buttonBuy.Text = "Buy";
        this.buttonBuy.UseVisualStyleBackColor = true;
        this.buttonBuy.Click += this.buttonBuy_Click;
        //
        //labelBuyAmount
        //
        this.labelBuyAmount.AutoSize = true;
        this.labelBuyAmount.Location = new System.Drawing.Point(181, 309);
        this.labelBuyAmount.Name = "labelBuyAmount";
        this.labelBuyAmount.Size = new System.Drawing.Size(75, 13);
        this.labelBuyAmount.TabIndex = 65;
        this.labelBuyAmount.Text = "Amount to buy";
        //
        //labelBuyPrice
        //
        this.labelBuyPrice.AutoSize = true;
        this.labelBuyPrice.Location = new System.Drawing.Point(12, 309);
        this.labelBuyPrice.Name = "labelBuyPrice";
        this.labelBuyPrice.Size = new System.Drawing.Size(146, 13);
        this.labelBuyPrice.TabIndex = 62;
        this.labelBuyPrice.Text = "Current Buy Price -50%\\+25%";
        //
        //comboboxFamily
        //
        this.comboboxFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboboxFamily.FormattingEnabled = true;
        this.comboboxFamily.Location = new System.Drawing.Point(12, 25);
        this.comboboxFamily.Name = "comboboxFamily";
        this.comboboxFamily.Size = new System.Drawing.Size(365, 21);
        this.comboboxFamily.TabIndex = 49;
        this.comboboxFamily.SelectedIndexChanged += this.comboboxFamily_SelectedIndexChanged;
        //
        //comboboxName
        //
        this.comboboxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
        this.comboboxName.FormattingEnabled = true;
        this.comboboxName.Location = new System.Drawing.Point(383, 25);
        this.comboboxName.Name = "comboboxName";
        this.comboboxName.Size = new System.Drawing.Size(365, 359);
        this.comboboxName.TabIndex = 54;
        this.comboboxName.SelectedIndexChanged += this.comboboxName_SelectedIndexChanged;
        //
        //comboboxCategory
        //
        this.comboboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboboxCategory.FormattingEnabled = true;
        this.comboboxCategory.Location = new System.Drawing.Point(12, 65);
        this.comboboxCategory.Name = "comboboxCategory";
        this.comboboxCategory.Size = new System.Drawing.Size(365, 21);
        this.comboboxCategory.TabIndex = 50;
        this.comboboxCategory.SelectedIndexChanged += this.comboboxCategory_SelectedIndexChanged;
        //
        //comboboxGenre
        //
        this.comboboxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboboxGenre.FormattingEnabled = true;
        this.comboboxGenre.Location = new System.Drawing.Point(12, 105);
        this.comboboxGenre.Name = "comboboxGenre";
        this.comboboxGenre.Size = new System.Drawing.Size(365, 21);
        this.comboboxGenre.TabIndex = 52;
        this.comboboxGenre.SelectedIndexChanged += this.comboboxGenre_SelectedIndexChanged;
        //
        //labelGenre
        //
        this.labelGenre.AutoSize = true;
        this.labelGenre.Location = new System.Drawing.Point(12, 89);
        this.labelGenre.Name = "labelGenre";
        this.labelGenre.Size = new System.Drawing.Size(36, 13);
        this.labelGenre.TabIndex = 60;
        this.labelGenre.Text = "Genre";
        //
        //labelFamily
        //
        this.labelFamily.AutoSize = true;
        this.labelFamily.Location = new System.Drawing.Point(12, 9);
        this.labelFamily.Name = "labelFamily";
        this.labelFamily.Size = new System.Drawing.Size(36, 13);
        this.labelFamily.TabIndex = 59;
        this.labelFamily.Text = "Family";
        //
        //labelCategory
        //
        this.labelCategory.AutoSize = true;
        this.labelCategory.Location = new System.Drawing.Point(12, 49);
        this.labelCategory.Name = "labelCategory";
        this.labelCategory.Size = new System.Drawing.Size(49, 13);
        this.labelCategory.TabIndex = 57;
        this.labelCategory.Text = "Category";
        //
        //labelName
        //
        this.labelName.AutoSize = true;
        this.labelName.Location = new System.Drawing.Point(380, 9);
        this.labelName.Name = "labelName";
        this.labelName.Size = new System.Drawing.Size(100, 13);
        this.labelName.TabIndex = 55;
        this.labelName.Text = "Product Name/Title";
        //
        //groupboxItemInfo
        //
        this.groupboxItemInfo.Controls.Add(this.labelItemBrandDisplay);
        this.groupboxItemInfo.Controls.Add(this.labelItemBrand);
        this.groupboxItemInfo.Controls.Add(this.labelItemCategoryDisplay);
        this.groupboxItemInfo.Controls.Add(this.labelItemCategory);
        this.groupboxItemInfo.Controls.Add(this.labelItemItemNameDisplay);
        this.groupboxItemInfo.Controls.Add(this.labelItemItemName);
        this.groupboxItemInfo.Controls.Add(this.labelItemCompanyDisplay);
        this.groupboxItemInfo.Controls.Add(this.labelItemCompany);
        this.groupboxItemInfo.Controls.Add(this.labelItemGenreDisplay);
        this.groupboxItemInfo.Controls.Add(this.labelItemGenre);
        this.groupboxItemInfo.Controls.Add(this.labelItemFamilyDisplay);
        this.groupboxItemInfo.Controls.Add(this.labelInfoFamily);
        this.groupboxItemInfo.Location = new System.Drawing.Point(12, 132);
        this.groupboxItemInfo.Name = "groupboxItemInfo";
        this.groupboxItemInfo.Size = new System.Drawing.Size(177, 118);
        this.groupboxItemInfo.TabIndex = 73;
        this.groupboxItemInfo.TabStop = false;
        this.groupboxItemInfo.Text = "Item Information";
        //
        //labelItemBrandDisplay
        //
        this.labelItemBrandDisplay.AutoSize = true;
        this.labelItemBrandDisplay.Location = new System.Drawing.Point(112, 84);
        this.labelItemBrandDisplay.Name = "labelItemBrandDisplay";
        this.labelItemBrandDisplay.Size = new System.Drawing.Size(0, 13);
        this.labelItemBrandDisplay.TabIndex = 64;
        //
        //labelItemBrand
        //
        this.labelItemBrand.AutoSize = true;
        this.labelItemBrand.Location = new System.Drawing.Point(6, 84);
        this.labelItemBrand.Name = "labelItemBrand";
        this.labelItemBrand.Size = new System.Drawing.Size(38, 13);
        this.labelItemBrand.TabIndex = 64;
        this.labelItemBrand.Text = "Brand:";
        //
        //labelItemCategoryDisplay
        //
        this.labelItemCategoryDisplay.AutoSize = true;
        this.labelItemCategoryDisplay.Location = new System.Drawing.Point(112, 33);
        this.labelItemCategoryDisplay.Name = "labelItemCategoryDisplay";
        this.labelItemCategoryDisplay.Size = new System.Drawing.Size(0, 13);
        this.labelItemCategoryDisplay.TabIndex = 64;
        //
        //labelItemCategory
        //
        this.labelItemCategory.AutoSize = true;
        this.labelItemCategory.Location = new System.Drawing.Point(6, 33);
        this.labelItemCategory.Name = "labelItemCategory";
        this.labelItemCategory.Size = new System.Drawing.Size(52, 13);
        this.labelItemCategory.TabIndex = 64;
        this.labelItemCategory.Text = "Category:";
        //
        //labelItemItemNameDisplay
        //
        this.labelItemItemNameDisplay.AutoSize = true;
        this.labelItemItemNameDisplay.Location = new System.Drawing.Point(112, 101);
        this.labelItemItemNameDisplay.Name = "labelItemItemNameDisplay";
        this.labelItemItemNameDisplay.Size = new System.Drawing.Size(0, 13);
        this.labelItemItemNameDisplay.TabIndex = 63;
        //
        //labelItemItemName
        //
        this.labelItemItemName.AutoSize = true;
        this.labelItemItemName.Location = new System.Drawing.Point(6, 101);
        this.labelItemItemName.Name = "labelItemItemName";
        this.labelItemItemName.Size = new System.Drawing.Size(61, 13);
        this.labelItemItemName.TabIndex = 63;
        this.labelItemItemName.Text = "Item Name:";
        //
        //labelItemCompanyDisplay
        //
        this.labelItemCompanyDisplay.AutoSize = true;
        this.labelItemCompanyDisplay.Location = new System.Drawing.Point(112, 67);
        this.labelItemCompanyDisplay.Name = "labelItemCompanyDisplay";
        this.labelItemCompanyDisplay.Size = new System.Drawing.Size(0, 13);
        this.labelItemCompanyDisplay.TabIndex = 61;
        //
        //labelItemCompany
        //
        this.labelItemCompany.AutoSize = true;
        this.labelItemCompany.Location = new System.Drawing.Point(6, 67);
        this.labelItemCompany.Name = "labelItemCompany";
        this.labelItemCompany.Size = new System.Drawing.Size(54, 13);
        this.labelItemCompany.TabIndex = 61;
        this.labelItemCompany.Text = "Company:";
        //
        //labelItemGenreDisplay
        //
        this.labelItemGenreDisplay.AutoSize = true;
        this.labelItemGenreDisplay.Location = new System.Drawing.Point(112, 50);
        this.labelItemGenreDisplay.Name = "labelItemGenreDisplay";
        this.labelItemGenreDisplay.Size = new System.Drawing.Size(0, 13);
        this.labelItemGenreDisplay.TabIndex = 63;
        //
        //labelItemGenre
        //
        this.labelItemGenre.AutoSize = true;
        this.labelItemGenre.Location = new System.Drawing.Point(6, 50);
        this.labelItemGenre.Name = "labelItemGenre";
        this.labelItemGenre.Size = new System.Drawing.Size(39, 13);
        this.labelItemGenre.TabIndex = 63;
        this.labelItemGenre.Text = "Genre:";
        //
        //labelItemFamilyDisplay
        //
        this.labelItemFamilyDisplay.AutoSize = true;
        this.labelItemFamilyDisplay.Location = new System.Drawing.Point(112, 16);
        this.labelItemFamilyDisplay.Name = "labelItemFamilyDisplay";
        this.labelItemFamilyDisplay.Size = new System.Drawing.Size(0, 13);
        this.labelItemFamilyDisplay.TabIndex = 61;
        //
        //labelInfoFamily
        //
        this.labelInfoFamily.AutoSize = true;
        this.labelInfoFamily.Location = new System.Drawing.Point(6, 16);
        this.labelInfoFamily.Name = "labelInfoFamily";
        this.labelInfoFamily.Size = new System.Drawing.Size(39, 13);
        this.labelInfoFamily.TabIndex = 61;
        this.labelInfoFamily.Text = "Family:";
        //
        //textboxPriceTotal
        //
        this.textboxPriceTotal.Location = new System.Drawing.Point(282, 325);
        this.textboxPriceTotal.Name = "textboxPriceTotal";
        this.textboxPriceTotal.ReadOnly = true;
        this.textboxPriceTotal.Size = new System.Drawing.Size(95, 20);
        this.textboxPriceTotal.TabIndex = 72;
        //
        //labelPriceTotal
        //
        this.labelPriceTotal.AutoSize = true;
        this.labelPriceTotal.Location = new System.Drawing.Point(282, 309);
        this.labelPriceTotal.Name = "labelPriceTotal";
        this.labelPriceTotal.Size = new System.Drawing.Size(58, 13);
        this.labelPriceTotal.TabIndex = 65;
        this.labelPriceTotal.Text = "Total Price";
        //
        //groupboxStatistics
        //
        this.groupboxStatistics.Controls.Add(this.labelStatisticsItemTierDisplay);
        this.groupboxStatistics.Controls.Add(this.labelStatisticsItemTier);
        this.groupboxStatistics.Controls.Add(this.labelStatisticsPopularityDisplay);
        this.groupboxStatistics.Controls.Add(this.labelStatisticsPopularity);
        this.groupboxStatistics.Controls.Add(this.labelStatisticsBaseWorthDisplay);
        this.groupboxStatistics.Controls.Add(this.labelStatisticsBaseWorth);
        this.groupboxStatistics.Controls.Add(this.labelStatisticsRarityDisplay);
        this.groupboxStatistics.Controls.Add(this.labelStatisticsRarity);
        this.groupboxStatistics.Controls.Add(this.labelStatisticsQualityDisplay);
        this.groupboxStatistics.Controls.Add(this.labelStatisticsQuality);
        this.groupboxStatistics.Location = new System.Drawing.Point(196, 132);
        this.groupboxStatistics.Name = "groupboxStatistics";
        this.groupboxStatistics.Size = new System.Drawing.Size(181, 118);
        this.groupboxStatistics.TabIndex = 74;
        this.groupboxStatistics.TabStop = false;
        this.groupboxStatistics.Text = "Statistics";
        //
        //labelStatisticsItemTierDisplay
        //
        this.labelStatisticsItemTierDisplay.AutoSize = true;
        this.labelStatisticsItemTierDisplay.Location = new System.Drawing.Point(112, 84);
        this.labelStatisticsItemTierDisplay.Name = "labelStatisticsItemTierDisplay";
        this.labelStatisticsItemTierDisplay.Size = new System.Drawing.Size(0, 13);
        this.labelStatisticsItemTierDisplay.TabIndex = 64;
        //
        //labelStatisticsItemTier
        //
        this.labelStatisticsItemTier.AutoSize = true;
        this.labelStatisticsItemTier.Location = new System.Drawing.Point(6, 84);
        this.labelStatisticsItemTier.Name = "labelStatisticsItemTier";
        this.labelStatisticsItemTier.Size = new System.Drawing.Size(51, 13);
        this.labelStatisticsItemTier.TabIndex = 64;
        this.labelStatisticsItemTier.Text = "Item Tier:";
        //
        //labelStatisticsPopularityDisplay
        //
        this.labelStatisticsPopularityDisplay.AutoSize = true;
        this.labelStatisticsPopularityDisplay.Location = new System.Drawing.Point(112, 33);
        this.labelStatisticsPopularityDisplay.Name = "labelStatisticsPopularityDisplay";
        this.labelStatisticsPopularityDisplay.Size = new System.Drawing.Size(0, 13);
        this.labelStatisticsPopularityDisplay.TabIndex = 64;
        //
        //labelStatisticsPopularity
        //
        this.labelStatisticsPopularity.AutoSize = true;
        this.labelStatisticsPopularity.Location = new System.Drawing.Point(6, 33);
        this.labelStatisticsPopularity.Name = "labelStatisticsPopularity";
        this.labelStatisticsPopularity.Size = new System.Drawing.Size(56, 13);
        this.labelStatisticsPopularity.TabIndex = 64;
        this.labelStatisticsPopularity.Text = "Popularity:";
        //
        //labelStatisticsBaseWorthDisplay
        //
        this.labelStatisticsBaseWorthDisplay.AutoSize = true;
        this.labelStatisticsBaseWorthDisplay.Location = new System.Drawing.Point(112, 67);
        this.labelStatisticsBaseWorthDisplay.Name = "labelStatisticsBaseWorthDisplay";
        this.labelStatisticsBaseWorthDisplay.Size = new System.Drawing.Size(0, 13);
        this.labelStatisticsBaseWorthDisplay.TabIndex = 61;
        //
        //labelStatisticsBaseWorth
        //
        this.labelStatisticsBaseWorth.AutoSize = true;
        this.labelStatisticsBaseWorth.Location = new System.Drawing.Point(6, 67);
        this.labelStatisticsBaseWorth.Name = "labelStatisticsBaseWorth";
        this.labelStatisticsBaseWorth.Size = new System.Drawing.Size(66, 13);
        this.labelStatisticsBaseWorth.TabIndex = 61;
        this.labelStatisticsBaseWorth.Text = "Base Worth:";
        //
        //labelStatisticsRarityDisplay
        //
        this.labelStatisticsRarityDisplay.AutoSize = true;
        this.labelStatisticsRarityDisplay.Location = new System.Drawing.Point(112, 50);
        this.labelStatisticsRarityDisplay.Name = "labelStatisticsRarityDisplay";
        this.labelStatisticsRarityDisplay.Size = new System.Drawing.Size(0, 13);
        this.labelStatisticsRarityDisplay.TabIndex = 63;
        //
        //labelStatisticsRarity
        //
        this.labelStatisticsRarity.AutoSize = true;
        this.labelStatisticsRarity.Location = new System.Drawing.Point(6, 50);
        this.labelStatisticsRarity.Name = "labelStatisticsRarity";
        this.labelStatisticsRarity.Size = new System.Drawing.Size(37, 13);
        this.labelStatisticsRarity.TabIndex = 63;
        this.labelStatisticsRarity.Text = "Rarity:";
        //
        //labelStatisticsQualityDisplay
        //
        this.labelStatisticsQualityDisplay.AutoSize = true;
        this.labelStatisticsQualityDisplay.Location = new System.Drawing.Point(112, 16);
        this.labelStatisticsQualityDisplay.Name = "labelStatisticsQualityDisplay";
        this.labelStatisticsQualityDisplay.Size = new System.Drawing.Size(0, 13);
        this.labelStatisticsQualityDisplay.TabIndex = 61;
        //
        //labelStatisticsQuality
        //
        this.labelStatisticsQuality.AutoSize = true;
        this.labelStatisticsQuality.Location = new System.Drawing.Point(6, 16);
        this.labelStatisticsQuality.Name = "labelStatisticsQuality";
        this.labelStatisticsQuality.Size = new System.Drawing.Size(42, 13);
        this.labelStatisticsQuality.TabIndex = 61;
        this.labelStatisticsQuality.Text = "Quality:";
        //
        //groupboxVarious
        //
        this.groupboxVarious.Controls.Add(this.labelVariousDescriptionDisplay);
        this.groupboxVarious.Controls.Add(this.labelVariousDescription);
        this.groupboxVarious.Controls.Add(this.labelVariousPicturePathDisplay);
        this.groupboxVarious.Controls.Add(this.labelVariousPicturePath);
        this.groupboxVarious.Location = new System.Drawing.Point(12, 256);
        this.groupboxVarious.Name = "groupboxVarious";
        this.groupboxVarious.Size = new System.Drawing.Size(365, 50);
        this.groupboxVarious.TabIndex = 75;
        this.groupboxVarious.TabStop = false;
        this.groupboxVarious.Text = "Various";
        //
        //labelVariousDescriptionDisplay
        //
        this.labelVariousDescriptionDisplay.AutoSize = true;
        this.labelVariousDescriptionDisplay.Location = new System.Drawing.Point(112, 33);
        this.labelVariousDescriptionDisplay.Name = "labelVariousDescriptionDisplay";
        this.labelVariousDescriptionDisplay.Size = new System.Drawing.Size(0, 13);
        this.labelVariousDescriptionDisplay.TabIndex = 64;
        //
        //labelVariousDescription
        //
        this.labelVariousDescription.AutoSize = true;
        this.labelVariousDescription.Location = new System.Drawing.Point(6, 33);
        this.labelVariousDescription.Name = "labelVariousDescription";
        this.labelVariousDescription.Size = new System.Drawing.Size(63, 13);
        this.labelVariousDescription.TabIndex = 64;
        this.labelVariousDescription.Text = "Description:";
        //
        //labelVariousPicturePathDisplay
        //
        this.labelVariousPicturePathDisplay.AutoSize = true;
        this.labelVariousPicturePathDisplay.Location = new System.Drawing.Point(112, 16);
        this.labelVariousPicturePathDisplay.Name = "labelVariousPicturePathDisplay";
        this.labelVariousPicturePathDisplay.Size = new System.Drawing.Size(0, 13);
        this.labelVariousPicturePathDisplay.TabIndex = 61;
        //
        //labelVariousPicturePath
        //
        this.labelVariousPicturePath.AutoSize = true;
        this.labelVariousPicturePath.Location = new System.Drawing.Point(6, 16);
        this.labelVariousPicturePath.Name = "labelVariousPicturePath";
        this.labelVariousPicturePath.Size = new System.Drawing.Size(93, 13);
        this.labelVariousPicturePath.TabIndex = 61;
        this.labelVariousPicturePath.Text = "Picture Path && File";
        //
        //formDC
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(760, 386);
        this.Controls.Add(this.groupboxVarious);
        this.Controls.Add(this.groupboxStatistics);
        this.Controls.Add(this.groupboxItemInfo);
        this.Controls.Add(this.textboxPriceTotal);
        this.Controls.Add(this.comboboxFamily);
        this.Controls.Add(this.textboxBuyAmount);
        this.Controls.Add(this.comboboxName);
        this.Controls.Add(this.comboboxCategory);
        this.Controls.Add(this.textboxBuyPrice);
        this.Controls.Add(this.comboboxGenre);
        this.Controls.Add(this.buttonClose);
        this.Controls.Add(this.labelGenre);
        this.Controls.Add(this.labelPriceTotal);
        this.Controls.Add(this.labelBuyAmount);
        this.Controls.Add(this.labelFamily);
        this.Controls.Add(this.buttonBuy);
        this.Controls.Add(this.labelBuyPrice);
        this.Controls.Add(this.labelCategory);
        this.Controls.Add(this.labelName);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "formDC";
        this.Text = "Buying Goods";
        Load += this.formItemManagement_Load;
        this.groupboxItemInfo.ResumeLayout(false);
        this.groupboxItemInfo.PerformLayout();
        this.groupboxStatistics.ResumeLayout(false);
        this.groupboxStatistics.PerformLayout();
        this.groupboxVarious.ResumeLayout(false);
        this.groupboxVarious.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
    
    private System.Windows.Forms.Label labelVariousPicturePathDisplay;
    private System.Windows.Forms.GroupBox groupboxVarious;
    private System.Windows.Forms.Label labelVariousPicturePath;
    private System.Windows.Forms.Label labelStatisticsQuality;
    private System.Windows.Forms.Label labelStatisticsQualityDisplay;
    private System.Windows.Forms.Label labelStatisticsRarity;
    private System.Windows.Forms.Label labelStatisticsRarityDisplay;
    private System.Windows.Forms.Label labelStatisticsBaseWorth;
    private System.Windows.Forms.Label labelStatisticsBaseWorthDisplay;
    private System.Windows.Forms.Label labelVariousDescription;
    private System.Windows.Forms.Label labelVariousDescriptionDisplay;
    private System.Windows.Forms.Label labelStatisticsPopularity;
    private System.Windows.Forms.Label labelStatisticsPopularityDisplay;
    private System.Windows.Forms.Label labelStatisticsItemTier;
    private System.Windows.Forms.Label labelStatisticsItemTierDisplay;
    private System.Windows.Forms.GroupBox groupboxStatistics;
    private System.Windows.Forms.Label labelItemFamilyDisplay;
    private System.Windows.Forms.Label labelItemGenreDisplay;
    private System.Windows.Forms.Label labelItemCompanyDisplay;
    private System.Windows.Forms.Label labelItemItemNameDisplay;
    private System.Windows.Forms.Label labelItemCategoryDisplay;
    private System.Windows.Forms.Label labelItemBrandDisplay;
    private System.Windows.Forms.Label labelInfoFamily;
    private System.Windows.Forms.Label labelItemGenre;
    private System.Windows.Forms.Label labelItemCompany;
    private System.Windows.Forms.Label labelItemItemName;
    private System.Windows.Forms.Label labelItemCategory;
    private System.Windows.Forms.Label labelItemBrand;
    private System.Windows.Forms.Label labelPriceTotal;
    private System.Windows.Forms.TextBox textboxPriceTotal;
    private System.Windows.Forms.GroupBox groupboxItemInfo;
    private System.Windows.Forms.TextBox textboxBuyAmount;
    private System.Windows.Forms.TextBox textboxBuyPrice;
    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.Button buttonBuy;
    private System.Windows.Forms.Label labelBuyAmount;
    private System.Windows.Forms.Label labelBuyPrice;
    private System.Windows.Forms.ComboBox comboboxFamily;
    private System.Windows.Forms.ComboBox comboboxName;
    private System.Windows.Forms.ComboBox comboboxCategory;
    private System.Windows.Forms.ComboBox comboboxGenre;
    private System.Windows.Forms.Label labelGenre;
    private System.Windows.Forms.Label labelFamily;
    private System.Windows.Forms.Label labelCategory;
    private System.Windows.Forms.Label labelName;
}