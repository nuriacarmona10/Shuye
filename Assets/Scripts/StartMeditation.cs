using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMeditation : MonoBehaviour
{
    // activar panel meditation
    // reproducir audio
    // cambiar camara de sitio
    // bloquear movimiento

    public GameObject PanelMed;
    public Transform mainCamera;
    public Transform spawnPoint;
    public GameObject locomotionSystem;

    private AudioSource audiosource;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
   public void StartMed()
    {
        PanelMed.SetActive(true);
        mainCamera.transform.position = spawnPoint.position;
        locomotionSystem.SetActive(false);
        audiosource.Play();



    }
}
