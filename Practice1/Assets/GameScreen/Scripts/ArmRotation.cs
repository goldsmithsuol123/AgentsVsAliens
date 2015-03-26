using UnityEngine;
using System.Collections;

public class ArmRotation : MonoBehaviour {

	public int rotationOffset = 90;
	GameObject GameMaster;
	pauseControls getPausesComp;

	void Start(){
		GameMaster = GameObject.Find ("GameMaster"); //find object called GameMaster
		getPausesComp = GameMaster.GetComponent<pauseControls> (); //get pauseControls class
		}
	// Update is called once per frame
	void Update () {
		if(getPausesComp.getPauseState() == false){//check if game is paused
			// subtracting the position of the player from the mouse position
			Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position; //position of mouse and character
			difference.Normalize ();		// normalizing the vector. Meaning that all the sum of the vector will be equal to 1


			float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;	// find the angle in degrees
			if (rotZ > 90 || rotZ < -90) 
			{
				//prevent arm and head rotating at unneccesary angles
			} 
			else 
			{
				transform.rotation = Quaternion.Euler (0f, 0f, rotZ + rotationOffset);		
			}
		}





	}
}
