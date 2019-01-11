using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public void EndGame ()
    {
        //when the "EndGame" is triggered, "Restart" will happen
        Restart();
    }

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        //Is turning the level/scene as completed
        completeLevelUI.SetActive(true);
    }

    void Restart ()
    {
        //"Restart" will load the same scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
