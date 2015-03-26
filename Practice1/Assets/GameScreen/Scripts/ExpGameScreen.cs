using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class ExpGameScreen : MonoBehaviour {

	public float playerXP;
	public float[] playerXPlvlRequirement = new float[20];
	public int getCurrentLvl;
	int getAlienKills; //get alien kills stats
	float xpEarned; //get total xp record


	
	void Start () {
		//get player records
		playerXP = PlayerPrefs.GetFloat ("CurrentExp");
		getCurrentLvl = PlayerPrefs.GetInt("CurrentLevel");
		getAlienKills = PlayerPrefs.GetInt("AlienKills");
		xpEarned = PlayerPrefs.GetFloat("TotalXpEarned");
	}
	
	public void increaseEXP(float xp)
	{
		playerXP += xp;
		//get player records
		getCurrentLvl = PlayerPrefs.GetInt("CurrentLevel");
		getAlienKills = PlayerPrefs.GetInt("AlienKills") + 1;
		xpEarned = PlayerPrefs.GetFloat("TotalXpEarned") + xp;
		//apply kill and xp earned
		PlayerPrefs.SetInt("AlienKills",getAlienKills);//increase aliens killed
		PlayerPrefs.SetFloat("TotalXpEarned",xpEarned );//record totalxpEarned
		if(playerXP > playerXPlvlRequirement[getCurrentLvl - 1])
		{
			//apply Level up
			playerXP -= playerXPlvlRequirement[getCurrentLvl - 1]; //n-1 due to array elements
			PlayerPrefs.SetInt("CurrentLevel", getCurrentLvl + 1); //increase level
			getCurrentLvl = PlayerPrefs.GetInt("CurrentLevel");

			PlayerPrefs.Save ();

		}
		//Increase XP
		PlayerPrefs.SetFloat ("CurrentExp", playerXP);
		PlayerPrefs.Save ();

	}



}
