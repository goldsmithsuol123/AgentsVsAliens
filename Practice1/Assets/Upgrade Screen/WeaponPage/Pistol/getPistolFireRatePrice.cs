using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class getPistolFireRatePrice : MonoBehaviour {
	Text getText;
	public GameObject findbar;
	buyFirerate findP;
	public string getPlayerPrefs;
	// Use this for initialization
	void Start () {


		findP = findbar.GetComponent<buyFirerate> ();
		getText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt (getPlayerPrefs) < 8)
		{
			getText.text = "$ " + (findP.findPrice(PlayerPrefs.GetInt (getPlayerPrefs))).ToString (); 
		}
		else
		{
			getText.text = "MAX";
		}
	}
}
