using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour
{
    private bool pauseGame = false;
    void Start() {
        
    }
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            pauseGame = !pauseGame;

            if (pauseGame == true)
            {
                Time.timeScale = 0;
               
                
            }
        }

        if (pauseGame == false)
        {
            Time.timeScale = 1;
        }
    }
    public void OnGUI()
    {
        if (pauseGame == true)
        {
            GUI.backgroundColor = Color.grey;
            
            GUIStyle myStyle = new GUIStyle();
            myStyle.fontSize = 50;
            myStyle.normal.textColor = Color.white;
            GUI.Label(new Rect(Screen.width*0.4f, Screen.height*0.5f, Screen.width*0.4f, Screen.height*0.4f), "PAUSED",myStyle);
        }
    }
}
