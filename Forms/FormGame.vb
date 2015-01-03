Public Partial Class formGame
	Private randomGenerator As New Random()
	Private timerHour As New System.Windows.Forms.Timer
	Private timerCustomer As New System.Windows.Forms.Timer
	Private integerCustomerNumber As Integer
	
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
			gamecache.currentCharacterStatistics.TotalDayCycles += 1
			buttonActionStart.Text = "Start Day"
			buttonActionStart.Enabled = True
			textboxActionHour.Text = CType(9, String)
			gamecache.currentCharacterProfile.SaveState()
			timerHour.Stop()
		End If
	End Sub
	
	Private Sub TimerCustomer_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
		If IntegerCustomerNumber > 0 Then 'More then Zero
			textboxActionLog.AppendText("[" & textboxActionHour.Text & "] " & mathematics.CustomerBuying)
			IntegerCustomerNumber -= 1
		Else 'Less then zero customers
			timerCustomer.Stop()
			TimerHour.Start()
		End If
	End Sub
End Class