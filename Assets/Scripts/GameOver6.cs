using UnityEngine;
using System.Collections;

public class GameOver6 : MonoBehaviour {
	
	int score = 0;
	
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(Screen.width / 2 - 45, 200, 80, 30), "GAME OVER");
		
		GUI.Label(new Rect(Screen.width / 2 - 40, 300, 80, 30), "Score: " + score);
		
		//GUI.Label (new Rect (Screen.width / 2 - 20, 350, 60, 30), "Retry?");
		
		if(GUI.Button(new Rect(Screen.width / 2 - 120, 400, 100, 30), "Retry?"))
		{
			Application.LoadLevel(12);
		}
		if(GUI.Button(new Rect(Screen.width / 2 + 30, 400, 100, 30), "Main Menu"))
		{
			Application.LoadLevel(0);
		}
	}
}
