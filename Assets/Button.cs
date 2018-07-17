using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
		public KeyCode key;
		 int MaxScore = 1000000;
		 int BaseScore;
		 int TotalNotes;
		bool active = false;
		GameObject note;
		SpriteRenderer sr;
		Color old;

	//Use this for awake	
	void Awake() {
		 sr =  GetComponent<SpriteRenderer>();
		 TotalNotes = GameObject.FindGameObjectsWithTag("Note").Length;
		 BaseScore = MaxScore / TotalNotes;
		 PlayerPrefs.SetInt("Score",0000000);
	}
	// Use this for initialization
	void Start () {
		old = sr.color;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(key)){
			StartCoroutine(Pressed());
		}
		if(Input.GetKeyDown(key)&&active){
			Destroy(note);
			AddScore();
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		active = true;
		if(col.gameObject.tag=="Note")
			note = col.gameObject;
	}

	void AddScore() {
		PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score")+ BaseScore);
	}

	void OnTriggerExit2D(Collider2D col) {
		active = false;
	}

	IEnumerator Pressed(){
		sr.color= new Color(0,0,0);
		yield return new WaitForSeconds(0.06f);
		sr.color = old;
	}
}
