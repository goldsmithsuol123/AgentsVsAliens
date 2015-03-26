using UnityEngine;
using System.Collections;

public class displaystats : MonoBehaviour {

	// THIS CLASS IS NOT USED WITHIN THE PROJECT
	//USED FOR TESTING AND TEACHING PURPOSES

	public Weapon wep;
	public Weapon wep2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.color = Color.red;
		GUI.Label(new Rect (100,20,200,20), "PistolDamage = " + (wep.getDamage()).ToString() );
		GUI.Label(new Rect (100,40,200,20), "SubMDamage = " + (wep2.getDamage()).ToString() );
	}
}
