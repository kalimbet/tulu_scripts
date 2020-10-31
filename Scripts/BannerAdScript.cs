using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAdScript : MonoBehaviour
{

    public string gameId = "3513636";
    public string placementId = "BannerAds";
    public bool testMode = true;
    public static bool state = true;
    void Start()
    {
        if(state == true)
        {
            Advertisement.Initialize(gameId, testMode);
            Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
            state = false;
        }


    }

    private void Update()
    {
        
        if(Variables.menuStatus == 0 || Variables.menuStatus == 2 || Variables.menuStatus == 4)
        {
            Advertisement.Banner.Show(placementId);
        }       
        else
        {
            Advertisement.Banner.Hide();
        }
    }
}