using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssistedTurn : MonoBehaviour
{
    private Toggle toggle;
    public GameObject locomotionSystem;
    void Start()
    {
         toggle = gameObject.GetComponent<Toggle>();
    }

    // Update is called once per frame
    public void checkToggle()
    {
        if(!toggle.isOn)
        {
          locomotionSystem.GetComponent<UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider>().enabled=false;
          locomotionSystem.GetComponent<UnityEngine.XR.Interaction.Toolkit.ActionBasedContinuousTurnProvider>().enabled=false;
        }
        else
        {
            locomotionSystem.GetComponent<UnityEngine.XR.Interaction.Toolkit.ActionBasedContinuousTurnProvider>().enabled = true;

        }
    }
}
