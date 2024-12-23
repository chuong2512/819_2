using UnityEngine;
using UnityEngine.Advertisements;

public class UnityRewardedAd : MonoBehaviour
{
    private string _adUnitId;

    public string AdUnitID { set { _adUnitId = value; } }

    public bool IsRewardedAdLoaded { get; private set; }

    public void LoadAd()
    {
       
    }

    public void ShowAd()
    {
       
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        IsRewardedAdLoaded = true;
    }

  
  
}
