using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopLogic : MonoBehaviour
{
    public string hatDefaultButton = "HatDefault";
    public string hatArmyButton = "HatArmy";
    public string hatGirlButton = "HatGirl";
    public string hatHolidayButton = "HatHoliday";
    public string hatMedicineButton = "HatMedicine";

    public string ballDefaultButton = "BallDefault";
    public string ballFirstVersionButton = "BallFirstVersion";
    public string ballSmileButton = "BallSmile";

    public AudioSource casaSound;
    public AudioSource casaOldSound;


    // Update is called once per frame
    void Update()
    {
        CheckHatButton();
        CheckBallButton();
    }
    void CheckHatButton()
    {
        if (SimpleInput.GetButtonUp(hatDefaultButton) && Variables.hatDefaultPriceStatus == true)
        {
            Variables.hatCondition = 1;
        }else if(SimpleInput.GetButtonUp(hatDefaultButton) && Variables.hatDefaultPriceStatus == false)
        {
            Variables.hatDefaultPriceStatus = BuyItem(Variables.hatDefaultPriceNumber);
        }

        if (SimpleInput.GetButtonUp(hatArmyButton) && Variables.hatArmyPriceStatus == true)
        {
            Variables.hatCondition = 2;
        }else if(SimpleInput.GetButtonUp(hatArmyButton) && Variables.hatArmyPriceStatus == false)
        {
            Variables.hatArmyPriceStatus = BuyItem(Variables.hatArmyPriceNumber);
        }

        if (SimpleInput.GetButtonUp(hatGirlButton) && Variables.hatGirlPriceStatus == true)
        {
            Variables.hatCondition = 3;
        }else if(SimpleInput.GetButtonUp(hatGirlButton) && Variables.hatGirlPriceStatus == false)
        {
            Variables.hatGirlPriceStatus = BuyItem(Variables.hatGirlPriceNumber);
        }

        if (SimpleInput.GetButtonUp(hatHolidayButton) && Variables.hatHolidayPriceStatus == true)
        {
            Variables.hatCondition = 4;
        }else if(SimpleInput.GetButtonUp(hatHolidayButton) && Variables.hatHolidayPriceStatus == false)
        {
            Variables.hatHolidayPriceStatus = BuyItem(Variables.hatHolidayPriceNumber);
        }

        if(SimpleInput.GetButtonUp(hatMedicineButton) && Variables.hatMedicinePriceStatus == true)
        {
            Variables.hatCondition = 5;
        }else if (SimpleInput.GetButtonUp(hatMedicineButton) && Variables.hatMedicinePriceStatus == false)
        {
            Variables.hatMedicinePriceStatus = BuyItem(Variables.hatMedicinePriceNumber);
        }
    }

    void CheckBallButton()
    {
        if (SimpleInput.GetButtonUp(ballDefaultButton) && Variables.ballDefaultPriceStatus == true)
        {
            Variables.ballCondition = 1;
        }else if(SimpleInput.GetButtonUp(ballDefaultButton) && Variables.ballDefaultPriceStatus == false)
        {
            Variables.ballDefaultPriceStatus = BuyItem(Variables.ballDefaultPriceNumber);
        }

        if (SimpleInput.GetButtonUp(ballFirstVersionButton) && Variables.ballFirstVersionPriceStatus == true)
        {
            Variables.ballCondition = 2;
        }else if(SimpleInput.GetButtonUp(ballFirstVersionButton) && Variables.ballFirstVersionPriceStatus == false)
        {
            Variables.ballFirstVersionPriceStatus = BuyItem(Variables.ballFirstVersionPriceNumber);
        }
        if (SimpleInput.GetButtonUp(ballSmileButton) && Variables.ballSmilePriceStatus == true)
        {
            Variables.ballCondition = 3;
        }else if(SimpleInput.GetButtonUp(ballSmileButton) && Variables.ballSmilePriceStatus == false)
        {
            Variables.ballSmilePriceStatus = BuyItem(Variables.ballSmilePriceNumber);
        }
    }

    bool BuyItem(int price)
    {
        if(0 <= Variables.coins - price)
        {
            if (Variables.soundSfx == true) casaOldSound.Play();
            Variables.coins -= price;
            LoadSave.conditionForSave = true;
            return true;
        }
        else return false;


    }
}
