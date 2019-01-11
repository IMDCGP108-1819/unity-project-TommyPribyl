using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigameMovement : MonoBehaviour {

    public Rigidbody2D rb;
    public float playerForce;
    //Editable player's speed
    public float speed;

    
    void FixedUpdate ()
    {
        // Adding force to automatically move forward
        rb.AddForce(new Vector2(0, playerForce));
        ////Setting horizontal axis - direction of player's movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        //Moving just horizontal directions
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb.velocity = movement * speed;
    }
}
