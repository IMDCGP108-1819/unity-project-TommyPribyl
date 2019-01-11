using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisSIDE : MonoBehaviour {
    //Reference to our player movement script
    public miniSIDE movement;

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        //If a player collides with anything tagged "Collidors" 
        if (collisionInfo.collider.tag == "Collidors")
        {
            //player will stop moving.
            movement.enabled = false;
            //Referring to script called GameManager - EndGame, which will restart the level.
            FindObjectOfType<GameManager>().EndGame();

        }
    }

}
