using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine( JumpToScene ());
	}
	IEnumerator JumpToScene()
    {
        //SceneManager will wait 23 seconds
        yield return new WaitForSeconds(23.0f);
        //after that the scene called "morning1" will start
        SceneManager.LoadScene("morning1");
    } 

	
}
