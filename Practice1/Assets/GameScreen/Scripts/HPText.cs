using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPText : MonoBehaviour {
	Text txt;
	float maxhp;
	GameObject findMaster;
	PlayerStats grabHealth;
	// Use this for initialization
	void Start () {
		maxhp = PlayerPrefs.GetFloat ("PlayerHealth");
		txt = GetComponent<Text>();
		findMaster = GameObject.Find ("GameMaster");
		grabHealth = findMaster.GetComponent<PlayerStats> ();
	}
	
	// Update is called once per frame
	void Update () {
		//display hp text
		maxhp = PlayerPrefs.GetFloat ("PlayerHealth");
		txt.text = "HP: " + grabHealth.playerHealth + "/" + maxhp;
	}
}
