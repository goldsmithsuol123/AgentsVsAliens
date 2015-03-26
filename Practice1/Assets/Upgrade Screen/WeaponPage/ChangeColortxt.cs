using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeColortxt : MonoBehaviour {
	//used for equip weapon btn
	// Use this for initialization
	public int currentID;
	int gunid;
	Text getTxt;

	void Start () {
		gunid = PlayerPrefs.GetInt("EquippedWeapon");
		getTxt = GetComponent<Text> ();
		if(gunid == currentID)
		{
			getTxt.color = Color.yellow;
		}
		else
		{
			getTxt.color = Color.red;
		}
	}
	
	// Update is called once per frame
	void Update () {
		Start ();
	}
}
