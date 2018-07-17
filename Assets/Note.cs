using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour {
		Rigidbody2D rb;
		public float Speed;

	// Use this for awake

	void Awake () {
		rb = GetComponent<Rigidbody2D>();
	}
	// Use this for initialization
	void Start () {
		rb.velocity= new Vector2(0,-Speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
