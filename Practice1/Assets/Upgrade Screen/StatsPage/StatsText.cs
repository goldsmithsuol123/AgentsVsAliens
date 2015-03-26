using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StatsText : MonoBehaviour {
	Text txt;

	// Use this for initialization
	void Start () {
		txt = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		//display Text
		txt.text = "Kills: "+ PlayerPrefs.GetInt("AlienKills") + "\n" +
		"Deaths: "+ PlayerPrefs.GetInt("PlayerDeaths")+ "\n" +
		"Bullets Fired: "+ PlayerPrefs.GetInt("BuletsFired")  + "\n" +
		"Waves Cleared: "+ PlayerPrefs.GetInt("WavesCleared")  + "\n" +
		"Total Xp Earned: "+ PlayerPrefs.GetFloat("TotalXpEarned") + "\n" +
		"Total Money Earned: $" + PlayerPrefs.GetFloat("TotalMoneyEarned");
	}
}
