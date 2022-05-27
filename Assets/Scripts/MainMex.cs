using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMex : MonoBehaviour
{
    public Image S1;
    public Image S2;
    public Image S3;
    public Image S4;
    public Image S5;
    public Image S6;
    public Image S7;
    public Image S8;
    public Image S9;

    //public static event OnSwipeInput SwipeEvent;
    public delegate void OnSwipeInput(Vector2 dec);
    private Vector2 tapPos;
    private Vector2 swipeDelta;
    private float deadZone = 1;

    private bool isSwiped;
    private bool isMobile;


    // Start is called before the first frame update
    void Start()
    {
        isMobile = Application.isMobilePlatform;
        Debug.Log("�����");
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
                Debug.Log("�������� �������");
                Debug.Log(tapPos.x);
                Debug.Log(tapPos.y);
                //Debug.Log(First.sqr.position);
                //Debug.Log(Sec.sqr.position);
                //Debug.Log(Thr.sqr.position);
                //Debug.Log(Four.sqr.position);
                //Debug.Log(Five.sqr.position);
                //Debug.Log(Six.sqr.position);
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
                    //Debug.Log("������� �������");
                }
                else if (Input.GetTouch(0).phase == TouchPhase.Canceled ||
                    Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    //Debug.Log("������� �����");
                    ResetSwipe();
                }
            }
        }
        //Debug.Log("������� �����");
        CheckSwipe();
    }

    private void CheckSwipe()
    {

        var high = Screen.height;
        var widt = Screen.width;

        var firHigh = high / 1.854;
        var secHigh = high / 2.537;
        var thiHigh = high / 4.08;

        var firWidt = widt / 4.3125;
        var secWidt = widt / 2;
        var thiWidt = widt / 1.32;

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
                if (tapPos.y > firHigh - (firHigh * 1.13 - firHigh) && tapPos.y < firHigh + (firHigh - firHigh * 0.879))
                {
                    //if (tapPos.x > Fsquare.position.x - 1 && tapPos.x < Tsquare.position.x + 1)
                    //{
                    if (swipeDelta.x > 0)
                    {
                        Debug.Log("������");
                        MoveRightFirstLine(S1, S2, S3);
                    }
                    else
                    {
                        Debug.Log("�����");

                        MoveLeftFirstLine(S1, S2, S3);
                    }
                }
                else if (tapPos.y > secHigh - (secHigh * 1.179 - secHigh) && tapPos.y < secHigh + (secHigh - secHigh * 0.845))
                {
                    if (swipeDelta.x > 0)
                    {
                        Debug.Log("������");
                        MoveRightSecondLine(S4, S5, S6);
                    }
                    else
                    {
                        Debug.Log("�����");
                        MoveLeftSecondLine(S4, S5, S6);
                    }
                }
                else if (tapPos.y > thiHigh - (thiHigh * 1.32 - thiHigh) && tapPos.y < thiHigh + (thiHigh - thiHigh * 0.765))
                {
                    if (swipeDelta.x > 0)
                    {
                        Debug.Log("������");
                        MoveRightTrirdLine(S7, S8, S9);
                    }
                    else
                    {
                        Debug.Log("�����");
                        MoveLeftThirdLine(S7, S8, S9);
                    }
                }
            }
            else
            {
                if (tapPos.x > firWidt - (firWidt - firWidt * 0.5) && tapPos.x < firWidt + (firWidt * 1.54 - firWidt))
                {
                    if (swipeDelta.y > 0)
                        MoveUpFirstLine(S1, S4, S7);
                    else
                        MoveDownFirstLine(S1, S4, S7);
                }
                if (tapPos.x > secWidt - (secWidt - secWidt * 0.74) && tapPos.x < secWidt + (secWidt * 1.22 - secWidt))
                {
                    if (swipeDelta.y > 0)
                        MoveUpSecondLine(S2, S5, S8);
                    else
                        MoveDownSecondLine(S2, S5, S8);
                }
                if (tapPos.x > thiWidt - (thiWidt - thiWidt * 0.833) && tapPos.x < thiWidt + (thiWidt * 1.15 - thiWidt))
                {
                    if (swipeDelta.y > 0)
                        MoveUpTrirdLine(S3, S6, S9);
                    else
                        MoveDownThirdLine(S3, S6, S9);
                }
            }
            //else
            //    SwipeEvent(swipeDelta.y > 0 ? Vector2.up : Vector2.down);


            ResetSwipe();
        }

    }

    private void ResetSwipe()
    {
        isSwiped = false;
        tapPos = Vector2.zero;
        swipeDelta = Vector2.zero;

    }

    private float minimum = 0f;
    private float maximum = 1f;

    private IEnumerator coroutine1;
    private IEnumerator coroutine2;
    private IEnumerator coroutine3;

    public void MoveLeftFirstLine(Image S1, Image S2, Image S3)
    {
        DoZeroSpriteFirstLineG();

        var q = S1.sprite;
        S1.sprite = S2.sprite;
        S2.sprite = S3.sprite;
        S3.sprite = q;

        coroutine1 = Enum1(minimum, 0.008f);
        StartCoroutine(coroutine1);
        coroutine2 = Enum2(minimum, 0.010f);
        StartCoroutine(coroutine2);
        coroutine3 = Enum3(minimum, 0.012f);
        StartCoroutine(coroutine3);
    }

    public void MoveRightFirstLine(Image S1, Image S2, Image S3)
    {
        DoZeroSpriteFirstLineG();

        var g = S3.sprite;
        S3.sprite = S2.sprite;
        S2.sprite = S1.sprite;
        S1.sprite = g;

        coroutine1 = Enum3(minimum, 0.008f);
        StartCoroutine(coroutine1);
        coroutine2 = Enum2(minimum, 0.010f);
        StartCoroutine(coroutine2);
        coroutine3 = Enum1(minimum, 0.012f);
        StartCoroutine(coroutine3);
    }

    public void MoveLeftSecondLine(Image S1, Image S2, Image S3)
    {
        DoZeroSpriteSecondLineG();

        var q = S1.sprite;
        S1.sprite = S2.sprite;
        S2.sprite = S3.sprite;
        S3.sprite = q;

        coroutine1 = Enum4(minimum, 0.008f);
        StartCoroutine(coroutine1);
        coroutine2 = Enum5(minimum, 0.010f);
        StartCoroutine(coroutine2);
        coroutine3 = Enum6(minimum, 0.012f);
        StartCoroutine(coroutine3);
    }

    public void MoveRightSecondLine(Image S1, Image S2, Image S3)
    {
        DoZeroSpriteSecondLineG();

        var g = S3.sprite;
        S3.sprite = S2.sprite;
        S2.sprite = S1.sprite;
        S1.sprite = g;

        coroutine1 = Enum6(minimum, 0.008f);
        StartCoroutine(coroutine1);
        coroutine2 = Enum5(minimum, 0.010f);
        StartCoroutine(coroutine2);
        coroutine3 = Enum4(minimum, 0.012f);
        StartCoroutine(coroutine3);
    }

    public void MoveLeftThirdLine(Image S1, Image S2, Image S3)
    {
        DoZeroSpriteThirdLineG();

        var q = S1.sprite;
        S1.sprite = S2.sprite;
        S2.sprite = S3.sprite;
        S3.sprite = q;

        coroutine1 = Enum7(minimum, 0.008f);
        StartCoroutine(coroutine1);
        coroutine2 = Enum8(minimum, 0.010f);
        StartCoroutine(coroutine2);
        coroutine3 = Enum9(minimum, 0.012f);
        StartCoroutine(coroutine3);
    }

    public void MoveRightTrirdLine(Image S1, Image S2, Image S3)
    {
        DoZeroSpriteThirdLineG();

        var g = S3.sprite;
        S3.sprite = S2.sprite;
        S2.sprite = S1.sprite;
        S1.sprite = g;

        coroutine1 = Enum9(minimum, 0.008f);
        StartCoroutine(coroutine1);
        coroutine2 = Enum8(minimum, 0.010f);
        StartCoroutine(coroutine2);
        coroutine3 = Enum7(minimum, 0.012f);
        StartCoroutine(coroutine3);
    }

    public void MoveUpFirstLine(Image S1, Image S2, Image S3)
    {
        DoZeroSpriteFirstLineV();

        var q = S1.sprite;
        S1.sprite = S2.sprite;
        S2.sprite = S3.sprite;
        S3.sprite = q;

        coroutine1 = Enum1(minimum, 0.008f);
        StartCoroutine(coroutine1);
        coroutine2 = Enum4(minimum, 0.010f);
        StartCoroutine(coroutine2);
        coroutine3 = Enum7(minimum, 0.012f);
        StartCoroutine(coroutine3);
    }

    public void MoveDownFirstLine(Image S1, Image S2, Image S3)
    {
        DoZeroSpriteFirstLineV();

        var g = S3.sprite;
        S3.sprite = S2.sprite;
        S2.sprite = S1.sprite;
        S1.sprite = g;

        coroutine1 = Enum7(minimum, 0.008f);
        StartCoroutine(coroutine1);
        coroutine2 = Enum4(minimum, 0.010f);
        StartCoroutine(coroutine2);
        coroutine3 = Enum1(minimum, 0.012f);
        StartCoroutine(coroutine3);
    }

    public void MoveUpSecondLine(Image S1, Image S2, Image S3)
    {
        DoZeroSpriteSecondLineV();

        var q = S1.sprite;
        S1.sprite = S2.sprite;
        S2.sprite = S3.sprite;
        S3.sprite = q;

        coroutine1 = Enum2(minimum, 0.008f);
        StartCoroutine(coroutine1);
        coroutine2 = Enum5(minimum, 0.010f);
        StartCoroutine(coroutine2);
        coroutine3 = Enum8(minimum, 0.012f);
        StartCoroutine(coroutine3);
    }

    public void MoveDownSecondLine(Image S1, Image S2, Image S3)
    {
        DoZeroSpriteSecondLineV();

        var g = S3.sprite;
        S3.sprite = S2.sprite;
        S2.sprite = S1.sprite;
        S1.sprite = g;

        coroutine1 = Enum8(minimum, 0.008f);
        StartCoroutine(coroutine1);
        coroutine2 = Enum5(minimum, 0.010f);
        StartCoroutine(coroutine2);
        coroutine3 = Enum2(minimum, 0.012f);
        StartCoroutine(coroutine3);
    }

    public void MoveUpTrirdLine(Image S1, Image S2, Image S3)
    {
        DoZeroSpriteThirdLineV();

        var q = S1.sprite;
        S1.sprite = S2.sprite;
        S2.sprite = S3.sprite;
        S3.sprite = q;

        coroutine1 = Enum3(minimum, 0.008f);
        StartCoroutine(coroutine1);
        coroutine2 = Enum6(minimum, 0.010f);
        StartCoroutine(coroutine2);
        coroutine3 = Enum9(minimum, 0.012f);
        StartCoroutine(coroutine3);
    }
    public void MoveDownThirdLine(Image S1, Image S2, Image S3)
    {
        DoZeroSpriteThirdLineV();

        var g = S3.sprite;
        S3.sprite = S2.sprite;
        S2.sprite = S1.sprite;
        S1.sprite = g;

        coroutine1 = Enum9(minimum, 0.008f);
        StartCoroutine(coroutine1);
        coroutine2 = Enum6(minimum, 0.010f);
        StartCoroutine(coroutine2);
        coroutine3 = Enum3(minimum, 0.012f);
        StartCoroutine(coroutine3);
    }

    public void DoZeroSpriteFirstLineG()
    {
        S1.transform.localScale = Vector3.zero;
        S2.transform.localScale = Vector3.zero;
        S3.transform.localScale = Vector3.zero;
    }

    public void DoZeroSpriteSecondLineG()
    {
        S4.transform.localScale = Vector3.zero;
        S5.transform.localScale = Vector3.zero;
        S6.transform.localScale = Vector3.zero;
    }

    public void DoZeroSpriteThirdLineG()
    {
        S7.transform.localScale = Vector3.zero;
        S8.transform.localScale = Vector3.zero;
        S9.transform.localScale = Vector3.zero;
    }

    public void DoZeroSpriteFirstLineV()
    {
        S1.transform.localScale = Vector3.zero;
        S4.transform.localScale = Vector3.zero;
        S7.transform.localScale = Vector3.zero;
    }

    public void DoZeroSpriteSecondLineV()
    {
        S2.transform.localScale = Vector3.zero;
        S5.transform.localScale = Vector3.zero;
        S8.transform.localScale = Vector3.zero;
    }

    public void DoZeroSpriteThirdLineV()
    {
        S3.transform.localScale = Vector3.zero;
        S6.transform.localScale = Vector3.zero;
        S9.transform.localScale = Vector3.zero;
    }


    IEnumerator Enum1(float minimum, float f)
    {
        for (minimum = 0f; minimum < maximum; minimum = minimum + 0.05f)
        {
            yield return new WaitForSeconds(f);
            S1.transform.localScale = new Vector3(minimum, minimum, minimum);
        }
    }
    IEnumerator Enum2(float minimum, float f)
    {
        for (minimum = 0f; minimum < maximum; minimum = minimum + 0.05f)
        {
            yield return new WaitForSeconds(f);
            S2.transform.localScale = new Vector3(minimum, minimum, minimum);    
        }
    }
    IEnumerator Enum3(float minimum, float f)
    {
        for (minimum = 0f; minimum < maximum; minimum = minimum + 0.05f)
        {
            yield return new WaitForSeconds(f);
            S3.transform.localScale = new Vector3(minimum, minimum, minimum);
        }
    }

    IEnumerator Enum4(float minimum, float f)
    {
        for (minimum = 0f; minimum < maximum; minimum = minimum + 3.2f)
        {
            yield return new WaitForSeconds(f);
            S4.transform.localScale = new Vector3(minimum, minimum, minimum);
        }
    }

    IEnumerator Enum5(float minimum, float f)
    {
        for (minimum = 0f; minimum < maximum; minimum = minimum + 3.2f)
        {
            yield return new WaitForSeconds(f);
            S5.transform.localScale = new Vector3(minimum, minimum, minimum);
        }
    }

    IEnumerator Enum6(float minimum, float f)
    {
        for (minimum = 0f; minimum < maximum; minimum = minimum + 3.2f)
        {
            yield return new WaitForSeconds(f);
            S6.transform.localScale = new Vector3(minimum, minimum, minimum);
        }
    }

    IEnumerator Enum7(float minimum, float f)
    {
        for (minimum = 0f; minimum < maximum; minimum = minimum + 3.2f)
        {
            yield return new WaitForSeconds(f);
            S7.transform.localScale = new Vector3(minimum, minimum, minimum);
        }
    }

    IEnumerator Enum8(float minimum, float f)
    {
        for (minimum = 0f; minimum < maximum; minimum = minimum + 3.2f)
        {
            yield return new WaitForSeconds(f);
            S8.transform.localScale = new Vector3(minimum, minimum, minimum);
        }
    }

    IEnumerator Enum9(float minimum, float f)
    {
        for (minimum = 0f; minimum < maximum; minimum = minimum + 3.2f)
        {
            yield return new WaitForSeconds(f);
            S9.transform.localScale = new Vector3(minimum, minimum, minimum);
        }
    }
}
