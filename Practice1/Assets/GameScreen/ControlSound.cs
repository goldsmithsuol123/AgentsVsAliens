using UnityEngine;
using System.Collections;

public class ControlSound : MonoBehaviour {
	int getMute;
	// Use this for initialization
	void Start () {
		getMute = PlayerPrefs.GetInt ("MuteSound");
		if(getMute == 0){
			
			AudioListener.volume = 1;
		}
		else{
			
			AudioListener.volume = 0;

		}
	}
	
	// Update is called once per frame
	public void controlMute(){
		if(getMute == 0){

			AudioListener.volume = 0;
			PlayerPrefs.SetInt("MuteSound",1);
			getMute = 1;
			PlayerPrefs.Save ();
		}
		else{

			AudioListener.volume = 1;
			PlayerPrefs.SetInt("MuteSound",0);
			getMute = 0;
			PlayerPrefs.Save ();
		}

	}


}
