using UnityEngine;
using System.Collections;

public class WPequip : MonoBehaviour {

	public int gunID;

	// Use this for initialization
	void Start () {

	}

	public void changeWeap()
	{
		PlayerPrefs.SetInt("EquippedWeapon",gunID);
		PlayerPrefs.Save ();
	}
	

}
