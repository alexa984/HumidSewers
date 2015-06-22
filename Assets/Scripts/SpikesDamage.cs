using UnityEngine;
using System.Collections;

public class SpikesDamage : MonoBehaviour {

    public GameObject plr;
    //private int playerHealth;
	// Use this for initialization
	void Start () 
    {
        //PLRControler plrhealth = plr.GetComponent<PLRControler>();
        //playerHealth = plrhealth.health;   
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player") 
        {
           PLRControler.health -= 5;
           Debug.Log(PLRControler.health);
        }
    }
    IEnumerator CutDownLife(int hlth) 
    {
       hlth -= 5;
        yield return new WaitForSeconds(5);
    }

    void OnCollisionStay2D() 
    {
         StartCoroutine(CutDownLife(PLRControler.health));
         Debug.Log(PLRControler.health);
    }
    
}
