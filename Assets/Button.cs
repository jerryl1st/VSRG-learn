using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
		public KeyCode key;

		public bool MappingMode;
		public GameObject n;

		 float MaxScore = 1000000;
		 float BaseScore;
		 float TotalNotes;
		bool active = false;
		GameObject note;
		SpriteRenderer sr;
		Color old;

	//Use this for awake	
	void Awake() {
		sr =  GetComponent<SpriteRenderer>();
		PlayerPrefs.SetInt("Score",0000000);
		TotalNotes = GameObject.FindGameObjectsWithTag ("Note").Length;
		BaseScore = Mathf.Ceil(MaxScore / TotalNotes);
	}
	// Use this for initialization
	void Start () {
		old = sr.color;

	}
	
	// Update is called once per frame
	void Update () {
		if(MappingMode){
			if(Input.GetKeyDown(key))
				Instantiate(n,transform.position,Quaternion.identity);
		}
		else {
			if(Input.GetKeyDown(key)){
				StartCoroutine(Pressed());
		}
			if(Input.GetKeyDown(key)&&active){
				Destroy(note);
				AddScore();
		}
		}
		if(PlayerPrefs.GetFloat("Score") > MaxScore)
		 PlayerPrefs.SetFloat("Score", MaxScore);
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		active = true;
		if(col.gameObject.tag=="Note")
			note = col.gameObject;
	}

	void AddScore() {
		PlayerPrefs.SetFloat("Score",PlayerPrefs.GetFloat("Score")+ BaseScore);
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
