using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    void Update() 
    {
        DontDestroyOnLoad(gameObject);
    }
    public void OnGUI()
    {
        Color32 myColor = new Color32(90, 140, 150, 250);
        GUI.color = myColor;
        GUI.Label(new Rect(10,30,100,20), "Health: " + PLRControler.health);
    }
}
