using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class moneyGUI : MonoBehaviour {

	Text txt;
	GameObject findMaster;
	PlayerStats getMoney;



	// Use this for initialization
	void Start () {
		txt = GetComponent<Text>();
		//get PlayerStats class
		findMaster = GameObject.Find ("GameMaster");
		getMoney = findMaster.GetComponent<PlayerStats> ();
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = "Cash: $" + getMoney.playerMoney;
	}
}
