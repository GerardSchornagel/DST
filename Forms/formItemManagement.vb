''' <summary>
''' Description of form/class/etc.
''' </summary>
Public Partial Class formItemManagement
	Private integerCounterSearch As Integer
	Private integerCounterArticle As Integer
	Private timerUpdate As New System.Windows.Forms.Timer
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Friend Sub formItemManagementLoad(sender As Object, e As EventArgs)
		AddHandler timerUpdate.Tick, AddressOf timerUpdateTick
		'TODO:Make a minium Interval value based on pc time to process random data equal to a medium big Savegame-size.
		timerUpdate.Interval = 5000
		timerUpdate.Start()

		'groupboxStorage
		labelStorageTotalSection.Text = "\ "& gamecache.playerStorage.arraySection.GetUpperBound(0)
		updownStorageSection.Maximum = gamecache.playerStorage.arraySection.GetUpperBound(0)
		If gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle IsNot Nothing Then
			labelStorageTotalArticle.Text = "\ "& gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle.GetUpperBound(0)
			updownStorageArticle.Maximum = gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle.GetUpperBound(0)
			
			textboxStoragePhItem.Text = gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticlePath & gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticleFile
			textboxStorageName.Text = gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ItemLink.Name_Title
			textboxStorageQuantity.Text = CType(gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).Quantity, String)
			textboxStorageLastSell.Text = CType(gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastSell, String)
			textboxStorageLastBuy.Text = CType(gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastBuy, String)
		End If
		
		'groupboxStore
		labelStoreTotalLevel.Text = "\ "& gamecache.playerStore.arrayLevel.GetUpperBound(0)
		updownStoreLevel.Maximum = gamecache.playerStore.arrayLevel.GetUpperBound(0)
		labelStoreTotalShelf.Text = "\ "& gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf.GetUpperBound(0)
		updownStoreShelf.Maximum = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf.GetUpperBound(0)
		If gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin IsNot Nothing Then
			labelStoreTotalBin.Text = "\ "& gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			updownStoreBin.Maximum = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			
			textboxStorePhItem.Text = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinPath & gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinFile
			textboxStoreName.Text = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleName
			textboxStoreQuantity.Text = CType((gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinQuantity), String)
			updownStorePrice.Value = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleLastSell
		End If
	End Sub
	
	Private Sub timerUpdateTick(sender As Object, e As system.EventArgs)
		'groupboxStorage
		labelStorageTotalSection.Text = "\ "& gamecache.playerStorage.arraySection.GetUpperBound(0)
		updownStorageSection.Maximum = gamecache.playerStorage.arraySection.GetUpperBound(0)
		If gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle IsNot Nothing Then
			labelStorageTotalArticle.Text = "\ "& gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle.GetUpperBound(0)
			updownStorageArticle.Maximum = gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle.GetUpperBound(0)
			
			textboxStoragePhItem.Text = gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticlePath & gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticleFile
			textboxStorageName.Text = gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ItemLink.Name_Title
			textboxStorageQuantity.Text = CType(gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).Quantity, String)
			textboxStorageLastSell.Text = CType(gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastSell, String)
			textboxStorageLastBuy.Text = CType(gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastBuy, String)
		End If
		'groupboxStore
		labelStoreTotalLevel.Text = "\ "& gamecache.playerStore.arrayLevel.GetUpperBound(0)
		updownStoreLevel.Maximum = gamecache.playerStore.arrayLevel.GetUpperBound(0)
		labelStoreTotalShelf.Text = "\ "& gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf.GetUpperBound(0)
		updownStoreShelf.Maximum = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf.GetUpperBound(0)
		If gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin IsNot Nothing Then
			labelStoreTotalBin.Text = "\ "& gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			updownStoreBin.Maximum = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			
			textboxStorePhItem.Text = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinPath & gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinFile
			textboxStoreName.Text = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleName
			textboxStoreQuantity.Text = CType((gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinQuantity), String)
			updownStorePrice.Value = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleLastSell
		End If
	End Sub
	
	Sub UpdownStoreLevelValueChanged(sender As Object, e As EventArgs)
		labelStoreTotalShelf.Text = "\ "& gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf.GetUpperBound(0)
		updownStoreShelf.Maximum = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf.GetUpperBound(0)
		If gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin IsNot Nothing Then
			labelStoreTotalBin.Text = "\ "& gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			updownStoreBin.Maximum = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			
			textboxStorePhItem.Text = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinPath & gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinFile
			textboxStoreName.Text = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleName
			textboxStoreQuantity.Text = CType((gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinQuantity), String)
			updownStorePrice.Value = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleLastSell
		End If
	End Sub
	
	Sub UpdownStoreShelfValueChanged(sender As Object, e As EventArgs)
		If gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin IsNot Nothing Then
			labelStoreTotalBin.Text = "\ "& gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			updownStoreBin.Maximum = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			
			textboxStorePhItem.Text = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinPath & gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinFile
			textboxStoreName.Text = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleName
			textboxStoreQuantity.Text = CType((gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinQuantity), String)
			updownStorePrice.Value = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleLastSell
		End If
	End Sub
	
	Sub UpdownStoreBinValueChanged(sender As Object, e As EventArgs)
		If gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin IsNot Nothing Then
			textboxStorePhItem.Text = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinPath & gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinFile
			textboxStoreName.Text = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleName
			textboxStoreQuantity.Text = CType((gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinQuantity), String)
			updownStorePrice.Value = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleLastSell
		End If
	End Sub
	
	Sub UpdownStorePriceLostFocus(sender As Object, e As EventArgs)
		updownStorePrice.Value = CType(updownStorePrice.Value, Integer)
		Dim integerSection As Integer = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).LinkSection
		Dim integerArticle As Integer = gamecache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).LinkArticle
		gamecache.playerStorage.arraySection(integerSection).arrayArticle(integerArticle).LastSell = CType(updownStorePrice.Value, Integer)
		gamecache.playerStorage.arraySection(integerSection).arrayArticle(integerArticle).ArticleSave(gamecache.playerStorage.arraySection(integerSection).SectionPath)

		formItemManagementLoad(Nothing, Nothing)
	End Sub
	
	Sub UpdownStorageSectionValueChanged(sender As Object, e As EventArgs)
		If gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle IsNot Nothing Then
			labelStorageTotalArticle.Text = "\ "& gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle.GetUpperBound(0)
			updownStorageArticle.Maximum = gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle.GetUpperBound(0)
			
			textboxStoragePhItem.Text = gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticlePath & gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticleFile
			textboxStorageName.Text = gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ItemLink.Name_Title
			textboxStorageQuantity.Text = CType(gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).Quantity, String)
			textboxStorageLastSell.Text = CType(gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastSell, String)
			textboxStorageLastBuy.Text = CType(gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastBuy, String)
		End If
	End Sub
	
	Sub UpdownStorageArticleValueChanged(sender As Object, e As EventArgs)
		If gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle IsNot Nothing Then
			textboxStoragePhItem.Text = gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticlePath & gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticleFile
			textboxStorageName.Text = gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ItemLink.Name_Title
			textboxStorageQuantity.Text = CType(gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).Quantity, String)
			textboxStorageLastSell.Text = CType(gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastSell, String)
			textboxStorageLastBuy.Text = CType(gamecache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastBuy, String)
		End If
	End Sub
	
	Sub buttonToStoreClick(sender As Object, e As EventArgs)
		timerUpdate.Enabled = False
		Dim integerStoreLevel As Integer = CType(updownStoreLevel.Value, Integer)
		Dim integerStoreShelf As Integer = CType(updownStoreShelf.Value, Integer)
		Dim integerStoreBin As Integer = CType(updownStoreBin.Value, Integer)
		Dim integerStorageSection As Integer = CType(updownStorageSection.Value, Integer)
		Dim integerStorageArticle As Integer = CType(updownStorageArticle.Value, Integer)
		
		If textboxStoreName.Text = textboxStorageName.Text Then
			gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity += gamecache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).Quantity
			gamecache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).Quantity = 0
			
			gamecache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).ArticleSave(gamecache.playerStorage.arraySection(integerStorageSection).SectionPath)
			gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinSave(gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).ShelfPath)
		Else
			If MsgBox("Replaces current item, else add new Bin to current Shelf." & Chr(10) & "Use No for the first time when a player is new.", Microsoft.VisualBasic.MsgBoxStyle.YesNo, "Replace?") = 6 Then
				Dim integerSection As Integer = gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkSection
				Dim integerArticle As Integer = gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkArticle
				gamecache.playerStorage.arraySection(integerSection).arrayArticle(integerArticle).Quantity += gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity
				gamecache.playerStorage.arraySection(integerSection).arrayArticle(integerArticle).ArticleSave(gamecache.playerStorage.arraySection(integerSection).SectionPath)
				
				gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkStorage = 0
				gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkSection = integerStorageSection
				gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkArticle = integerStorageArticle
				gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity = gamecache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).Quantity
				gamecache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).Quantity = 0
				
				gamecache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).ArticleSave(gamecache.playerStorage.arraySection(integerStorageSection).SectionPath)
				gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinSave(gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).ShelfPath)

			Else
				gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).BinAdd(New String() {"0", CType(integerStorageSection, String), CType(integerStorageArticle, String), textboxStorageQuantity.Text})
				gamecache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).Quantity = 0
				
				gamecache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).ArticleSave(gamecache.playerStorage.arraySection(integerStorageSection).SectionPath)
				
			End If			
		End If
		timerUpdate.Enabled = True
		timerUpdateTick(Nothing, Nothing)
	End Sub
	
	Sub buttonToStorageClick(sender As Object, e As EventArgs)
		Dim integerStoreLevel As Integer = CType(updownStoreLevel.Value, Integer)
		Dim integerStoreShelf As Integer = CType(updownStoreShelf.Value, Integer)
		Dim integerStoreBin As Integer = CType(updownStoreBin.Value, Integer)
		Dim integerStorageSection As Integer = CType(updownStorageSection.Value, Integer)
		Dim integerStorageArticle As Integer = CType(updownStorageArticle.Value, Integer)
		
		Dim integerSection As Integer = gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkSection
		Dim integerArticle As Integer = gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkArticle
		gamecache.playerStorage.arraySection(integerSection).arrayArticle(integerArticle).Quantity += gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity
		gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity = 0
		
		gamecache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).ArticleSave(gamecache.playerStorage.arraySection(integerStorageSection).SectionPath)
		gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinSave(gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).ShelfPath)
		
		timerUpdateTick(Nothing, Nothing)
	End Sub
	
	Sub ButtonCloseClick(sender As Object, e As EventArgs)
		Me.Hide()
	End Sub	
End Class