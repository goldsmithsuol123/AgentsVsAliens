using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FireRateText : MonoBehaviour {
	
	
	public GameObject findstats;
	
	Text tempText;
	public string typeText = "";
	buyFirerate getStats;
	public string getPlayerPrefs;
	// Use this for initialization
	void Start () {
		tempText = GetComponent<Text> ();
		getStats = findstats.GetComponent<buyFirerate> ();
	}
	
	// Update is called once per frame
	public void displayText() {
		gameObject.SetActive (true);
	}
	
	void Update()
	{
		tempText.text = typeText + getStats.pistolFireRate[PlayerPrefs.GetInt(getPlayerPrefs)];
	}

}
