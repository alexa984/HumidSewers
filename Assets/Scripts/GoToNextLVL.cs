using UnityEngine;
using System.Collections;

public class GoToNextLVL : MonoBehaviour {
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel("Scene2");
        }
    }

}
