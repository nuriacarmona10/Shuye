using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSoundOn : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera mainCamera;
    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        AudioSource audio = mainCamera.GetComponent<AudioSource>();
        audio.Play();
    }
}
