using UnityEngine;
using System.Collections;

public class RatCollect : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            ScoreCounter.score += 10;
            Destroy(gameObject);
        }
    }
}
