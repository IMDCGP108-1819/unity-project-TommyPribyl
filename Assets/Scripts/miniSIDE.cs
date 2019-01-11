
using UnityEngine;

public class miniSIDE : MonoBehaviour {

    //Reference to a player
    public Rigidbody2D rb;
    //Editable player's forward speed in Unity program
    public float playerForce;
    //Editable player's sideways speed in Unity program
    public float speed;

    //Update is called once per frame
    void FixedUpdate()
    {
        //Adding force to automatically move forward
        rb.AddForce(new Vector2(-playerForce, 0));
        //Setting vertical axis - direction of player's movement
        float moveVertical = Input.GetAxis("Vertical");
        //Moving just vertical directions
        Vector2 movement = new Vector2(0, moveVertical);
        rb.velocity = movement * speed;
    }

  }
