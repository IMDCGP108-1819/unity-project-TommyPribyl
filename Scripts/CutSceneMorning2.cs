using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneMorning2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        StartCoroutine(JumpToScene());

    }

    IEnumerator JumpToScene()
    {
        //SceneManager will wait 19 seconds
        yield return new WaitForSeconds(19.0f);
        //after that the scene called "Day2" will start
        SceneManager.LoadScene("Day2");
    }

}