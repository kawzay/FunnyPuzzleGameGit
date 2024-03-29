using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class BiomLevels : MonoBehaviour
{
    public Button lvl1;
    public Button lvl2;
    public Button lvl3;
    public Button lvl4;
    public int startIndex;
    public Sprite lockLevel;
    public Sprite unlock;
    public Sprite resolvedLevel1;
    public Sprite resolvedLevel2;
    public Sprite resolvedLevel3;
    public Sprite resolvedLevel4;
    string levelComplete;



    void Start()
    {
        lvl2.interactable = false;
        lvl3.interactable = false;
        lvl4.interactable = false;

        lvl1.image.sprite = unlock;
        lvl2.image.sprite = lockLevel;
        lvl3.image.sprite = lockLevel;
        lvl4.image.sprite = lockLevel;

        levelComplete = PlayerPrefs.GetString("LevelComplete");
        //PlayerPrefs.SetString("LevelComplete", ""); //������� ��������
        string[] levelCompleteArr = levelComplete.Split(new char[] { ' ' });


        if (levelCompleteArr.Contains((4 + startIndex).ToString()))
        {
            lvl2.interactable = true;
            lvl3.interactable = true;
            lvl4.interactable = true;
       
            lvl1.image.sprite = resolvedLevel1;
            lvl2.image.sprite = resolvedLevel2;
            lvl3.image.sprite = resolvedLevel3;
            lvl4.image.sprite = resolvedLevel4;
        }

        else if (levelCompleteArr.Contains((3 + startIndex).ToString()))
        {
            lvl2.interactable = true;
            lvl3.interactable = true;
            lvl4.interactable = true;

            lvl1.image.sprite = resolvedLevel1;
            lvl2.image.sprite = resolvedLevel2;
            lvl3.image.sprite = resolvedLevel3;
            lvl4.image.sprite = unlock;
        }

        else if (levelCompleteArr.Contains((2 + startIndex).ToString()))
        {
            lvl2.interactable = true;
            lvl3.interactable = true;

            lvl1.image.sprite = resolvedLevel1;
            lvl2.image.sprite = resolvedLevel2;
            lvl3.image.sprite = unlock;
            lvl4.image.sprite = lockLevel;
        }

        else if (levelCompleteArr.Contains((1 + startIndex).ToString()))
        {
            lvl2.interactable = true;

            lvl1.image.sprite = resolvedLevel1;
            lvl2.image.sprite = unlock;
            lvl3.image.sprite = lockLevel;
            lvl4.image.sprite = lockLevel;
        }

    }
}

