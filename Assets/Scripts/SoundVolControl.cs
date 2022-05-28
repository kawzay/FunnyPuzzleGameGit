using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundVolControl : MonoBehaviour
{
    [Header ("Script")]
    [SerializeField] public AudioSource audio;
    [SerializeField] public Slider slider;
    [SerializeField] public string SaveVolume;
    [SerializeField] public float volume;
    [SerializeField] public string sliderTag;

    private void Awake()
    {
        if(PlayerPrefs.HasKey(this.SaveVolume))
        {
            this.volume = PlayerPrefs.GetFloat(this.SaveVolume);
            this.audio.volume = this.volume;

            GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);
            if (sliderObj != null)
            {
                this.slider = sliderObj.GetComponent<Slider>();
                this.slider.value = this.volume;
            }
        }
        else
        {
            this.volume = 0.5f;
            PlayerPrefs.SetFloat(this.SaveVolume, this.volume);
            this.audio.volume = this.volume;
        }


    }
    private void LateUpdate()
    {
        GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);
        if (sliderObj != null)
        {
            this.slider = sliderObj.GetComponent<Slider>();
            this.volume = slider.value;

            if (this.audio.volume != this.volume)
            {
                PlayerPrefs.SetFloat(this.SaveVolume, this.volume);
            }
        }

        this.audio.volume = this.volume;
    }
}
