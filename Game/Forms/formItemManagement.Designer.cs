using System;

partial class formItemManagement : System.Windows.Forms.Form
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
        this.labelStoreTotalLevel = new System.Windows.Forms.Label();
        this.updownStoreLevel = new System.Windows.Forms.NumericUpDown();
        this.labelStoreLevel = new System.Windows.Forms.Label();
        this.labelStoreShelf = new System.Windows.Forms.Label();
        this.updownStoreShelf = new System.Windows.Forms.NumericUpDown();
        this.labelStoreTotalShelf = new System.Windows.Forms.Label();
        this.labelStoreTotalBin = new System.Windows.Forms.Label();
        this.updownStoreBin = new System.Windows.Forms.NumericUpDown();
        this.labelStoreBin = new System.Windows.Forms.Label();
        this.groupboxStoreNavigation = new System.Windows.Forms.GroupBox();
        this.groupboxStoreSelected = new System.Windows.Forms.GroupBox();
        this.updownStorePrice = new System.Windows.Forms.NumericUpDown();
        this.textboxStoreQuantity = new System.Windows.Forms.TextBox();
        this.labelStorePrice = new System.Windows.Forms.Label();
        this.textboxStoreName = new System.Windows.Forms.TextBox();
        this.labelStoreQuantity = new System.Windows.Forms.Label();
        this.textboxStorePhItem = new System.Windows.Forms.TextBox();
        this.labelStoreName = new System.Windows.Forms.Label();
        this.labelStorePhItem = new System.Windows.Forms.Label();
        this.textboxStoragePhItem = new System.Windows.Forms.TextBox();
        this.labelStoragePhItem = new System.Windows.Forms.Label();
        this.buttonToStore = new System.Windows.Forms.Button();
        this.buttonToStorage = new System.Windows.Forms.Button();
        this.buttonClose = new System.Windows.Forms.Button();
        this.groupboxStore = new System.Windows.Forms.GroupBox();
        this.labelStorageQuantity = new System.Windows.Forms.Label();
        this.labelStorageLastBuy = new System.Windows.Forms.Label();
        this.labelStorageLastSell = new System.Windows.Forms.Label();
        this.groupboxStorage = new System.Windows.Forms.GroupBox();
        this.groupboxStorageNavigation = new System.Windows.Forms.GroupBox();
        this.labelStorageArticle = new System.Windows.Forms.Label();
        this.labelStorageSection = new System.Windows.Forms.Label();
        this.updownStorageArticle = new System.Windows.Forms.NumericUpDown();
        this.labelStorageTotalSection = new System.Windows.Forms.Label();
        this.labelStorageTotalArticle = new System.Windows.Forms.Label();
        this.updownStorageSection = new System.Windows.Forms.NumericUpDown();
        this.groupboxStorageSelected = new System.Windows.Forms.GroupBox();
        this.textboxStorageLastBuy = new System.Windows.Forms.TextBox();
        this.textboxStorageName = new System.Windows.Forms.TextBox();
        this.textboxStorageLastSell = new System.Windows.Forms.TextBox();
        this.textboxStorageQuantity = new System.Windows.Forms.TextBox();
        this.labelStorageName = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)this.updownStoreLevel).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.updownStoreShelf).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.updownStoreBin).BeginInit();
        this.groupboxStoreNavigation.SuspendLayout();
        this.groupboxStoreSelected.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.updownStorePrice).BeginInit();
        this.groupboxStore.SuspendLayout();
        this.groupboxStorage.SuspendLayout();
        this.groupboxStorageNavigation.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.updownStorageArticle).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.updownStorageSection).BeginInit();
        this.groupboxStorageSelected.SuspendLayout();
        this.SuspendLayout();
        //
        //labelStoreTotalLevel
        //
        this.labelStoreTotalLevel.AutoSize = true;
        this.labelStoreTotalLevel.Location = new System.Drawing.Point(46, 34);
        this.labelStoreTotalLevel.Name = "labelStoreTotalLevel";
        this.labelStoreTotalLevel.Size = new System.Drawing.Size(21, 13);
        this.labelStoreTotalLevel.TabIndex = 1;
        this.labelStoreTotalLevel.Text = "\\ 0";
        //
        //updownStoreLevel
        //
        this.updownStoreLevel.Location = new System.Drawing.Point(6, 32);
        this.updownStoreLevel.Name = "updownStoreLevel";
        this.updownStoreLevel.Size = new System.Drawing.Size(34, 20);
        this.updownStoreLevel.TabIndex = 2;
        this.updownStoreLevel.ValueChanged += this.updownStoreLevel_ValueChanged;
        //
        //labelStoreLevel
        //
        this.labelStoreLevel.AutoSize = true;
        this.labelStoreLevel.Location = new System.Drawing.Point(6, 16);
        this.labelStoreLevel.Name = "labelStoreLevel";
        this.labelStoreLevel.Size = new System.Drawing.Size(36, 13);
        this.labelStoreLevel.TabIndex = 3;
        this.labelStoreLevel.Text = "Level:";
        //
        //labelStoreShelf
        //
        this.labelStoreShelf.AutoSize = true;
        this.labelStoreShelf.Location = new System.Drawing.Point(98, 16);
        this.labelStoreShelf.Name = "labelStoreShelf";
        this.labelStoreShelf.Size = new System.Drawing.Size(34, 13);
        this.labelStoreShelf.TabIndex = 6;
        this.labelStoreShelf.Text = "Shelf:";
        //
        //updownStoreShelf
        //
        this.updownStoreShelf.Location = new System.Drawing.Point(98, 32);
        this.updownStoreShelf.Name = "updownStoreShelf";
        this.updownStoreShelf.Size = new System.Drawing.Size(34, 20);
        this.updownStoreShelf.TabIndex = 5;
        this.updownStoreShelf.ValueChanged += this.updownStoreShelf_ValueChanged;
        //
        //labelStoreTotalShelf
        //
        this.labelStoreTotalShelf.AutoSize = true;
        this.labelStoreTotalShelf.Location = new System.Drawing.Point(138, 34);
        this.labelStoreTotalShelf.Name = "labelStoreTotalShelf";
        this.labelStoreTotalShelf.Size = new System.Drawing.Size(21, 13);
        this.labelStoreTotalShelf.TabIndex = 4;
        this.labelStoreTotalShelf.Text = "\\ 0";
        //
        //labelStoreTotalBin
        //
        this.labelStoreTotalBin.AutoSize = true;
        this.labelStoreTotalBin.Location = new System.Drawing.Point(233, 34);
        this.labelStoreTotalBin.Name = "labelStoreTotalBin";
        this.labelStoreTotalBin.Size = new System.Drawing.Size(21, 13);
        this.labelStoreTotalBin.TabIndex = 4;
        this.labelStoreTotalBin.Text = "\\ 0";
        //
        //updownStoreBin
        //
        this.updownStoreBin.Location = new System.Drawing.Point(193, 32);
        this.updownStoreBin.Name = "updownStoreBin";
        this.updownStoreBin.Size = new System.Drawing.Size(34, 20);
        this.updownStoreBin.TabIndex = 5;
        this.updownStoreBin.ValueChanged += this.updownStoreBin_ValueChanged;
        //
        //labelStoreBin
        //
        this.labelStoreBin.AutoSize = true;
        this.labelStoreBin.Location = new System.Drawing.Point(193, 16);
        this.labelStoreBin.Name = "labelStoreBin";
        this.labelStoreBin.Size = new System.Drawing.Size(25, 13);
        this.labelStoreBin.TabIndex = 6;
        this.labelStoreBin.Text = "Bin:";
        //
        //groupboxStoreNavigation
        //
        this.groupboxStoreNavigation.Controls.Add(this.labelStoreLevel);
        this.groupboxStoreNavigation.Controls.Add(this.labelStoreBin);
        this.groupboxStoreNavigation.Controls.Add(this.labelStoreTotalLevel);
        this.groupboxStoreNavigation.Controls.Add(this.labelStoreShelf);
        this.groupboxStoreNavigation.Controls.Add(this.updownStoreLevel);
        this.groupboxStoreNavigation.Controls.Add(this.updownStoreBin);
        this.groupboxStoreNavigation.Controls.Add(this.labelStoreTotalShelf);
        this.groupboxStoreNavigation.Controls.Add(this.labelStoreTotalBin);
        this.groupboxStoreNavigation.Controls.Add(this.updownStoreShelf);
        this.groupboxStoreNavigation.Location = new System.Drawing.Point(6, 19);
        this.groupboxStoreNavigation.Name = "groupboxStoreNavigation";
        this.groupboxStoreNavigation.Size = new System.Drawing.Size(260, 57);
        this.groupboxStoreNavigation.TabIndex = 7;
        this.groupboxStoreNavigation.TabStop = false;
        this.groupboxStoreNavigation.Text = "Navigation";
        //
        //groupboxStoreSelected
        //
        this.groupboxStoreSelected.Controls.Add(this.updownStorePrice);
        this.groupboxStoreSelected.Controls.Add(this.textboxStoreQuantity);
        this.groupboxStoreSelected.Controls.Add(this.labelStorePrice);
        this.groupboxStoreSelected.Controls.Add(this.textboxStoreName);
        this.groupboxStoreSelected.Controls.Add(this.labelStoreQuantity);
        this.groupboxStoreSelected.Controls.Add(this.textboxStorePhItem);
        this.groupboxStoreSelected.Controls.Add(this.labelStoreName);
        this.groupboxStoreSelected.Controls.Add(this.labelStorePhItem);
        this.groupboxStoreSelected.Location = new System.Drawing.Point(6, 82);
        this.groupboxStoreSelected.Name = "groupboxStoreSelected";
        this.groupboxStoreSelected.Size = new System.Drawing.Size(260, 142);
        this.groupboxStoreSelected.TabIndex = 8;
        this.groupboxStoreSelected.TabStop = false;
        this.groupboxStoreSelected.Text = "Selected Bin";
        //
        //updownStorePrice
        //
        this.updownStorePrice.Location = new System.Drawing.Point(112, 97);
        this.updownStorePrice.Name = "updownStorePrice";
        this.updownStorePrice.Size = new System.Drawing.Size(141, 20);
        this.updownStorePrice.TabIndex = 4;
        this.updownStorePrice.LostFocus += this.updownStorePrice_LostFocus;
        //
        //textboxStoreQuantity
        //
        this.textboxStoreQuantity.Location = new System.Drawing.Point(112, 71);
        this.textboxStoreQuantity.Name = "textboxStoreQuantity";
        this.textboxStoreQuantity.Size = new System.Drawing.Size(141, 20);
        this.textboxStoreQuantity.TabIndex = 3;
        //
        //labelStorePrice
        //
        this.labelStorePrice.AutoSize = true;
        this.labelStorePrice.Location = new System.Drawing.Point(5, 100);
        this.labelStorePrice.Name = "labelStorePrice";
        this.labelStorePrice.Size = new System.Drawing.Size(68, 13);
        this.labelStorePrice.TabIndex = 2;
        this.labelStorePrice.Text = "Selling Price:";
        //
        //textboxStoreName
        //
        this.textboxStoreName.Location = new System.Drawing.Point(112, 45);
        this.textboxStoreName.Name = "textboxStoreName";
        this.textboxStoreName.Size = new System.Drawing.Size(141, 20);
        this.textboxStoreName.TabIndex = 3;
        //
        //labelStoreQuantity
        //
        this.labelStoreQuantity.AutoSize = true;
        this.labelStoreQuantity.Location = new System.Drawing.Point(5, 74);
        this.labelStoreQuantity.Name = "labelStoreQuantity";
        this.labelStoreQuantity.Size = new System.Drawing.Size(49, 13);
        this.labelStoreQuantity.TabIndex = 2;
        this.labelStoreQuantity.Text = "Quantity:";
        //
        //textboxStorePhItem
        //
        this.textboxStorePhItem.Location = new System.Drawing.Point(112, 19);
        this.textboxStorePhItem.Name = "textboxStorePhItem";
        this.textboxStorePhItem.Size = new System.Drawing.Size(141, 20);
        this.textboxStorePhItem.TabIndex = 3;
        //
        //labelStoreName
        //
        this.labelStoreName.AutoSize = true;
        this.labelStoreName.Location = new System.Drawing.Point(5, 48);
        this.labelStoreName.Name = "labelStoreName";
        this.labelStoreName.Size = new System.Drawing.Size(61, 13);
        this.labelStoreName.TabIndex = 2;
        this.labelStoreName.Text = "Item Name:";
        //
        //labelStorePhItem
        //
        this.labelStorePhItem.AutoSize = true;
        this.labelStorePhItem.Location = new System.Drawing.Point(5, 22);
        this.labelStorePhItem.Name = "labelStorePhItem";
        this.labelStorePhItem.Size = new System.Drawing.Size(49, 13);
        this.labelStorePhItem.TabIndex = 2;
        this.labelStorePhItem.Text = "Ph. Item:";
        //
        //textboxStoragePhItem
        //
        this.textboxStoragePhItem.Location = new System.Drawing.Point(113, 13);
        this.textboxStoragePhItem.Name = "textboxStoragePhItem";
        this.textboxStoragePhItem.Size = new System.Drawing.Size(146, 20);
        this.textboxStoragePhItem.TabIndex = 3;
        //
        //labelStoragePhItem
        //
        this.labelStoragePhItem.AutoSize = true;
        this.labelStoragePhItem.Location = new System.Drawing.Point(6, 16);
        this.labelStoragePhItem.Name = "labelStoragePhItem";
        this.labelStoragePhItem.Size = new System.Drawing.Size(49, 13);
        this.labelStoragePhItem.TabIndex = 2;
        this.labelStoragePhItem.Text = "Ph. Item:";
        //
        //buttonToStore
        //
        this.buttonToStore.Location = new System.Drawing.Point(295, 77);
        this.buttonToStore.Name = "buttonToStore";
        this.buttonToStore.Size = new System.Drawing.Size(74, 65);
        this.buttonToStore.TabIndex = 1;
        this.buttonToStore.Text = "Bin >>";
        this.buttonToStore.UseVisualStyleBackColor = true;
        this.buttonToStore.Click += this.buttonToStore_Click;
        //
        //buttonToStorage
        //
        this.buttonToStorage.Location = new System.Drawing.Point(295, 12);
        this.buttonToStorage.Name = "buttonToStorage";
        this.buttonToStorage.Size = new System.Drawing.Size(74, 59);
        this.buttonToStorage.TabIndex = 0;
        this.buttonToStorage.Text = "<< Storage";
        this.buttonToStorage.UseVisualStyleBackColor = true;
        this.buttonToStorage.Click += this.buttonToStorage_Click;
        //
        //buttonClose
        //
        this.buttonClose.Location = new System.Drawing.Point(295, 148);
        this.buttonClose.Name = "buttonClose";
        this.buttonClose.Size = new System.Drawing.Size(74, 94);
        this.buttonClose.TabIndex = 0;
        this.buttonClose.Text = "Close";
        this.buttonClose.UseVisualStyleBackColor = true;
        this.buttonClose.Click += this.buttonClose_Click;
        //
        //groupboxStore
        //
        this.groupboxStore.Controls.Add(this.groupboxStoreNavigation);
        this.groupboxStore.Controls.Add(this.groupboxStoreSelected);
        this.groupboxStore.Location = new System.Drawing.Point(375, 12);
        this.groupboxStore.Name = "groupboxStore";
        this.groupboxStore.Size = new System.Drawing.Size(272, 230);
        this.groupboxStore.TabIndex = 10;
        this.groupboxStore.TabStop = false;
        this.groupboxStore.Text = "Store";
        //
        //labelStorageQuantity
        //
        this.labelStorageQuantity.AutoSize = true;
        this.labelStorageQuantity.Location = new System.Drawing.Point(6, 68);
        this.labelStorageQuantity.Name = "labelStorageQuantity";
        this.labelStorageQuantity.Size = new System.Drawing.Size(46, 13);
        this.labelStorageQuantity.TabIndex = 0;
        this.labelStorageQuantity.Text = "Quantity";
        //
        //labelStorageLastBuy
        //
        this.labelStorageLastBuy.AutoSize = true;
        this.labelStorageLastBuy.Location = new System.Drawing.Point(6, 120);
        this.labelStorageLastBuy.Name = "labelStorageLastBuy";
        this.labelStorageLastBuy.Size = new System.Drawing.Size(89, 13);
        this.labelStorageLastBuy.TabIndex = 0;
        this.labelStorageLastBuy.Text = "Last Buying Price";
        //
        //labelStorageLastSell
        //
        this.labelStorageLastSell.AutoSize = true;
        this.labelStorageLastSell.Location = new System.Drawing.Point(6, 94);
        this.labelStorageLastSell.Name = "labelStorageLastSell";
        this.labelStorageLastSell.Size = new System.Drawing.Size(88, 13);
        this.labelStorageLastSell.TabIndex = 0;
        this.labelStorageLastSell.Text = "Last Selling Price";
        //
        //groupboxStorage
        //
        this.groupboxStorage.Controls.Add(this.groupboxStorageNavigation);
        this.groupboxStorage.Controls.Add(this.groupboxStorageSelected);
        this.groupboxStorage.Location = new System.Drawing.Point(12, 12);
        this.groupboxStorage.Name = "groupboxStorage";
        this.groupboxStorage.Size = new System.Drawing.Size(277, 230);
        this.groupboxStorage.TabIndex = 9;
        this.groupboxStorage.TabStop = false;
        this.groupboxStorage.Text = "Storage";
        //
        //groupboxStorageNavigation
        //
        this.groupboxStorageNavigation.Controls.Add(this.labelStorageArticle);
        this.groupboxStorageNavigation.Controls.Add(this.labelStorageSection);
        this.groupboxStorageNavigation.Controls.Add(this.updownStorageArticle);
        this.groupboxStorageNavigation.Controls.Add(this.labelStorageTotalSection);
        this.groupboxStorageNavigation.Controls.Add(this.labelStorageTotalArticle);
        this.groupboxStorageNavigation.Controls.Add(this.updownStorageSection);
        this.groupboxStorageNavigation.Location = new System.Drawing.Point(6, 19);
        this.groupboxStorageNavigation.Name = "groupboxStorageNavigation";
        this.groupboxStorageNavigation.Size = new System.Drawing.Size(265, 57);
        this.groupboxStorageNavigation.TabIndex = 7;
        this.groupboxStorageNavigation.TabStop = false;
        this.groupboxStorageNavigation.Text = "Navigation";
        //
        //labelStorageArticle
        //
        this.labelStorageArticle.AutoSize = true;
        this.labelStorageArticle.Location = new System.Drawing.Point(198, 16);
        this.labelStorageArticle.Name = "labelStorageArticle";
        this.labelStorageArticle.Size = new System.Drawing.Size(39, 13);
        this.labelStorageArticle.TabIndex = 6;
        this.labelStorageArticle.Text = "Article:";
        //
        //labelStorageSection
        //
        this.labelStorageSection.AutoSize = true;
        this.labelStorageSection.Location = new System.Drawing.Point(12, 16);
        this.labelStorageSection.Name = "labelStorageSection";
        this.labelStorageSection.Size = new System.Drawing.Size(46, 13);
        this.labelStorageSection.TabIndex = 6;
        this.labelStorageSection.Text = "Section:";
        //
        //updownStorageArticle
        //
        this.updownStorageArticle.Location = new System.Drawing.Point(198, 32);
        this.updownStorageArticle.Name = "updownStorageArticle";
        this.updownStorageArticle.Size = new System.Drawing.Size(34, 20);
        this.updownStorageArticle.TabIndex = 5;
        this.updownStorageArticle.ValueChanged += this.updownStorageArticle_ValueChanged;
        //
        //labelStorageTotalSection
        //
        this.labelStorageTotalSection.AutoSize = true;
        this.labelStorageTotalSection.Location = new System.Drawing.Point(52, 34);
        this.labelStorageTotalSection.Name = "labelStorageTotalSection";
        this.labelStorageTotalSection.Size = new System.Drawing.Size(21, 13);
        this.labelStorageTotalSection.TabIndex = 4;
        this.labelStorageTotalSection.Text = "\\ 0";
        //
        //labelStorageTotalArticle
        //
        this.labelStorageTotalArticle.AutoSize = true;
        this.labelStorageTotalArticle.Location = new System.Drawing.Point(238, 34);
        this.labelStorageTotalArticle.Name = "labelStorageTotalArticle";
        this.labelStorageTotalArticle.Size = new System.Drawing.Size(21, 13);
        this.labelStorageTotalArticle.TabIndex = 4;
        this.labelStorageTotalArticle.Text = "\\ 0";
        //
        //updownStorageSection
        //
        this.updownStorageSection.Location = new System.Drawing.Point(12, 32);
        this.updownStorageSection.Name = "updownStorageSection";
        this.updownStorageSection.Size = new System.Drawing.Size(34, 20);
        this.updownStorageSection.TabIndex = 5;
        this.updownStorageSection.ValueChanged += this.updownStorageSection_ValueChanged;
        //
        //groupboxStorageSelected
        //
        this.groupboxStorageSelected.Controls.Add(this.labelStorageQuantity);
        this.groupboxStorageSelected.Controls.Add(this.textboxStorageLastBuy);
        this.groupboxStorageSelected.Controls.Add(this.textboxStorageName);
        this.groupboxStorageSelected.Controls.Add(this.textboxStoragePhItem);
        this.groupboxStorageSelected.Controls.Add(this.textboxStorageLastSell);
        this.groupboxStorageSelected.Controls.Add(this.labelStorageLastBuy);
        this.groupboxStorageSelected.Controls.Add(this.labelStorageLastSell);
        this.groupboxStorageSelected.Controls.Add(this.textboxStorageQuantity);
        this.groupboxStorageSelected.Controls.Add(this.labelStoragePhItem);
        this.groupboxStorageSelected.Controls.Add(this.labelStorageName);
        this.groupboxStorageSelected.Location = new System.Drawing.Point(6, 82);
        this.groupboxStorageSelected.Name = "groupboxStorageSelected";
        this.groupboxStorageSelected.Size = new System.Drawing.Size(265, 142);
        this.groupboxStorageSelected.TabIndex = 8;
        this.groupboxStorageSelected.TabStop = false;
        this.groupboxStorageSelected.Text = "Selected Article";
        //
        //textboxStorageLastBuy
        //
        this.textboxStorageLastBuy.Location = new System.Drawing.Point(113, 117);
        this.textboxStorageLastBuy.Name = "textboxStorageLastBuy";
        this.textboxStorageLastBuy.Size = new System.Drawing.Size(146, 20);
        this.textboxStorageLastBuy.TabIndex = 3;
        //
        //textboxStorageName
        //
        this.textboxStorageName.Location = new System.Drawing.Point(113, 39);
        this.textboxStorageName.Name = "textboxStorageName";
        this.textboxStorageName.Size = new System.Drawing.Size(146, 20);
        this.textboxStorageName.TabIndex = 3;
        //
        //textboxStorageLastSell
        //
        this.textboxStorageLastSell.Location = new System.Drawing.Point(113, 91);
        this.textboxStorageLastSell.Name = "textboxStorageLastSell";
        this.textboxStorageLastSell.Size = new System.Drawing.Size(146, 20);
        this.textboxStorageLastSell.TabIndex = 3;
        //
        //textboxStorageQuantity
        //
        this.textboxStorageQuantity.Location = new System.Drawing.Point(113, 65);
        this.textboxStorageQuantity.Name = "textboxStorageQuantity";
        this.textboxStorageQuantity.Size = new System.Drawing.Size(146, 20);
        this.textboxStorageQuantity.TabIndex = 3;
        //
        //labelStorageName
        //
        this.labelStorageName.AutoSize = true;
        this.labelStorageName.Location = new System.Drawing.Point(6, 42);
        this.labelStorageName.Name = "labelStorageName";
        this.labelStorageName.Size = new System.Drawing.Size(61, 13);
        this.labelStorageName.TabIndex = 2;
        this.labelStorageName.Text = "Item Name:";
        //
        //formItemManagement
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(660, 254);
        this.Controls.Add(this.groupboxStore);
        this.Controls.Add(this.groupboxStorage);
        this.Controls.Add(this.buttonClose);
        this.Controls.Add(this.buttonToStorage);
        this.Controls.Add(this.buttonToStore);
        this.Name = "formItemManagement";
        this.Text = "My First Store";
        Load += this.formItemManagement_Load;
        ((System.ComponentModel.ISupportInitialize)this.updownStoreLevel).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.updownStoreShelf).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.updownStoreBin).EndInit();
        this.groupboxStoreNavigation.ResumeLayout(false);
        this.groupboxStoreNavigation.PerformLayout();
        this.groupboxStoreSelected.ResumeLayout(false);
        this.groupboxStoreSelected.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.updownStorePrice).EndInit();
        this.groupboxStore.ResumeLayout(false);
        this.groupboxStorage.ResumeLayout(false);
        this.groupboxStorageNavigation.ResumeLayout(false);
        this.groupboxStorageNavigation.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.updownStorageArticle).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.updownStorageSection).EndInit();
        this.groupboxStorageSelected.ResumeLayout(false);
        this.groupboxStorageSelected.PerformLayout();
        this.ResumeLayout(false);
    }
    
    private System.Windows.Forms.Label labelStorageName;
    private System.Windows.Forms.TextBox textboxStorageLastSell;
    private System.Windows.Forms.TextBox textboxStorageName;
    private System.Windows.Forms.TextBox textboxStorageLastBuy;
    private System.Windows.Forms.Label labelStorePhItem;
    private System.Windows.Forms.TextBox textboxStorePhItem;
    private System.Windows.Forms.GroupBox groupboxStorageSelected;
    private System.Windows.Forms.NumericUpDown updownStorageSection;
    private System.Windows.Forms.Label labelStorageTotalArticle;
    private System.Windows.Forms.Label labelStorageTotalSection;
    private System.Windows.Forms.NumericUpDown updownStorageArticle;
    private System.Windows.Forms.Label labelStorageSection;
    private System.Windows.Forms.Label labelStorageArticle;
    private System.Windows.Forms.GroupBox groupboxStorageNavigation;
    private System.Windows.Forms.GroupBox groupboxStorage;
    private System.Windows.Forms.TextBox textboxStorageQuantity;
    private System.Windows.Forms.Label labelStorageLastSell;
    private System.Windows.Forms.Label labelStorageLastBuy;
    private System.Windows.Forms.Label labelStorageQuantity;
    private System.Windows.Forms.GroupBox groupboxStore;
    private System.Windows.Forms.NumericUpDown updownStorePrice;
    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.Button buttonToStorage;
    private System.Windows.Forms.Button buttonToStore;
    private System.Windows.Forms.Label labelStoragePhItem;
    private System.Windows.Forms.Label labelStoreName;
    private System.Windows.Forms.TextBox textboxStoragePhItem;
    private System.Windows.Forms.Label labelStoreQuantity;
    private System.Windows.Forms.TextBox textboxStoreName;
    private System.Windows.Forms.Label labelStorePrice;
    private System.Windows.Forms.TextBox textboxStoreQuantity;
    private System.Windows.Forms.GroupBox groupboxStoreSelected;
    private System.Windows.Forms.GroupBox groupboxStoreNavigation;
    private System.Windows.Forms.Label labelStoreBin;
    private System.Windows.Forms.NumericUpDown updownStoreBin;
    private System.Windows.Forms.Label labelStoreTotalBin;
    private System.Windows.Forms.Label labelStoreTotalShelf;
    private System.Windows.Forms.NumericUpDown updownStoreShelf;
    private System.Windows.Forms.Label labelStoreShelf;
    private System.Windows.Forms.Label labelStoreLevel;
    private System.Windows.Forms.NumericUpDown updownStoreLevel;
    private System.Windows.Forms.Label labelStoreTotalLevel;
}