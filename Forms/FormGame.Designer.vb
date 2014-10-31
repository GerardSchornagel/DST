
Partial Class formGame
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
		Me.buttonStoreInventory = New System.Windows.Forms.Button()
		Me.buttonProductBuy = New System.Windows.Forms.Button()
		Me.labelCustomerName = New System.Windows.Forms.Label()
		Me.textboxCustomerName = New System.Windows.Forms.TextBox()
		Me.labelCustomerMoney = New System.Windows.Forms.Label()
		Me.textboxCustomerMoney = New System.Windows.Forms.TextBox()
		Me.buttonActionStart = New System.Windows.Forms.Button()
		Me.labelActionHour = New System.Windows.Forms.Label()
		Me.textboxActionHour = New System.Windows.Forms.TextBox()
		Me.labelActionLog = New System.Windows.Forms.Label()
		Me.textboxActionLog = New System.Windows.Forms.TextBox()
		Me.SuspendLayout
		'
		'buttonStoreInventory
		'
		Me.buttonStoreInventory.AutoSize = true
		Me.buttonStoreInventory.Location = New System.Drawing.Point(184, 9)
		Me.buttonStoreInventory.Name = "buttonStoreInventory"
		Me.buttonStoreInventory.Size = New System.Drawing.Size(101, 23)
		Me.buttonStoreInventory.TabIndex = 0
		Me.buttonStoreInventory.Text = "Inventory of Store"
		'
		'buttonProductBuy
		'
		Me.buttonProductBuy.AutoSize = true
		Me.buttonProductBuy.Location = New System.Drawing.Point(184, 38)
		Me.buttonProductBuy.Name = "buttonProductBuy"
		Me.buttonProductBuy.Size = New System.Drawing.Size(80, 23)
		Me.buttonProductBuy.TabIndex = 1
		Me.buttonProductBuy.Text = "Buy Products"
		'
		'labelCustomerName
		'
		Me.labelCustomerName.AutoSize = true
		Me.labelCustomerName.Location = New System.Drawing.Point(12, 92)
		Me.labelCustomerName.Name = "labelCustomerName"
		Me.labelCustomerName.Size = New System.Drawing.Size(82, 13)
		Me.labelCustomerName.TabIndex = 2
		Me.labelCustomerName.Text = "Customer Name"
		'
		'textboxCustomerName
		'
		Me.textboxCustomerName.Location = New System.Drawing.Point(12, 120)
		Me.textboxCustomerName.Name = "textboxCustomerName"
		Me.textboxCustomerName.ReadOnly = true
		Me.textboxCustomerName.Size = New System.Drawing.Size(128, 20)
		Me.textboxCustomerName.TabIndex = 3
		'
		'labelCustomerMoney
		'
		Me.labelCustomerMoney.AutoSize = true
		Me.labelCustomerMoney.Location = New System.Drawing.Point(12, 150)
		Me.labelCustomerMoney.Name = "labelCustomerMoney"
		Me.labelCustomerMoney.Size = New System.Drawing.Size(86, 13)
		Me.labelCustomerMoney.TabIndex = 4
		Me.labelCustomerMoney.Text = "Customer Money"
		'
		'textboxCustomerMoney
		'
		Me.textboxCustomerMoney.Location = New System.Drawing.Point(12, 190)
		Me.textboxCustomerMoney.Name = "textboxCustomerMoney"
		Me.textboxCustomerMoney.ReadOnly = true
		Me.textboxCustomerMoney.Size = New System.Drawing.Size(128, 20)
		Me.textboxCustomerMoney.TabIndex = 5
		'
		'buttonActionStart
		'
		Me.buttonActionStart.AutoSize = true
		Me.buttonActionStart.Location = New System.Drawing.Point(93, 25)
		Me.buttonActionStart.Name = "buttonActionStart"
		Me.buttonActionStart.Size = New System.Drawing.Size(61, 23)
		Me.buttonActionStart.TabIndex = 6
		Me.buttonActionStart.Text = "Start Day"
		'
		'labelActionHour
		'
		Me.labelActionHour.AutoSize = true
		Me.labelActionHour.Location = New System.Drawing.Point(12, 9)
		Me.labelActionHour.Name = "labelActionHour"
		Me.labelActionHour.Size = New System.Drawing.Size(142, 13)
		Me.labelActionHour.TabIndex = 7
		Me.labelActionHour.Text = "Opening hours [0900 - 1800]"
		'
		'textboxActionHour
		'
		Me.textboxActionHour.Location = New System.Drawing.Point(12, 25)
		Me.textboxActionHour.Name = "textboxActionHour"
		Me.textboxActionHour.ReadOnly = true
		Me.textboxActionHour.Size = New System.Drawing.Size(75, 20)
		Me.textboxActionHour.TabIndex = 8
		Me.textboxActionHour.Text = "9"
		'
		'labelActionLog
		'
		Me.labelActionLog.AutoSize = true
		Me.labelActionLog.Location = New System.Drawing.Point(147, 92)
		Me.labelActionLog.Name = "labelActionLog"
		Me.labelActionLog.Size = New System.Drawing.Size(80, 13)
		Me.labelActionLog.TabIndex = 9
		Me.labelActionLog.Text = "Transaction-log"
		'
		'textboxActionLog
		'
		Me.textboxActionLog.Location = New System.Drawing.Point(147, 108)
		Me.textboxActionLog.Multiline = true
		Me.textboxActionLog.Name = "textboxActionLog"
		Me.textboxActionLog.ReadOnly = true
		Me.textboxActionLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.textboxActionLog.Size = New System.Drawing.Size(339, 256)
		Me.textboxActionLog.TabIndex = 10
		'
		'formGame
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(498, 377)
		Me.Controls.Add(Me.buttonStoreInventory)
		Me.Controls.Add(Me.buttonProductBuy)
		Me.Controls.Add(Me.labelCustomerName)
		Me.Controls.Add(Me.textboxCustomerName)
		Me.Controls.Add(Me.labelCustomerMoney)
		Me.Controls.Add(Me.textboxCustomerMoney)
		Me.Controls.Add(Me.buttonActionStart)
		Me.Controls.Add(Me.labelActionHour)
		Me.Controls.Add(Me.textboxActionHour)
		Me.Controls.Add(Me.labelActionLog)
		Me.Controls.Add(Me.textboxActionLog)
		Me.Location = New System.Drawing.Point(320, 274)
		Me.Name = "formGame"
		Me.Text = "Department Store Tycoon"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private buttonStoreInventory As System.Windows.Forms.button
	Private buttonProductBuy As System.Windows.Forms.button
	Private labelCustomerName As System.Windows.Forms.label
	Private textboxCustomerName As System.Windows.Forms.TextBox
	Private labelCustomerMoney As System.Windows.Forms.label
	Private textboxCustomerMoney As System.Windows.Forms.TextBox
	Private buttonActionStart As System.Windows.Forms.button
	Private labelActionHour As System.Windows.Forms.label
	Private textboxActionHour As System.Windows.Forms.TextBox
	Private labelActionLog As System.Windows.Forms.label
	Private textboxActionLog As System.Windows.Forms.TextBox
End Class
