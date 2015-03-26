using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class viewCash : MonoBehaviour {
	Text getText;

	// Use this for initialization
	void Start () {
		getText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		getText.text = "Cash: $" + PlayerPrefs.GetFloat ("Money");
	}
}
