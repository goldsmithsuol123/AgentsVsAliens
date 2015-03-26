using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public float fireRate = 0; // 0 means its a single burst weapon
	public float Damage = 10;
	public LayerMask whatToHit;

	public Transform BulletTrailPrefab;
	public float timeToSpawnEffect = 0;
	public float effectSpawnRate = 10;
	public PlayerStats stats;

	float timeToFire = 0;
	Transform firePoint;

	// Use this for initialization


	void Awake () {
		//find Firepoint of the weapon
		firePoint = transform.FindChild ("FirePoint");
		if (firePoint == null) {
			Debug.LogError("No firepoint? WHAT?!");		
		}
		//check what weapon is equiped and find attributes of the weapon
		if(transform.name == "pistol")
		{
			Damage = PlayerPrefs.GetFloat ("pistoldamage");
			fireRate = PlayerPrefs.GetFloat ("pistolFireRate");
		}
		if(transform.name == "smg")
		{
			Damage = PlayerPrefs.GetFloat ("smgdamage");
			fireRate = PlayerPrefs.GetFloat ("smgFireRate");
		}
		if(transform.name == "AR")
		{
			Damage = PlayerPrefs.GetFloat ("ARdamage");
			fireRate = PlayerPrefs.GetFloat ("ARFireRate");
		}
		if(transform.name == "lmg")
		{
			Damage = PlayerPrefs.GetFloat ("lmgdamage");
			fireRate = PlayerPrefs.GetFloat ("lmgFireRate");
		}

		if(transform.name == "sniper")
		{
			Damage = PlayerPrefs.GetFloat ("sniperdamage");
			fireRate = PlayerPrefs.GetFloat ("sniperFireRate");
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (fireRate == 0) { // single burst 
			if (Input.GetButtonDown ("Fire1")) {
				Shoot ();
			}
		}
		else{
			if(Input.GetButton("Fire1") && Time.time > timeToFire){
					timeToFire = Time.time + 1/fireRate;
					Shoot();
			}
		}
	
	}
	//this is the function that makes the gun shoot the aliens
	void Shoot() {
		Vector2 mousePosition = new Vector2 (Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
		Vector2 firePointPosition = new Vector2 (firePoint.position.x, firePoint.position.y);
		RaycastHit2D hit = Physics2D.Raycast (firePointPosition, mousePosition - firePointPosition, 100, whatToHit);

		if( Time.time >= timeToSpawnEffect){
			Effect ();
			timeToSpawnEffect = Time.time + 1/effectSpawnRate;

		}
		Debug.DrawLine (firePointPosition, (mousePosition - firePointPosition)*100);
		if (hit.collider != null) {
			Debug.DrawLine( firePointPosition, hit.point, Color.red);
			Debug.Log("We hit " + hit.collider.name);
		}

	}
	void Effect(){
		Instantiate (BulletTrailPrefab, firePoint.position, firePoint.rotation);
		PlayerPrefs.SetInt("BuletsFired",PlayerPrefs.GetInt("BuletsFired") + 1);
		PlayerPrefs.Save ();
	}

	public float getDamage()
	{
		return Damage;

	}

	public string getName()
	{
		return gameObject.name;

	}

	public void saveWeaponStats()
	{

		PlayerPrefs.SetFloat ("pistoldamage", Damage );
		PlayerPrefs.SetFloat ("smgdamage", Damage);
		PlayerPrefs.Save ();

	}


}
