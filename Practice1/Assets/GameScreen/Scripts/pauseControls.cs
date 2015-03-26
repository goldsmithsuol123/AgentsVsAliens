using UnityEngine;
using System.Collections;

public class pauseControls : MonoBehaviour {

	bool paused;

	// Use this for initialization
	void Start () {
		paused = false;
	}


	public void PauseGame(){
		if(paused == false){
			paused = true;
			Time.timeScale = 0;
		}
	}

	public void unPauseGame(){
		if(paused == true){
			paused = false;
			Time.timeScale = 1;
		}
	}

	public bool getPauseState()
	{
		return paused;
	}

}
