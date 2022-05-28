using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeverStopMus : MonoBehaviour
{
    [Header("Scr")]
    [SerializeField] public string createdTag;
    private void Awake()
    {
        GameObject obj = GameObject.FindWithTag(createdTag);
        if(obj != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            this.gameObject.tag = this.createdTag;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
