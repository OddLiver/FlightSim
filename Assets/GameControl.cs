using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
public int hell;
public int lost = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	hell = Random.Range(1, 1);
	
	if(lost > 4) {
		gameObject.SendMessage("GameLost");
	}


	}

//void GameRefresh() {
//	lost = 0;
//};

 void OnTriggerEnter(Collider other){
   

    if(other.gameObject.tag == "range") {
			Debug.Log("enterrange");
			  if(hell == 1) {
			  	Debug.Log("ded");
      		this.gameObject.SendMessage("DeathMan");
        //this.GetComponent("TargetExplode.cs").TargetHit();
        //playerScript.TargetHit;
		}
		
		if(other.gameObject.tag == "town") {
			lost += 1;
			Debug.Log("entertown");
			Destroy(this.gameObject);
		}
	
     
 }


}
}