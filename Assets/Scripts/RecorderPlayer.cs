using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecorderPlayer : MonoBehaviour
{
    public Animator animator2;


    private Animator animator;
    private AudioSource audio;

    private void Start()
    {
        animator = GetComponent<Animator>();
        
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlayMusic()
    {
        animator.enabled = true;
        animator2.enabled = true;
        audio.Play();
    }
    public void StopMusic()
    {
        animator.enabled = false;
        animator2.enabled = false;
        audio.Stop();
    }
}
