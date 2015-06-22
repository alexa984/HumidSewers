using UnityEngine;
using System.Collections;

public class BossScript : MonoBehaviour {

    public GameObject plr;
    private Animator anim;
    private Animator plrstate;
    Transform playerpos;
    private int myHealth = 5;
    private bool isTransformed = false;
    private bool stoppedUpdate = false;
    private BoxCollider2D bxcol;
    
    void Start () 
    {
        playerpos = GameObject.Find("Player").transform;
        this.anim = this.GetComponent<Animator>();
        this.plrstate = plr.GetComponent<Animator>();
        this.bxcol=this.GetComponent<BoxCollider2D>();
	}
	void Update () 
    {
        if (stoppedUpdate == false)
        {
            //float posNow = this.transform.position.x;
            if (isTransformed == false)
            {
                if (playerpos.position.x > this.transform.position.x - 6.5f)
                {
                    anim.Play("DragonTransform");
                    anim.SetInteger("BossState", 1);
                    bxcol.offset = new Vector2(0.15f, 0);
                    isTransformed = true;
                }
            }
        }
	}
    IEnumerator destroyme(Collision2D colis)
    {
        yield return new WaitForSeconds(5);
        if (colis.gameObject.tag == "Player")
        {

            plrstate = this.plr.GetComponent<Animator>();
            if (plrstate.GetInteger("PlayerState") == 4 || plrstate.GetInteger("PlayerState") == 3)
            {
                if (myHealth > 0)
                {
                    
                    myHealth -= 1;
                    if (myHealth == 0)
                    {
                        anim.Play("BossHitted");
                        Destroy(this.gameObject);
                        stoppedUpdate = true;
                    }
                }

            }
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        StartCoroutine(destroyme(col));
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            plrstate = this.plr.GetComponent<Animator>();
            if (!(plrstate.GetInteger("PlayerState") == 4 || plrstate.GetInteger("PlayerState") == 3))
            {
                PLRControler.health -= 40;
            }

        }
    }
}
