using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class displayWeaponPage : MonoBehaviour {

	public GameObject[] weaponpage1 = new GameObject[2];
	public int pageid = 0;

	// Use this for initialization
	void Start () {
		for(int i = 0; i < weaponpage1.Length; i++)
		{
			weaponpage1[i].SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void showPage()
	{
		for(int i = 0; i < weaponpage1.Length; i++)
		{
			if(i == pageid)
			{

				weaponpage1[i].SetActive(true);
			}
			else
			{

				weaponpage1[i].SetActive(false);
			}
		}
	}
}
