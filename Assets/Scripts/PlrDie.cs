using UnityEngine;
using System.Collections;

public class PlrDie : MonoBehaviour {
	void Update () 
    {
        if (PLRControler.health <= 0) 
        {
            Application.LoadLevel("GameOver");
        }
	}
}
