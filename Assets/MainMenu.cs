using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public string ButtonName;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	 void OnMouseUp() {
     if(ButtonName=="StartBtn")
		 SceneManager.LoadScene("suzuya", LoadSceneMode.Single);
	
	  }
}
