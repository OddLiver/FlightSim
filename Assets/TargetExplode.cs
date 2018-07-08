using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetExplode : MonoBehaviour {
public GameObject Fire;
UnityEngine.AI.NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void TargetHit () {
		Fire.SetActive(true);

		gameObject.transform.parent.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
	}
}
