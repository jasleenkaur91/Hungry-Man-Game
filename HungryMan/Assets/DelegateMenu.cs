using UnityEngine;
using System.Collections;

public class DelegateMenu : MonoBehaviour {
	
	private delegate void MenuDelegate();
	private MenuDelegate menuFunction;
	
	private float screenHeight;
	private float screenWidth;
	private float buttonHeight;
	private float buttonWidth;
	
	
	
	// Use this for initialization
	void Start () 
	{
	screenHeight = Screen.height;
	screenWidth = Screen.width;
		
	buttonHeight = screenHeight * 0.3f;
	buttonWidth = screenWidth * 0.4f;
		
	menuFunction = anyKey;
	}
	
 
	void OnGUI()
	{
	menuFunction();
    

	}
	GUIStyle style = new GUIStyle();//Declare it a new object
	GUIStyle style1 = new GUIStyle();
	GUIStyle style2 = new GUIStyle();
	GUIStyle style3 = new GUIStyle();
	void anyKey()
	{
		if(Input.anyKey)
		{
			menuFunction = mainMenu;
		}
		GUI.skin.label.alignment = TextAnchor.MiddleCenter;
		style.fontSize = 44;
		style1.fontSize = 34;
		style2.fontSize = 24;
		style3.fontSize=24;
    	style.normal.textColor=Color.red;
		style1.normal.textColor = Color.red;
		style2.normal.textColor = Color.blue;
		style3.normal.textColor = Color.red;
   		style.alignment=TextAnchor.MiddleCenter;
		style1.alignment=TextAnchor.MiddleCenter;
		style2.alignment=TextAnchor.MiddleCenter;
		style3.alignment=TextAnchor.MiddleCenter;
   	    GUI.Label (new Rect(Screen.width / 2-300, Screen.height / 2-20, 600, 40), "HUNGRY MAN!", style);
		GUI.Label(new Rect(screenWidth * 0.45f, screenHeight * 0.55f, screenWidth * 0.1f, screenHeight * 0.1f),"Press Any Key to Continue!", style1);
		GUI.Label(new Rect(screenWidth * 0.45f, screenHeight * 0.75f, screenWidth * 0.1f, screenHeight * 0.1f),"<Use Arrow Keys to Play Game>", style2);
		GUI.Label(new Rect(screenWidth * 0.45f, screenHeight * 0.65f, screenWidth * 0.1f, screenHeight * 0.1f),"\"Eating broccoli's will cause death!\"", style3);
		
		
		
	}
	// Update is called once per frame
	void mainMenu()
	{
		
		
	}
}
