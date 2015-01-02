''' <summary>
''' Description of form/class/etc.
''' </summary>
Public Partial Class gamecache
	Friend Shared MainMenu as New formMain()
	Friend Shared StatusForm As System.Windows.Forms.Form
	Friend Shared GameForm As System.Windows.Forms.Form
	Friend Shared ItemManagementForm As System.Windows.Forms.Form
	Friend Shared MapForm As System.Windows.Forms.Form
	Friend Shared DCForm As System.Windows.Forms.Form
	Friend Shared InfoProfileForm As System.Windows.Forms.Form
	Friend Shared EditorForm As System.Windows.Forms.Form
	
	Friend Shared settingsGlobal As New settings()
	
	Friend Shared profileInformation As New profile()
	Friend Shared profileStats As New profileStatistics()
	
	Friend Shared playerCharacter As New character()
	Friend Shared playerStorage As New storage()
	Friend Shared playerStore As New store()
	
	Friend Shared cacheCustomer As New customer()
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\settings.ini") = False Then
			'Create new settings and opens New Profile window.
			settingsGlobal.NewSettings()
			InfoProfileForm = New formProfileManagement()
			InfoProfileForm.Show()
		Else
			labelDescription.Text = "Loading Global Settings"
			progressbarLoading.Value = 4
			'Load settings
			settingsGlobal.LoadSettings()
			labelDescription.Text = "Load Latest Profile"
			progressbarLoading.Value = 8
			'Load latest Profile
			profileStats.LoadStatistics()
			labelDescription.Text = "Opening Main Menu"
			progressbarLoading.Value = 10
			MainMenu.Show()
		End If
		Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
	End Sub
	
	Public Shared Sub InfoProfile()
		InfoProfileForm = New formProfileManagement
		InfoProfileForm.Show()
		MainMenu.Hide()
		gamecache.WindowState = System.Windows.Forms.FormWindowState.Minimized
	End Sub
	
	Public Sub ResumeGame()
		MainMenu.Hide()
		progressbarLoading.Value = 0
		labelDescription.Text = "Loading Profile."
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		progressbarLoading.Value = 1
		labelDescription.Text = "Making new Profile."
		profileInformation.LoadProfile()
		progressbarLoading.Value = 2
		labelDescription.Text = "Making new Character."
		playerCharacter.LoadCharacter()
		progressbarLoading.Value = 3
		labelDescription.Text = "Making new Storage."
		playerStorage.StoragePath = System.IO.Directory.GetCurrentDirectory & "\Save\" & gamecache.settingsGlobal.LastProfile & "\Storage\0"
		playerStorage.StorageInitialize()
		playerStorage.StorageLoad()
		progressbarLoading.Value = 6
		labelDescription.Text = "Creating Store Layout."
		playerStore.StorePath = System.IO.Directory.GetCurrentDirectory & "\Save\" & gamecache.settingsGlobal.LastProfile & "\MyFirstStore"
		playerStore.StoreInitialize()
		playerStore.StoreLoad()
		progressbarLoading.Value = 9
		labelDescription.Text = "Opening Forms."
		StartGame()
		progressbarLoading.Value = 10
		labelDescription.Text = ""
		Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
	End Sub
	
	Public Sub NewProfile()
		InfoProfileForm.Hide()
		progressbarLoading.Value = 2
		labelDescription.Text = "Making new Character."
		playerCharacter.LoadCharacter()
		progressbarLoading.Value = 3
		labelDescription.Text = "Making new Storage."
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\Save\" & gamecache.settingsGlobal.LastProfile & "\Storage\0")
		playerStorage.StoragePath = System.IO.Directory.GetCurrentDirectory & "\Save\" & gamecache.settingsGlobal.LastProfile & "\Storage\0"
		playerStorage.StorageInitialize()
		playerStorage.StorageLoad()
		playerStorage.SectionAdd()
		progressbarLoading.Value = 6
		labelDescription.Text = "Creating Store Layout."
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\Save\" & gamecache.settingsGlobal.LastProfile & "\MyFirstStore")
		playerStore.StorePath = System.IO.Directory.GetCurrentDirectory & "\Save\" & gamecache.settingsGlobal.LastProfile & "\MyFirstStore"
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
	
	Public Shared Sub StartGame()
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
		gamecache.WindowState = System.Windows.Forms.FormWindowState.Minimized
	End Sub
End Class
