using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    //Reference to our player movement script
    public minigameMovement movement;

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //If a player collides with anything tagged "Collidors"
        if (collisionInfo.collider.tag == "Collidors")
        {
            movement.enabled = false;
            //Referring to script called GameManager - EndGame, which will restart the level.
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
    
}
