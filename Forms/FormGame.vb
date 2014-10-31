
Public Partial Class formGame
  Inherits System.Windows.Forms.Form

Private CustomerNew As New customer()
Private classShelf As New Shelf("Store", "Floor", "Aisle", "Shelf", CurrentShelf, LayoutData)
Dim LayoutData As String(,)
Private randomGenerator As New Random()
Private timerHour As New System.Windows.Forms.Timer
Private timerCustomer As New System.Windows.Forms.Timer
Private integerCustomerNumber As Integer
Private stringCurrentShelf(5) As String
Private integerCurrentSpace As Integer

Public Sub New()
	AddHandler timerHour.Tick, AddressOf TimerHour_Tick
    AddHandler TimerCustomer.Tick, AddressOf TimerCustomer_Tick
End Sub
'*** Rewrite code to work and COMMIT ***
Private Sub buttonActionStart_Click(ByVal sender As Object, ByVal e As System.EventArgs)
	textboxActionHour.Text = "9"
    buttonActionStart.Text = "Day Started..."
    buttonActionStart.Enabled = False
    'Write away previous log an d proccess data to/through formStatus
    textboxActionLog.Text = ""
    'Add 4 buttons for speed control (Pause/Slow[1Thread]/Medium[2Threads]/Fast[4Threads])
    'I think I've to adapt the randomgenerator for this with 4 customs seeds provided by 5th random for cycling the lesser.
    timerHour.Interval = 500
    timerHour.Start()
End Sub

Private Sub buttonStoreInventory_Click(ByVal sender As Object, ByVal e As System.EventArgs)
	
End Sub

Private Sub buttonProductBuy_Click(ByVal sender As Object, ByVal e As System.EventArgs)
	
End Sub

Private Sub TimerHour_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
	If textboxActionHour.Text >= 0 Then 'Before zero
		'For deciding how many customers per hour
    	IntegerCustomerNumber = RandomGenerator.Next(5)
    	TimerCustomer.Interval = 250
    	'Stop this element and let timerCustomer take over.
    	TimerCustomer.Start()
    	textboxActionHour.Text -= 1
    	TimerHour.Stop()
    	
    Else 'Beneath zero
    	'Pass information for procces to/through formStatus
    	FormPlayer.IntegerCycles += 1
    	buttonActionStart.Text = "Start Day"
    	buttonActionStart.Enabled = True
    	textboxActionHour.Text = 9
    	timerHour.Stop()
    End If
End Sub

Private Sub TimerCustomer_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
  '  'TODO:
  '  '--Redo writing and reading processes handling mostly by class
  '  '--AFTER SELL SUBTRACT FROM Inventory
  If IntegerCustomerNumber >= 0 Then 'More then Zero
	'Make new Customer and get his/her data for log
	CustomerNew=New customer()
	textboxCustomerName.Text = CustomerNew.Name
	textboxCustomerMoney.Text = CustomerNew.Money
	
	CurrentShelf = New String() {"0", "0", "1", "5", "5"}
	classShelf =  New Shelf("Store", "Floor", "Aisle", "Shelf", CurrentShelf, LayoutData)
	CurrentSpace = RandomGenerator.Next(4)
	
  If Val(classShelf.GetItem(CurrentSpace, "Quantity")) > 0 Then 'Check for inventory true
  	If Val(classShelf.GetItem(CurrentSpace, "Price")) < CustomerNew.Money Then 'BUY:Check for customer-money and item sell-price
  		textboxActionLog.AppendText(classShelf.GetItem(CurrentSpace, "Tag") & " sold to " & CustomerNew.Name & " ($ " & CustomerNew.Money & ")" & Chr(10))
  		'SEARCH FOR SELLING PRODUCT IN Inventory AND SUBSTRACT 1
  		Dim pos As Integer = 0 'UPDATE WHEN ADDING CHAR INFO
  		Do Until pos > formStatus.ArrayStoreInventory.GetUpperBound(0)
  			If formStatus.ArrayStoreInventory(pos).Contains(classShelf.GetItem(CurrentSpace, "Tag")) = True Then
  			Loop
  			pos += 1
  			formStatus.ArrayStoreInventory(pos) -= 1
  			pos += 1
  		Else
  			pos += 2
  		End If
  	Loop
  	'Update Balance
  	formStatus.IntegerBalance += Val(classShelf.GetItem(CurrentSpace, "Price"))
  	
  	ElseIf Val(classShelf.GetItem(CurrentSpace, "Price")) >= CustomerNew.Money Then 'NOCASH:Check for customer-money and item sell-price
  		textboxActionLog.AppendText(classShelf.GetItem(CurrentSpace, "Tag") & " too Expensive for " & CustomerNew.Name & " ($ " & CustomerNew.Money & ")" & Chr(10))
  	End If
  	
  ElseIf classShelf.GetItem(CurrentSpace, "Quantity") = "0" Then 'NOSTASH:Check for customer-money and item sell-price
  	textboxActionLog.AppendText(classShelf.GetItem(CurrentSpace, "Tag") & " stock Depleted" & Chr(10))
  	textboxActionHour.Text = -1
  	textboxCustomerMoney.Text = ""
  	textboxCustomerName.Text = ""
  	TimerHour.Start()
  	TimerCustomer.Stop()
  End If
  
  IntegerCustomerNumber -= 1
  Else 'Less then zero customers
  	TimerCustomer.Stop()
  	TimerHour.Start()
  End If
End Sub
End Class