using System;
using Game.Classes.Settings;

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

    static internal settingsMain MainSettings = new settingsMain();

    static internal settingsPlayer currentPlayer = new settingsPlayer();
    static internal storage currentCharacterStorage = new storage();
    static internal store currentCharacterStore = new store();

    static internal settingsCharacter currentCharacter = new settingsCharacter();

    static internal ethnics cacheCustomer = new ethnics();

    public gamecache()
    {
        // The Me.InitializeComponent call is required for Windows Forms designer support.
        this.InitializeComponent();

        if (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + (char)92 + "save" + (char)92 + "settings" + (char)92 + "Main.ini")) {
            //Load latest Profile
             MainMenu.Show();
        } else {
            //Create new settings and opens New Profile window.
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
//        currentPlayer.LoadPlayerProfile();
//        currentPlayerStatistics.LoadPlayerStatistics();
//        currentCharacter.LoadCharacterProfile();
//        currentCharacter.LoadCharacterStatistics();
        currentCharacterStorage.StoragePath = System.IO.Directory.GetCurrentDirectory() + "\\Save\\" + gamecache.MainSettings.LastUserID + "\\Storage\\0";
        currentCharacterStorage.StorageInitialize();
        currentCharacterStorage.StorageLoad();
        currentCharacterStore.StorePath = System.IO.Directory.GetCurrentDirectory() + "\\Save\\" + gamecache.MainSettings.LastUserID + "\\MyFirstStore";
        currentCharacterStore.StoreInitialize();
        currentCharacterStore.StoreLoad();
        StartGame();
    }

    public static void NewProfile()
    {
        InfoProfileForm.Hide();
//        currentCharacter.LoadCharacterProfile();
//        currentCharacter.LoadCharacterStatistics();
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\Save\\" + gamecache.MainSettings.LastUserID + "\\Storage\\0");
        currentCharacterStorage.StoragePath = System.IO.Directory.GetCurrentDirectory() + "\\Save\\" + gamecache.MainSettings.LastUserID + "\\Storage\\0";
        currentCharacterStorage.StorageInitialize();
        currentCharacterStorage.StorageLoad();
        currentCharacterStorage.SectionAdd();
        System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\Save\\" + gamecache.MainSettings.LastUserID + "\\MyFirstStore");
        currentCharacterStore.StorePath = System.IO.Directory.GetCurrentDirectory() + "\\Save\\" + gamecache.MainSettings.LastUserID + "\\MyFirstStore";
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