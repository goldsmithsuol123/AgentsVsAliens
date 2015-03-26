using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HpBarScript : MonoBehaviour {

	Image findbar;
	float maxhp;
	GameObject findMaster;
	PlayerStats grabHealth;

	// Use this for initialization
	void Start () {
		//get Image
		findbar = GetComponent<Image> ();
		maxhp = PlayerPrefs.GetFloat ("PlayerHealth");

		findMaster = GameObject.Find ("GameMaster");
		grabHealth = findMaster.GetComponent<PlayerStats> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//apply fillAmount change to image
		findbar.fillAmount = (grabHealth.playerHealth / maxhp);
	}
}
