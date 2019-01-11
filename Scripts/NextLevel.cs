using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    //If an object collide with this object
    void OnTriggerEnter2D(Collider2D collision)
    {
        //and if the first object is "Player"
        if(collision.transform.name == "Player")
        {
            //the game will load next scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
