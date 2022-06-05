using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class sliderAudio : MonoBehaviour
{
    [SerializeField] private AudioMixer musicAudioMixer;

    public void setVolume(float sliderValue) {
        musicAudioMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue)*20);
     }
}
