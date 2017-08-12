using UnityEngine;
using System.Collections;

public class Level1completion : MonoBehaviour {

	int score = 0;
	
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
	}
	
	void OnGUI()
	{

		GUI.Label(new Rect(Screen.width / 2 - 90, 200, 300, 200), "YOU SUCCESSFULLY FLED!");
		
		GUI.Label(new Rect(Screen.width / 2 - 40, 300, 80, 30), "Score: " + score);
		
		//GUI.Label (new Rect (Screen.width / 2 - 20, 350, 60, 30), "Retry?");
		
		if(GUI.Button(new Rect(Screen.width / 2 - 120, 400, 100, 30), "Next Level"))
		{
			Application.LoadLevel(3);
		}
		if(GUI.Button(new Rect(Screen.width / 2 + 30, 400, 100, 30), "Main Menu"))
		{
			Application.LoadLevel(0);
		}
	}
}
