using UnityEngine;
using System.Collections;

public class PlayerPrefsFirstTime : MonoBehaviour {
	//Used for first time playing the game
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("firstTime") == 1)
		{
			//not their first time;
			//PlayerPrefs.SetInt("firstTime", 0);
			//PlayerPrefs.Save ();
		}
		else
		{
			PlayerPrefs.SetInt("firstTime", 1);
			//================WEAPONS====================
			//pistol
			PlayerPrefs.SetFloat ("pistoldamage", 1);
			PlayerPrefs.SetFloat ("pistolFireRate" ,1);
			PlayerPrefs.SetInt ("pistoldmgPurchases", 0);
			PlayerPrefs.SetInt ("pistolFireRatePurchases",0);
			
			//smg
			PlayerPrefs.SetFloat ("smgdamage", 1);
			PlayerPrefs.SetFloat ("smgFireRate" ,3);
			PlayerPrefs.SetInt ("smgdmgPurchases", 0);
			PlayerPrefs.SetInt ("smgFireRatePurchases",0);
			PlayerPrefs.SetInt ("smgUnlock",0);
			
			//AutoRifle 
			PlayerPrefs.SetFloat ("ARdamage", 4);
			PlayerPrefs.SetFloat ("ARFireRate" ,2);
			PlayerPrefs.SetInt ("ARdmgPurchases", 0);
			PlayerPrefs.SetInt ("ARFireRatePurchases",0);
			PlayerPrefs.SetInt ("ARUnlock",0); // 0 means weapon is locked. 1 means it is unlocked.
			
			//lmg
			PlayerPrefs.SetFloat ("lmgdamage", 6);
			PlayerPrefs.SetFloat ("lmgFireRate" ,3);
			PlayerPrefs.SetInt ("lmgdmgPurchases", 0);
			PlayerPrefs.SetInt ("lmgFireRatePurchases",0);
			PlayerPrefs.SetInt ("lmgUnlock",0);
			
			//sniper
			PlayerPrefs.SetFloat ("sniperdamage", 30);
			PlayerPrefs.SetFloat ("sniperFireRate" ,0.5f);
			PlayerPrefs.SetInt ("sniperdmgPurchases", 0);
			PlayerPrefs.SetInt ("sniperFireRatePurchases",0);
			PlayerPrefs.SetInt ("sniperUnlock",0);
			
			//==========================================
			
			
			//Player Attributes
			PlayerPrefs.SetInt("EquippedWeapon",0);// control what weapon player has
			PlayerPrefs.SetFloat ("Money",0); //player money
			PlayerPrefs.SetFloat ("PlayerHealth",100);// current max hp
			PlayerPrefs.SetFloat ("CurrentExp",0);
			PlayerPrefs.SetInt ("CurrentLevel",1);
			
			//PlayerStats History
			PlayerPrefs.SetInt("AlienKills",0);
			PlayerPrefs.SetInt("PlayerDeaths",0);
			PlayerPrefs.SetInt("WavesCleared",0);
			PlayerPrefs.SetInt("BuletsFired",0);
			PlayerPrefs.SetFloat("TotalXpEarned",0);
			PlayerPrefs.SetFloat("TotalMoneyEarned",0);
			
			//System stats
			PlayerPrefs.SetInt("MuteSound",0);
			
			PlayerPrefs.Save ();
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
