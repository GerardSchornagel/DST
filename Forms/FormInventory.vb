Public Partial Class formInventory
	Private arrayBin1A() As String
	Private arrayBin1B() As String
	Private arrayBin1C() As String
	Private arrayBin2A() As String
	Private arrayBin2B() As String
	Private arrayBin2C() As String
	Private arrayBin3A() As String
	Private arrayBin3B() As String
	Private arrayBin3C() As String
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub FormInventoryClosing(sender As Object, e As EventArgs)
		'Save all Selling prices into Last Selling in inventory
		arrayBin1A(2) = updownPrice1A.Text
		formGame.StoreCurrent.getsetBin(0) = arrayBin1A
		'If textboxName1B.Text = "Empty" Then GoTo SaveandExit
		arrayBin1B(2) = updownPrice1B.Text
		formGame.StoreCurrent.getsetBin(1) = arrayBin1B
		'If textboxName1C.Text = "Empty" Then GoTo SaveandExit
		arrayBin1C(2) = updownPrice1C.Text
		formGame.StoreCurrent.getsetBin(2) = arrayBin1C
		
		If textboxName2A.Text = "Empty" Then GoTo SaveandExit
		arrayBin2A(2) = updownPrice2A.Text
		formGame.StoreCurrent.getsetBin(3) = arrayBin2A
		If textboxName2B.Text = "Empty" Then GoTo SaveandExit
		arrayBin2B(2) = updownPrice2B.Text
		formGame.StoreCurrent.getsetBin(4) = arrayBin2B
		If textboxName2C.Text = "Empty" Then GoTo SaveandExit
		arrayBin2C(2) = updownPrice2C.Text
		formGame.StoreCurrent.getsetBin(5) = arrayBin2C
		
		If textboxName3A.Text = "Empty" Then GoTo SaveandExit
		arrayBin3A(2) = updownPrice3A.Text
		formGame.StoreCurrent.getsetBin(6) = arrayBin3A
		If textboxName3B.Text = "Empty" Then GoTo SaveandExit
		arrayBin3B(2) = updownPrice3B.Text
		formGame.StoreCurrent.getsetBin(7) = arrayBin3B
		If textboxName3C.Text = "Empty" Then GoTo SaveandExit
		arrayBin3C(2) = updownPrice3C.Text
		formGame.StoreCurrent.getsetBin(8) = arrayBin3C
		
SaveandExit:
		formGame.StoreCurrent.SaveState()
	End Sub
	
	Sub FormInventoryLoad(sender As Object, e As EventArgs)
		arrayBin1A = formGame.StoreCurrent.getsetBin(0)
		arrayBin1B = formGame.StoreCurrent.getsetBin(1)
		arrayBin1C = formGame.StoreCurrent.getsetBin(2)
		arrayBin2A = formGame.StoreCurrent.getsetBin(3)
		arrayBin2B = formGame.StoreCurrent.getsetBin(4)
		arrayBin2C = formGame.StoreCurrent.getsetBin(5)
		arrayBin3A = formGame.StoreCurrent.getsetBin(6)
		arrayBin3B = formGame.StoreCurrent.getsetBin(7)
		arrayBin3C = formGame.StoreCurrent.getsetBin(8)
	
	'Get all info from store.vb
		textboxName1A.Text = arrayBin1A(0)
		textboxQuantity1A.Text = arrayBin1A(1)
		updownPrice1A.Text = arrayBin1A(2)
		If arrayBin1B Is Nothing Then Exit Sub
		textboxName1B.Text = arrayBin1B(0)
		textboxQuantity1B.Text = arrayBin1B(1)
		updownPrice1B.Text = arrayBin1B(2)
		If arrayBin1C Is Nothing Then Exit Sub
		textboxName1C.Text = arrayBin1C(0)
		textboxQuantity1C.Text = arrayBin1C(1)
		updownPrice1C.Text = arrayBin1C(2)
		
		If arrayBin2A Is Nothing Then Exit Sub
		textboxName2A.Text = arrayBin2A(0)
		textboxQuantity2A.Text = arrayBin2A(1)
		updownPrice2A.Text = arrayBin2A(2)
		If arrayBin2B Is Nothing Then Exit Sub
		textboxName2B.Text = arrayBin2B(0)
		textboxQuantity2B.Text = arrayBin2B(1)
		updownPrice2B.Text = arrayBin2B(2)
		If arrayBin2C Is Nothing Then Exit Sub
		textboxName2C.Text = arrayBin2C(0)
		textboxQuantity2C.Text = arrayBin2C(1)
		updownPrice2C.Text = arrayBin2C(2)
		
		If arrayBin3A Is Nothing Then Exit Sub
		textboxName3A.Text = arrayBin3A(0)
		textboxQuantity3A.Text = arrayBin3A(1)
		updownPrice3A.Text = arrayBin3A(2)
		If arrayBin3B Is Nothing Then Exit Sub
		textboxName3B.Text = arrayBin3B(0)
		textboxQuantity3B.Text = arrayBin3B(1)
		updownPrice3B.Text = arrayBin3B(2)
		If arrayBin3C Is Nothing Then Exit Sub
		textboxName3C.Text = arrayBin3C(0)
		textboxQuantity3C.Text = arrayBin3C(1)
		updownPrice3C.Text = arrayBin3C(2)
	End Sub
End Class
