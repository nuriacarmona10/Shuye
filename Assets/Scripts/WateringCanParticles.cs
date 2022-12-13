using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCanParticles : MonoBehaviour
{

     public ParticleSystem particleSystem;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        Debug.Log("ROTACION:"+ transform.eulerAngles.x);
        if (gameObject.transform.eulerAngles.x > 24 && gameObject.transform.eulerAngles.x < 90)
        {
            particleSystem.Play();
            Debug.Log("Estoy regando");
        }
        else
        {
            particleSystem.Stop();

        }
    }
}
