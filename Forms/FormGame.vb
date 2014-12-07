Public Partial Class formGame
	Dim LayoutData As String(,)
	Private randomGenerator As New Random()
	Private timerHour As New System.Windows.Forms.Timer
	Private timerCustomer As New System.Windows.Forms.Timer
	Private integerCustomerNumber As Integer
	Private stringCurrentShelf(5) As String
	Private integerCurrentSpace As Integer
	Private CurrentSpace As Integer
	Private CustomerNew As New customer()
	Shared Friend StoreCurrent As New OLDstore()
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub formGameLoad(sender As Object, e As EventArgs)
		AddHandler timerHour.Tick, AddressOf TimerHour_Tick
		AddHandler TimerCustomer.Tick, AddressOf TimerCustomer_Tick
		StoreCurrent.LoadStore()
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
			
			CurrentSpace = RandomGenerator.Next(8)
			
			If CType(StoreCurrent.getsetBin(CurrentSpace)(1), Integer) > 0 Then 'Check for inventory true
				If CType(StoreCurrent.getsetBin(CurrentSpace)(2), Integer) < CustomerNew.Money Then 'BUY:Check for customer-money and item sell-price
					textboxActionLog.AppendText("[" & textboxActionHour.Text & "]" & CType(StoreCurrent.getsetBin(CurrentSpace)(0), String) & " sold to " & CustomerNew.Name & " ($ " & CustomerNew.Money & ") from slot " & CurrentSpace & Chr(10))
					cache.playerCharacter.Balance += CType(StoreCurrent.getsetBin(CurrentSpace)(2), Integer)
					Dim setBin(2) As String
					setBin = CType(StoreCurrent.getsetBin(CurrentSpace), String())
					setBin(1) = CType(CType(setBin(1), Integer) - 1, String)
					StoreCurrent.getsetBin(CurrentSpace) = setBin
					cache.playerCharacter.TotalItemsSold += 1
					
				ElseIf CType(StoreCurrent.getsetBin(CurrentSpace)(2), Integer) >= CustomerNew.Money Then 'NOCASH:Check for customer-money and item sell-price
					textboxActionLog.AppendText("[" & textboxActionHour.Text & "]" & CType(StoreCurrent.getsetBin(CurrentSpace)(0), String) & " too Expensive for " & CustomerNew.Name & " ($ " & CustomerNew.Money & ") from slot" & CurrentSpace & Chr(10))
				End If
				
			ElseIf CType(StoreCurrent.getsetBin(CurrentSpace)(1), String) = "0" Then 'NOSTASH:Check for customer-money and item sell-price
				textboxActionLog.AppendText("[" & textboxActionHour.Text & "]" & CType(StoreCurrent.getsetBin(CurrentSpace)(0), String) & " stock Depleted" & Chr(10))
			End If
			
			IntegerCustomerNumber -= 1
		Else 'Less then zero customers
			timerCustomer.Stop()
			TimerHour.Start()
		End If
	End Sub
End Class