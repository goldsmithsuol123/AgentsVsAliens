using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class changeSoundIcon : MonoBehaviour {
	public Sprite[] geticons = new Sprite[2];
	int getMute;
	Image getImage;
	// Use this for initialization
	void Start () {
		getMute = PlayerPrefs.GetInt ("MuteSound");
		getImage = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		getMute = PlayerPrefs.GetInt ("MuteSound");
		if(getMute == 0){
			getImage.sprite = geticons[0];
		}
		else{
			getImage.sprite = geticons[1];

		}
	}
}
