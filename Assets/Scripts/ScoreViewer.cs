using UnityEngine;
using System.Collections;

public class ScoreViewer : MonoBehaviour {
	void Start () {
	
	}
	void Update () {
	
	}
    public void OnGUI() 
    {
        Color32 myColor=new Color32(90,140,150,250);
        GUI.color = myColor;
        GUI.Label(new Rect(10,10,100,20), "Score: "+ScoreCounter.score);
    }
}
