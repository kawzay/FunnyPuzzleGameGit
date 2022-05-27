using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BiomForestLevels : MonoBehaviour
{
    public Button lvl1;
    public Button lvl2;
    public Button lvl3;
    public Button lvl4;
    public Sprite unlock;
    public Sprite resolvedLevel1;
    int levelComplete;

    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        levelComplete = 2;
        lvl2.interactable = false;
        lvl3.interactable = false;
        lvl4.interactable = false;
        //lvl2.image.color = new Color(0f, 0f, 0f, .0f);
        //lvl3.image.color = new Color(0f, 0f, 0f, .0f);
        //lvl4.image.color = new Color(0f, 0f, 0f, .0f);



        switch (levelComplete)
        {
            case 1:
                lvl2.interactable = true;
                lvl1.image.sprite = resolvedLevel1;
                break;
            case 2:
                lvl2.interactable = true;
                lvl3.interactable = true;
                lvl1.image.sprite = resolvedLevel1;
                //lvl4.image.color = new Color(0f, 0f, 0f, .100f);
                lvl2.image.sprite = resolvedLevel1;
                lvl3.image.sprite = unlock;
                break;
            case 3:
                lvl2.interactable = true;
                lvl3.interactable = true;
                lvl4.interactable = true;
                lvl1.image.sprite = resolvedLevel1;
                lvl2.image.sprite = resolvedLevel1;
                lvl2.image.sprite = resolvedLevel1;
                lvl3.image.sprite = resolvedLevel1;
                lvl4.image.sprite = unlock;
                break;
            case 4:
                lvl2.interactable = true;
                lvl3.interactable = true;
                lvl4.interactable = true;
                lvl1.image.sprite = resolvedLevel1;
                lvl2.image.sprite = resolvedLevel1;
                lvl2.image.sprite = resolvedLevel1;
                lvl3.image.sprite = resolvedLevel1;
                lvl4.image.sprite = resolvedLevel1;
                break;
        }
    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Reset()
    {
        lvl2.interactable = false;
        lvl3.interactable = false;
        lvl4.interactable = false;
        PlayerPrefs.DeleteAll();
    }
}

