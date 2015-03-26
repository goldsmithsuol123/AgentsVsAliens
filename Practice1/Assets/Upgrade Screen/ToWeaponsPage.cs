using UnityEngine;
using System.Collections;

public class ToWeaponsPage : MonoBehaviour {
	public int loadID = 0;

	// Use this for initialization
	public void onMouseUp()
	{
		Application.LoadLevel(loadID);
	}
}
