using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsListener
{

    public static AdsManager instance; //By creating a public static variable, you can reference it from anywhere in your code
                                       //without needing to pass a reference to an instance of the AdsManager class.
                                       //This can be useful for things like accessing a single instance of a manager or controller object
                                       //such as for managing advertisements.
    string GameID = "5225113";

    private void Awake()
    {
        if (instance == null)
        { 
        
            instance = this;
        
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(GameID);

        Advertisement.AddListener(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        { 
            //ShowAds();  // when you just click
            //ShowRewardedAds(); // reward Ads


        }
        
    }

    //AdsManager.instance.ShowAds(); //Impliment Ads in the moment (gameOver, etc.)


    public void ShowAds()
    {

        if (Advertisement.IsReady("Interstitial_Android"))
        {

            Advertisement.Show("Interstitial_Android");
        
        }
    
    }

    /// <summary>
    /// Reward Ads
    /// </summary>
    public void ShowRewardedAds()
    {
        print("Show Rewarded Ads");

        if (Advertisement.IsReady("Rewarded_Android"))
        {

            Advertisement.Show("Rewarded_Android");

        }

    }

    public void OnUnityAdsReady(string placementId)
    {
       // throw new NotImplementedException();
    }

    public void OnUnityAdsDidError(string message)
    {
       // throw new NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
       // throw new NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        
        

        if(showResult == ShowResult.Finished)
        {
            //Reward the user
            print("Reward the user! Example 5 coin, or extra life");
            GameManager.Instance.RewardUser();
            
        }
        if(showResult == ShowResult.Skipped)
        {
            //Skipped Add
            print("User Skipped Add");

        }

    }
}
