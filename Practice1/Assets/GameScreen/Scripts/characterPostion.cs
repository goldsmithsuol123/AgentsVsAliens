using UnityEngine;
using System.Collections;

public class characterPostion : MonoBehaviour {

	Camera cam;
	float height;
	float width ;

	// Use this for initialization
	void Start () {
		cam = Camera.main; //get Camera object with MainCamera tag
		height = 2f * cam.orthographicSize; //calculate the height of camera
		width = height * cam.aspect; //calculate the width of camera
	}
	
	// Update is called once per frame
	void Update () {
		//set agent position depending on the camera size
		transform.position = new Vector2 (cam.transform.position.x - (width / 2 - 1), -3.76f); 
	}
}
