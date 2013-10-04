using UnityEngine;
using System.Collections;

public class Endgame : MonoBehaviour {

	void OnCollisionEnter(Collision obj){
			
			Application.LoadLevel(Application.loadedLevel);
		}
		 
	
}
