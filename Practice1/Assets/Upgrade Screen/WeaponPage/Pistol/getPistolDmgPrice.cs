using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class getPistolDmgPrice : MonoBehaviour {
	Text getText;
	public GameObject findbar;
	damagestats findP;
	public string getPlayerPrefs;
	// Use this for initialization
	void Start () {


		findP = findbar.GetComponent<damagestats> ();
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
