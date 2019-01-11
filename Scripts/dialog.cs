using UnityEngine;

public class dialog : MonoBehaviour {

    //setting the text as Non-displayed
    bool display = false;
    public string text;

    //If an object collides with this object, it triggers a function
    void OnTriggerEnter2D(Collider2D collided)
    {
        //if the first object is "Player"
        if(collided.transform.name == "Player")
        {
            //text will appear
            display = true;
        }
    }

    //If an object stop colliding with this object
    void OnTriggerExit2D(Collider2D collidere)
    {
        //and the first object is a "Player"
        if(collidere.transform.name == "Player")
        {
            //text will disappear
            display = false;
        }
    }

    void OnGUI ()
    {
        if(display == true)
        {
            //setting position of the text
            GUI.Box(new Rect(0, 500, Screen.width, Screen.height), text);
        }
    }


}
