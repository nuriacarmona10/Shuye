using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlesColision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject flower;

    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnParticleCollision(GameObject other)
    {
       // GameObject newFlower = Instantiate(flower);
       // newFlower.transform.position = particleSystem.transform.position;
        Debug.Log("EStoy colisionando");
    }
}
