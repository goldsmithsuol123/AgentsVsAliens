using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class displayPistol : MonoBehaviour {




	Text tempText;
	public string typeText = "";
	// Use this for initialization
	void Start () {
		tempText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	public void displayText() {
		gameObject.SetActive (true);
	}

	void Update()
	{
		tempText.text = typeText;
	}
}
