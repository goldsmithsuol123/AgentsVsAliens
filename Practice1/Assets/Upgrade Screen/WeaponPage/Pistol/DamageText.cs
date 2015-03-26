using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DamageText : MonoBehaviour {
	
	
	public GameObject findstats;
	
	Text tempText;
	public string typeText = "";
	damagestats getStats;
	public string getPlayerPrefs;
	// Use this for initialization
	void Start () {
		tempText = GetComponent<Text> ();
		getStats = findstats.GetComponent<damagestats> ();
	}
	
	// Update is called once per frame
	public void displayText() {
		gameObject.SetActive (true);
	}
	
	void Update()
	{
		//display Text
		tempText.text = typeText + getStats.pistoldamages[PlayerPrefs.GetInt(getPlayerPrefs)];
	}
}
