using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class buyFirerate : MonoBehaviour {


	//for pistol firerate
	public Sprite[] statschange = new Sprite[9]; 
	public float[] pistolFireRate = new float[9]; 
	public float[] pistolprices = new float[9]; 
	Image getImage;
	public float playerMoney;
	public int purchases;
	public string[] getPlayerPrefs = new string[2];
	// Use this for initialization
	void Start () {
		getImage = gameObject.GetComponent<Image>();
		purchases = PlayerPrefs.GetInt (getPlayerPrefs[0]);
		stateStat ();
		playerMoney = PlayerPrefs.GetFloat ("Money");
	}
	
	void Update()
	{
		playerMoney = PlayerPrefs.GetFloat ("Money");
		PlayerPrefs.Save();
		
	}
	
	public void purchaseValid()
	{
		if(purchases < 8)//max purchases is 9
		{
			if(playerMoney >=  findPrice(purchases))
			{
				PlayerPrefs.SetFloat ("Money",playerMoney - findPrice(purchases));
				PlayerPrefs.Save();
				playerMoney = PlayerPrefs.GetFloat ("Money"); 
				purchases++;
				stateStat(); //apply upgrades
			}
		}
		else
		{
			//stat is maxed
		}	
	}
	
	public float findPrice(int find)
	{
		return pistolprices [find];
	}
	//change image of the bar
	void stateStat()
	{
		for(int i = 0; i < 9; i++)
		{
			if(purchases == i)
			{
				getImage.sprite = statschange[i];
				PlayerPrefs.SetFloat (getPlayerPrefs[1], pistolFireRate[i] );
				PlayerPrefs.SetInt (getPlayerPrefs[0], i);
				PlayerPrefs.Save();
				//Debug.Log (PlayerPrefs.GetFloat("pistolFireRate"));
			}
		}
	}
}
