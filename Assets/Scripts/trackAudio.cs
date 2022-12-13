using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class trackAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public TMP_Text time;

    private Slider tracking;
    void Start()
    {
        tracking = GetComponent<Slider>();
        tracking.maxValue = audioSource.clip.length;
    }

    // Update is called once per frame
    void Update()
    {
        tracking.value = audioSource.time;
        time.text = "00:0"+ Math.Round(audioSource.time).ToString();
    }
}
