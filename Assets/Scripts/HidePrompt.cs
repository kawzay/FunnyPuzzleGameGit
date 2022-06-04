using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePrompt : MonoBehaviour
{
    public GameObject Prompt;
    public GameObject Canvas;

    void Start()
    {
        Canvas.GetComponent<MainMex>().isPromptShow = true;
    }

    public void Hide()
    {
        Prompt.SetActive(false);
        Canvas.GetComponent<MainMex>().isPromptShow = false;
    }

}
