using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTags : MonoBehaviour
{

    //private YandexSDK sdk;
    private void Start()
    {
       //sdk = YandexSDK.instance;
       // sdk.onRewardedAdReward += WatchStar;
    }
    public void StartGetting()
    {
        if (PlayerPrefs.HasKey("flag"))
        {
            if (PlayerPrefs.GetInt("flag") == 1)
            {
                PlayerPrefs.SetInt("TotalStar", 0);
                PlayerPrefs.SetInt("St1", 0);
                PlayerPrefs.SetInt("St2", 0);
                PlayerPrefs.SetInt("St3", 0);
                PlayerPrefs.SetInt("St4", 0);
                PlayerPrefs.SetInt("St5", 0);
                PlayerPrefs.SetInt("St6", 0);
                PlayerPrefs.SetInt("St7", 0);
                PlayerPrefs.SetInt("St8", 0);
                PlayerPrefs.SetInt("St9", 0);
                PlayerPrefs.SetInt("St10", 0);
                PlayerPrefs.SetInt("St11", 0);
                PlayerPrefs.SetInt("St12", 0);
                PlayerPrefs.SetInt("St13", 0);
                PlayerPrefs.SetInt("St14", 0);
                PlayerPrefs.SetInt("St15", 0);
                PlayerPrefs.SetInt("St16", 0);
                PlayerPrefs.SetInt("flag", 0);
            }
        }
        else
            PlayerPrefs.SetInt("flag", 1);
    }

    public void WatchStar(string str)
    {
        //if (str == "star")
        //{
            PlayerPrefs.SetInt("TotalStar", PlayerPrefs.GetInt("TotalStar") + 1);
        //}
    }
}