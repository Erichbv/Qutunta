using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinDelete : MonoBehaviour {
	public int contador=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player"){
			float yOffset = 0.4f;
			contador = contador + 1;
			if (transform.position.y + yOffset > col.transform.position.y){
				contador+=1;
				col.SendMessage("EnemyJump");
				Destroy(gameObject);
				Debug.Log (contador.ToString ());
			} else {
				col.SendMessage("EnemyKnockBack", transform.position.x);
			}
		}
	}
}
