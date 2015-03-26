using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EquipWeapon : MonoBehaviour {

	public GameObject[] getWeapons = new GameObject[2];

	// Use this for initialization
	void Start () {
		for(int i = 0 ;i < getWeapons.Length; i++)
		{
			if(i == PlayerPrefs.GetInt("EquippedWeapon"))
			{
				
				getWeapons[i].SetActive(true);//make object active in scene
			}
			else
			{
				
				getWeapons[i].SetActive(false);//make object inactive in scene
			}

		}
	}
	

}
