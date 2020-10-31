using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroItems : MonoBehaviour
{
    public GameObject hatArmyRun;
    public GameObject hatGirlRun;
    public GameObject hatHolidayRun;
    public GameObject hatMedicineRun;

    public GameObject hatArmyJump;
    public GameObject hatGirlJump;
    public GameObject hatHolidayJump;
    public GameObject hatMedicineJump;

    public GameObject ballDefault;
    public GameObject ballFirstVersion;
    public GameObject ballSmile;


    // Update is called once per frame
    void Update()
    {
        CheckHatCondition();
        CheckBallCondition();
    }

    void CheckHatCondition()
    {
        switch (Variables.hatCondition)
        {
            case 1:
                hatArmyRun.SetActive(false);
                hatArmyJump.SetActive(false);

                hatGirlRun.SetActive(false);
                hatGirlJump.SetActive(false);

                hatHolidayRun.SetActive(false);
                hatHolidayJump.SetActive(false);

                hatMedicineRun.SetActive(false);
                hatMedicineJump.SetActive(false);
                break;
            case 2:
                hatArmyRun.SetActive(true);
                hatArmyJump.SetActive(true);

                hatGirlRun.SetActive(false);
                hatGirlJump.SetActive(false);

                hatHolidayRun.SetActive(false);
                hatHolidayJump.SetActive(false);

                hatMedicineRun.SetActive(false);
                hatMedicineJump.SetActive(false);
                break;

            case 3:
                hatArmyRun.SetActive(false);
                hatArmyJump.SetActive(false);

                hatGirlRun.SetActive(true);
                hatGirlJump.SetActive(true);

                hatHolidayRun.SetActive(false);
                hatHolidayJump.SetActive(false);

                hatMedicineRun.SetActive(false);
                hatMedicineJump.SetActive(false);
                break;
            case 4:
                hatArmyRun.SetActive(false);
                hatArmyJump.SetActive(false);

                hatGirlRun.SetActive(false);
                hatGirlJump.SetActive(false);

                hatHolidayRun.SetActive(true);
                hatHolidayJump.SetActive(true);

                hatMedicineRun.SetActive(false);
                hatMedicineJump.SetActive(false);
                break;
            case 5:
                hatArmyRun.SetActive(false);
                hatArmyJump.SetActive(false);

                hatGirlRun.SetActive(false);
                hatGirlJump.SetActive(false);

                hatHolidayRun.SetActive(false);
                hatHolidayJump.SetActive(false);

                hatMedicineRun.SetActive(true);
                hatMedicineJump.SetActive(true);
                break;
        }
    }

    void CheckBallCondition()
    {
        switch (Variables.ballCondition)
        {
            case 1:
                ballDefault.SetActive(true);
                ballFirstVersion.SetActive(false);
                ballSmile.SetActive(false);
                break;
            case 2:
                ballDefault.SetActive(false);
                ballFirstVersion.SetActive(true);
                ballSmile.SetActive(false);
                break;
            case 3:
                ballDefault.SetActive(false);
                ballFirstVersion.SetActive(false);
                ballSmile.SetActive(true);
                break;
        }
    }
}
