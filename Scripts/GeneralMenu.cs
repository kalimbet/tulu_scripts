using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralMenu : MonoBehaviour
{
    public string resumeButton = "Resume";
    public string newGameButton = "Play";
    public string settingsButton = "Settings";
    public string creditsButton = "Credits";

    public string muteButton = "Mute";
    public string muteSfxButton = "MuteSfx";
    public string pauseButton = "Pause";
    public string exitButton = "Exit";
    public string shopButton = "Shop";
    public string rewardButton = "Reward";
    public string shopCloseButton = "ShopClose";
    public string closeSettingsButton = "CloseSettings";


    public GameObject generalMenu;
    public GameObject generalInterface;
    public GameObject generalRestartMenu;
    public GameObject generalPauseMenu;
    public GameObject playButton;

    public GameObject generalSettingsMenu;
    public GameObject fpsObj;

    public GameObject onSound;
    public GameObject offSound;

    public GameObject onSoundSfx;
    public GameObject offSoundSfx;

    public GameObject audioForGeneralMenu;
    public GameObject audioForRestartMenu;
    public GameObject audioForInterfaceMenu;
    public GameObject audioForPauseMenu;

    public GameObject soundForButton;
    public GameObject soundForBackground;
    public GameObject soundForRock;
    

    public GameObject cameraForMenu;
    public GameObject cameraForGame;
    public GameObject rewardButtonObjMenu;
    public GameObject rewardButtonObjGame;
    public GameObject soundGameObj;

    public AudioSource soundCoin;
    
    
    //public GameObject rewardAdsGame;

    float value = 3.2f;
    bool startTim = false;
    float defaultSpeedLevel;


    // Use this for initialization
    void Start() { defaultSpeedLevel = Variables.speedLevel;}


    // Update is called once per frame
    void Update()
    {
        Check();
        TimerBeforeStartGame();
        CheckerForAds();
    }

  

    public void Check()
    {

        CheckerForShowMenu();
        CheckerForPlaySound();
        CheckerForPlaySoundSfx();

        if (ManagerAds.soundCoin == true) { soundCoin.Play(); ManagerAds.soundCoin = false; }

        if (SimpleInput.GetButtonUp(resumeButton)) { ResumeGameMethod(); }

        if (SimpleInput.GetButtonUp(rewardButton)) { }      

        if (SimpleInput.GetButtonUp(newGameButton)) { NewGameButtonMethod(); }

        if (SimpleInput.GetButtonUp(shopButton)) { Variables.menuStatus = 4; }

        if (SimpleInput.GetButtonUp(shopCloseButton)) { Variables.menuStatus = 1; }

        if (SimpleInput.GetButtonUp(pauseButton)) { PauseMethod(); }

        if (SimpleInput.GetButtonUp(creditsButton)) { SceneManager.LoadScene("LoadingCredits"); }

        if (SimpleInput.GetButtonUp(settingsButton)) { GeneralSettings(); }

        if (SimpleInput.GetButtonUp(closeSettingsButton)) { CloseSettings(); }

        if (SimpleInput.GetButtonUp(exitButton)) { ExiteGameMethod(); CloseSettings(); }

        if (SimpleInput.GetButtonUp(muteButton)) { MuteSoundMethod(); }
        
        if (SimpleInput.GetButtonUp(muteSfxButton)) { MuteSfxSoundMethod(); }

    }

    void CheckerForAds()
    {
        if (Variables.numberForAds % 2 == 0) { rewardButtonObjGame.SetActive(true); }
        else { rewardButtonObjMenu.SetActive(false); rewardButtonObjGame.SetActive(false); }
    }

    void TimerBeforeStartGame()
    {
        if (startTim == true)
        {
            value -= Time.deltaTime * 1;
            if (value > 0) { }
            else
            {
                NewGameMethod();
                startTim = false;
                value = 2f;
            }
        }
    }
    void ResumeGameMethod()
    {
        generalInterface.SetActive(true);
        generalMenu.SetActive(false);
        generalPauseMenu.SetActive(false);
        Variables.inGame = true;
        Variables.menuStatus = 3;
        Time.timeScale = 1;
    }

    void NewGameButtonMethod()
    {
        if (Variables.menuStatus == 1)
        {
            playButton.SetActive(false);
            startTim = true;
            Variables.menuStatus = 3;
            HeroForMenu.statusMenu = true;
            LoadSave.conditionForSave = false;
        }
        else if (Variables.menuStatus == 0) { RestartGameMethod(); }
    }

    void NewGameMethod()
    {
        //SceneManager.LoadScene("Level");
        ManagerAds.stateForReward = true;
        Variables.isLife = true;
        Variables.inGame = true;
        Time.timeScale = 1;
        Variables.speedLevel = defaultSpeedLevel;
        GameScore.valueScore = 0;
    }

    void RestartGameMethod()
    {
        //Debug.Log("Restart");
        SceneManager.LoadScene("Level");
        ManagerAds.stateForReward = true;
        GeneralRestartMenu();
        Variables.isLife = true;
        Variables.inGame = true;
        Variables.menuStatus = 3;
        Time.timeScale = 1;
        Variables.speedLevel = defaultSpeedLevel;
        GameScore.valueScore = 0;
    }

    void ExiteGameMethod()
    {
        if (Variables.menuStatus == 1)
        {
            Debug.Log("Exite");
            Application.Quit();

        }
        else if (Variables.menuStatus == 0 || Variables.menuStatus == 2)
        {
            Variables.menuStatus = 1;
            SceneManager.LoadScene("Level");
            Time.timeScale = 1;
            Variables.speedLevel = defaultSpeedLevel;
        }
    }
    void MuteSoundMethod()
    {
        if (Variables.soundMusic == true) Variables.soundMusic = false;
        else Variables.soundMusic = true;
    }

    void MuteSfxSoundMethod()
    {
        if (Variables.soundSfx == true) Variables.soundSfx = false;
        else Variables.soundSfx = true;
    }
    void PauseMethod()
    {
        //Debug.Log("Меню паузы");
        Variables.inGame = false;
        Variables.menuStatus = 2;
        Time.timeScale = 0;
    }

    void CheckerForPlaySound()
    {
        if(Variables.soundMusic == true )
        {
            audioForGeneralMenu.SetActive(true);
            audioForInterfaceMenu.SetActive(true);
            audioForRestartMenu.SetActive(true);
            audioForPauseMenu.SetActive(true);

            onSound.SetActive(true);
            offSound.SetActive(false);

        }
        else if(Variables.soundMusic == false)
        {
            audioForGeneralMenu.SetActive(false);
            audioForInterfaceMenu.SetActive(false);
            audioForRestartMenu.SetActive(false);
            audioForPauseMenu.SetActive(false); 
            onSound.SetActive(false);
            offSound.SetActive(true);

        }
    }

    void CheckerForPlaySoundSfx()
    {
        if (Variables.soundSfx == true )
        {
            soundForBackground.SetActive(true);
            soundForButton.SetActive(true);
            soundForRock.SetActive(true);
            onSoundSfx.SetActive(true);
            offSoundSfx.SetActive(false);
        }
        else if (Variables.soundSfx == false )
        {
            soundForBackground.SetActive(false);
            soundForButton.SetActive(false);
            soundForRock.SetActive(false);
            onSoundSfx.SetActive(false);
            offSoundSfx.SetActive(true);
        }
        
    }
    void CheckerForShowMenu()
    {
        if (Variables.inGame == false && Variables.menuStatus == 1) { GeneralPlayMenu(); }
        else if (Variables.inGame == false && Variables.menuStatus == 0) { GeneralRestartMenu(); }
        else if (Variables.inGame == true && Variables.isLife == true) { GeneralInterfaceMenu(); }
        else if(Variables.menuStatus == 2) { GeneralPauseMenu(); }
        else if(Variables.menuStatus == 3) { GeneralInGame(); }
        else if(Variables.menuStatus == 4) { LoadSave.conditionForSave = true; }
    }

    void GeneralPlayMenu()
    {
        //Debug.Log("Главное меню");
        generalInterface.SetActive(false);
        generalMenu.SetActive(true);
        generalRestartMenu.SetActive(false);
        generalPauseMenu.SetActive(false);
        cameraForMenu.SetActive(true);
        cameraForGame.SetActive(false);
    }

    void GeneralInGame() { soundGameObj.SetActive(true); }

    void GeneralSettings()
    {
        generalInterface.SetActive(false);
        generalMenu.SetActive(true);
        generalRestartMenu.SetActive(false);
        generalPauseMenu.SetActive(false);
        generalSettingsMenu.SetActive(true);
    }


    void CloseSettings() { generalSettingsMenu.SetActive(false); }

    void GeneralRestartMenu()
    {
        //Debug.Log("Меню перезапуска");
        //soundForRestart.SetActive(true);
        //generalInterface.SetActive(false);
        soundGameObj.SetActive(false);
        generalMenu.SetActive(false);
        generalRestartMenu.SetActive(true);
        generalPauseMenu.SetActive(false);
        cameraForGame.SetActive(true);
        cameraForMenu.SetActive(false);
        
    }

    void GeneralInterfaceMenu()
    {
        //Debug.Log("Вывод интерфейса");
        generalInterface.SetActive(true);
        generalMenu.SetActive(false);
        generalRestartMenu.SetActive(false);
        generalPauseMenu.SetActive(false);
        cameraForGame.SetActive(true);
        cameraForMenu.SetActive(false);
        
    }

    void GeneralPauseMenu()
    {
        //generalInterface.SetActive(false);
        soundGameObj.SetActive(false);
        generalMenu.SetActive(false);
        generalRestartMenu.SetActive(false);
        generalPauseMenu.SetActive(true);
    }
}
