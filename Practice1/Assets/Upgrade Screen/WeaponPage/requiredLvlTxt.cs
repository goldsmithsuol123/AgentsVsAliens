using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class requiredLvlTxt : MonoBehaviour {
	int getLvl;
	Text txt;
	public GameObject getObject;
	UnlockWeapon getClass;
	int checkUnlock;
	public string unlockNameID;



	// Use this for initialization
	void Start () {
		txt = GetComponent<Text>();
		getClass = getObject.GetComponent<UnlockWeapon> ();
		getLvl = getClass.getLevelrequired ();
		checkUnlock = PlayerPrefs.GetInt (unlockNameID);
		if(checkUnlock == 1)
		{
			gameObject.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {

		txt.text = "Level Required: " + getLvl;
		checkUnlock = PlayerPrefs.GetInt (unlockNameID);
		if(checkUnlock == 1)
		{
			gameObject.SetActive(false);
		}
	}
}
