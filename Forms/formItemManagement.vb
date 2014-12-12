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
		labelStorageTotalSection.Text = "\ "& cache.playerStorage.arraySection.GetUpperBound(0)
		updownStorageSection.Maximum = cache.playerStorage.arraySection.GetUpperBound(0)
		If cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle IsNot Nothing Then
			labelStorageTotalArticle.Text = "\ "& cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle.GetUpperBound(0)
			updownStorageArticle.Maximum = cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle.GetUpperBound(0)
			
			textboxStoragePhItem.Text = cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticlePath & cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticleFile
			textboxStorageName.Text = cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ItemName
			textboxStorageQuantity.Text = CType(cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).Quantity, String)
			textboxStorageLastSell.Text = CType(cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastSell, String)
			textboxStorageLastBuy.Text = CType(cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastBuy, String)
		End If
		
		'groupboxStore
		labelStoreTotalLevel.Text = "\ "& cache.playerStore.arrayLevel.GetUpperBound(0)
		updownStoreLevel.Maximum = cache.playerStore.arrayLevel.GetUpperBound(0)
		labelStoreTotalShelf.Text = "\ "& cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf.GetUpperBound(0)
		updownStoreShelf.Maximum = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf.GetUpperBound(0)
		If cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin IsNot Nothing Then
			labelStoreTotalBin.Text = "\ "& cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			updownStoreBin.Maximum = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			
			textboxStorePhItem.Text = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinPath & cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinFile
			textboxStoreName.Text = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleName
			textboxStoreQuantity.Text = CType((cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinQuantity), String)
			updownStorePrice.Value = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleLastSell
		End If
	End Sub
	
	Private Sub timerUpdateTick(sender As Object, e As system.EventArgs)
		'groupboxStorage
		labelStorageTotalSection.Text = "\ "& cache.playerStorage.arraySection.GetUpperBound(0)
		updownStorageSection.Maximum = cache.playerStorage.arraySection.GetUpperBound(0)
		If cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle IsNot Nothing Then
			labelStorageTotalArticle.Text = "\ "& cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle.GetUpperBound(0)
			updownStorageArticle.Maximum = cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle.GetUpperBound(0)
			
			textboxStoragePhItem.Text = cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticlePath & cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticleFile
			textboxStorageName.Text = cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ItemName
			textboxStorageQuantity.Text = CType(cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).Quantity, String)
			textboxStorageLastSell.Text = CType(cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastSell, String)
			textboxStorageLastBuy.Text = CType(cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastBuy, String)
		End If
		'groupboxStore
		labelStoreTotalLevel.Text = "\ "& cache.playerStore.arrayLevel.GetUpperBound(0)
		updownStoreLevel.Maximum = cache.playerStore.arrayLevel.GetUpperBound(0)
		labelStoreTotalShelf.Text = "\ "& cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf.GetUpperBound(0)
		updownStoreShelf.Maximum = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf.GetUpperBound(0)
		If cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin IsNot Nothing Then
			labelStoreTotalBin.Text = "\ "& cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			updownStoreBin.Maximum = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			
			textboxStorePhItem.Text = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinPath & cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinFile
			textboxStoreName.Text = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleName
			textboxStoreQuantity.Text = CType((cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinQuantity), String)
			updownStorePrice.Value = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleLastSell
		End If
	End Sub
	
	Sub UpdownStoreLevelValueChanged(sender As Object, e As EventArgs)
		labelStoreTotalShelf.Text = "\ "& cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf.GetUpperBound(0)
		updownStoreShelf.Maximum = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf.GetUpperBound(0)
		If cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin IsNot Nothing Then
			labelStoreTotalBin.Text = "\ "& cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			updownStoreBin.Maximum = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			
			textboxStorePhItem.Text = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinPath & cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinFile
			textboxStoreName.Text = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleName
			textboxStoreQuantity.Text = CType((cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinQuantity), String)
			updownStorePrice.Value = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleLastSell
		End If
	End Sub
	
	Sub UpdownStoreShelfValueChanged(sender As Object, e As EventArgs)
		If cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin IsNot Nothing Then
			labelStoreTotalBin.Text = "\ "& cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			updownStoreBin.Maximum = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin.GetUpperBound(0)
			
			textboxStorePhItem.Text = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinPath & cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinFile
			textboxStoreName.Text = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleName
			textboxStoreQuantity.Text = CType((cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinQuantity), String)
			updownStorePrice.Value = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleLastSell
		End If
	End Sub
	
	Sub UpdownStoreBinValueChanged(sender As Object, e As EventArgs)
		If cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin IsNot Nothing Then
			textboxStorePhItem.Text = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinPath & cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinFile
			textboxStoreName.Text = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleName
			textboxStoreQuantity.Text = CType((cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).BinQuantity), String)
			updownStorePrice.Value = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).ArticleLastSell
		End If
	End Sub
	
	Sub UpdownStorePriceLostFocus(sender As Object, e As EventArgs)
		updownStorePrice.Value = CType(updownStorePrice.Value, Integer)
		Dim integerSection As Integer = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).LinkSection
		Dim integerArticle As Integer = cache.playerStore.arrayLevel(CType(updownStoreLevel.Value, Integer)).arrayShelf(CType(updownStoreShelf.Value, Integer)).arrayBin(CType(updownStoreBin.Value, Integer)).LinkArticle
		cache.playerStorage.arraySection(integerSection).arrayArticle(integerArticle).LastSell = CType(updownStorePrice.Value, Integer)
		cache.playerStorage.arraySection(integerSection).arrayArticle(integerArticle).ArticleSave(cache.playerStorage.arraySection(integerSection).SectionPath)

		formItemManagementLoad(Nothing, Nothing)
	End Sub
	
	Sub UpdownStorageSectionValueChanged(sender As Object, e As EventArgs)
		If cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle IsNot Nothing Then
			labelStorageTotalArticle.Text = "\ "& cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle.GetUpperBound(0)
			updownStorageArticle.Maximum = cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle.GetUpperBound(0)
			
			textboxStoragePhItem.Text = cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticlePath & cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticleFile
			textboxStorageName.Text = cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ItemName
			textboxStorageQuantity.Text = CType(cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).Quantity, String)
			textboxStorageLastSell.Text = CType(cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastSell, String)
			textboxStorageLastBuy.Text = CType(cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastBuy, String)
		End If
	End Sub
	
	Sub UpdownStorageArticleValueChanged(sender As Object, e As EventArgs)
		If cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle IsNot Nothing Then
			textboxStoragePhItem.Text = cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticlePath & cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ArticleFile
			textboxStorageName.Text = cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).ItemName
			textboxStorageQuantity.Text = CType(cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).Quantity, String)
			textboxStorageLastSell.Text = CType(cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastSell, String)
			textboxStorageLastBuy.Text = CType(cache.playerStorage.arraySection(CType(updownStorageSection.Value, Integer)).arrayArticle(CType(UpdownStorageArticle.Value, Integer)).LastBuy, String)
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
			cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity += cache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).Quantity
			cache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).Quantity = 0
			
			cache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).ArticleSave(cache.playerStorage.arraySection(integerStorageSection).SectionPath)
			cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinSave(cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).ShelfPath)
		Else
			If MsgBox("Replaces current item, else add new Bin to current Shelf." & Chr(10) & "Use No for the first time when a player is new.", Microsoft.VisualBasic.MsgBoxStyle.YesNo, "Replace?") = 6 Then
				Dim integerSection As Integer = cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkSection
				Dim integerArticle As Integer = cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkArticle
				cache.playerStorage.arraySection(integerSection).arrayArticle(integerArticle).Quantity += cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity
				cache.playerStorage.arraySection(integerSection).arrayArticle(integerArticle).ArticleSave(cache.playerStorage.arraySection(integerSection).SectionPath)
				
				cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkStorage = 0
				cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkSection = integerStorageSection
				cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkArticle = integerStorageArticle
				cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity = cache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).Quantity
				cache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).Quantity = 0
				
				cache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).ArticleSave(cache.playerStorage.arraySection(integerStorageSection).SectionPath)
				cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinSave(cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).ShelfPath)

			Else
				cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).BinAdd(New String() {"0", CType(integerStorageSection, String), CType(integerStorageArticle, String), textboxStorageQuantity.Text})
				cache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).Quantity = 0
				
				cache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).ArticleSave(cache.playerStorage.arraySection(integerStorageSection).SectionPath)
				
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
		
		Dim integerSection As Integer = cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkSection
		Dim integerArticle As Integer = cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).LinkArticle
		cache.playerStorage.arraySection(integerSection).arrayArticle(integerArticle).Quantity += cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity
		cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity = 0
		
		cache.playerStorage.arraySection(integerStorageSection).arrayArticle(integerStorageArticle).ArticleSave(cache.playerStorage.arraySection(integerStorageSection).SectionPath)
		cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinSave(cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).ShelfPath)
		
		timerUpdateTick(Nothing, Nothing)
	End Sub
	
	Sub ButtonCloseClick(sender As Object, e As EventArgs)
		Me.Hide()
	End Sub	
End Class