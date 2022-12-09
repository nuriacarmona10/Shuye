using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCountdown());
    }
    
    IEnumerator StartCountdown()
    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadSceneAsync(1);
    }
}
