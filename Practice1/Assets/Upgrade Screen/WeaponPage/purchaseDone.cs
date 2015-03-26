using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class purchaseDone : MonoBehaviour {

	public GameObject[] showstats = new GameObject[9];
	public string unlockNameID;
	int unlockVal;

	// Use this for initialization
	void Start () {
		unlockVal = PlayerPrefs.GetInt (unlockNameID);

	}
	
	// Update is called once per frame
	void Update () {
		unlockVal = PlayerPrefs.GetInt (unlockNameID);
		if(unlockVal == 1)
		{
			for(int i = 0; i < 9 ; i++)
			{
				showstats[i].SetActive(true);
			}
		}

	}
}
