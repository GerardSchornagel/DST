Public Partial Class formGame
	Private randomGenerator As New Random()
	Private timerHour As New System.Windows.Forms.Timer
	Private timerCustomer As New System.Windows.Forms.Timer
	Private integerCustomerNumber As Integer
	Private integerStoreLevels As Integer
	Private integerStoreShelfs As Integer
	Private integerStoreBins As Integer
	Private stringBinName As String
	Private integerBinQuantity As Integer
	Private integerBinPrice As Integer
	
	Private CustomerNew As New customer()
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub formGameLoad(sender As Object, e As EventArgs)
		AddHandler timerHour.Tick, AddressOf TimerHour_Tick
		AddHandler TimerCustomer.Tick, AddressOf TimerCustomer_Tick
	End Sub
	
	Private Sub ButtonActionStartClick(ByVal sender As Object, ByVal e As System.EventArgs)
		textboxActionHour.Text = "9"
		buttonActionStart.Text = "Day Started..."
		buttonActionStart.Enabled = False
		'Write away previous log an d proccess data to/through formStatus
		textboxActionLog.Text = ""
		'Add 4 buttons for speed control (Pause/Slow[1Thread]/Medium[2Threads]/Fast[4Threads])
		'I think I've to adapt the randomgenerator for this with 4 customs seeds provided by 5th random for cycling the lesser.
		timerHour.Interval = 1000
		timerHour.Start()
	End Sub
	
	Private Sub TimerHour_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
		If CType(textboxActionHour.Text, Double) > 0 Then 'Before zero
			'For deciding how many customers per hour
			IntegerCustomerNumber = RandomGenerator.Next(5)
			TimerCustomer.Interval = 250
			'Stop this element and let timerCustomer take over.
			TimerCustomer.Start()
			textboxActionHour.Text = CType(CType(textboxActionHour.Text, Double) - 1,String)
			TimerHour.Stop()
			
		Else 'Beneath zero
			'Pass information for procces to/through formStatus
			cache.playerCharacter.TotalDayCycles += 1
			buttonActionStart.Text = "Start Day"
			buttonActionStart.Enabled = True
			textboxActionHour.Text = CType(9, String)
			cache.playerCharacter.SaveState()
			timerHour.Stop()
		End If
	End Sub
	
	Private Sub TimerCustomer_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
		If IntegerCustomerNumber > 0 Then 'More then Zero
			'Make new Customer and get his/her data for log
			CustomerNew.newCustomer
			
			integerStoreLevels = randomGenerator.Next(store.arrayLevel.GetUpperBound(0))
			integerStoreShelfs = randomGenerator.Next(store.arrayLevel(integerStoreLevels).arrayShelf.GetUpperBound(0))
			integerStoreBins = randomGenerator.Next(store.arrayLevel(integerStoreLevels).arrayShelf(integerStoreShelfs).arrayBin.GetUpperBound(0))
			stringBinName = cache.playerStore.arrayLevel(integerStoreLevels).arrayShelf(integerStoreShelfs).arrayBin(integerStoreBins).ArticleName
			integerBinQuantity = cache.playerStore.arrayLevel(integerStoreLevels).arrayShelf(integerStoreShelfs).arrayBin(integerStoreBins).BinQuantity
			integerBinPrice = cache.playerStore.arrayLevel(integerStoreLevels).arrayShelf(integerStoreShelfs).arrayBin(integerStoreBins).ArticleLastSell
						
			If integerBinQuantity > 0 Then 'Check for available quantity.
				If integerBinPrice <= CustomerNew.Money Then 'BUY:Check for customer-money and item sell-price
					textboxActionLog.AppendText("[" & textboxActionHour.Text & "] " & stringBinName & " sold to " & CustomerNew.Name & " ($ " & CustomerNew.Money & ") from slot " & integerStoreBins & Chr(10))
					cache.playerCharacter.Balance += integerBinPrice
					cache.playerStore.arrayLevel(integerStoreLevels).arrayShelf(integerStoreShelfs).arrayBin(integerStoreBins).BinQuantity -= 1
					cache.playerStore.arrayLevel(integerStoreLevels).arrayShelf(integerStoreShelfs).arrayBin(integerStoreBins).BinSave(cache.playerStore.arrayLevel(integerStoreLevels).arrayShelf(integerStoreShelfs).ShelfPath)
					cache.playerCharacter.TotalItemsSold += 1
'					
				ElseIf integerBinPrice >= CustomerNew.Money Then 'NOCASH:Check for customer-money and item sell-price
					textboxActionLog.AppendText("[" & textboxActionHour.Text & "] " & stringBinName & " too Expensive for " & CustomerNew.Name & " ($ " & CustomerNew.Money & ") from slot " & integerStoreBins & Chr(10))
				End If
				
			ElseIf integerBinQuantity = 0 Then 'NOSTASH:Check for customer-money and item sell-price
				textboxActionLog.AppendText("[" & textboxActionHour.Text & "] " & stringBinName & " stock Depleted on slot " & integerStoreBins & Chr(10))
			End If
			
			IntegerCustomerNumber -= 1
		Else 'Less then zero customers
			timerCustomer.Stop()
			TimerHour.Start()
		End If
	End Sub
End Class