using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrowStars : MonoBehaviour
{
    public  int first;
    public  int sec;
    public  int thir;
    public  int four;
    public int five;
    public int six;

    public  GameObject Z11;
    public  GameObject Z12;
    public  GameObject Z13;
    public  GameObject Z21;
    public  GameObject Z22;
    public  GameObject Z23;
    public  GameObject Z31;
    public  GameObject Z32;
    public  GameObject Z33;
    public  GameObject Z41;
    public  GameObject Z42;
    public  GameObject Z43;
    public GameObject Z51;
    public GameObject Z52;
    public GameObject Z53;
    public GameObject Z61;
    public GameObject Z62;
    public GameObject Z63;
    private static Vector4 Color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);

    private void Start()
    {
        Z11.SetActive(false);
        Z12.SetActive(false);
        Z13.SetActive(false);
        Z21.SetActive(false);
        Z22.SetActive(false);
        Z23.SetActive(false);
        Z31.SetActive(false);
        Z32.SetActive(false);
        Z33.SetActive(false);
        Z41.SetActive(false);
        Z42.SetActive(false);
        Z43.SetActive(false);
        Z51.SetActive(false);
        Z52.SetActive(false);
        Z53.SetActive(false);
        Z61.SetActive(false);
        Z62.SetActive(false);
        Z63.SetActive(false);

    }
    void Update()
    {
            if(first == 1)
            {
                var q = PlayerPrefs.GetInt("St1");
                Z11.SetActive(true);
                Z12.SetActive(true);
                Z13.SetActive(true);
                if (q == 1)
                    Z11.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z11.GetComponent<Image>().color = Color;
                    Z12.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z11.GetComponent<Image>().color = Color;
                    Z12.GetComponent<Image>().color = Color;
                    Z13.GetComponent<Image>().color = Color;
                }
            }
            if(first == 7)
            {
                var q = PlayerPrefs.GetInt("St7");
                Z11.SetActive(true);
                Z12.SetActive(true);
                Z13.SetActive(true);
                if (q == 1)
                    Z11.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z11.GetComponent<Image>().color = Color;
                    Z12.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z11.GetComponent<Image>().color = Color;
                    Z12.GetComponent<Image>().color = Color;
                    Z13.GetComponent<Image>().color = Color;
                }
            }
            if (first == 13)
            {
                var q = PlayerPrefs.GetInt("St13");
                Z11.SetActive(true);
                Z12.SetActive(true);
                Z13.SetActive(true);
                if (q == 1)
                    Z11.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z11.GetComponent<Image>().color = Color;
                    Z12.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z11.GetComponent<Image>().color = Color;
                    Z12.GetComponent<Image>().color = Color;
                    Z13.GetComponent<Image>().color = Color;
                }
            }
            if (first == 19)
            {
                var q = PlayerPrefs.GetInt("St19");
                Z11.SetActive(true);
                Z12.SetActive(true);
                Z13.SetActive(true);
                if (q == 1)
                    Z11.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z11.GetComponent<Image>().color = Color;
                    Z12.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z11.GetComponent<Image>().color = Color;
                    Z12.GetComponent<Image>().color = Color;
                    Z13.GetComponent<Image>().color = Color;
                }
            }
            if (sec == 2)
            {
                var q = PlayerPrefs.GetInt("St2");
                Z21.SetActive(true);
                Z22.SetActive(true);
                Z23.SetActive(true);
                if (q == 1)
                    Z21.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z21.GetComponent<Image>().color = Color;
                    Z22.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z21.GetComponent<Image>().color = Color;
                    Z22.GetComponent<Image>().color = Color;
                    Z23.GetComponent<Image>().color = Color;
                }
            }
            if (sec == 8)
            {
                var q = PlayerPrefs.GetInt("St8");
                Z21.SetActive(true);
                Z22.SetActive(true);
                Z23.SetActive(true);
                if (q == 1)
                    Z21.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z21.GetComponent<Image>().color = Color;
                    Z22.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z21.GetComponent<Image>().color = Color;
                    Z22.GetComponent<Image>().color = Color;
                    Z23.GetComponent<Image>().color = Color;
                }
            }
            if (sec == 14)
            {
                var q = PlayerPrefs.GetInt("St14");
                Z21.SetActive(true);
                Z22.SetActive(true);
                Z23.SetActive(true);
                if (q == 1)
                    Z21.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z21.GetComponent<Image>().color = Color;
                    Z22.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z21.GetComponent<Image>().color = Color;
                    Z22.GetComponent<Image>().color = Color;
                    Z23.GetComponent<Image>().color = Color;
                }
            }
            if (sec == 20)
            {
                var q = PlayerPrefs.GetInt("St20");
                Z21.SetActive(true);
                Z22.SetActive(true);
                Z23.SetActive(true);
                if (q == 1)
                    Z21.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z21.GetComponent<Image>().color = Color;
                    Z22.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z21.GetComponent<Image>().color = Color;
                    Z22.GetComponent<Image>().color = Color;
                    Z23.GetComponent<Image>().color = Color;
                }
            }
            if (thir == 3)
            {
                var q = PlayerPrefs.GetInt("St3");
                Z31.SetActive(true);
                Z32.SetActive(true);
                Z33.SetActive(true);
                if (q == 1)
                    Z31.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z31.GetComponent<Image>().color = Color;
                    Z32.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z31.GetComponent<Image>().color = Color;
                    Z32.GetComponent<Image>().color = Color;
                    Z33.GetComponent<Image>().color = Color;
                }
            }
            if (thir == 9)
            {
                var q = PlayerPrefs.GetInt("St9");
                Z31.SetActive(true);
                Z32.SetActive(true);
                Z33.SetActive(true);
                if (q == 1)
                    Z31.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z31.GetComponent<Image>().color = Color;
                    Z32.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z31.GetComponent<Image>().color = Color;
                    Z32.GetComponent<Image>().color = Color;
                    Z33.GetComponent<Image>().color = Color;
                }
            }
            if (thir == 15)
            {
                var q = PlayerPrefs.GetInt("St15");
                Z31.SetActive(true);
                Z32.SetActive(true);
                Z33.SetActive(true);
                if (q == 1)
                    Z31.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z31.GetComponent<Image>().color = Color;
                    Z32.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z31.GetComponent<Image>().color = Color;
                    Z32.GetComponent<Image>().color = Color;
                    Z33.GetComponent<Image>().color = Color;
                }
            }
            if (thir == 21)
            {
                var q = PlayerPrefs.GetInt("St21");
                Z31.SetActive(true);
                Z32.SetActive(true);
                Z33.SetActive(true);
                if (q == 1)
                    Z31.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z31.GetComponent<Image>().color = Color;
                    Z32.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z31.GetComponent<Image>().color = Color;
                    Z32.GetComponent<Image>().color = Color;
                    Z33.GetComponent<Image>().color = Color;
                }
            }
            if (four == 4)
            {
                var q = PlayerPrefs.GetInt("St4");
                Z41.SetActive(true);
                Z42.SetActive(true);
                Z43.SetActive(true);
                if (q == 1)
                    Z41.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z41.GetComponent<Image>().color = Color;
                    Z42.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z41.GetComponent<Image>().color = Color;
                    Z42.GetComponent<Image>().color = Color;
                    Z43.GetComponent<Image>().color = Color;
                }
            }
            if (four == 10)
            {
                var q = PlayerPrefs.GetInt("St10");
                Z41.SetActive(true);
                Z42.SetActive(true);
                Z43.SetActive(true);
                if (q == 1)
                    Z41.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z41.GetComponent<Image>().color = Color;
                    Z42.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z41.GetComponent<Image>().color = Color;
                    Z42.GetComponent<Image>().color = Color;
                    Z43.GetComponent<Image>().color = Color;
                }
            }
            if (four == 16)
            {
                var q = PlayerPrefs.GetInt("St16");
                Z41.SetActive(true);
                Z42.SetActive(true);
                Z43.SetActive(true);
                if (q == 1)
                    Z41.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z41.GetComponent<Image>().color = Color;
                    Z42.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z41.GetComponent<Image>().color = Color;
                    Z42.GetComponent<Image>().color = Color;
                    Z43.GetComponent<Image>().color = Color;
                }
            }
            if (four == 22)
            {
                var q = PlayerPrefs.GetInt("St22");
                Z41.SetActive(true);
                Z42.SetActive(true);
                Z43.SetActive(true);
                if (q == 1)
                    Z41.GetComponent<Image>().color = Color;
                if (q == 2)
                {
                    Z41.GetComponent<Image>().color = Color;
                    Z42.GetComponent<Image>().color = Color;
                }
                if (q == 3)
                {
                    Z41.GetComponent<Image>().color = Color;
                    Z42.GetComponent<Image>().color = Color;
                    Z43.GetComponent<Image>().color = Color;
                }
            }
        if (five == 5)
        {
            var q = PlayerPrefs.GetInt("St5");
            Z51.SetActive(true);
            Z52.SetActive(true);
            Z53.SetActive(true);
            if (q == 1)
                Z51.GetComponent<Image>().color = Color;
            if (q == 2)
            {
                Z51.GetComponent<Image>().color = Color;
                Z52.GetComponent<Image>().color = Color;
            }
            if (q == 3)
            {
                Z51.GetComponent<Image>().color = Color;
                Z52.GetComponent<Image>().color = Color;
                Z53.GetComponent<Image>().color = Color;
            }
        }
        if (five == 11)
        {
            var q = PlayerPrefs.GetInt("St11");
            Z51.SetActive(true);
            Z52.SetActive(true);
            Z53.SetActive(true);
            if (q == 1)
                Z51.GetComponent<Image>().color = Color;
            if (q == 2)
            {
                Z51.GetComponent<Image>().color = Color;
                Z52.GetComponent<Image>().color = Color;
            }
            if (q == 3)
            {
                Z51.GetComponent<Image>().color = Color;
                Z52.GetComponent<Image>().color = Color;
                Z53.GetComponent<Image>().color = Color;
            }
        }
        if (five == 17)
        {
            var q = PlayerPrefs.GetInt("St17");
            Z51.SetActive(true);
            Z52.SetActive(true);
            Z53.SetActive(true);
            if (q == 1)
                Z51.GetComponent<Image>().color = Color;
            if (q == 2)
            {
                Z51.GetComponent<Image>().color = Color;
                Z52.GetComponent<Image>().color = Color;
            }
            if (q == 3)
            {
                Z51.GetComponent<Image>().color = Color;
                Z52.GetComponent<Image>().color = Color;
                Z53.GetComponent<Image>().color = Color;
            }
        }
        if (five == 23)
        {
            var q = PlayerPrefs.GetInt("St23");
            Z51.SetActive(true);
            Z52.SetActive(true);
            Z53.SetActive(true);
            if (q == 1)
                Z51.GetComponent<Image>().color = Color;
            if (q == 2)
            {
                Z51.GetComponent<Image>().color = Color;
                Z52.GetComponent<Image>().color = Color;
            }
            if (q == 3)
            {
                Z51.GetComponent<Image>().color = Color;
                Z52.GetComponent<Image>().color = Color;
                Z53.GetComponent<Image>().color = Color;
            }
        }
        if (six == 6)
        {
            var q = PlayerPrefs.GetInt("St6");
            Z61.SetActive(true);
            Z62.SetActive(true);
            Z63.SetActive(true);
            if (q == 1)
                Z61.GetComponent<Image>().color = Color;
            if (q == 2)
            {
                Z61.GetComponent<Image>().color = Color;
                Z62.GetComponent<Image>().color = Color;
            }
            if (q == 3)
            {
                Z61.GetComponent<Image>().color = Color;
                Z62.GetComponent<Image>().color = Color;
                Z63.GetComponent<Image>().color = Color;
            }
        }
        if (six == 12)
        {
            var q = PlayerPrefs.GetInt("St12");
            Z61.SetActive(true);
            Z62.SetActive(true);
            Z63.SetActive(true);
            if (q == 1)
                Z61.GetComponent<Image>().color = Color;
            if (q == 2)
            {
                Z61.GetComponent<Image>().color = Color;
                Z62.GetComponent<Image>().color = Color;
            }
            if (q == 3)
            {
                Z61.GetComponent<Image>().color = Color;
                Z62.GetComponent<Image>().color = Color;
                Z63.GetComponent<Image>().color = Color;
            }
        }
        if (six == 18)
        {
            var q = PlayerPrefs.GetInt("St18");
            Z61.SetActive(true);
            Z62.SetActive(true);
            Z63.SetActive(true);
            if (q == 1)
                Z61.GetComponent<Image>().color = Color;
            if (q == 2)
            {
                Z61.GetComponent<Image>().color = Color;
                Z62.GetComponent<Image>().color = Color;
            }
            if (q == 3)
            {
                Z61.GetComponent<Image>().color = Color;
                Z62.GetComponent<Image>().color = Color;
                Z63.GetComponent<Image>().color = Color;
            }
        }
        if (six == 24)
        {
            var q = PlayerPrefs.GetInt("St24");
            Z61.SetActive(true);
            Z62.SetActive(true);
            Z63.SetActive(true);
            if (q == 1)
                Z61.GetComponent<Image>().color = Color;
            if (q == 2)
            {
                Z61.GetComponent<Image>().color = Color;
                Z62.GetComponent<Image>().color = Color;
            }
            if (q == 3)
            {
                Z61.GetComponent<Image>().color = Color;
                Z62.GetComponent<Image>().color = Color;
                Z63.GetComponent<Image>().color = Color;
            }
        }
    }
}
