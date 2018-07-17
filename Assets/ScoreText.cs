using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreText : MonoBehaviour {
	public string namestring;
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = PlayerPrefs.GetFloat(namestring)+"";
	}
}
