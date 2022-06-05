using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePrompt : MonoBehaviour
{
    public GameObject Prompt;
    public GameObject Canvas;

    void Start()
    {
        if (!PlayerPrefs.HasKey("promt"))
        {
            Prompt.SetActive(true);
            Canvas.GetComponent<MainMex>().isPromptShow = true;
        }
    }

    public void Hide()
    {
        Prompt.SetActive(false);
        Canvas.GetComponent<MainMex>().isPromptShow = false;
        PlayerPrefs.SetInt("promt", 1);
    }

}
