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

        if (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\save\\settings.ini")) {
            //Load settings
            currentSettings.LoadSettings();
            //Load latest Profile
            currentPlayerStatistics.LoadPlayerStatistics();
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
    }
    
    public static void ResumeGame()
    {
        MainMenu.Hide();
        currentPlayerProfile.LoadPlayerProfile();
        currentPlayerStatistics.LoadPlayerStatistics();
        currentCharacterProfile.LoadCharacterProfile();
        currentCharacterStatistics.LoadCharacterStatistics();
        currentCharacterStorage.StoragePath = System.IO.Directory.GetCurrentDirectory() + "\\Save\\" + gamecache.currentSettings.LastProfile + "\\Storage\\0";
        currentCharacterStorage.StorageInitialize();
        currentCharacterStorage.StorageLoad();
        currentCharacterStore.StorePath = System.IO.Directory.GetCurrentDirectory() + "\\Save\\" + gamecache.currentSettings.LastProfile + "\\MyFirstStore";
        currentCharacterStore.StoreInitialize();
        currentCharacterStore.StoreLoad();
        StartGame();
    }

    public static void NewProfile()
    {
        InfoProfileForm.Hide();
        currentCharacterProfile.LoadCharacterProfile();
        currentCharacterStatistics.LoadCharacterStatistics();
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\Save\\" + gamecache.currentSettings.LastProfile + "\\Storage\\0");
        currentCharacterStorage.StoragePath = System.IO.Directory.GetCurrentDirectory() + "\\Save\\" + gamecache.currentSettings.LastProfile + "\\Storage\\0";
        currentCharacterStorage.StorageInitialize();
        currentCharacterStorage.StorageLoad();
        currentCharacterStorage.SectionAdd();
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\Save\\" + gamecache.currentSettings.LastProfile + "\\MyFirstStore");
        currentCharacterStore.StorePath = System.IO.Directory.GetCurrentDirectory() + "\\Save\\" + gamecache.currentSettings.LastProfile + "\\MyFirstStore";
        currentCharacterStore.StoreInitialize();
        currentCharacterStore.StoreLoad();
        currentCharacterStore.LevelAdd();
        StartGame();
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
    }
}