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

    }
    void Update()
    {
            if(first == 1)
            {
                var q = GetStars.St1;
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
            if(first == 5)
            {
                var q = GetStars.St5;
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
            if (first == 9)
            {
                var q = GetStars.St9;
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
                var q = GetStars.St13;
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
            if (first == 2)
            {
                var q = GetStars.St2;
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
            if (first == 6)
            {
                var q = GetStars.St6;
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
            if (first == 10)
            {
                var q = GetStars.St10;
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
            if (first == 14)
            {
                var q = GetStars.St14;
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
            if (first == 3)
            {
                var q = GetStars.St3;
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
            if (first == 7)
            {
                var q = GetStars.St7;
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
            if (first == 11)
            {
                var q = GetStars.St11;
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
            if (first == 15)
            {
                var q = GetStars.St15;
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
            if (first == 4)
            {
                var q = GetStars.St4;
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
            if (first == 8)
            {
                var q = GetStars.St8;
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
            if (first == 12)
            {
                var q = GetStars.St12;
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
            if (first == 16)
            {
                var q = GetStars.St16;
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
    }
}
