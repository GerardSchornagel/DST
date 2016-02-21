using System;

/// <summary>
/// Description of form/class/etc.
/// </summary>
public partial class gamecache
{
    static internal formMain MainMenu = new formMain();
    static internal System.Windows.Forms.Form StatusForm;
    static internal System.Windows.Forms.Form GameForm;
    static internal System.Windows.Forms.Form ItemManagementForm;
    static internal System.Windows.Forms.Form MapForm;
    static internal System.Windows.Forms.Form DCForm;
    static internal System.Windows.Forms.Form InfoProfileForm;
    static internal System.Windows.Forms.Form EditorForm;

    static internal settings currentSettings = new settings();

    static internal playerProfile currentPlayerProfile = new playerProfile();
    static internal playerStatistics currentPlayerStatistics = new playerStatistics();
    static internal storage currentCharacterStorage = new storage();
    static internal store currentCharacterStore = new store();

    static internal characterProfile currentCharacterProfile = new characterProfile();
    static internal characterStatistics currentCharacterStatistics = new characterStatistics();

    static internal customer cacheCustomer = new customer();

    public gamecache()
    {
        // The Me.InitializeComponent call is required for Windows Forms designer support.
        this.InitializeComponent();

        if (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory + "\\save\\settings.ini")) {
            labelDescription.Text = "Loading Global Settings";
            progressbarLoading.Value = 4;
            //Load settings
            currentSettings.LoadSettings();
            labelDescription.Text = "Load Latest Profile";
            progressbarLoading.Value = 8;
            //Load latest Profile
            currentPlayerStatistics.LoadPlayerStatistics();
            labelDescription.Text = "Opening Main Menu";
            progressbarLoading.Value = 10;
            MainMenu.Show();
        } else {
            //Create new settings and opens New Profile window.
            currentSettings.NewSettings();
            InfoProfileForm = new formPlayerManagement();
            InfoProfileForm.Show();
        }
        this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
    }

    public static void InfoProfile()
    {
        InfoProfileForm = new formPlayerManagement();
        InfoProfileForm.Show();
        MainMenu.Hide();
        gamecache.WindowState = System.Windows.Forms.FormWindowState.Minimized;
    }

    public void ResumeGame()
    {
        MainMenu.Hide();
        progressbarLoading.Value = 0;
        labelDescription.Text = "Loading Profile.";
        this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        progressbarLoading.Value = 1;
        labelDescription.Text = "Making new Profile.";
        currentPlayerProfile.LoadPlayerProfile();
        progressbarLoading.Value = 2;
        labelDescription.Text = "Making new Character.";
        currentCharacterProfile.LoadCharacterProfile();
        currentCharacterStatistics.LoadCharacterStatistics();
        progressbarLoading.Value = 3;
        labelDescription.Text = "Making new Storage.";
        currentCharacterStorage.StoragePath = System.IO.Directory.GetCurrentDirectory + "\\Save\\" + gamecache.currentSettings.LastProfile + "\\Storage\\0";
        currentCharacterStorage.StorageInitialize();
        currentCharacterStorage.StorageLoad();
        progressbarLoading.Value = 6;
        labelDescription.Text = "Creating Store Layout.";
        currentCharacterStore.StorePath = System.IO.Directory.GetCurrentDirectory + "\\Save\\" + gamecache.currentSettings.LastProfile + "\\MyFirstStore";
        currentCharacterStore.StoreInitialize();
        currentCharacterStore.StoreLoad();
        progressbarLoading.Value = 9;
        labelDescription.Text = "Opening Forms.";
        StartGame();
        progressbarLoading.Value = 10;
        labelDescription.Text = "";
        this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
    }

    public void NewProfile()
    {
        InfoProfileForm.Hide();
        progressbarLoading.Value = 2;
        labelDescription.Text = "Making new Character.";
        currentCharacterProfile.LoadCharacterProfile();
        currentCharacterStatistics.LoadCharacterStatistics();
        progressbarLoading.Value = 3;
        labelDescription.Text = "Making new Storage.";
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\\Save\\" + gamecache.currentSettings.LastProfile + "\\Storage\\0");
        currentCharacterStorage.StoragePath = System.IO.Directory.GetCurrentDirectory + "\\Save\\" + gamecache.currentSettings.LastProfile + "\\Storage\\0";
        currentCharacterStorage.StorageInitialize();
        currentCharacterStorage.StorageLoad();
        currentCharacterStorage.SectionAdd();
        progressbarLoading.Value = 6;
        labelDescription.Text = "Creating Store Layout.";
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\\Save\\" + gamecache.currentSettings.LastProfile + "\\MyFirstStore");
        currentCharacterStore.StorePath = System.IO.Directory.GetCurrentDirectory + "\\Save\\" + gamecache.currentSettings.LastProfile + "\\MyFirstStore";
        currentCharacterStore.StoreInitialize();
        currentCharacterStore.StoreLoad();
        currentCharacterStore.LevelAdd();
        progressbarLoading.Value = 9;
        labelDescription.Text = "Opening Forms.";
        StartGame();
        progressbarLoading.Value = 10;
        labelDescription.Text = "";
        this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
    }

    public static void StartGame()
    {
        StatusForm = new formStatus();
        GameForm = new formGame();
        ItemManagementForm = new formItemManagement();
        MapForm = new formMap();
        DCForm = new formDC();

        MainMenu.ShowInTaskbar = false;
        MainMenu.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        GameForm.ShowInTaskbar = true;
        GameForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
        StatusForm.ShowInTaskbar = true;
        StatusForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
        ItemManagementForm.ShowInTaskbar = false;
        ItemManagementForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        MapForm.ShowInTaskbar = false;
        MapForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        DCForm.ShowInTaskbar = false;
        DCForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;

        DCForm.Show();
        GameForm.Show();
        StatusForm.Show();
        ItemManagementForm.Show();
        MapForm.Show();
        DCForm.Show();
        gamecache.WindowState = System.Windows.Forms.FormWindowState.Minimized;
    }
}