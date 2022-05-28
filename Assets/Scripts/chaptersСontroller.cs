using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class chapters—ontroller : MonoBehaviour
{
    public Button chp1;
    public Button chp2;
    public Button chp3;
    public Button chp4;

    void Start()
    {
        var totalStars = int.Parse(GetStars.GetTotal());
        chp2.interactable = false;
        chp3.interactable = false;
        chp4.interactable = false;


        chp2.GetComponentInChildren<Text>().text = "9";
        chp3.GetComponentInChildren<Text>().text = "20";
        chp4.GetComponentInChildren<Text>().text = "30";

        
        if (totalStars > 8)
        {
            chp2.interactable = true;
        }
        else if (totalStars > 19)
        {
            chp3.interactable = true;
        }
        else if (totalStars > 29)
        {
            chp4.interactable = true;
        }
 
    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Reset()
    {
        //lvl2.interactable = false;
        //lvl3.interactable = false;
       // lvl4.interactable = false;
       // PlayerPrefs.DeleteAll();
    }
}

