using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingGame : MonoBehaviour
{

    void Start()
    {
        
        StartCoroutine(JumpToScene());
    }

    IEnumerator JumpToScene()
    {
        //SceneManager will wait 5 seconds
        yield return new WaitForSeconds(5.0f);
        //after that he will start scene called "StartMenu"
        SceneManager.LoadScene("StartMenu");
    }

}
