using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneMorning5 : MonoBehaviour
{

    
    void Start()
    {

        StartCoroutine(JumpToScene());

    }

    IEnumerator JumpToScene()
    {
        //SceneManager will wait 21 seconds
        yield return new WaitForSeconds(21.0f);
        //after that the scene called "EndGame" will start
        SceneManager.LoadScene("EndGame");
    }

}
