''' <summary>
''' Description of form/class/etc.
''' </summary>
Public Partial Class cache
	Friend Shared MainMenu as New formMain()
	Friend Shared StatusForm As System.Windows.Forms.Form
	Friend Shared GameForm As System.Windows.Forms.Form
	Friend Shared ItemManagementForm As System.Windows.Forms.Form
	Friend Shared MapForm As System.Windows.Forms.Form
	Friend Shared DCForm As System.Windows.Forms.Form
	Friend Shared NewGameForm As System.Windows.Forms.Form

	Friend Shared settingsGlobal As New settings()
	Friend Shared playerProfile As New player()
	Friend Shared playerCharacter As New character()
	Friend Shared playerStorage As New storage()
	Friend Shared playerStore As New store()
	
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
	
	Public Sub NewGame()
		NewGameForm = New formNewGame
		NewGameForm.Show()
		MainMenu.Hide()
	End Sub
	
	Public Sub NewPlayer(Template() As String)
		NewGameForm.Hide()
		progressbarLoading.Value = 0
		labelDescription.Text = "Creating New Player."
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		settingsGlobal.NewPlayer()
		progressbarLoading.Value = 1
		labelDescription.Text = "Making new Profile."
		playerProfile.Load(Template)
		progressbarLoading.Value = 2
		labelDescription.Text = "Making new Character."
		playerCharacter.Load()
		progressbarLoading.Value = 3
		labelDescription.Text = "Making new Storage."
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\Save\" & playerProfile.PlayerID & "\Storage\0")
		playerStorage.StoragePath = System.IO.Directory.GetCurrentDirectory & "\Save\" & playerProfile.PlayerID & "\Storage\0"
		playerStorage.StorageInitialize()
		playerStorage.StorageLoad()
		playerStorage.SectionAdd()
		progressbarLoading.Value = 6
		labelDescription.Text = "Creating Store Layout."
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\Save\" & playerProfile.PlayerID & "\MyFirstStore")
		playerStore.StorePath = System.IO.Directory.GetCurrentDirectory & "\Save\" & playerProfile.PlayerID & "\MyFirstStore"
		playerStore.StoreInitialize()
		playerStore.StoreLoad()
		playerStore.LevelAdd()
		progressbarLoading.Value = 9
		labelDescription.Text = "Opening Forms."
		StartGame()
		progressbarLoading.Value = 10
		labelDescription.Text = ""
		Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
	End Sub
	
	Public Sub StartGame()
		StatusForm = New formStatus()
		GameForm = New formGame()
		ItemManagementForm = New formItemManagement()
		MapForm = New formMap()
		DCForm = New formDC()
		
		MainMenu.ShowInTaskbar = False
		MainMenu.WindowState = System.Windows.Forms.FormWindowState.Minimized
		GameForm.ShowInTaskbar = True
		GameForm.WindowState = System.Windows.Forms.FormWindowState.Normal
		StatusForm.ShowInTaskbar = True
		StatusForm.WindowState = System.Windows.Forms.FormWindowState.Normal
		ItemManagementForm.ShowInTaskbar = False
		ItemManagementForm.WindowState = System.Windows.Forms.FormWindowState.Minimized
		MapForm.ShowInTaskbar = False
		MapForm.WindowState = System.Windows.Forms.FormWindowState.Minimized
		DCForm.ShowInTaskbar = False
		DCForm.WindowState = System.Windows.Forms.FormWindowState.Minimized
		
		DCForm.Show()
		GameForm.Show()
		StatusForm.Show()
		ItemManagementForm.Show()
		MapForm.Show()
		DCForm.Show()
	End Sub
End Class
