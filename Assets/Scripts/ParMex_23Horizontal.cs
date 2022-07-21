using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ParMex_23Horizontal : MonoBehaviour
{
    public GameObject Play;
    public GameObject CircleLeft;
    public GameObject CircleRight;
    public GameObject Home;
    public TextMeshProUGUI TotalStar;
    public TextMeshProUGUI TotalStar2;
    public TextMeshProUGUI PlusStar;
    public TextMeshProUGUI Text;
    public TextMeshProUGUI MaxValue;
    new RectTransform transform;
    public GameObject Finalimg;
    public GameObject PausePanel;
    public GameObject StatusBar;
    public GameObject StatusBack;
    public GameObject LastStar;
    public GameObject LastStar2;
    public GameObject LastStar3;
    public GameObject Shadow;
    public GameObject ResetPanel;
    public GameObject MenuPanel;
    public TextMeshProUGUI TxtLvl;
    public Button WinOrDefeatButton;
    public int points;
    public int OneStar;
    public int TwoStar;
    private Vector4 Color = new Vector4(49 / 255.0f, 41 / 255.0f, 41 / 255.0f, 1);
    private int stars = 3;
    float piece;


    public Image S1;
    public Image S2;
    public Image S3;
    public Image S4;
    public Image S5;
    public Image S6;
    public Image S7;
    public Image S8;
    public Image S9;
    public Image S10;
    public Image S11;

    public bool win = false;

    public int Lvl;
    public int one;
    public int two;
    public int three;
    public int four;
    public int five;
    public int six;
    public int seven;
    public int eight;
    public int nine;

    public delegate void OnSwipeInput(Vector2 dec);
    private Vector2 tapPos;
    private Vector2 swipeDelta;
    private float deadZone;
    public bool isPromptShow = false;
    private bool isAnimation = false;
    private bool Cont;

    private bool isSwiped;
    private bool isMobile;

    Vector3 pos1;
    Vector3 pos2;
    Vector3 pos3;
    Vector3 pos4;
    Vector3 pos5;
    Vector3 pos6;
    Vector3 pos7;
    Vector3 pos8;
    Vector3 pos9;
    Vector3 pos10;
    Vector3 pos11;
    Vector3 pos12;


    // Start is called before the first frame update
    void Start()
    {
        pos1 = S1.rectTransform.localPosition;
        pos1.x += S1.rectTransform.localPosition.x;
        pos2 = S4.rectTransform.localPosition;
        pos2.x += S4.rectTransform.localPosition.x;
        pos3 = S7.rectTransform.localPosition;
        pos3.x += S7.rectTransform.localPosition.x;
        pos4 = S3.rectTransform.localPosition;
        pos4.x += S3.rectTransform.localPosition.x;
        pos5 = S6.rectTransform.localPosition;
        pos5.x += S6.rectTransform.localPosition.x;
        pos6 = S9.rectTransform.localPosition;
        pos6.x += S9.rectTransform.localPosition.x;
        pos7 = S1.rectTransform.localPosition;
        pos7.y += S1.rectTransform.localPosition.y;
        pos8 = S2.rectTransform.localPosition;
        pos8.y += S2.rectTransform.localPosition.y;
        pos9 = S3.rectTransform.localPosition;
        pos9.y += S3.rectTransform.localPosition.y;
        pos10 = S7.rectTransform.localPosition;
        pos10.y += S7.rectTransform.localPosition.y;
        pos11 = S8.rectTransform.localPosition;
        pos11.y += S8.rectTransform.localPosition.y;
        pos12 = S9.rectTransform.localPosition;
        pos12.y += S9.rectTransform.localPosition.y;
        Cont = false;
        TotalStar.text = GetStars.GetTotal();
        Debug.Log(points);
        isMobile = Application.isMobilePlatform;
        Shadow.SetActive(false);
        WinOrDefeatButton.gameObject.SetActive(false);
        Finalimg.SetActive(false);
        PausePanel.SetActive(false);
        Text.text = points.ToString();
        MaxValue.text = points.ToString();
        transform = StatusBack.GetComponent<RectTransform>();
        piece = transform.sizeDelta.x / points;
    }

    // Update is called once per frame
    public void Update()
    {
        if (!isMobile)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isSwiped = true;
                tapPos = Input.mousePosition;
            }
            else if (Input.GetMouseButtonUp(0))
                ResetSwipe();
        }
        else
        {
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    isSwiped = true;
                    tapPos = Input.GetTouch(0).position;
                }
                else if (Input.GetTouch(0).phase == TouchPhase.Canceled ||
                    Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    ResetSwipe();
                }
            }
        }
        CheckSwipe();
    }

    private void CheckSwipe()
    {
        var high = Screen.height;
        var widt = Screen.width;

        float firHigh;
        float firWidt;
        float secHigh;
        float secWidt;
        float thiHigh;
        float thiWidt;

        if (0 < (high * widt) / 1000 && (high * widt) / 1000 <= 384)
            deadZone = 80;
        else if ((high * widt) / 1000 > 384 && (high * widt) / 1000 <= 410)
            deadZone = 100;
        else if ((high * widt) / 1000 > 410 && (high * widt) / 1000 <= 640)
            deadZone = 120;
        else if ((high * widt) / 1000 > 640 && (high * widt) / 1000 <= 922)
            deadZone = 150;
        else if ((high * widt) / 1000 > 922 && (high * widt) / 1000 <= 2074)
            deadZone = 230;
        else if (((high * widt) / 1000 > 2074 && (high * widt) / 1000 <= 2333))
            deadZone = 270;
        else if ((high * widt) / 1000 > 2333 && (high * widt) / 1000 <= 3887)
            deadZone = 300;
        else if ((high * widt) / 1000 > 3887 && (high * widt) / 1000 <= 4263)
            deadZone = 380;
        else
            deadZone = 450;


        if ((CheckLock() && !isPromptShow && !isAnimation) || (Cont && !isAnimation))
        {
            if (high > widt)
            {
                firHigh = high / 1.854f;
                secHigh = high / 2.537f;
                thiHigh = high / 4.08f;

                firWidt = widt / 4.3125f;
                secWidt = widt / 2f;
                thiWidt = widt / 1.32f;

                swipeDelta = Vector2.zero;


                if (isSwiped)
                {
                    if (!isMobile && Input.GetMouseButton(0))
                    {
                        swipeDelta = (Vector2)Input.mousePosition - tapPos;
                    }
                    else if (Input.touchCount > 0)
                        swipeDelta = Input.GetTouch(0).position - tapPos;
                }

                if (swipeDelta.magnitude > deadZone)
                {
                    if (Mathf.Abs(swipeDelta.x) > Mathf.Abs(swipeDelta.y))
                    {
                        if (tapPos.x > firWidt - (firWidt - firWidt * 0.5) && tapPos.x < thiWidt + (thiWidt * 1.15 - thiWidt))
                        {
                            if (tapPos.y > firHigh - (firHigh * 1.13 - firHigh) && tapPos.y < firHigh + (firHigh - firHigh * 0.879))
                            {
                                if (swipeDelta.x > 0)
                                {
                                    MoveRightFirstLine();
                                }
                                else
                                {
                                    MoveLeftFirstLine();
                                }
                            }
                            else if (tapPos.y > secHigh - (secHigh * 1.179 - secHigh) && tapPos.y < secHigh + (secHigh - secHigh * 0.845))
                            {
                                if (swipeDelta.x > 0)
                                {
                                    MoveRightSecondLine();
                                    MoveRightTrirdLine();
                                    CheckWin();
                                }
                                else
                                {
                                    MoveLeftSecondLine();
                                    MoveLeftThirdLine();
                                    CheckWin();
                                }
                            }
                            else if (tapPos.y > thiHigh - (thiHigh * 1.32 - thiHigh) && tapPos.y < thiHigh + (thiHigh - thiHigh * 0.765))
                            {
                                if (swipeDelta.x > 0)
                                {
                                    MoveRightSecondLine();
                                    MoveRightTrirdLine();
                                    CheckWin();
                                }
                                else
                                {
                                    MoveLeftSecondLine();
                                    MoveLeftThirdLine();
                                    CheckWin();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (tapPos.y < firHigh + (firHigh - firHigh * 0.879) && tapPos.y > thiHigh - (thiHigh * 1.32 - thiHigh))
                        {
                            if (tapPos.x > firWidt - (firWidt - firWidt * 0.5) && tapPos.x < firWidt + (firWidt * 1.54 - firWidt))
                            {
                                if (swipeDelta.y > 0)
                                    MoveUpFirstLine();
                                else
                                    MoveDownFirstLine();
                            }
                            if (tapPos.x > secWidt - (secWidt - secWidt * 0.74) && tapPos.x < secWidt + (secWidt * 1.22 - secWidt))
                            {
                                if (swipeDelta.y > 0)
                                    MoveUpSecondLine();
                                else
                                    MoveDownSecondLine();
                            }
                            if (tapPos.x > thiWidt - (thiWidt - thiWidt * 0.833) && tapPos.x < thiWidt + (thiWidt * 1.15 - thiWidt))
                            {
                                if (swipeDelta.y > 0)
                                    MoveUpTrirdLine();
                                else
                                    MoveDownThirdLine();
                            }
                        }
                    }
                    ResetSwipe();

                }
            }
            else
            {
                firHigh = high / 1.825f;
                secHigh = high / 2.548f;
                thiHigh = high / 3.9669f;

                firWidt = widt / 2.3747f;
                secWidt = widt / 2f;
                thiWidt = widt / 1.7403f;

                swipeDelta = Vector2.zero;


                if (isSwiped)
                {
                    if (!isMobile && Input.GetMouseButton(0))
                    {
                        swipeDelta = (Vector2)Input.mousePosition - tapPos;
                    }
                    else if (Input.touchCount > 0)
                        swipeDelta = Input.GetTouch(0).position - tapPos;
                }

                if (swipeDelta.magnitude > deadZone)
                {
                    if (Mathf.Abs(swipeDelta.x) > Mathf.Abs(swipeDelta.y))
                    {
                        if (tapPos.x > firWidt - (firWidt - firWidt * 0.898) && tapPos.x < thiWidt + (thiWidt * 1.0708 - thiWidt))
                        {
                            if (tapPos.y > firHigh - (firHigh * 1.117 - firHigh) && tapPos.y < firHigh + (firHigh - firHigh * 0.872))
                            {
                                if (swipeDelta.x > 0)
                                {
                                    MoveRightFirstLine();
                                }
                                else
                                {
                                    MoveLeftFirstLine();
                                }
                            }
                            else if (tapPos.y > secHigh - (secHigh * 1.1912 - secHigh) && tapPos.y < secHigh + (secHigh - secHigh * 0.85))
                            {
                                if (swipeDelta.x > 0)
                                {
                                    MoveRightSecondLine();
                                    MoveRightTrirdLine();
                                    CheckWin();
                                }
                                else
                                {
                                    MoveLeftSecondLine();
                                    MoveLeftThirdLine();
                                    CheckWin();
                                }
                            }
                            else if (tapPos.y > thiHigh - (thiHigh * 1.2785 - thiHigh) && tapPos.y < thiHigh + (thiHigh - thiHigh * 0.75))
                            {
                                if (swipeDelta.x > 0)
                                {
                                    MoveRightSecondLine();
                                    MoveRightTrirdLine();
                                    CheckWin();
                                }
                                else
                                {
                                    MoveLeftFirstLine();
                                    MoveLeftThirdLine();
                                    CheckWin();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (tapPos.y < firHigh + (firHigh - firHigh * 0.872) && tapPos.y > thiHigh - (thiHigh * 1.2785 - thiHigh))
                        {
                            if (tapPos.x > firWidt - (firWidt - firWidt * 0.898) && tapPos.x < firWidt + (firWidt * 1.079 - firWidt))
                            {
                                if (swipeDelta.y > 0)
                                {
                                    MoveUpFirstLine();
                                }
                                else
                                {
                                    MoveDownFirstLine();
                                }
                            }
                            if (tapPos.x > secWidt - (secWidt - secWidt * 0.9204) && tapPos.x < secWidt + (secWidt * 1.0696 - secWidt))
                            {
                                if (swipeDelta.y > 0)
                                {
                                    MoveUpSecondLine();
                                }
                                else
                                {
                                    MoveDownSecondLine();
                                }

                            }
                            if (tapPos.x > thiWidt - (thiWidt - thiWidt * 0.941) && tapPos.x < thiWidt + (thiWidt * 1.0708 - thiWidt))
                            {
                                if (swipeDelta.y > 0)
                                {
                                    MoveUpTrirdLine();
                                }
                                else
                                {
                                    MoveDownThirdLine();
                                }

                            }
                        }
                    }
                    ResetSwipe();
                }
            }
        }
    }

    private void ResetSwipe()
    {
        isSwiped = false;
        tapPos = Vector2.zero;
        swipeDelta = Vector2.zero;

    }

    private float minimum = 0f;

    private IEnumerator coroutine1;

    public void MoveLeftFirstLine()
    {
        isAnimation = true;
        coroutine1 = Enum1(3, 0.005f);
        StartCoroutine(coroutine1);
    }

    public void MoveRightFirstLine()
    {
        isAnimation = true;
        coroutine1 = Enum1(1, 0.005f);
        StartCoroutine(coroutine1);
    }


    public void MoveLeftSecondLine()
    {
        isAnimation = true;
        coroutine1 = Enum2(3, 0.005f);
        StartCoroutine(coroutine1);
    }

    public void MoveRightSecondLine()
    {
        isAnimation = true;
        coroutine1 = Enum2(1, 0.005f);
        StartCoroutine(coroutine1);
    }

    public void MoveLeftThirdLine()
    {
        isAnimation = true;
        coroutine1 = Enum3(3, 0.005f);
        StartCoroutine(coroutine1);
    }

    public void MoveRightTrirdLine()
    {
        isAnimation = true;
        coroutine1 = Enum3(1, 0.005f);
        StartCoroutine(coroutine1);
    }

    public void MoveUpFirstLine()
    {
        isAnimation = true;
        coroutine1 = Enum4(4, 0.005f);
        StartCoroutine(coroutine1);
    }

    public void MoveDownFirstLine()
    {
        isAnimation = true;
        coroutine1 = Enum4(2, 0.005f);
        StartCoroutine(coroutine1);
    }

    public void MoveUpSecondLine()
    {
        isAnimation = true;
        coroutine1 = Enum5(4, 0.005f);
        StartCoroutine(coroutine1);
    }

    public void MoveDownSecondLine()
    {
        isAnimation = true;
        coroutine1 = Enum5(2, 0.005f);
        StartCoroutine(coroutine1);
    }

    public void MoveUpTrirdLine()
    {
        isAnimation = true;
        coroutine1 = Enum6(4, 0.005f);
        StartCoroutine(coroutine1);
    }
    public void MoveDownThirdLine()
    {
        isAnimation = true;
        coroutine1 = Enum6(2, 0.005f);
        StartCoroutine(coroutine1);
    }


    IEnumerator Enum1(int flag, float f)
    {
        if (flag == 1)
        {
            isAnimation = true;
            S10.sprite = S3.sprite;
            S10.rectTransform.localPosition = pos1;
            var min = 1f;
            var max = 0f;
            for (minimum = 0f; minimum < 106f; minimum += 2.65f)
            {
                S10.GetComponent<RectTransform>().localPosition =
                    new Vector3(S10.transform.localPosition.x + 2.65f, S10.transform.localPosition.y, S10.transform.localPosition.z);
                S1.GetComponent<RectTransform>().localPosition =
                    new Vector3(S1.transform.localPosition.x + 2.65f, S1.transform.localPosition.y, S1.transform.localPosition.z);
                S2.GetComponent<RectTransform>().localPosition =
                    new Vector3(S2.transform.localPosition.x + 2.65f, S2.transform.localPosition.y, S2.transform.localPosition.z);
                S3.GetComponent<RectTransform>().localPosition =
                    new Vector3(S3.transform.localPosition.x + 2.65f, S3.transform.localPosition.y, S3.transform.localPosition.z);
                min -= 0.05f;
                max += 0.05f;
                S3.GetComponent<Image>().color = new Color(1, 1, 1, min);
                S10.GetComponent<Image>().color = new Color(1, 1, 1, max);
                yield return new WaitForSeconds(f);
            }
            RF();
        }
        else if (flag == 3)
        {
            isAnimation = true;
            S10.sprite = S1.sprite;
            S10.rectTransform.localPosition = pos4;
            var min = 1f;
            var max = 0f;
            for (minimum = 0f; minimum < 106f; minimum += 2.65f)
            {
                S10.GetComponent<RectTransform>().localPosition =
                    new Vector3(S10.transform.localPosition.x - 2.65f, S10.transform.localPosition.y, S10.transform.localPosition.z);
                S1.GetComponent<RectTransform>().localPosition =
                    new Vector3(S1.transform.localPosition.x - 2.65f, S1.transform.localPosition.y, S1.transform.localPosition.z);
                S2.GetComponent<RectTransform>().localPosition =
                    new Vector3(S2.transform.localPosition.x - 2.65f, S2.transform.localPosition.y, S2.transform.localPosition.z);
                S3.GetComponent<RectTransform>().localPosition =
                    new Vector3(S3.transform.localPosition.x - 2.65f, S3.transform.localPosition.y, S3.transform.localPosition.z);
                S1.GetComponent<Image>().color = new Color(1, 1, 1, a: min -= 0.05f);
                S10.GetComponent<Image>().color = new Color(1, 1, 1, a: max += 0.05f);
                yield return new WaitForSeconds(f);
            }
            LF();
        }
    }
    IEnumerator Enum2(int flag, float f)
    {
        if (flag == 1)
        {
            isAnimation = true;
            S10.sprite = S6.sprite;
            S10.rectTransform.localPosition = pos2;
            var min = 1f;
            var max = 0f;
            for (minimum = 0f; minimum < 208f; minimum += 2.65f)
            {
                S10.GetComponent<RectTransform>().localPosition =
                    new Vector3(S10.transform.localPosition.x + 2.65f, S10.transform.localPosition.y, S10.transform.localPosition.z);
                S4.GetComponent<RectTransform>().localPosition =
                    new Vector3(S4.transform.localPosition.x + 2.65f, S4.transform.localPosition.y, S4.transform.localPosition.z);
                S5.GetComponent<RectTransform>().localPosition =
                    new Vector3(S5.transform.localPosition.x + 2.65f, S5.transform.localPosition.y, S5.transform.localPosition.z);
                S6.GetComponent<RectTransform>().localPosition =
                    new Vector3(S6.transform.localPosition.x + 2.65f, S6.transform.localPosition.y, S6.transform.localPosition.z);
                min -= 0.05f;
                max += 0.05f;
                S6.GetComponent<Image>().color = new Color(1, 1, 1, min);
                S10.GetComponent<Image>().color = new Color(1, 1, 1, max);
                yield return new WaitForSeconds(f);
            }
            RS();
        }
        else if (flag == 3)
        {
            isAnimation = true;
            S10.sprite = S4.sprite;
            S10.rectTransform.localPosition = pos5;
            var min = 1f;
            var max = 0f;
            for (minimum = 0f; minimum < 208f; minimum += 2.65f)
            {
                S10.GetComponent<RectTransform>().localPosition =
                    new Vector3(S10.transform.localPosition.x - 2.65f, S10.transform.localPosition.y, S10.transform.localPosition.z);
                S4.GetComponent<RectTransform>().localPosition =
                    new Vector3(S4.transform.localPosition.x - 2.65f, S4.transform.localPosition.y, S4.transform.localPosition.z);
                S5.GetComponent<RectTransform>().localPosition =
                    new Vector3(S5.transform.localPosition.x - 2.65f, S5.transform.localPosition.y, S5.transform.localPosition.z);
                S6.GetComponent<RectTransform>().localPosition =
                    new Vector3(S6.transform.localPosition.x - 2.65f, S6.transform.localPosition.y, S6.transform.localPosition.z);
                S4.GetComponent<Image>().color = new Color(1, 1, 1, a: min -= 0.05f);
                S10.GetComponent<Image>().color = new Color(1, 1, 1, a: max += 0.05f);
                yield return new WaitForSeconds(f);
            }
            LS();
        }
    }
    IEnumerator Enum3(int flag, float f)
    {
        if (flag == 1)
        {
            isAnimation = true;
            S11.sprite = S9.sprite;
            S11.rectTransform.localPosition = pos3;
            var min = 1f;
            var max = 0f;
            for (minimum = 0f; minimum < 208f; minimum += 2.65f)
            {
                S11.GetComponent<RectTransform>().localPosition =
                    new Vector3(S11.transform.localPosition.x + 2.65f, S11.transform.localPosition.y, S11.transform.localPosition.z);
                S7.GetComponent<RectTransform>().localPosition =
                    new Vector3(S7.transform.localPosition.x + 2.65f, S7.transform.localPosition.y, S7.transform.localPosition.z);
                S8.GetComponent<RectTransform>().localPosition =
                    new Vector3(S8.transform.localPosition.x + 2.65f, S8.transform.localPosition.y, S8.transform.localPosition.z);
                S9.GetComponent<RectTransform>().localPosition =
                    new Vector3(S9.transform.localPosition.x + 2.65f, S9.transform.localPosition.y, S9.transform.localPosition.z);
                min -= 0.05f;
                max += 0.05f;
                S9.GetComponent<Image>().color = new Color(1, 1, 1, min);
                S11.GetComponent<Image>().color = new Color(1, 1, 1, max);
                yield return new WaitForSeconds(f);
            }
            RT();
        }
        else if (flag == 3)
        {
            isAnimation = true;
            S11.sprite = S7.sprite;
            S11.rectTransform.localPosition = pos6;
            var min = 1f;
            var max = 0f;
            for (minimum = 0f; minimum < 208f; minimum += 2.65f)
            {
                S11.GetComponent<RectTransform>().localPosition =
                    new Vector3(S11.transform.localPosition.x - 2.65f, S11.transform.localPosition.y, S11.transform.localPosition.z);
                S7.GetComponent<RectTransform>().localPosition =
                    new Vector3(S7.transform.localPosition.x - 2.65f, S7.transform.localPosition.y, S7.transform.localPosition.z);
                S8.GetComponent<RectTransform>().localPosition =
                    new Vector3(S8.transform.localPosition.x - 2.65f, S8.transform.localPosition.y, S8.transform.localPosition.z);
                S9.GetComponent<RectTransform>().localPosition =
                    new Vector3(S9.transform.localPosition.x - 2.65f, S9.transform.localPosition.y, S9.transform.localPosition.z);
                S7.GetComponent<Image>().color = new Color(1, 1, 1, a: min -= 0.05f);
                S11.GetComponent<Image>().color = new Color(1, 1, 1, a: max += 0.05f);
                yield return new WaitForSeconds(f);
            }
            LT();
        }
    }

    IEnumerator Enum4(int flag, float f)
    {
        if (flag == 2)
        {
            isAnimation = true;
            S10.sprite = S7.sprite;
            S10.rectTransform.localPosition = pos7;
            var min = 1f;
            var max = 0f;
            for (minimum = 0f; minimum < 106f; minimum += 2.65f)
            {
                S10.GetComponent<RectTransform>().localPosition =
                    new Vector3(S10.transform.localPosition.x, S10.transform.localPosition.y - 2.65f, S10.transform.localPosition.z);
                S1.GetComponent<RectTransform>().localPosition =
                    new Vector3(S1.transform.localPosition.x, S1.transform.localPosition.y - 2.65f, S1.transform.localPosition.z);
                S4.GetComponent<RectTransform>().localPosition =
                    new Vector3(S4.transform.localPosition.x, S4.transform.localPosition.y - 2.65f, S4.transform.localPosition.z);
                S7.GetComponent<RectTransform>().localPosition =
                    new Vector3(S7.transform.localPosition.x, S7.transform.localPosition.y - 2.65f, S7.transform.localPosition.z);
                min -= 0.05f;
                max += 0.05f;
                S7.GetComponent<Image>().color = new Color(1, 1, 1, min);
                S10.GetComponent<Image>().color = new Color(1, 1, 1, max);
                yield return new WaitForSeconds(f);
            }
            DF();
        }
        else if (flag == 4)
        {
            isAnimation = true;
            S10.sprite = S1.sprite;
            S10.rectTransform.localPosition = pos10;
            var min = 1f;
            var max = 0f;
            for (minimum = 0f; minimum < 106f; minimum += 2.65f)
            {
                S10.GetComponent<RectTransform>().localPosition =
                     new Vector3(S10.transform.localPosition.x, S10.transform.localPosition.y + 2.65f, S10.transform.localPosition.z);
                S1.GetComponent<RectTransform>().localPosition =
                    new Vector3(S1.transform.localPosition.x, S1.transform.localPosition.y + 2.65f, S1.transform.localPosition.z);
                S4.GetComponent<RectTransform>().localPosition =
                    new Vector3(S4.transform.localPosition.x, S4.transform.localPosition.y + 2.65f, S4.transform.localPosition.z);
                S7.GetComponent<RectTransform>().localPosition =
                    new Vector3(S7.transform.localPosition.x, S7.transform.localPosition.y + 2.65f, S7.transform.localPosition.z);
                min -= 0.05f;
                max += 0.05f;
                S1.GetComponent<Image>().color = new Color(1, 1, 1, min);
                S10.GetComponent<Image>().color = new Color(1, 1, 1, max);
                yield return new WaitForSeconds(f);
            }
            UF();
        }
    }
    IEnumerator Enum5(int flag, float f)
    {
        if (flag == 2)
        {
            isAnimation = true;
            S10.sprite = S8.sprite;
            S10.rectTransform.localPosition = pos8;
            var min = 1f;
            var max = 0f;
            for (minimum = 0f; minimum < 106f; minimum += 2.65f)
            {
                S10.GetComponent<RectTransform>().localPosition =
                    new Vector3(S10.transform.localPosition.x, S10.transform.localPosition.y - 2.65f, S10.transform.localPosition.z);
                S2.GetComponent<RectTransform>().localPosition =
                    new Vector3(S2.transform.localPosition.x, S2.transform.localPosition.y - 2.65f, S2.transform.localPosition.z);
                S5.GetComponent<RectTransform>().localPosition =
                    new Vector3(S5.transform.localPosition.x, S5.transform.localPosition.y - 2.65f, S5.transform.localPosition.z);
                S8.GetComponent<RectTransform>().localPosition =
                    new Vector3(S8.transform.localPosition.x, S8.transform.localPosition.y - 2.65f, S8.transform.localPosition.z);
                min -= 0.05f;
                max += 0.05f;
                S8.GetComponent<Image>().color = new Color(1, 1, 1, min);
                S10.GetComponent<Image>().color = new Color(1, 1, 1, max);
                yield return new WaitForSeconds(f);
            }
            DS();
        }
        else if (flag == 4)
        {
            isAnimation = true;
            S10.sprite = S2.sprite;
            S10.rectTransform.localPosition = pos11;
            var min = 1f;
            var max = 0f;
            for (minimum = 0f; minimum < 106f; minimum += 2.65f)
            {
                S10.GetComponent<RectTransform>().localPosition =
                     new Vector3(S10.transform.localPosition.x, S10.transform.localPosition.y + 2.65f, S10.transform.localPosition.z);
                S2.GetComponent<RectTransform>().localPosition =
                    new Vector3(S2.transform.localPosition.x, S2.transform.localPosition.y + 2.65f, S2.transform.localPosition.z);
                S5.GetComponent<RectTransform>().localPosition =
                    new Vector3(S5.transform.localPosition.x, S5.transform.localPosition.y + 2.65f, S5.transform.localPosition.z);
                S8.GetComponent<RectTransform>().localPosition =
                    new Vector3(S8.transform.localPosition.x, S8.transform.localPosition.y + 2.65f, S8.transform.localPosition.z);
                min -= 0.05f;
                max += 0.05f;
                S2.GetComponent<Image>().color = new Color(1, 1, 1, min);
                S10.GetComponent<Image>().color = new Color(1, 1, 1, max);
                yield return new WaitForSeconds(f);
            }
            US();
        }
    }

    IEnumerator Enum6(int flag, float f)
    {
        if (flag == 2)
        {
            isAnimation = true;
            S10.sprite = S9.sprite;
            S10.rectTransform.localPosition = pos9;
            var min = 1f;
            var max = 0f;
            for (minimum = 0f; minimum < 106f; minimum += 2.65f)
            {
                S10.GetComponent<RectTransform>().localPosition =
                    new Vector3(S10.transform.localPosition.x, S10.transform.localPosition.y - 2.65f, S10.transform.localPosition.z);
                S3.GetComponent<RectTransform>().localPosition =
                    new Vector3(S3.transform.localPosition.x, S3.transform.localPosition.y - 2.65f, S3.transform.localPosition.z);
                S6.GetComponent<RectTransform>().localPosition =
                    new Vector3(S6.transform.localPosition.x, S6.transform.localPosition.y - 2.65f, S6.transform.localPosition.z);
                S9.GetComponent<RectTransform>().localPosition =
                    new Vector3(S9.transform.localPosition.x, S9.transform.localPosition.y - 2.65f, S9.transform.localPosition.z);
                min -= 0.05f;
                max += 0.05f;
                S9.GetComponent<Image>().color = new Color(1, 1, 1, min);
                S10.GetComponent<Image>().color = new Color(1, 1, 1, max);
                yield return new WaitForSeconds(f);
            }
            DT();
        }
        else if (flag == 4)
        {
            isAnimation = true;
            S10.sprite = S3.sprite;
            S10.rectTransform.localPosition = pos12;
            var min = 1f;
            var max = 0f;
            for (minimum = 0f; minimum < 106f; minimum += 2.65f)
            {
                S10.GetComponent<RectTransform>().localPosition =
                     new Vector3(S10.transform.localPosition.x, S10.transform.localPosition.y + 2.65f, S10.transform.localPosition.z);
                S3.GetComponent<RectTransform>().localPosition =
                    new Vector3(S3.transform.localPosition.x, S3.transform.localPosition.y + 2.65f, S3.transform.localPosition.z);
                S6.GetComponent<RectTransform>().localPosition =
                    new Vector3(S6.transform.localPosition.x, S6.transform.localPosition.y + 2.65f, S6.transform.localPosition.z);
                S9.GetComponent<RectTransform>().localPosition =
                    new Vector3(S9.transform.localPosition.x, S9.transform.localPosition.y + 2.65f, S9.transform.localPosition.z);
                min -= 0.05f;
                max += 0.05f;
                S3.GetComponent<Image>().color = new Color(1, 1, 1, min);
                S10.GetComponent<Image>().color = new Color(1, 1, 1, max);
                yield return new WaitForSeconds(f);
            }
            UT();
        }
    }

    public void CheckWin()
    {
        isAnimation = false;
        if (one == 1 && two == 2 && three == 3 && four == 4 && five == 5 &&
            six == 6 && seven == 7 && eight == 8 && nine == 9)
        {
            var prevLvls = PlayerPrefs.GetString("LevelComplete");  // Код для подсчета пройденных уровней
            if (!prevLvls.Contains(Lvl.ToString()))
            {
                PlayerPrefs.SetString("LevelComplete", prevLvls + " " + Lvl.ToString());
            }
            if (!Cont)
                win = true;
        }
        PassingPoints();
    }

    public void PassingPoints()
    {
        if (!Cont)
            points--;
        Text.text = points.ToString();
        StatusBar.GetComponent<RectTransform>().offsetMax = new Vector2(StatusBar.GetComponent<RectTransform>().offsetMax.x - piece, 0);
        if (points == 0)
        {
            Cont = true;
            PausePanel.SetActive(true);
            WinOrDefeatButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("grayBut");
            WinOrDefeatButton.gameObject.SetActive(true);

            stars--;
            GameObject.Find("Star").GetComponent<Image>().color = Color;
            LastStar.GetComponent<Image>().color = Color;
            CircleLeft.SetActive(false);
            Play.SetActive(false);
            PlusStar.text = "+ " + GetStars.StarChanger(Lvl, stars);
            TotalStar.text = GetStars.GetTotal();
            TotalStar2.text = TotalStar.text;
            //Shadow.SetActive(true);

        }
        else if (points == OneStar)
        {
            stars--;
            GameObject.Find("Star3").GetComponent<Image>().color = Color;
            LastStar3.GetComponent<Image>().color = Color;
        }
        else if (points == TwoStar)
        {
            stars--;
            GameObject.Find("Star2").GetComponent<Image>().color = Color;
            LastStar2.GetComponent<Image>().color = Color;
        }
        if (win)
        {
            PausePanel.SetActive(true);
            Finalimg.SetActive(true);
            WinOrDefeatButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("greenBut");
            WinOrDefeatButton.gameObject.SetActive(true);

            TxtLvl.text = "Пазл собран";
            if (stars == 3)
            {
                CircleRight.SetActive(false);
                CircleLeft.SetActive(false);
            }
            if (stars == 2 || stars == 1)
            {
                Home.SetActive(false);
                CircleRight.SetActive(false);
            }
            PlusStar.text = "+ " + GetStars.StarChanger(Lvl, stars);
            TotalStar.text = GetStars.GetTotal();
            TotalStar2.text = TotalStar.text;
            //Shadow.SetActive(true);
        }
    }

    public bool CheckLock()
    {
        if (WinOrDefeatButton.gameObject.activeInHierarchy)
            return false;
        else if (ResetPanel.activeInHierarchy)
            return false;
        else if (MenuPanel.activeInHierarchy)
            return false;
        return true;
    }

    public void RF()
    {
        S10.color = new Color(1, 1, 1, 0);
        S3.color = new Color(1, 1, 1, 1);
        S3.rectTransform.localPosition = S2.rectTransform.localPosition;
        S2.rectTransform.localPosition = S1.rectTransform.localPosition;
        S1.rectTransform.localPosition = S10.rectTransform.localPosition;

        var g = S3.sprite;
        S3.sprite = S2.sprite;
        S2.sprite = S1.sprite;
        S1.sprite = g;

        int q = three;
        three = two;
        two = one;
        one = q;
        CheckWin();
    }

    public void LF()
    {
        S10.color = new Color(1, 1, 1, 0);
        S1.color = new Color(1, 1, 1, 1);
        S1.rectTransform.localPosition = S2.rectTransform.localPosition;
        S2.rectTransform.localPosition = S3.rectTransform.localPosition;
        S3.rectTransform.localPosition = S10.rectTransform.localPosition;

        var q = S1.sprite;
        S1.sprite = S2.sprite;
        S2.sprite = S3.sprite;
        S3.sprite = q;

        int g = one;
        one = two;
        two = three;
        three = g;
        CheckWin();
    }

    public void LS()
    {
        S10.color = new Color(1, 1, 1, 0);
        S4.color = new Color(1, 1, 1, 1);
        S4.rectTransform.localPosition = S5.rectTransform.localPosition;
        S5.rectTransform.localPosition = S6.rectTransform.localPosition;
        S6.rectTransform.localPosition = S10.rectTransform.localPosition;
        var q = S4.sprite;
        S4.sprite = S5.sprite;
        S5.sprite = S6.sprite;
        S6.sprite = q;

        int g = four;
        four = five;
        five = six;
        six = g;

    }

    public void RS()
    {
        S10.color = new Color(1, 1, 1, 0);
        S6.color = new Color(1, 1, 1, 1);
        S6.rectTransform.localPosition = S5.rectTransform.localPosition;
        S5.rectTransform.localPosition = S4.rectTransform.localPosition;
        S4.rectTransform.localPosition = S10.rectTransform.localPosition;
        var g = S6.sprite;
        S6.sprite = S5.sprite;
        S5.sprite = S4.sprite;
        S4.sprite = g;

        int q = six;
        six = five;
        five = four;
        four = q;

    }

    public void LT()
    {
        S10.color = new Color(1, 1, 1, 0);
        S7.color = new Color(1, 1, 1, 1);
        S7.rectTransform.localPosition = S8.rectTransform.localPosition;
        S8.rectTransform.localPosition = S9.rectTransform.localPosition;
        S9.rectTransform.localPosition = S10.rectTransform.localPosition;
        var q = S7.sprite;
        S7.sprite = S8.sprite;
        S8.sprite = S9.sprite;
        S9.sprite = q;

        int g = seven;
        seven = eight;
        eight = nine;
        nine = g;

    }

    public void RT()
    {
        S10.color = new Color(1, 1, 1, 0);
        S9.color = new Color(1, 1, 1, 1);
        S9.rectTransform.localPosition = S8.rectTransform.localPosition;
        S8.rectTransform.localPosition = S7.rectTransform.localPosition;
        S7.rectTransform.localPosition = S10.rectTransform.localPosition;
        var g = S9.sprite;
        S9.sprite = S8.sprite;
        S8.sprite = S7.sprite;
        S7.sprite = g;

        int q = nine;
        nine = eight;
        eight = seven;
        seven = q;

    }

    public void UF()
    {
        S10.color = new Color(1, 1, 1, 0);
        S1.color = new Color(1, 1, 1, 1);
        S1.rectTransform.localPosition = S4.rectTransform.localPosition;
        S4.rectTransform.localPosition = S7.rectTransform.localPosition;
        S7.rectTransform.localPosition = S10.rectTransform.localPosition;

        var q = S1.sprite;
        S1.sprite = S4.sprite;
        S4.sprite = S7.sprite;
        S7.sprite = q;

        int g = one;
        one = four;
        four = seven;
        seven = g;
        CheckWin();
    }

    public void DF()
    {
        S10.color = new Color(1, 1, 1, 0);
        S7.color = new Color(1, 1, 1, 1);
        S7.rectTransform.localPosition = S4.rectTransform.localPosition;
        S4.rectTransform.localPosition = S1.rectTransform.localPosition;
        S1.rectTransform.localPosition = S10.rectTransform.localPosition;

        var q = S7.sprite;
        S7.sprite = S4.sprite;
        S4.sprite = S1.sprite;
        S1.sprite = q;

        int g = seven;
        seven = four;
        four = one;
        one = g;
        CheckWin();
    }

    public void US()
    {
        S10.color = new Color(1, 1, 1, 0);
        S2.color = new Color(1, 1, 1, 1);
        S2.rectTransform.localPosition = S5.rectTransform.localPosition;
        S5.rectTransform.localPosition = S8.rectTransform.localPosition;
        S8.rectTransform.localPosition = S10.rectTransform.localPosition;

        var q = S2.sprite;
        S2.sprite = S5.sprite;
        S5.sprite = S8.sprite;
        S8.sprite = q;

        int g = two;
        two = five;
        five = eight;
        eight = g;
        CheckWin();
    }

    public void DS()
    {
        S10.color = new Color(1, 1, 1, 0);
        S8.color = new Color(1, 1, 1, 1);
        S8.rectTransform.localPosition = S5.rectTransform.localPosition;
        S5.rectTransform.localPosition = S2.rectTransform.localPosition;
        S2.rectTransform.localPosition = S10.rectTransform.localPosition;

        var g = S8.sprite;
        S8.sprite = S5.sprite;
        S5.sprite = S2.sprite;
        S2.sprite = g;

        int q = eight;
        eight = five;
        five = two;
        two = q;
        CheckWin();
    }

    public void UT()
    {
        S11.color = new Color(1, 1, 1, 0);
        S3.color = new Color(1, 1, 1, 1);
        S3.rectTransform.localPosition = S6.rectTransform.localPosition;
        S6.rectTransform.localPosition = S9.rectTransform.localPosition;
        S9.rectTransform.localPosition = S11.rectTransform.localPosition;

        var q = S3.sprite;
        S3.sprite = S6.sprite;
        S6.sprite = S9.sprite;
        S9.sprite = q;

        int g = three;
        three = six;
        six = nine;
        nine = g;
        CheckWin();
    }

    public void DT()
    {
        S11.color = new Color(1, 1, 1, 0);
        S9.color = new Color(1, 1, 1, 1);
        S9.rectTransform.localPosition = S6.rectTransform.localPosition;
        S6.rectTransform.localPosition = S3.rectTransform.localPosition;
        S3.rectTransform.localPosition = S11.rectTransform.localPosition;

        var q = S9.sprite;
        S9.sprite = S6.sprite;
        S6.sprite = S3.sprite;
        S3.sprite = q;

        int g = nine;
        nine = six;
        six = three;
        three = g;
        CheckWin();
    }
}
