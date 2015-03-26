using UnityEngine;
using System.Collections;

public class applyDeath : MonoBehaviour {
	//apply death stats
	int getDeaths;
	// Use this for initialization
	void Start () {
		getDeaths = PlayerPrefs.GetInt("PlayerDeaths");
		PlayerPrefs.SetInt("PlayerDeaths",getDeaths + 1);
		PlayerPrefs.Save ();
	}
	
	// Update is called once per frame
}
