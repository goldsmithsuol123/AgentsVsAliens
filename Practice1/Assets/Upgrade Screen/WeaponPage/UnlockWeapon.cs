using UnityEngine;
using System.Collections;

public class UnlockWeapon : MonoBehaviour {

	int getCurrentLevel;
	int checkUnlock;
	public int requiredLevel;
	public string unlockNameID;
	public float costInFloat;
	float playerMoney;
	
	// Use this for initialization
	void Start () {
		checkUnlock = PlayerPrefs.GetInt (unlockNameID);
		playerMoney = PlayerPrefs.GetFloat ("Money");
		getCurrentLevel = PlayerPrefs.GetInt ("CurrentLevel");
		if(checkUnlock == 1)
		{
			gameObject.SetActive(false);
		}

	}
	
	// Update is called once per frame
	public void purchaseWeapon()
	{
		if(getCurrentLevel >= requiredLevel && playerMoney >= costInFloat )
		{
			PlayerPrefs.SetInt (unlockNameID,1);
			PlayerPrefs.SetFloat ("Money",playerMoney - costInFloat);
			PlayerPrefs.Save();
			gameObject.SetActive(false);
		}
		else
		{
			//insufficient funds
		}	
	}

	public int getLevelrequired()
	{
		return requiredLevel;

	}
}
