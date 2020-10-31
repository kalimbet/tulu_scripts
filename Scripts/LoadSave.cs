using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadSave : MonoBehaviour
{
    private Save sv = new Save();
    private string path;
    public static bool conditionForSave = false;
    public byte deviceStatus = 2;
    public static bool condition = true;
    //public static bool condition = true;


    // Start is called before the first frame update
    void Start()
    {
        
        if (deviceStatus == 1) { path = Path.Combine(Application.persistentDataPath, "Save.json"); }
        else if(deviceStatus == 2) { path = Path.Combine(Application.dataPath, "Save.json"); }

        if (File.Exists(path)) { sv = JsonUtility.FromJson<Save>(File.ReadAllText(path)); }
        else Debug.Log("Path dosnt exists");
    }

    private void Update()
    {
        if (Variables.menuStatus == 1 && conditionForSave == false)
        {
            if (File.Exists(path))
            {
                LoadItems();
                LoadCoins();
                LoadRecordDistance();
                //conditionForSave = true;
            }
            else SaveItemsFromGame();

        } else if (Variables.menuStatus == 1 && conditionForSave == true)
        {
            SaveCoinsFromGame();
            SaveItemsFromGame();
            SaveFile();
            conditionForSave = false;
        }
        else if (Variables.menuStatus == 0 && condition == true)
        {
            SaveRecordDistance();
            SaveCoinsFromGame();
            SaveItemsFromGame();
            SaveFile();
            condition = false;
        }
        
    }
    public void SaveCoinsFromGame()
    {
        sv.coinsInFile = Variables.coins;

    }

    public void SaveRecordDistance()
    {
        sv.recordDistance = Variables.recordDistance;
    }

    public void SaveItemsFromGame()
    {
        sv.hatCondition = Variables.hatCondition;
        sv.hatDefaultPriceStatus = Variables.hatDefaultPriceStatus;
        sv.hatArmyPriceStatus = Variables.hatArmyPriceStatus;
        sv.hatGirlPriceStatus = Variables.hatGirlPriceStatus;
        sv.hatHolidayPriceStatus = Variables.hatHolidayPriceStatus;
        sv.hatMedicinePriceStatus = Variables.hatMedicinePriceStatus;

        sv.ballCondition = Variables.ballCondition;
        sv.ballDefaultPriceStatus = Variables.ballDefaultPriceStatus;
        sv.ballFirstVersionPriceStatus = Variables.ballFirstVersionPriceStatus;
        sv.ballSmilePriceStatus = Variables.ballSmilePriceStatus;
    }

    public void LoadCoins() { Variables.coins = sv.coinsInFile; }

    public void LoadItems()
    {
        Variables.hatCondition = sv.hatCondition;
        Variables.hatDefaultPriceStatus = sv.hatDefaultPriceStatus;
        Variables.hatArmyPriceStatus = sv.hatArmyPriceStatus;
        Variables.hatGirlPriceStatus = sv.hatGirlPriceStatus;
        Variables.hatHolidayPriceStatus = sv.hatHolidayPriceStatus;
        Variables.hatMedicinePriceStatus = sv.hatMedicinePriceStatus;

        Variables.ballCondition = sv.ballCondition;
        Variables.ballDefaultPriceStatus = sv.ballDefaultPriceStatus;
        Variables.ballFirstVersionPriceStatus = sv.ballFirstVersionPriceStatus;
        Variables.ballSmilePriceStatus = sv.ballSmilePriceStatus;
    }

    public void LoadRecordDistance() { Variables.recordDistance = sv.recordDistance; }

    public void SaveFile()
    {
        if(deviceStatus == 1) { File.WriteAllText(path, JsonUtility.ToJson(sv));}
        else if(deviceStatus == 2) { File.WriteAllText(path, JsonUtility.ToJson(sv)); }
    }


    [SerializeField]
    public class Save
    {
        public int coinsInFile;
        public int recordDistance = 0;

        public int hatCondition = 1;

        public bool hatDefaultPriceStatus;
        public bool hatArmyPriceStatus;
        public bool hatGirlPriceStatus;
        public bool hatHolidayPriceStatus;
        public bool hatMedicinePriceStatus;

        public int ballCondition = 1;

        public bool ballDefaultPriceStatus;
        public bool ballFirstVersionPriceStatus;
        public bool ballSmilePriceStatus;

    }
}
