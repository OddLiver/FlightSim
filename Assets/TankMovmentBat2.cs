using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovmentBat2 : MonoBehaviour {
public Transform target;
Vector3 destination;
UnityEngine.AI.NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

		agent.destination =  target.position;
		//destination =
		//destination;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//if (Input.GetKeyDown(KeyCode.Space)) {
		//}
		//}
	}
}
