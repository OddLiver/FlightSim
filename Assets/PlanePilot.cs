using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePilot : MonoBehaviour {
	
	public float speed = 90.0f;
	
	public GameObject Spawn;

	void Start () {
		Debug.Log("plane pilot script added to : " + gameObject.name);
		
	}
	

	void Update () {

		Vector3 moveCamTo = transform.position - transform.forward * 12.0f + Vector3.up * 5;
			Camera.main.transform.position = moveCamTo;
		Camera.main.transform.LookAt(transform.position + transform.forward * 30.0f);

		transform.position += transform.forward * Time.fixedDeltaTime * speed;

		speed -= transform.forward.y * Time.deltaTime * 50.0f;

		if (speed < 35.0f) {
			speed = 35.0f;
		
		}

		transform.Rotate( Input.GetAxis("Vertical"), 0.0f, -(Input.GetAxis("Horizontal") * 5));

		float terrainHieghtWhereWeAre = Terrain.activeTerrain.SampleHeight(transform.position);

		if(terrainHieghtWhereWeAre > transform.position.y) {
			gameObject.transform.position = Spawn.transform.position;
			speed = 35;
			gameObject.transform.eulerAngles = new Vector3(0, 0, 0);

			//transform.position = new Vector3(
				//transform.position.x,
				//terrainHieghtWhereWeAre,
				//transform.position.z
				
	}
}
	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Boundary") {
	gameObject.transform.position = Spawn.transform.position;
			speed = 35;
			gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
}
}

}
