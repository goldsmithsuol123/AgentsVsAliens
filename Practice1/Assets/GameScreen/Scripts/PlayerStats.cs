using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerStats: MonoBehaviour {

	public float playerHealth;
	public float playerMoney;
	public float[] setMaxHp = new float[20];
	int getCurrentLevel;
	float moneyEarned;


	void Start () {
		playerMoney = PlayerPrefs.GetFloat ("Money");
		getCurrentLevel = PlayerPrefs.GetInt ("CurrentLevel");
		PlayerPrefs.SetFloat ("PlayerHealth",setMaxHp[getCurrentLevel - 1]);
		playerHealth = PlayerPrefs.GetFloat ("PlayerHealth");
		moneyEarned = PlayerPrefs.GetFloat("TotalMoneyEarned");
	}

	void Update()
	{
		if(playerHealth < 1)
		{
			Application.LoadLevel(5);
		}
	}
	
	public void increaseMoney(float mon)
	{

		playerMoney += mon;
		moneyEarned = PlayerPrefs.GetFloat("TotalMoneyEarned");
		PlayerPrefs.SetFloat("TotalMoneyEarned",moneyEarned + mon);
		PlayerPrefs.Save ();//check reset.cs

	}

	public void decreaseMoney(float mon)
	{
		playerMoney -= mon;
	}


	public void applyHealthDamage(float hp)
	{
		playerHealth -= hp;
	}








}
