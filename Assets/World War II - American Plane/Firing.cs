using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour {
public GameObject spellEffect;
public float timeBetweenShots = 0.25f;
private float shootTime;
private Vector3 firespotpos;
private GameObject firespot;
//private Wfirespotrot;

//void Start () {
	//shootTime = Time.time;
	//firespot = GameObject.Find ("firespot");
//}


	// Update is called once per frame
	//void Update () {
		//firespotrot
		//firespotpos = firespot.transform.position;
		//Vector3 dP = firespotpos, anchor;
		//Quaternion shotRot = Quaternion.LookRotation(dP, Vector3.forward);
		//if(Time.timeScale > 0) {
		//	if(Input.GetMouseButton(0) && Time.time > shootTime) {
			//	shootTime = Time.time + timeBetweenShots;
				

				//Instantiate(spellEffect, firespotpos, Quaternion.identity);
			//}
	//	}
//	}
}
