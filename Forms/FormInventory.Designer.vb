Partial Class formInventory
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
		Me.groupbox1A = New System.Windows.Forms.GroupBox()
		Me.updownPrice1A = New System.Windows.Forms.DomainUpDown()
		Me.labelPrice1A = New System.Windows.Forms.Label()
		Me.labelQuantity1A = New System.Windows.Forms.Label()
		Me.textboxQuantity1A = New System.Windows.Forms.TextBox()
		Me.textboxName1A = New System.Windows.Forms.TextBox()
		Me.groupbox1B = New System.Windows.Forms.GroupBox()
		Me.updownPrice1B = New System.Windows.Forms.DomainUpDown()
		Me.labelPrice1B = New System.Windows.Forms.Label()
		Me.labelQuantity1B = New System.Windows.Forms.Label()
		Me.textboxQuantity1B = New System.Windows.Forms.TextBox()
		Me.textboxName1B = New System.Windows.Forms.TextBox()
		Me.groupbox1C = New System.Windows.Forms.GroupBox()
		Me.updownPrice1C = New System.Windows.Forms.DomainUpDown()
		Me.labelPrice1C = New System.Windows.Forms.Label()
		Me.labelQuantity1C = New System.Windows.Forms.Label()
		Me.textboxQuantity1C = New System.Windows.Forms.TextBox()
		Me.textboxName1C = New System.Windows.Forms.TextBox()
		Me.groupbox2A = New System.Windows.Forms.GroupBox()
		Me.updownPrice2A = New System.Windows.Forms.DomainUpDown()
		Me.labelPrice2A = New System.Windows.Forms.Label()
		Me.labelQuantity2A = New System.Windows.Forms.Label()
		Me.textboxQuantity2A = New System.Windows.Forms.TextBox()
		Me.textboxName2A = New System.Windows.Forms.TextBox()
		Me.groupbox2B = New System.Windows.Forms.GroupBox()
		Me.updownPrice2B = New System.Windows.Forms.DomainUpDown()
		Me.labelPrice2B = New System.Windows.Forms.Label()
		Me.labelQuantity2B = New System.Windows.Forms.Label()
		Me.textboxQuantity2B = New System.Windows.Forms.TextBox()
		Me.textboxName2B = New System.Windows.Forms.TextBox()
		Me.groupbox2C = New System.Windows.Forms.GroupBox()
		Me.updownPrice2C = New System.Windows.Forms.DomainUpDown()
		Me.labelPrice2C = New System.Windows.Forms.Label()
		Me.labelQuantity2C = New System.Windows.Forms.Label()
		Me.textboxQuantity2C = New System.Windows.Forms.TextBox()
		Me.textboxName2C = New System.Windows.Forms.TextBox()
		Me.groupbox3A = New System.Windows.Forms.GroupBox()
		Me.updownPrice3A = New System.Windows.Forms.DomainUpDown()
		Me.labelPrice3A = New System.Windows.Forms.Label()
		Me.labelQuantity3A = New System.Windows.Forms.Label()
		Me.textboxQuantity3A = New System.Windows.Forms.TextBox()
		Me.textboxName3A = New System.Windows.Forms.TextBox()
		Me.groupbox3B = New System.Windows.Forms.GroupBox()
		Me.updownPrice3B = New System.Windows.Forms.DomainUpDown()
		Me.labelPrice3B = New System.Windows.Forms.Label()
		Me.labelQuantity3B = New System.Windows.Forms.Label()
		Me.textboxQuantity3B = New System.Windows.Forms.TextBox()
		Me.textboxName3B = New System.Windows.Forms.TextBox()
		Me.groupbox3C = New System.Windows.Forms.GroupBox()
		Me.updownPrice3C = New System.Windows.Forms.DomainUpDown()
		Me.labelPrice3C = New System.Windows.Forms.Label()
		Me.labelQuantity3C = New System.Windows.Forms.Label()
		Me.textboxQuantity3C = New System.Windows.Forms.TextBox()
		Me.textboxName3C = New System.Windows.Forms.TextBox()
		Me.tabcontrolStore = New System.Windows.Forms.TabControl()
		Me.tabpageShelf = New System.Windows.Forms.TabPage()
		Me.groupbox1A.SuspendLayout
		Me.groupbox1B.SuspendLayout
		Me.groupbox1C.SuspendLayout
		Me.groupbox2A.SuspendLayout
		Me.groupbox2B.SuspendLayout
		Me.groupbox2C.SuspendLayout
		Me.groupbox3A.SuspendLayout
		Me.groupbox3B.SuspendLayout
		Me.groupbox3C.SuspendLayout
		Me.tabcontrolStore.SuspendLayout
		Me.tabpageShelf.SuspendLayout
		Me.SuspendLayout
		'
		'groupbox1A
		'
		Me.groupbox1A.Controls.Add(Me.updownPrice1A)
		Me.groupbox1A.Controls.Add(Me.labelPrice1A)
		Me.groupbox1A.Controls.Add(Me.labelQuantity1A)
		Me.groupbox1A.Controls.Add(Me.textboxQuantity1A)
		Me.groupbox1A.Controls.Add(Me.textboxName1A)
		Me.groupbox1A.Location = New System.Drawing.Point(6, 6)
		Me.groupbox1A.Name = "groupbox1A"
		Me.groupbox1A.Size = New System.Drawing.Size(144, 73)
		Me.groupbox1A.TabIndex = 0
		Me.groupbox1A.TabStop = false
		Me.groupbox1A.Text = "Bin 1A"
		'
		'updownPrice1A
		'
		Me.updownPrice1A.Location = New System.Drawing.Point(89, 46)
		Me.updownPrice1A.Name = "updownPrice1A"
		Me.updownPrice1A.Size = New System.Drawing.Size(45, 20)
		Me.updownPrice1A.TabIndex = 2
		'
		'labelPrice1A
		'
		Me.labelPrice1A.Location = New System.Drawing.Point(64, 48)
		Me.labelPrice1A.Name = "labelPrice1A"
		Me.labelPrice1A.Size = New System.Drawing.Size(24, 16)
		Me.labelPrice1A.TabIndex = 1
		Me.labelPrice1A.Text = "Prc."
		'
		'labelQuantity1A
		'
		Me.labelQuantity1A.Location = New System.Drawing.Point(6, 48)
		Me.labelQuantity1A.Name = "labelQuantity1A"
		Me.labelQuantity1A.Size = New System.Drawing.Size(24, 16)
		Me.labelQuantity1A.TabIndex = 1
		Me.labelQuantity1A.Text = "Qnt."
		'
		'textboxQuantity1A
		'
		Me.textboxQuantity1A.Location = New System.Drawing.Point(31, 46)
		Me.textboxQuantity1A.Name = "textboxQuantity1A"
		Me.textboxQuantity1A.ReadOnly = true
		Me.textboxQuantity1A.Size = New System.Drawing.Size(32, 20)
		Me.textboxQuantity1A.TabIndex = 0
		'
		'textboxName1A
		'
		Me.textboxName1A.Location = New System.Drawing.Point(6, 19)
		Me.textboxName1A.Name = "textboxName1A"
		Me.textboxName1A.Size = New System.Drawing.Size(128, 20)
		Me.textboxName1A.TabIndex = 0
		'
		'groupbox1B
		'
		Me.groupbox1B.Controls.Add(Me.updownPrice1B)
		Me.groupbox1B.Controls.Add(Me.labelPrice1B)
		Me.groupbox1B.Controls.Add(Me.labelQuantity1B)
		Me.groupbox1B.Controls.Add(Me.textboxQuantity1B)
		Me.groupbox1B.Controls.Add(Me.textboxName1B)
		Me.groupbox1B.Location = New System.Drawing.Point(156, 6)
		Me.groupbox1B.Name = "groupbox1B"
		Me.groupbox1B.Size = New System.Drawing.Size(144, 73)
		Me.groupbox1B.TabIndex = 0
		Me.groupbox1B.TabStop = false
		Me.groupbox1B.Text = "Bin 1B"
		'
		'updownPrice1B
		'
		Me.updownPrice1B.Location = New System.Drawing.Point(89, 46)
		Me.updownPrice1B.Name = "updownPrice1B"
		Me.updownPrice1B.Size = New System.Drawing.Size(45, 20)
		Me.updownPrice1B.TabIndex = 2
		'
		'labelPrice1B
		'
		Me.labelPrice1B.Location = New System.Drawing.Point(64, 48)
		Me.labelPrice1B.Name = "labelPrice1B"
		Me.labelPrice1B.Size = New System.Drawing.Size(24, 16)
		Me.labelPrice1B.TabIndex = 1
		Me.labelPrice1B.Text = "Prc."
		'
		'labelQuantity1B
		'
		Me.labelQuantity1B.Location = New System.Drawing.Point(6, 48)
		Me.labelQuantity1B.Name = "labelQuantity1B"
		Me.labelQuantity1B.Size = New System.Drawing.Size(24, 16)
		Me.labelQuantity1B.TabIndex = 1
		Me.labelQuantity1B.Text = "Qnt."
		'
		'textboxQuantity1B
		'
		Me.textboxQuantity1B.Location = New System.Drawing.Point(31, 46)
		Me.textboxQuantity1B.Name = "textboxQuantity1B"
		Me.textboxQuantity1B.ReadOnly = true
		Me.textboxQuantity1B.Size = New System.Drawing.Size(32, 20)
		Me.textboxQuantity1B.TabIndex = 0
		'
		'textboxName1B
		'
		Me.textboxName1B.Location = New System.Drawing.Point(6, 19)
		Me.textboxName1B.Name = "textboxName1B"
		Me.textboxName1B.Size = New System.Drawing.Size(128, 20)
		Me.textboxName1B.TabIndex = 0
		'
		'groupbox1C
		'
		Me.groupbox1C.Controls.Add(Me.updownPrice1C)
		Me.groupbox1C.Controls.Add(Me.labelPrice1C)
		Me.groupbox1C.Controls.Add(Me.labelQuantity1C)
		Me.groupbox1C.Controls.Add(Me.textboxQuantity1C)
		Me.groupbox1C.Controls.Add(Me.textboxName1C)
		Me.groupbox1C.Location = New System.Drawing.Point(306, 6)
		Me.groupbox1C.Name = "groupbox1C"
		Me.groupbox1C.Size = New System.Drawing.Size(144, 73)
		Me.groupbox1C.TabIndex = 0
		Me.groupbox1C.TabStop = false
		Me.groupbox1C.Text = "Bin 1C"
		'
		'updownPrice1C
		'
		Me.updownPrice1C.Location = New System.Drawing.Point(89, 46)
		Me.updownPrice1C.Name = "updownPrice1C"
		Me.updownPrice1C.Size = New System.Drawing.Size(45, 20)
		Me.updownPrice1C.TabIndex = 2
		'
		'labelPrice1C
		'
		Me.labelPrice1C.Location = New System.Drawing.Point(64, 48)
		Me.labelPrice1C.Name = "labelPrice1C"
		Me.labelPrice1C.Size = New System.Drawing.Size(24, 16)
		Me.labelPrice1C.TabIndex = 1
		Me.labelPrice1C.Text = "Prc."
		'
		'labelQuantity1C
		'
		Me.labelQuantity1C.Location = New System.Drawing.Point(6, 48)
		Me.labelQuantity1C.Name = "labelQuantity1C"
		Me.labelQuantity1C.Size = New System.Drawing.Size(24, 16)
		Me.labelQuantity1C.TabIndex = 1
		Me.labelQuantity1C.Text = "Qnt."
		'
		'textboxQuantity1C
		'
		Me.textboxQuantity1C.Location = New System.Drawing.Point(31, 46)
		Me.textboxQuantity1C.Name = "textboxQuantity1C"
		Me.textboxQuantity1C.ReadOnly = true
		Me.textboxQuantity1C.Size = New System.Drawing.Size(32, 20)
		Me.textboxQuantity1C.TabIndex = 0
		'
		'textboxName1C
		'
		Me.textboxName1C.Location = New System.Drawing.Point(6, 19)
		Me.textboxName1C.Name = "textboxName1C"
		Me.textboxName1C.Size = New System.Drawing.Size(128, 20)
		Me.textboxName1C.TabIndex = 0
		'
		'groupbox2A
		'
		Me.groupbox2A.Controls.Add(Me.updownPrice2A)
		Me.groupbox2A.Controls.Add(Me.labelPrice2A)
		Me.groupbox2A.Controls.Add(Me.labelQuantity2A)
		Me.groupbox2A.Controls.Add(Me.textboxQuantity2A)
		Me.groupbox2A.Controls.Add(Me.textboxName2A)
		Me.groupbox2A.Location = New System.Drawing.Point(6, 85)
		Me.groupbox2A.Name = "groupbox2A"
		Me.groupbox2A.Size = New System.Drawing.Size(144, 73)
		Me.groupbox2A.TabIndex = 0
		Me.groupbox2A.TabStop = false
		Me.groupbox2A.Text = "Bin 2A"
		'
		'updownPrice2A
		'
		Me.updownPrice2A.Location = New System.Drawing.Point(89, 46)
		Me.updownPrice2A.Name = "updownPrice2A"
		Me.updownPrice2A.Size = New System.Drawing.Size(45, 20)
		Me.updownPrice2A.TabIndex = 2
		'
		'labelPrice2A
		'
		Me.labelPrice2A.Location = New System.Drawing.Point(64, 48)
		Me.labelPrice2A.Name = "labelPrice2A"
		Me.labelPrice2A.Size = New System.Drawing.Size(24, 16)
		Me.labelPrice2A.TabIndex = 1
		Me.labelPrice2A.Text = "Prc."
		'
		'labelQuantity2A
		'
		Me.labelQuantity2A.Location = New System.Drawing.Point(6, 48)
		Me.labelQuantity2A.Name = "labelQuantity2A"
		Me.labelQuantity2A.Size = New System.Drawing.Size(24, 16)
		Me.labelQuantity2A.TabIndex = 1
		Me.labelQuantity2A.Text = "Qnt."
		'
		'textboxQuantity2A
		'
		Me.textboxQuantity2A.Location = New System.Drawing.Point(31, 46)
		Me.textboxQuantity2A.Name = "textboxQuantity2A"
		Me.textboxQuantity2A.ReadOnly = true
		Me.textboxQuantity2A.Size = New System.Drawing.Size(32, 20)
		Me.textboxQuantity2A.TabIndex = 0
		'
		'textboxName2A
		'
		Me.textboxName2A.Location = New System.Drawing.Point(6, 19)
		Me.textboxName2A.Name = "textboxName2A"
		Me.textboxName2A.Size = New System.Drawing.Size(128, 20)
		Me.textboxName2A.TabIndex = 0
		'
		'groupbox2B
		'
		Me.groupbox2B.Controls.Add(Me.updownPrice2B)
		Me.groupbox2B.Controls.Add(Me.labelPrice2B)
		Me.groupbox2B.Controls.Add(Me.labelQuantity2B)
		Me.groupbox2B.Controls.Add(Me.textboxQuantity2B)
		Me.groupbox2B.Controls.Add(Me.textboxName2B)
		Me.groupbox2B.Location = New System.Drawing.Point(156, 85)
		Me.groupbox2B.Name = "groupbox2B"
		Me.groupbox2B.Size = New System.Drawing.Size(144, 73)
		Me.groupbox2B.TabIndex = 0
		Me.groupbox2B.TabStop = false
		Me.groupbox2B.Text = "Bin 2B"
		'
		'updownPrice2B
		'
		Me.updownPrice2B.Location = New System.Drawing.Point(89, 46)
		Me.updownPrice2B.Name = "updownPrice2B"
		Me.updownPrice2B.Size = New System.Drawing.Size(45, 20)
		Me.updownPrice2B.TabIndex = 2
		'
		'labelPrice2B
		'
		Me.labelPrice2B.Location = New System.Drawing.Point(64, 48)
		Me.labelPrice2B.Name = "labelPrice2B"
		Me.labelPrice2B.Size = New System.Drawing.Size(24, 16)
		Me.labelPrice2B.TabIndex = 1
		Me.labelPrice2B.Text = "Prc."
		'
		'labelQuantity2B
		'
		Me.labelQuantity2B.Location = New System.Drawing.Point(6, 48)
		Me.labelQuantity2B.Name = "labelQuantity2B"
		Me.labelQuantity2B.Size = New System.Drawing.Size(24, 16)
		Me.labelQuantity2B.TabIndex = 1
		Me.labelQuantity2B.Text = "Qnt."
		'
		'textboxQuantity2B
		'
		Me.textboxQuantity2B.Location = New System.Drawing.Point(31, 46)
		Me.textboxQuantity2B.Name = "textboxQuantity2B"
		Me.textboxQuantity2B.ReadOnly = true
		Me.textboxQuantity2B.Size = New System.Drawing.Size(32, 20)
		Me.textboxQuantity2B.TabIndex = 0
		'
		'textboxName2B
		'
		Me.textboxName2B.Location = New System.Drawing.Point(6, 19)
		Me.textboxName2B.Name = "textboxName2B"
		Me.textboxName2B.Size = New System.Drawing.Size(128, 20)
		Me.textboxName2B.TabIndex = 0
		'
		'groupbox2C
		'
		Me.groupbox2C.Controls.Add(Me.updownPrice2C)
		Me.groupbox2C.Controls.Add(Me.labelPrice2C)
		Me.groupbox2C.Controls.Add(Me.labelQuantity2C)
		Me.groupbox2C.Controls.Add(Me.textboxQuantity2C)
		Me.groupbox2C.Controls.Add(Me.textboxName2C)
		Me.groupbox2C.Location = New System.Drawing.Point(306, 85)
		Me.groupbox2C.Name = "groupbox2C"
		Me.groupbox2C.Size = New System.Drawing.Size(144, 73)
		Me.groupbox2C.TabIndex = 0
		Me.groupbox2C.TabStop = false
		Me.groupbox2C.Text = "Bin 2C"
		'
		'updownPrice2C
		'
		Me.updownPrice2C.Location = New System.Drawing.Point(89, 46)
		Me.updownPrice2C.Name = "updownPrice2C"
		Me.updownPrice2C.Size = New System.Drawing.Size(45, 20)
		Me.updownPrice2C.TabIndex = 2
		'
		'labelPrice2C
		'
		Me.labelPrice2C.Location = New System.Drawing.Point(64, 48)
		Me.labelPrice2C.Name = "labelPrice2C"
		Me.labelPrice2C.Size = New System.Drawing.Size(24, 16)
		Me.labelPrice2C.TabIndex = 1
		Me.labelPrice2C.Text = "Prc."
		'
		'labelQuantity2C
		'
		Me.labelQuantity2C.Location = New System.Drawing.Point(6, 48)
		Me.labelQuantity2C.Name = "labelQuantity2C"
		Me.labelQuantity2C.Size = New System.Drawing.Size(24, 16)
		Me.labelQuantity2C.TabIndex = 1
		Me.labelQuantity2C.Text = "Qnt."
		'
		'textboxQuantity2C
		'
		Me.textboxQuantity2C.Location = New System.Drawing.Point(31, 46)
		Me.textboxQuantity2C.Name = "textboxQuantity2C"
		Me.textboxQuantity2C.ReadOnly = true
		Me.textboxQuantity2C.Size = New System.Drawing.Size(32, 20)
		Me.textboxQuantity2C.TabIndex = 0
		'
		'textboxName2C
		'
		Me.textboxName2C.Location = New System.Drawing.Point(6, 19)
		Me.textboxName2C.Name = "textboxName2C"
		Me.textboxName2C.Size = New System.Drawing.Size(128, 20)
		Me.textboxName2C.TabIndex = 0
		'
		'groupbox3A
		'
		Me.groupbox3A.Controls.Add(Me.updownPrice3A)
		Me.groupbox3A.Controls.Add(Me.labelPrice3A)
		Me.groupbox3A.Controls.Add(Me.labelQuantity3A)
		Me.groupbox3A.Controls.Add(Me.textboxQuantity3A)
		Me.groupbox3A.Controls.Add(Me.textboxName3A)
		Me.groupbox3A.Location = New System.Drawing.Point(6, 164)
		Me.groupbox3A.Name = "groupbox3A"
		Me.groupbox3A.Size = New System.Drawing.Size(144, 73)
		Me.groupbox3A.TabIndex = 0
		Me.groupbox3A.TabStop = false
		Me.groupbox3A.Text = "Bin 3A"
		'
		'updownPrice3A
		'
		Me.updownPrice3A.Location = New System.Drawing.Point(89, 46)
		Me.updownPrice3A.Name = "updownPrice3A"
		Me.updownPrice3A.Size = New System.Drawing.Size(45, 20)
		Me.updownPrice3A.TabIndex = 2
		'
		'labelPrice3A
		'
		Me.labelPrice3A.Location = New System.Drawing.Point(64, 48)
		Me.labelPrice3A.Name = "labelPrice3A"
		Me.labelPrice3A.Size = New System.Drawing.Size(24, 16)
		Me.labelPrice3A.TabIndex = 1
		Me.labelPrice3A.Text = "Prc."
		'
		'labelQuantity3A
		'
		Me.labelQuantity3A.Location = New System.Drawing.Point(6, 48)
		Me.labelQuantity3A.Name = "labelQuantity3A"
		Me.labelQuantity3A.Size = New System.Drawing.Size(24, 16)
		Me.labelQuantity3A.TabIndex = 1
		Me.labelQuantity3A.Text = "Qnt."
		'
		'textboxQuantity3A
		'
		Me.textboxQuantity3A.Location = New System.Drawing.Point(31, 46)
		Me.textboxQuantity3A.Name = "textboxQuantity3A"
		Me.textboxQuantity3A.ReadOnly = true
		Me.textboxQuantity3A.Size = New System.Drawing.Size(32, 20)
		Me.textboxQuantity3A.TabIndex = 0
		'
		'textboxName3A
		'
		Me.textboxName3A.Location = New System.Drawing.Point(6, 19)
		Me.textboxName3A.Name = "textboxName3A"
		Me.textboxName3A.Size = New System.Drawing.Size(128, 20)
		Me.textboxName3A.TabIndex = 0
		'
		'groupbox3B
		'
		Me.groupbox3B.Controls.Add(Me.updownPrice3B)
		Me.groupbox3B.Controls.Add(Me.labelPrice3B)
		Me.groupbox3B.Controls.Add(Me.labelQuantity3B)
		Me.groupbox3B.Controls.Add(Me.textboxQuantity3B)
		Me.groupbox3B.Controls.Add(Me.textboxName3B)
		Me.groupbox3B.Location = New System.Drawing.Point(156, 164)
		Me.groupbox3B.Name = "groupbox3B"
		Me.groupbox3B.Size = New System.Drawing.Size(144, 73)
		Me.groupbox3B.TabIndex = 0
		Me.groupbox3B.TabStop = false
		Me.groupbox3B.Text = "Bin 3B"
		'
		'updownPrice3B
		'
		Me.updownPrice3B.Location = New System.Drawing.Point(89, 46)
		Me.updownPrice3B.Name = "updownPrice3B"
		Me.updownPrice3B.Size = New System.Drawing.Size(45, 20)
		Me.updownPrice3B.TabIndex = 2
		'
		'labelPrice3B
		'
		Me.labelPrice3B.Location = New System.Drawing.Point(64, 48)
		Me.labelPrice3B.Name = "labelPrice3B"
		Me.labelPrice3B.Size = New System.Drawing.Size(24, 16)
		Me.labelPrice3B.TabIndex = 1
		Me.labelPrice3B.Text = "Prc."
		'
		'labelQuantity3B
		'
		Me.labelQuantity3B.Location = New System.Drawing.Point(6, 48)
		Me.labelQuantity3B.Name = "labelQuantity3B"
		Me.labelQuantity3B.Size = New System.Drawing.Size(24, 16)
		Me.labelQuantity3B.TabIndex = 1
		Me.labelQuantity3B.Text = "Qnt."
		'
		'textboxQuantity3B
		'
		Me.textboxQuantity3B.Location = New System.Drawing.Point(31, 46)
		Me.textboxQuantity3B.Name = "textboxQuantity3B"
		Me.textboxQuantity3B.ReadOnly = true
		Me.textboxQuantity3B.Size = New System.Drawing.Size(32, 20)
		Me.textboxQuantity3B.TabIndex = 0
		'
		'textboxName3B
		'
		Me.textboxName3B.Location = New System.Drawing.Point(6, 19)
		Me.textboxName3B.Name = "textboxName3B"
		Me.textboxName3B.Size = New System.Drawing.Size(128, 20)
		Me.textboxName3B.TabIndex = 0
		'
		'groupbox3C
		'
		Me.groupbox3C.Controls.Add(Me.updownPrice3C)
		Me.groupbox3C.Controls.Add(Me.labelPrice3C)
		Me.groupbox3C.Controls.Add(Me.labelQuantity3C)
		Me.groupbox3C.Controls.Add(Me.textboxQuantity3C)
		Me.groupbox3C.Controls.Add(Me.textboxName3C)
		Me.groupbox3C.Location = New System.Drawing.Point(306, 164)
		Me.groupbox3C.Name = "groupbox3C"
		Me.groupbox3C.Size = New System.Drawing.Size(144, 73)
		Me.groupbox3C.TabIndex = 0
		Me.groupbox3C.TabStop = false
		Me.groupbox3C.Text = "Bin 3C"
		'
		'updownPrice3C
		'
		Me.updownPrice3C.Location = New System.Drawing.Point(89, 46)
		Me.updownPrice3C.Name = "updownPrice3C"
		Me.updownPrice3C.Size = New System.Drawing.Size(45, 20)
		Me.updownPrice3C.TabIndex = 2
		'
		'labelPrice3C
		'
		Me.labelPrice3C.Location = New System.Drawing.Point(64, 48)
		Me.labelPrice3C.Name = "labelPrice3C"
		Me.labelPrice3C.Size = New System.Drawing.Size(24, 16)
		Me.labelPrice3C.TabIndex = 1
		Me.labelPrice3C.Text = "Prc."
		'
		'labelQuantity3C
		'
		Me.labelQuantity3C.Location = New System.Drawing.Point(6, 48)
		Me.labelQuantity3C.Name = "labelQuantity3C"
		Me.labelQuantity3C.Size = New System.Drawing.Size(24, 16)
		Me.labelQuantity3C.TabIndex = 1
		Me.labelQuantity3C.Text = "Qnt."
		'
		'textboxQuantity3C
		'
		Me.textboxQuantity3C.Location = New System.Drawing.Point(31, 46)
		Me.textboxQuantity3C.Name = "textboxQuantity3C"
		Me.textboxQuantity3C.ReadOnly = true
		Me.textboxQuantity3C.Size = New System.Drawing.Size(32, 20)
		Me.textboxQuantity3C.TabIndex = 0
		'
		'textboxName3C
		'
		Me.textboxName3C.Location = New System.Drawing.Point(6, 19)
		Me.textboxName3C.Name = "textboxName3C"
		Me.textboxName3C.Size = New System.Drawing.Size(128, 20)
		Me.textboxName3C.TabIndex = 0
		'
		'tabcontrolStore
		'
		Me.tabcontrolStore.Controls.Add(Me.tabpageShelf)
		Me.tabcontrolStore.Location = New System.Drawing.Point(12, 12)
		Me.tabcontrolStore.Name = "tabcontrolStore"
		Me.tabcontrolStore.SelectedIndex = 0
		Me.tabcontrolStore.Size = New System.Drawing.Size(466, 271)
		Me.tabcontrolStore.TabIndex = 1
		'
		'tabpageShelf
		'
		Me.tabpageShelf.Controls.Add(Me.groupbox1A)
		Me.tabpageShelf.Controls.Add(Me.groupbox3C)
		Me.tabpageShelf.Controls.Add(Me.groupbox2A)
		Me.tabpageShelf.Controls.Add(Me.groupbox2C)
		Me.tabpageShelf.Controls.Add(Me.groupbox3A)
		Me.tabpageShelf.Controls.Add(Me.groupbox1C)
		Me.tabpageShelf.Controls.Add(Me.groupbox1B)
		Me.tabpageShelf.Controls.Add(Me.groupbox3B)
		Me.tabpageShelf.Controls.Add(Me.groupbox2B)
		Me.tabpageShelf.Location = New System.Drawing.Point(4, 22)
		Me.tabpageShelf.Name = "tabpageShelf"
		Me.tabpageShelf.Padding = New System.Windows.Forms.Padding(3)
		Me.tabpageShelf.Size = New System.Drawing.Size(458, 245)
		Me.tabpageShelf.TabIndex = 0
		Me.tabpageShelf.Text = "Shelf"
		Me.tabpageShelf.UseVisualStyleBackColor = true
		'
		'formInventory
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(487, 296)
		Me.Controls.Add(Me.tabcontrolStore)
		Me.Name = "formInventory"
		Me.Text = "Store Layout"
		AddHandler Closing, AddressOf Me.FormInventoryClosing
		AddHandler Load, AddressOf Me.FormInventoryLoad
		Me.groupbox1A.ResumeLayout(false)
		Me.groupbox1A.PerformLayout
		Me.groupbox1B.ResumeLayout(false)
		Me.groupbox1B.PerformLayout
		Me.groupbox1C.ResumeLayout(false)
		Me.groupbox1C.PerformLayout
		Me.groupbox2A.ResumeLayout(false)
		Me.groupbox2A.PerformLayout
		Me.groupbox2B.ResumeLayout(false)
		Me.groupbox2B.PerformLayout
		Me.groupbox2C.ResumeLayout(false)
		Me.groupbox2C.PerformLayout
		Me.groupbox3A.ResumeLayout(false)
		Me.groupbox3A.PerformLayout
		Me.groupbox3B.ResumeLayout(false)
		Me.groupbox3B.PerformLayout
		Me.groupbox3C.ResumeLayout(false)
		Me.groupbox3C.PerformLayout
		Me.tabcontrolStore.ResumeLayout(false)
		Me.tabpageShelf.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private tabpageShelf As System.Windows.Forms.TabPage
	Private tabcontrolStore As System.Windows.Forms.TabControl
	Private textboxName3C As System.Windows.Forms.TextBox
	Private textboxQuantity3C As System.Windows.Forms.TextBox
	Private labelQuantity3C As System.Windows.Forms.Label
	Private labelPrice3C As System.Windows.Forms.Label
	Private updownPrice3C As System.Windows.Forms.DomainUpDown
	Private groupbox3C As System.Windows.Forms.GroupBox
	Private textboxName3B As System.Windows.Forms.TextBox
	Private textboxQuantity3B As System.Windows.Forms.TextBox
	Private labelQuantity3B As System.Windows.Forms.Label
	Private labelPrice3B As System.Windows.Forms.Label
	Private updownPrice3B As System.Windows.Forms.DomainUpDown
	Private groupbox3B As System.Windows.Forms.GroupBox
	Private textboxName3A As System.Windows.Forms.TextBox
	Private textboxQuantity3A As System.Windows.Forms.TextBox
	Private labelQuantity3A As System.Windows.Forms.Label
	Private labelPrice3A As System.Windows.Forms.Label
	Private updownPrice3A As System.Windows.Forms.DomainUpDown
	Private groupbox3A As System.Windows.Forms.GroupBox
	Private textboxName2C As System.Windows.Forms.TextBox
	Private textboxQuantity2C As System.Windows.Forms.TextBox
	Private labelQuantity2C As System.Windows.Forms.Label
	Private labelPrice2C As System.Windows.Forms.Label
	Private updownPrice2C As System.Windows.Forms.DomainUpDown
	Private groupbox2C As System.Windows.Forms.GroupBox
	Private textboxName2B As System.Windows.Forms.TextBox
	Private textboxQuantity2B As System.Windows.Forms.TextBox
	Private labelQuantity2B As System.Windows.Forms.Label
	Private labelPrice2B As System.Windows.Forms.Label
	Private updownPrice2B As System.Windows.Forms.DomainUpDown
	Private groupbox2B As System.Windows.Forms.GroupBox
	Private textboxName2A As System.Windows.Forms.TextBox
	Private textboxQuantity2A As System.Windows.Forms.TextBox
	Private labelQuantity2A As System.Windows.Forms.Label
	Private labelPrice2A As System.Windows.Forms.Label
	Private updownPrice2A As System.Windows.Forms.DomainUpDown
	Private groupbox2A As System.Windows.Forms.GroupBox
	Private textboxName1C As System.Windows.Forms.TextBox
	Private textboxQuantity1C As System.Windows.Forms.TextBox
	Private labelQuantity1C As System.Windows.Forms.Label
	Private labelPrice1C As System.Windows.Forms.Label
	Private updownPrice1C As System.Windows.Forms.DomainUpDown
	Private groupbox1C As System.Windows.Forms.GroupBox
	Private textboxName1B As System.Windows.Forms.TextBox
	Private textboxQuantity1B As System.Windows.Forms.TextBox
	Private labelQuantity1B As System.Windows.Forms.Label
	Private labelPrice1B As System.Windows.Forms.Label
	Private updownPrice1B As System.Windows.Forms.DomainUpDown
	Private groupbox1B As System.Windows.Forms.GroupBox
	Private textboxName1A As System.Windows.Forms.TextBox
	Private textboxQuantity1A As System.Windows.Forms.TextBox
	Private labelQuantity1A As System.Windows.Forms.Label
	Private labelPrice1A As System.Windows.Forms.Label
	Private updownPrice1A As System.Windows.Forms.DomainUpDown
	Private groupbox1A As System.Windows.Forms.GroupBox
End Class
