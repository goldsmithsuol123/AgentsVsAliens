using UnityEngine;
using System.Collections;



public class swapWeapons : MonoBehaviour {
	public GameObject weapon01;
	public GameObject weapon02;

	// THIS CLASS IS NOT USED WITHIN THE PROJECT
	//USED FOR TESTING AND TEACHING PURPOSES

	// Use this for initialization
	void Start () {
	
	}

	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Q))
		{

			changeweapons();

		}
	
	}

	void changeweapons()
	{
		if (weapon01.activeSelf) 
		{
			weapon01.SetActive(false);
			weapon02.SetActive(true);
		}
		else
		{
			weapon01.SetActive(true);
			weapon02.SetActive(false);
		}
	}


}
