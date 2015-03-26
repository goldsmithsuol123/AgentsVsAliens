// GUI Aspect ratio scale. Script by Devin Curry 4...
using UnityEngine;
using System.Collections;

public class GUIAspectRatioScale : MonoBehaviour {

	public Vector2 scaleOnRatio1 = new Vector2(0.1f,0.2f);
	private Transform myTrans;
	private float widthHeigthRatio;
	// THIS CLASS IS NOT USED WITHIN THE PROJECT
	//USED FOR TESTING AND TEACHING PURPOSES


	// Use this for initialization
	void Start () {
		myTrans = transform;
		SetScale ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		SetScale ();
	}

	//TODO Delete the Update() and also call on an event that tells if the apsect ratio changed
	void SetScale()
	{
		//find the aspect ratio
		widthHeigthRatio = (float)Screen.width / Screen.height * Screen.height;

		//Apply the scale. We only calculate y since our aspect ratio is x (width) authoritative : width/height (x/y)
		myTrans.localScale = new Vector3 (scaleOnRatio1.x, widthHeigthRatio * scaleOnRatio1.y, 1);
	}
}
