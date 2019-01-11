using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovs : MonoBehaviour {

    //Editable player's speed
    public float speed;
    private Rigidbody2D rb2d;
    Animator anim;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        //Setting player's movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //Moving all directions
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.velocity = movement * speed;

        //If a key "A" is pressed, animator will change the state to "2" - changing animation
        if (Input.GetKeyDown (KeyCode.A))
        {
            anim.SetInteger("State", 2);
        }
        //If a key "D" is pressed, animator will change the state to "1" - changing animation
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetInteger("State", 1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetInteger("State", 1);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetInteger("State", 1);
        }

        //If a key "A" is released, animator will change the state to "0" - changing animation
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetInteger("State", 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetInteger("State", 0);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetInteger("State", 0);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetInteger("State", 0);
        }
    }
}
