using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstIntro : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(JumpToScene());
    }
    IEnumerator JumpToScene()
    {
        //SceneManager will wait 7 seconds
        yield return new WaitForSeconds(7.0f);
        //after that, the scene called "intro" will start
        SceneManager.LoadScene("intro");
    }


}
