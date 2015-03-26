using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	// THIS CLASS IS NOT USED WITHIN THE PROJECT
	//USED FOR TESTING AND TEACHING PURPOSES
	
	// Update is called once per frame
	public void ChangeToScene (string sceneToChangeTo) {
		Application.LoadLevel (sceneToChangeTo);
	}
}
