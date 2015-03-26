using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelGUI : MonoBehaviour {
	
	Text txt;
	int cLvl;//current lvl
	
	
	
	// Use this for initialization
	void Start () {
		txt = GetComponent<Text>();
		cLvl = PlayerPrefs.GetInt ("CurrentLevel");
	}
	
	// Update is called once per frame
	void Update () {
		//display Level Text
		txt.text = "Level: " + cLvl;
		cLvl =  PlayerPrefs.GetInt ("CurrentLevel");
		
	}
}
