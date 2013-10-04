using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {
	static public int score = 0;
	
	
	
	void OnCollisionEnter( Collision obj ) {
		if(obj.gameObject.tag == "burgerscore")
		{
		audio.Play ();
		score ++;
		
		}
		if (obj.gameObject.tag == "broccoliscore"){
		audio.Play();
	//score = score - 5;
	//
		}
		
		
	}
	
	private void OnGUI(){
	
		GUI.Label(new Rect(20,15,150,25), "Find the CAKE!");
		GUI.Label(new Rect(20, 30, 150, 25), "Highest Score: " + score);
		
		
		
	}
	
	//private void OnGUI()
		
		
	//{
	//	GUI.Label(new Rect(20, 15, 150, 25), "Hello Hungry Man!");
	//	GUI.Label(new Rect(20, 30, 150, 25), "Your Score: ");		
	//}
	
}
