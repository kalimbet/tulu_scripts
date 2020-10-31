using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Text hatDefaultPriceGet;
    public Text hatArmyPriceGet;
    public Text hatGirlPriceGet;
    public Text hatHolidayPriceGet;
    public Text hatMedicinePriceGet;

    public Text hatDefaultConditionGet;
    public Text hatArmyConditionGet;
    public Text hatGirlConditionGet;
    public Text hatHolidayCoditionGet;
    public Text hatMedicineConditionGet;

    public Text ballDefaultPriceGet;
    public Text ballFirstVersionPriceGet;
    public Text ballSmilePriceGet;

    public Text ballDefaultConditionGet;
    public Text ballFirstVersionConditionGet;
    public Text ballSmilePriceConditionGet;

    string gameDollar = " $";
    string gameOwned = "Owned";
    string gameBuy = "Buy";
    string gameSelected = "Selected";
    string gameSelect = "Select";

    void Update()
    {
        ShowHatPrice();
        ShowBallPrice();

        
        ShowHatCondition();
        ShowBallCondition();
        
        checkHatCondition();
        checkBallCondition();

    }

    void ShowHatCondition()
    {
        switch (Variables.hatCondition)
        {
            case 1:
                if(Variables.hatDefaultPriceStatus == true) { hatDefaultConditionGet.text = gameSelected; }
                else { hatDefaultConditionGet.text = gameBuy; }
                
                if(Variables.hatArmyPriceStatus == true) { hatArmyConditionGet.text = gameSelect; }
                else { hatArmyConditionGet.text = gameBuy; }

                if(Variables.hatGirlPriceStatus == true) { hatGirlConditionGet.text = gameSelect; }
                else { hatGirlConditionGet.text = gameBuy; }

                if(Variables.hatHolidayPriceStatus == true) { hatHolidayCoditionGet.text = gameSelect; }
                else { hatHolidayCoditionGet.text = gameBuy; }

                if(Variables.hatMedicinePriceStatus == true) { hatMedicineConditionGet.text = gameSelect; }
                else { hatMedicineConditionGet.text = gameBuy; }

                break;
            case 2:
                if (Variables.hatDefaultPriceStatus == true) { hatDefaultConditionGet.text = gameSelect; }
                else { hatDefaultConditionGet.text = gameBuy; }

                if (Variables.hatArmyPriceStatus == true) { hatArmyConditionGet.text = gameSelected; }
                else { hatArmyConditionGet.text = gameBuy; }

                if (Variables.hatGirlPriceStatus == true) { hatGirlConditionGet.text = gameSelect; }
                else { hatGirlConditionGet.text = gameBuy; }

                if (Variables.hatHolidayPriceStatus == true) { hatHolidayCoditionGet.text = gameSelect; }
                else { hatHolidayCoditionGet.text = gameBuy; }

                if (Variables.hatMedicinePriceStatus == true) { hatMedicineConditionGet.text = gameSelect; }
                else { hatMedicineConditionGet.text = gameBuy; }
                break;
            case 3:
                if (Variables.hatDefaultPriceStatus == true) { hatDefaultConditionGet.text = gameSelect; }
                else { hatDefaultConditionGet.text = gameBuy; }

                if (Variables.hatArmyPriceStatus == true) { hatArmyConditionGet.text = gameSelect; }
                else { hatArmyConditionGet.text = gameBuy; }

                if (Variables.hatGirlPriceStatus == true) { hatGirlConditionGet.text = gameSelected; }
                else { hatGirlConditionGet.text = gameBuy; }

                if (Variables.hatHolidayPriceStatus == true) { hatHolidayCoditionGet.text = gameSelect; }
                else { hatHolidayCoditionGet.text = gameBuy; }

                if (Variables.hatMedicinePriceStatus == true) { hatMedicineConditionGet.text = gameSelect; }
                else { hatMedicineConditionGet.text = gameBuy; }
                break;
            case 4:
                if (Variables.hatDefaultPriceStatus == true) { hatDefaultConditionGet.text = gameSelect; }
                else { hatDefaultConditionGet.text = gameBuy; }

                if (Variables.hatArmyPriceStatus == true) { hatArmyConditionGet.text = gameSelect; }
                else { hatArmyConditionGet.text = gameBuy; }

                if (Variables.hatGirlPriceStatus == true) { hatGirlConditionGet.text = gameSelect; }
                else { hatGirlConditionGet.text = gameBuy; }

                if (Variables.hatHolidayPriceStatus == true) { hatHolidayCoditionGet.text = gameSelected; }
                else { hatHolidayCoditionGet.text = gameBuy; }

                if (Variables.hatMedicinePriceStatus == true) { hatMedicineConditionGet.text = gameSelect; }
                else { hatMedicineConditionGet.text = gameBuy; }
                break;
            case 5:
                if (Variables.hatDefaultPriceStatus == true) { hatDefaultConditionGet.text = gameSelect; }
                else { hatDefaultConditionGet.text = gameBuy; }

                if (Variables.hatArmyPriceStatus == true) { hatArmyConditionGet.text = gameSelect; }
                else { hatArmyConditionGet.text = gameBuy; }

                if (Variables.hatGirlPriceStatus == true) { hatGirlConditionGet.text = gameSelect; }
                else { hatGirlConditionGet.text = gameBuy; }

                if (Variables.hatHolidayPriceStatus == true) { hatHolidayCoditionGet.text = gameSelect; }
                else { hatHolidayCoditionGet.text = gameBuy; }

                if (Variables.hatMedicinePriceStatus == true) { hatMedicineConditionGet.text = gameSelected; }
                else { hatMedicineConditionGet.text = gameBuy; }
                break;
        }
    }

    void ShowBallCondition()
    {
        switch (Variables.ballCondition)
        {
            case 1:
                if(Variables.ballDefaultPriceStatus == true) { ballDefaultConditionGet.text = gameSelected; }
                else { ballDefaultConditionGet.text = gameBuy; }

                if(Variables.ballFirstVersionPriceStatus == true) { ballFirstVersionConditionGet.text = gameSelect; }
                else { ballFirstVersionConditionGet.text = gameBuy; }

                if(Variables.ballSmilePriceStatus == true) { ballSmilePriceConditionGet.text = gameSelect; }
                else { ballSmilePriceConditionGet.text = gameBuy; }

                break;
            case 2:
                if (Variables.ballDefaultPriceStatus == true) { ballDefaultConditionGet.text = gameSelect; }
                else { ballDefaultConditionGet.text = gameBuy; }

                if (Variables.ballFirstVersionPriceStatus == true) { ballFirstVersionConditionGet.text = gameSelected; }
                else { ballFirstVersionConditionGet.text = gameBuy; }

                if (Variables.ballSmilePriceStatus == true) { ballSmilePriceConditionGet.text = gameSelect; }
                else { ballSmilePriceConditionGet.text = gameBuy; }

                break;
            case 3:
                if (Variables.ballDefaultPriceStatus == true) { ballDefaultConditionGet.text = gameSelect; }
                else { ballDefaultConditionGet.text = gameBuy; }

                if (Variables.ballFirstVersionPriceStatus == true) { ballFirstVersionConditionGet.text = gameSelect; }
                else { ballFirstVersionConditionGet.text = gameBuy; }

                if (Variables.ballSmilePriceStatus == true) { ballSmilePriceConditionGet.text = gameSelected; }
                else { ballSmilePriceConditionGet.text = gameBuy; }

                break;
        }
    }

    void ShowHatPrice()
    {
        if(Variables.hatDefaultPriceStatus == true) { hatDefaultPriceGet.text = gameOwned; }
        else { hatDefaultPriceGet.text = Variables.hatDefaultPriceNumber.ToString() + gameDollar; }
        
        if(Variables.hatArmyPriceStatus == true) { hatArmyPriceGet.text = gameOwned; }
        else { hatArmyPriceGet.text = Variables.hatArmyPriceNumber.ToString() + gameDollar; }

        if(Variables.hatGirlPriceStatus == true) { hatGirlPriceGet.text = gameOwned; }
        else { hatGirlPriceGet.text = Variables.hatGirlPriceNumber.ToString() + gameDollar; }
        
        if(Variables.hatHolidayPriceStatus == true) { hatHolidayPriceGet.text = gameOwned; }
        else { hatHolidayPriceGet.text = Variables.hatHolidayPriceNumber.ToString() + gameDollar; }
        
        if(Variables.hatMedicinePriceStatus == true) { hatMedicinePriceGet.text = gameOwned; }
        else { hatMedicinePriceGet.text = Variables.hatMedicinePriceNumber.ToString() + gameDollar; }
    }

    void ShowBallPrice()
    {
        if(Variables.ballDefaultPriceStatus == true) { ballDefaultPriceGet.text = gameOwned; }
        else { ballDefaultPriceGet.text = Variables.ballDefaultPriceNumber.ToString() + gameDollar; }

        if(Variables.ballFirstVersionPriceStatus == true) { ballFirstVersionPriceGet.text = gameOwned; }
        else { ballFirstVersionPriceGet.text = Variables.ballFirstVersionPriceNumber.ToString() + gameDollar; }

        if(Variables.ballSmilePriceStatus == true) { ballSmilePriceGet.text = gameOwned; }
        else { ballSmilePriceGet.text = Variables.ballSmilePriceNumber.ToString() + gameDollar; }

    }

    void checkHatCondition()
    {
        switch (Variables.hatCondition)
        {
            case 1:
                Variables.hatDefault = true;
                Variables.hatArmy = false;
                Variables.hatGirl = false;
                Variables.hatHoliday = false;
                Variables.hatMedicine = false;
                break;
            case 2:
                Variables.hatDefault = false;
                Variables.hatArmy = true;
                Variables.hatGirl = false;
                Variables.hatHoliday = false;
                Variables.hatMedicine = false;
                break;
            case 3:
                Variables.hatDefault = false;
                Variables.hatArmy = false;
                Variables.hatGirl = true;
                Variables.hatHoliday = false;
                Variables.hatMedicine = false;
                break;
            case 4:
                Variables.hatDefault = false;
                Variables.hatArmy = false;
                Variables.hatGirl = false;
                Variables.hatHoliday = true;
                Variables.hatMedicine = false;
                break;
            case 5:
                Variables.hatDefault = false;
                Variables.hatArmy = false;
                Variables.hatGirl = false;
                Variables.hatHoliday = false;
                Variables.hatMedicine = true;
                break;
        }
    }

    void checkBallCondition()
    {
        switch (Variables.ballCondition)
        {
            case 1:
                Variables.ballDefault = true;
                Variables.ballFirstVersion = false;
                Variables.ballSmile = false;
                break;
            case 2:
                Variables.ballDefault = false;
                Variables.ballFirstVersion = true;
                Variables.ballSmile = false;
                break;
            case 3:
                Variables.ballDefault = false;
                Variables.ballFirstVersion = false;
                Variables.ballSmile = true;
                break;
        }
    }
}
