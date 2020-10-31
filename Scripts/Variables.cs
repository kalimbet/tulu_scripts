using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public static bool inGame = false;
    public static int menuStatus = 1;
    public static bool isLife = false;
    public static bool soundMusic = true;
    public static bool soundSfx = true;
    public static float speedLevel = 12;
    public static int numberOfDead = 0;
    public static int numberForAds = 0;
    public static int coins = 0;
    public static int coinsMultiply = 1;
    public static int recordDistance = 0;
    public static int coinsForReward = 50;


    // Hat
    public static int hatCondition = 1;

    public static bool hatDefault = true;
    public static bool hatArmy = false;
    public static bool hatGirl = false;
    public static bool hatHoliday = false;
    public static bool hatMedicine = false;

    public static int hatDefaultPriceNumber = 0;
    public static int hatArmyPriceNumber = 700;
    public static int hatGirlPriceNumber = 1300;
    public static int hatHolidayPriceNumber = 1700;
    public static int hatMedicinePriceNumber = 1800;

    public static bool hatDefaultPriceStatus = true;
    public static bool hatArmyPriceStatus = false;
    public static bool hatGirlPriceStatus = false;
    public static bool hatHolidayPriceStatus = false;
    public static bool hatMedicinePriceStatus = false;

    // Ball
    public static int ballCondition = 1;

    public static bool ballDefault = true;
    public static bool ballFirstVersion = false;
    public static bool ballSmile = false;

    public static int ballDefaultPriceNumber = 0;
    public static int ballFirstVersionPriceNumber = 1700;
    public static int ballSmilePriceNumber = 2100;

    public static bool ballDefaultPriceStatus = true;
    public static bool ballFirstVersionPriceStatus = false;
    public static bool ballSmilePriceStatus = false;
}
