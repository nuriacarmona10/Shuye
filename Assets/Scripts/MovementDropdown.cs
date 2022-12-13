using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementDropdown : MonoBehaviour
{
    public GameObject locomotionSystem;

    Dropdown dropdown;
    void Start()
    {
        dropdown = GetComponent<Dropdown>();
    }

    // Update is called once per frame
    public void checkValues()
    {
        switch (dropdown.value)
        {
            case 0:
                Debug.Log("Continuo");
                break;
            case 1:
                Debug.Log("Teleport");
                break;
        }
    }
}
