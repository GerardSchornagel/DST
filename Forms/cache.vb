''' <summary>
''' Description of form/class/etc.
''' </summary>
Public Partial Class cache
	Friend Shared MainMenu as New formMain()
	Friend Shared StatusForm As System.Windows.Forms.Form
	Friend Shared GameForm As System.Windows.Forms.Form
	
	Friend Shared settingsGlobal As New settings()
	Friend Shared playerProfile As New player()
	Friend Shared playerCharacter As New character()
	Friend Shared playerInventory As New inventory()
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		labelDescription.Text = "Main Menu"
		progressbarLoading.Value = 10
		MainMenu.Show()
		Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
	End Sub
	
	Public Sub NewPlayer()
		MainMenu.Hide()
		progressbarLoading.Value = 0
		labelDescription.Text = "Creating New Player."
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		settingsGlobal.NewPlayer()
		progressbarLoading.Value = 1
		labelDescription.Text = "Making new Profile."
		playerProfile.Load()
		progressbarLoading.Value = 2
		labelDescription.Text = "Making new Character."
		playerCharacter.Load()
		progressbarLoading.Value = 3
		labelDescription.Text = "Making new Inventory."
		playerInventory.Load()
		progressbarLoading.Value = 6
		labelDescription.Text = "Creating Store Layout."
		Dim newStore As New OLDstore()
		newStore.NewStore()
		newStore.SaveState()
		progressbarLoading.Value = 9
		labelDescription.Text = "Opening Forms."
		StatusForm = New formStatus()
		GameForm = New formGame()
		progressbarLoading.Value = 10
		labelDescription.Text = ""
		Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
		MainMenu.ShowInTaskbar = False
		MainMenu.WindowState = System.Windows.Forms.FormWindowState.Minimized
		MainMenu.Show()
		GameForm.ShowInTaskbar = True
		GameForm.WindowState = System.Windows.Forms.FormWindowState.Normal
		StatusForm.ShowInTaskbar = True
		StatusForm.WindowState = System.Windows.Forms.FormWindowState.Normal
		GameForm.Show()
		StatusForm.Show()
	End Sub
End Class
