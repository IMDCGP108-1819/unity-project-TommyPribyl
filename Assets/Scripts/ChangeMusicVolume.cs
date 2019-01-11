using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMusicVolume : MonoBehaviour {
    //Editable volume through a slider
    public Slider Volume;
    public AudioSource myMusic;
	
	
	void Update () {
        //Volume of a music equals a value on slider
        myMusic.volume = Volume.value;
        
	}
}
