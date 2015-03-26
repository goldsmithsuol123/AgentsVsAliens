using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class weaponCost : MonoBehaviour {
	Text getText;
	public GameObject purchaseBtn;
	UnlockWeapon getPrice;
	public string unlockID;


	
	// Use this for initialization
	void Start () {
		getPrice = purchaseBtn.GetComponent<UnlockWeapon>();
		getText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt (unlockID) == 1)
		{
			gameObject.SetActive(false);
		}
		else
		{
			getText.text = "Cost: $" + getPrice.costInFloat.ToString();
		}

	}
}
