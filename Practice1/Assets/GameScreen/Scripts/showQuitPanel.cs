using UnityEngine;
using System.Collections;

public class showQuitPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	public void showPanel(){
		gameObject.SetActive (true);

	}

	public void hidePanel(){
		gameObject.SetActive (false);
		
	}
}
