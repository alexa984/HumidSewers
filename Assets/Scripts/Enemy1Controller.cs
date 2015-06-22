using UnityEngine;
using System.Collections;


public class Enemy1Controller : MonoBehaviour
{

    public GameObject plr;
    public bool canRunAway;
    private Animator anim;
    Transform playerpos;
    private Animator plrstate;
    //private int playerHealth;


    void Start()
    {
        this.anim = this.GetComponent<Animator>();
        playerpos = GameObject.Find("Player").transform;
        this.plrstate = plr.GetComponent<Animator>();
        //PLRControler plrhealth = plr.GetComponent<PLRControler>();
        //playerHealth = plrhealth.health;

    }
    void Update()
    {
        anim.SetInteger("Enemy1State", 0);
        float posNow = this.transform.position.x;
        do
        {
            if (playerpos.position.x > this.transform.position.x - 1.5f)
            {
                anim.SetInteger("Enemy1State", 1);
                continue;

            }
            if (playerpos.position.x > this.transform.position.x - 4.5f && canRunAway==true)
            {

                anim.SetInteger("Enemy1State", 2);

                transform.position = new Vector3(transform.position.x + (1.5f * Time.deltaTime), transform.position.y, 0);


                //if (playerpos.position.x > this.transform.position.x - 1.5f)
                //{
                //    anim.SetInteger("Enemy1State", 1);

                //}
            }
        }
        while (transform.position.x >= posNow + 5);

    }
    void OnCollisionStay2D(Collision2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            
            plrstate = this.plr.GetComponent<Animator>();
            if (plrstate.GetInteger("PlayerState") == 4 || plrstate.GetInteger("PlayerState") == 3)
            {
               
                Destroy(gameObject);
                ScoreCounter.score += 20;
            }
            //else PLRControler.health -= 15;
            //else playerHealth -= 20;
            // Debug.Log(playerHealth);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Player")
        {

            plrstate = this.plr.GetComponent<Animator>();
            if (!(plrstate.GetInteger("PlayerState") == 4 || plrstate.GetInteger("PlayerState") == 3))
            {

                PLRControler.health -= 15;
                //Debug.Log(PLRControler.health);
            }

        }
    }
}
