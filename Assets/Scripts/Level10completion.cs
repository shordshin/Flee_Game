using UnityEngine;
using System.Collections;

public class Level10completion : MonoBehaviour {
	
	int score = 0;
	
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
	}
	
	void OnGUI()
	{
		
		GUI.Label(new Rect(Screen.width / 2 - 70, 200, 300, 200), "CONGRATULATIONS!");
		GUI.Label(new Rect(Screen.width / 2 - 50, 220, 300, 200), "YOU'RE FREE!!!");
		
		GUI.Label(new Rect(Screen.width / 2 - 40, 300, 80, 30), "Score: " + score);
		
		//GUI.Label (new Rect (Screen.width / 2 - 20, 350, 60, 30), "Retry?");
		
		//if(GUI.Button(new Rect(Screen.width / 2 - 120, 400, 100, 30), "Next Level"))
		//{
			//Application.LoadLevel(24);
		//}
		if(GUI.Button(new Rect(Screen.width / 2 - 50, 400, 100, 30), "Main Menu"))
		{
			Application.LoadLevel(0);
		}
	}
}
