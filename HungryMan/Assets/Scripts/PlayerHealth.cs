using UnityEngine;
using System.Collections;

//[ExecuteInEditMode]
public class PlayerHealth : MonoBehaviour {
	public int health =9;

	void OnCollisionEnter(Collision obj){
		
		if(obj.gameObject.tag == "broccoliscore"){
		--health; 
		}
		 else if(health < 0){
			
			Application.LoadLevel(Application.loadedLevel);
		}
		 
	}
	
	
	
		

}
