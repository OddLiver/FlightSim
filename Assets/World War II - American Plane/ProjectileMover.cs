using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMover : MonoBehaviour {
	public float speed = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Target") {
			other.gameObject.SendMessage("TargetHit");
			Debug.Log("hitpanzer");
			Destroy(this.gameObject);
		}
	}
	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Boundary") {
			Destroy(this.gameObject);
		}
	}
}

