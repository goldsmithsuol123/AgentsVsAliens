using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class EnemyAiScript : MonoBehaviour {

	public float health = 10;
	// Use this for initialization

	protected Animator animator;

	GameObject getCharacter;//for character position;

	public float speed = 1.0f; //speed of the enemy
	public int attack = 1;//use as a trigger for the enemies attack animation
	float stopPos; //stop position
	public float[] HpScale = new float[20];
	public float[] XpScale = new float[20];
	public float[] MoneyScale = new float[20];
	string[] weaponsPath = new string[5]; //String namePath for each weapon
	int getCurrentLevel;
	float xpGiven;

	//Get Classes from GameMaster object
	GameObject findMaster;
	PlayerStats changeMoney;
	ExpGameScreen changeXP;
	MobSpawner checkspawns;


	// Weapons

	Weapon equippedWeapon;



	void Start () 
	{
		getCharacter = GameObject.Find ("character_body");

		//setup animations
		animator = GetComponent<Animator>();
		animator.SetFloat ("Speed", speed);
		animator.SetInteger ("Attack", 0);
		//get GameMaster
		findMaster = GameObject.Find ("GameMaster");
		//get Classes from GameMaster Object
		checkspawns = findMaster.GetComponent<MobSpawner> ();
		changeXP = findMaster.GetComponent<ExpGameScreen> ();
		changeMoney = findMaster.GetComponent<PlayerStats> ();

		//Run applyPlayerDamage 
		StartCoroutine (applyPlayerDamage ());

		//get Current Level and set hp
		getCurrentLevel = PlayerPrefs.GetInt ("CurrentLevel");
		health = HpScale [getCurrentLevel-1];
		xpGiven = XpScale [getCurrentLevel-1];


		//get weapons
		weaponsPath[0] = "character_body/character_arm/pistol";
		weaponsPath[1] = "character_body/character_arm/smg";
		weaponsPath[2] = "character_body/character_arm/AR";
		weaponsPath[3] = "character_body/character_arm/lmg";
		weaponsPath[4] = "character_body/character_arm/sniper";
		equippedWeapon = getEquippedWeapon ();
		/*
		pistol = GameObject.Find ("character_body/character_arm/pistol");
		if(pistol == null)
		{
			//weapon not found
		}
		else
		{
			getPistol = pistol.GetComponent<Weapon> ();
		}



		AutoR = GameObject.Find ("character_body/character_arm/autoRifle");
		if(AutoR == null)
		{
			//weapon not found
		}
		else
		{
			getAutoR = AutoR.GetComponent<Weapon> ();
		}
		*/
	}

	void Update() {
		//findWeapon ();
		stopPos = getCharacter.transform.position.x + 2;
		float step = speed * Time.deltaTime;
		// as step gets more positive with time, it will get closer to its destination.
		transform.position = Vector3.MoveTowards(transform.position, new Vector3(stopPos,transform.position.y,0), step);
		if(transform.position.x <= stopPos)
		{
			animator.SetFloat ("Speed", 0);
			animator.SetInteger ("Attack", attack);


		}
	}

	//enemy collision
	void OnTriggerEnter2D (Collider2D col)
	{


		if(col.gameObject.tag == "PBullet")
		{
			Destroy(col.gameObject);
			applyDamage(equippedWeapon);
		}
		else
		{
			//miss
		}
	}

	//find what weapon is currently equipped
	Weapon getEquippedWeapon()
	{

		GameObject getWeaponObject;
		Weapon foundWeapon = null;


		for(int i = 0; i < weaponsPath.Length;i++ )//loops through all weapons until equipped one is found
		{
			getWeaponObject = GameObject.Find (weaponsPath[i]);
			if(getWeaponObject == null)
			{
				foundWeapon = null;//weapon not found
			}
			else
			{
				foundWeapon = getWeaponObject.GetComponent<Weapon> ();
				break;
			}

		}

		return foundWeapon;
	}


	//apply damage to enemy
	void applyDamage(Weapon wep)
	{
		health -= wep.getDamage(); 
		Debug.Log (health);
		if(health < 1)
		{
			Destroy(this.gameObject);
			checkspawns.subtractEnemy();
			changeMoney.increaseMoney(MoneyScale[getCurrentLevel - 1]);
			if(getCurrentLevel < 20){ //max level only 20
				changeXP.increaseEXP (xpGiven);
			}

		}
	}




	//enemy apply damageOverTime(DOT) on player
	IEnumerator applyPlayerDamage()
	{
		while(true)
		{
			yield return new WaitForSeconds(1);
			if(transform.position.x <= stopPos)
			{
				changeMoney.applyHealthDamage(3f);
				
			}
		}
	}
	
	
	
	





}
