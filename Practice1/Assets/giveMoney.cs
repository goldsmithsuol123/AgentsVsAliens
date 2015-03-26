using UnityEngine;
using System.Collections;

public class giveMoney : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseUp()
	{
		PlayerPrefs.SetFloat ("Money",1000000);
		PlayerPrefs.Save ();
	}
}
