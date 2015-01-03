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
	
	Friend Shared currentSettings As New settings()
	
	Friend Shared currentPlayerProfile As New playerProfile()
	Friend Shared currentPlayerStatistics As New playerStatistics()
	Friend Shared currentCharacterStorage As New storage()
	Friend Shared currentCharacterStore As New store()
	
	Friend Shared currentCharacterProfile As New characterProfile()
	Friend Shared currentCharacterStatistics As New characterStatistics()
		
	Friend Shared cacheCustomer As New customer()
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		If System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory & "\save\settings.ini") = False Then
			'Create new settings and opens New Profile window.
			currentSettings.NewSettings()
			InfoProfileForm = New formPlayerManagement()
			InfoProfileForm.Show()
		Else
			labelDescription.Text = "Loading Global Settings"
			progressbarLoading.Value = 4
			'Load settings
			currentSettings.LoadSettings()
			labelDescription.Text = "Load Latest Profile"
			progressbarLoading.Value = 8
			'Load latest Profile
			currentPlayerStatistics.LoadPlayerStatistics()
			labelDescription.Text = "Opening Main Menu"
			progressbarLoading.Value = 10
			MainMenu.Show()
		End If
		Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
	End Sub
	
	Public Shared Sub InfoProfile()
		InfoProfileForm = New formPlayerManagement
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
		currentPlayerProfile.LoadPlayerProfile()
		progressbarLoading.Value = 2
		labelDescription.Text = "Making new Character."
		currentCharacterProfile.LoadCharacterProfile()
		currentCharacterStatistics.LoadCharacterStatistics()
		progressbarLoading.Value = 3
		labelDescription.Text = "Making new Storage."
		currentCharacterStorage.StoragePath = System.IO.Directory.GetCurrentDirectory & "\Save\" & gamecache.currentSettings.LastProfile & "\Storage\0"
		currentCharacterStorage.StorageInitialize()
		currentCharacterStorage.StorageLoad()
		progressbarLoading.Value = 6
		labelDescription.Text = "Creating Store Layout."
		currentCharacterStore.StorePath = System.IO.Directory.GetCurrentDirectory & "\Save\" & gamecache.currentSettings.LastProfile & "\MyFirstStore"
		currentCharacterStore.StoreInitialize()
		currentCharacterStore.StoreLoad()
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
		currentCharacterProfile.LoadCharacterProfile()
		currentCharacterStatistics.LoadCharacterStatistics()
		progressbarLoading.Value = 3
		labelDescription.Text = "Making new Storage."
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\Save\" & gamecache.currentSettings.LastProfile & "\Storage\0")
		currentCharacterStorage.StoragePath = System.IO.Directory.GetCurrentDirectory & "\Save\" & gamecache.currentSettings.LastProfile & "\Storage\0"
		currentCharacterStorage.StorageInitialize()
		currentCharacterStorage.StorageLoad()
		currentCharacterStorage.SectionAdd()
		progressbarLoading.Value = 6
		labelDescription.Text = "Creating Store Layout."
		System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory & "\Save\" & gamecache.currentSettings.LastProfile & "\MyFirstStore")
		currentCharacterStore.StorePath = System.IO.Directory.GetCurrentDirectory & "\Save\" & gamecache.currentSettings.LastProfile & "\MyFirstStore"
		currentCharacterStore.StoreInitialize()
		currentCharacterStore.StoreLoad()
		currentCharacterStore.LevelAdd()
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
