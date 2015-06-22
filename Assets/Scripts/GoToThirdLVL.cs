using UnityEngine;
using System.Collections;

public class GoToThirdLVL : MonoBehaviour {
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel("Scene3");
        }
    }
}
