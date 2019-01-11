using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

     void OnTriggerEnter2D()
    {
        //script called GameManager will trigger "CompleteLevel" function
        gameManager.CompleteLevel();
    }

}
