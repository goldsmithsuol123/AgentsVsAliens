using System;
using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {


	
	// THIS CLASS IS NOT USED WITHIN THE PROJECT
	//USED FOR TESTING AND TEACHING PURPOSES



	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Enemies")
		{
			wait();
			Destroy(this.gameObject);

		}
	}

	public IEnumerator wait() 
	{
		yield return new WaitForSeconds(3f);
	}
}
