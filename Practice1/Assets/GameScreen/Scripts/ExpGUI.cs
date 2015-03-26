using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExpGUI : MonoBehaviour {

	Text txt;
	GameObject findMaster;
	ExpGameScreen getXP;
	int cLvl;//current lvl
	
	
	
	// Use this for initialization
	void Start () {
		//get Text Component 
		txt = GetComponent<Text>();
		findMaster = GameObject.Find ("GameMaster");
		getXP = findMaster.GetComponent<ExpGameScreen> ();
		cLvl = PlayerPrefs.GetInt ("CurrentLevel");

	}
	
	// Update is called once per frame
	void Update () {
		//display Text
		txt.text = "XP: " + getXP.playerXP + "/" + getXP.playerXPlvlRequirement[cLvl - 1];
		cLvl =  PlayerPrefs.GetInt ("CurrentLevel");

	}
}
