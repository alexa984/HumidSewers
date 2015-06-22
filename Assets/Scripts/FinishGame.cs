using UnityEngine;
using System.Collections;

public class FinishGame : MonoBehaviour {
    public void OnTriggerStay2D(Collider2D col) 
    {
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel("GameOver");
        }
    }
}
