using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class ManagerAds : MonoBehaviour, IUnityAdsListener
{
    public string playStoreID = "";
    public string appStoreID = "";
    

    public string rewardedVideoAd = "rewardedVideo";
    public string interstitialAd = "video";

    public bool isTargetPlayStore;
    public bool isTestAd;
    
    public static bool state = true;
    public static bool stateForReward = true;
    public static bool soundCoin = false;
    private void Start()
    {
        if(state == true) { Advertisement.AddListener(this); InitializeAdvertisment(); state = false; }
    }

    private void InitializeAdvertisment()
    {
        if (isTargetPlayStore) { Advertisement.Initialize(playStoreID, isTestAd); return; }
        Advertisement.Initialize(appStoreID, isTestAd);
    }
    public void PlayInterstitialAd()
    {
        if (!Advertisement.IsReady(interstitialAd)) { return; }
        Advertisement.Show(interstitialAd);

    }

    public void PlayRewardedVideoAd()
    {
        if (!Advertisement.IsReady(rewardedVideoAd)) { return; }
        Advertisement.Show(rewardedVideoAd);      
    }


    public void OnUnityAdsReady(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidError(string message)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        switch (showResult)
        {
            case ShowResult.Failed:
                break;
            case ShowResult.Skipped:
                Variables.numberForAds++;
                break;
            case ShowResult.Finished:
                if (stateForReward == true)
                {
                    if (placementId == rewardedVideoAd) { Variables.coins += Variables.coinsForReward; soundCoin = true; LoadSave.condition = true; LoadSave.conditionForSave = true; }
                    if (placementId == interstitialAd) { }
                    Variables.numberForAds++;
                    stateForReward = false;
                }
                
                
                break;
        }
    }
}
