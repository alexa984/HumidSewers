using UnityEngine;
using System.Collections;

public class HealScript : MonoBehaviour {
    void OnCollisionEnter2D() 
    {
        PLRControler.health += 50;
        Destroy(gameObject);
    }
}
