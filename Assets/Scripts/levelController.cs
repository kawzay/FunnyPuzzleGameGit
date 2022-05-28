using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelController : MonoBehaviour
{

    public static levelController instance = null;
    int sceneIndex;
    int levelComplete;


    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
    }

    public void isEndGame()
    {
        if (sceneIndex == 4)
        {
            Invoke("LoadForestMenu", 1f);
        }
        else
        {
            if (levelComplete < sceneIndex)
                PlayerPrefs.SetInt("LevelComplete", sceneIndex);
            Invoke("NextLevel", 1f);
        }
    }

    public void Win()
    {
        PlayerPrefs.SetInt("LevelComplete", sceneIndex);
    }

    public void NextLevel()
    {
        if (PlayerPrefs.GetInt("LevelComplete") >= sceneIndex)
            SceneManager.LoadScene(sceneIndex + 1);
    }

    public void LoadForestMenu()
    {
        SceneManager.LoadScene("BiomForestLevels");
    }
}
