using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnGUI()
    {
            GUI.backgroundColor = Color.grey;
            GUIStyle myStyle = new GUIStyle();
            myStyle.fontSize = 50;
            myStyle.normal.textColor = Color.white;
            GUI.Label(new Rect(Screen.width * 0.25f, Screen.height * 0.2f, Screen.width * 0.4f, Screen.height * 0.4f),"Thank you for playing!",myStyle);
            GUI.Label(new Rect(Screen.width * 0.25f, Screen.height * 0.5f, Screen.width * 0.4f, Screen.height * 0.4f), "Your Final Score is: "+(PLRControler.health+ScoreCounter.score), myStyle);
        
    }
}
