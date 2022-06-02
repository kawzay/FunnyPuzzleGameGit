using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundVolControl : MonoBehaviour
{


    public Sprite S2;
    public Sprite S1;
    private Sprite S3;
    //public SpriteRenderer spriteRenderer;

    public bool isOn;

    private void Start()
    {
        isOn = true;
    }

    public void OnOffSound()
    {
        if (!isOn)
        {
            AudioListener.volume = 0.5f;
            isOn = true;
        }
        else
        {
            AudioListener.volume = 0f;
            isOn = false;
        }
    }
    private int i;
    public void OnClick()
    {
        i++;
        if(i%2 == 1)
            GetComponent<Image>().sprite = S2;
        else
            GetComponent<Image>().sprite = S1;




    }
 
}
