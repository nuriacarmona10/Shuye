using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setParent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Set()
    {
         Vector3 pos = transform.position;
        transform.SetParent(null, false);
        transform.position = pos;

    }

}
