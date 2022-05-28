using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BiomLevels : MonoBehaviour
{
    public Button lvl1;
    public Button lvl2;
    public Button lvl3;
    public Button lvl4;
    public int startIndex;
    public Sprite unlock;
    public Sprite resolvedLevel1;
    public Sprite resolvedLevel2;
    public Sprite resolvedLevel3;
    public Sprite resolvedLevel4;
    int levelComplete;
    bool isCompleted = false;



    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");

        var cc = lvl2.image.color;
        if (!isCompleted)
        {
            lvl2.interactable = false;
            lvl3.interactable = false;
            lvl4.interactable = false;

            cc = lvl2.image.color;
            cc.a = 0f;
            lvl2.image.color = cc;
            cc = lvl3.image.color;
            cc.a = 0f;
            lvl3.image.color = cc;
            cc = lvl4.image.color;
            cc.a = 0f;
            lvl4.image.color = cc;
        }

        if (levelComplete == 1 + startIndex)
        {
            lvl2.interactable = true;

            cc = lvl2.image.color;
            cc.a = 1f;
            lvl2.image.color = cc;

            lvl1.image.sprite = resolvedLevel1;
            lvl2.image.sprite = unlock;
        }
        if (levelComplete == 2 + startIndex)
        {
            lvl2.interactable = true;
            lvl3.interactable = true;

            cc = lvl2.image.color;
            cc.a = 1f;
            lvl2.image.color = cc;

            cc = lvl3.image.color;
            cc.a = 1f;
            lvl3.image.color = cc;

            lvl1.image.sprite = resolvedLevel1;
            lvl2.image.sprite = resolvedLevel2;
            lvl3.image.sprite = unlock;
        }
        if (levelComplete == 3 + startIndex)
        {
            lvl2.interactable = true;
            lvl3.interactable = true;
            lvl4.interactable = true;

            cc = lvl2.image.color;
            cc.a = 1f;
            lvl2.image.color = cc;

            cc = lvl3.image.color;
            cc.a = 1f;
            lvl3.image.color = cc;

            cc = lvl4.image.color;
            cc.a = 1f;
            lvl4.image.color = cc;

            lvl1.image.sprite = resolvedLevel1;
            lvl2.image.sprite = resolvedLevel2;
            lvl3.image.sprite = resolvedLevel3;
            lvl4.image.sprite = unlock;
        }
        if (levelComplete >= 4 + startIndex)
        {
            isCompleted = true;
            lvl2.interactable = true;
            lvl3.interactable = true;
            lvl4.interactable = true;

            cc = lvl2.image.color;
            cc.a = 1f;
            lvl2.image.color = cc;

            cc = lvl3.image.color;
            cc.a = 1f;
            lvl3.image.color = cc;

            cc = lvl4.image.color;
            cc.a = 1f;
            lvl4.image.color = cc;

            lvl1.image.sprite = resolvedLevel1;
            lvl2.image.sprite = resolvedLevel2;
            lvl3.image.sprite = resolvedLevel3;
            lvl4.image.sprite = resolvedLevel4;
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

