using UnityEngine;
using System.Collections;

public class QuitOnEsc : MonoBehaviour {

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Application.Quit();
        }
	}
}
