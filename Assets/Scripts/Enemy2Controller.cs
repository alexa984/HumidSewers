using UnityEngine;
using System.Collections;

public class Enemy2Controller : MonoBehaviour
{
    public GameObject plr;
    Transform playerpos;
    private Animator plrstate;
    private AudioSource aud;
    public AudioClip roar;
    private Animator anim;
    private int myHealth = 3;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;



    void Start()
    {
        this.anim = this.GetComponent<Animator>();
        playerpos = GameObject.Find("Player").transform;
        this.plrstate = plr.GetComponent<Animator>();
        this.aud = this.GetComponent<AudioSource>();

    }
    void Update()
    {
        anim.SetInteger("Enemy2State", 0);
        float posNow = this.transform.position.x;
        do
        {
            if (playerpos.position.x > this.transform.position.x - 1.5f)
            {
                anim.SetInteger("Enemy2State", 2);
                continue;

            }
            if (playerpos.position.x > this.transform.position.x - 4.5f)
            {
                //roar and come to player
                aud.PlayOneShot(roar, 0.2f);
                anim.Play("Enemy2Roar");
                anim.SetInteger("Enemy2State", 1);
                if (transform.rotation.y == 0f)
                {
                    transform.position = new Vector3(transform.position.x - (1.5f * Time.deltaTime), transform.position.y, 0);
                }
                if (transform.rotation.y == 180f) {
                    transform.position = new Vector3(transform.position.x + (1.5f * Time.deltaTime), transform.position.y, 0);
                }
            }
        }
        while (transform.position.x >= posNow + 5);

    }
    IEnumerator playdeath(Animator a) 
    {
        a.Play("Enemy2Die");
        yield return new WaitForSeconds(1);
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
                    anim.Play("Enemy2Hitted");
                    myHealth -= 1;
                    //Debug.Log(myHealth);

                    if (myHealth == 0)
                    {
                        //anim.Play("Enemy2Die");
                        StartCoroutine(playdeath(anim));
                        Destroy(gameObject);
                        Destroy(obj1);
                        Destroy(obj2);
                        Destroy(obj3);
                    }
                    anim.Play("Enemy2Hitted");
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
                ScoreCounter.score += 50;
                PLRControler.health -= 20;
                //Debug.Log(PLRControler.health);


            }

        }
    }
}

