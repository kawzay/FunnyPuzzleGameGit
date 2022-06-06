using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class chaptersÑontroller : MonoBehaviour
{
    public Button chp1;
    public Button chp2;
    public GameObject star2;
    public TMP_Text textRef2;
    public Button chp3;
    public TMP_Text textRef3;
    public GameObject star3;
    public Button chp4;
    public TMP_Text textRef4;
    public GameObject star4;

    void Start()
    {
        var totalStars = int.Parse(GetStars.GetTotal());
        chp2.interactable = false;
        chp3.interactable = false;
        chp4.interactable = false;


        textRef2.text = "10";
        textRef3.text = "20";
        textRef4.text = "30";

        if (totalStars >= 10)
        {
            textRef2.text = "Îêåàí";
            star2.SetActive(false);
            chp2.interactable = true;
        }
        if (totalStars >= 20)
        {
            textRef3.text = "Ïóñòûíÿ";
            star3.SetActive(false);
            chp3.interactable = true;
        }
        if (totalStars >= 30)
        {
            textRef4.text = "Ñåâåğíûé ïîëşñ";
            star4.SetActive(false);
            chp4.interactable = true;
        }
 
    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }
}

