using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MobSpawner : MonoBehaviour {

	public GameObject[] enemyPrefab =  new GameObject[2];

	public int spawnlimit = 30;
	public int spawncounter = 0 ;
	public int enemyLeft = 0;

	GameObject findMaster;
	PlayerStats getMoney;
	 
	Camera cam;
	float height;
	float width ;


	// Use this for initializations
	void Start () {
		//get Camera size
		cam = Camera.main;
		height = 2f * cam.orthographicSize;
		width = height * cam.aspect;
		//set amount of enemies spawned
		spawnlimit = Random.Range (10, 20);
		spawncounter = 0;
		enemyLeft = spawnlimit;
		//spawn enemies
		StartCoroutine(EnemySpawn());
	}

	IEnumerator EnemySpawn()
	{
		while(spawncounter < spawnlimit)
		{
			Instantiate (enemyPrefab[Random.Range(0,enemyPrefab.Length)], new Vector2 (cam.transform.position.x + (width / 2 + 1),Random.Range(-4f,-0.6f)), Quaternion.identity);
			yield return new WaitForSeconds(Random.Range(0f,5f));
			spawncounter++;
		}

	}

	void Update()
	{
		//last enemy killed, wave complete
		if(enemyLeft == 0)
		{
			Application.LoadLevel(1);
			findMaster = GameObject.Find ("GameMaster");
			getMoney = findMaster.GetComponent<PlayerStats> ();
			PlayerPrefs.SetInt("WavesCleared",PlayerPrefs.GetInt("WavesCleared") + 1);//record wave cleared
			PlayerPrefs.SetFloat ("Money", getMoney.playerMoney);//save money earned
			PlayerPrefs.Save();

		}
	}

	public void subtractEnemy()
	{
		enemyLeft--;//calculate enemies remaining
	}
	
}

