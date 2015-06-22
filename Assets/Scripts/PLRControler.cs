using UnityEngine;
using System.Collections;

public class PLRControler : MonoBehaviour
{
    public static int health = 150;
    public float speed = 5.0f;

    private Animator anim;
   // private Rigidbody2D rb;
    //public BoxCollider2D bxcol;

    void Start()
    {
        this.anim = this.GetComponent<Animator>();
        //this.rb = this.GetComponent<Rigidbody2D>();
       
    }
    
    void Update()
    {
        

        anim.SetInteger("PlayerState", 0);
        
        //Debug.Log("I should be idle");
        // animator.Play("PlayerStay");

        if (Input.anyKey&&Time.timeScale>0)
        {
            //bxcol.size = new Vector2(4.5f, 1.1f);
            
            if (Input.GetKeyDown(KeyCode.Z))
            {
                anim.SetInteger("PlayerState", 3);
                anim.Play("PlayerCrochet");
                
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                anim.Play("PlayerKick");
                anim.SetInteger("PlayerState", 4);
                //Debug.Log("I'm really kickin' u out");
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.Play("PlayerJump");

                Vector2 myPosition = new Vector2(this.transform.position.x, this.transform.position.y);
                Mathf.Clamp(myPosition.y, -1f, 0f);
                
                myPosition += new Vector2(0,1.7f);
                this.transform.position = myPosition;

            }
            //if (Input.GetKeyDown(KeyCode.DownArrow))
            //{
                //rb.mass = 1000;
                //this.bxcol.size = new Vector2(0.44f,0.7f);
                //Vector2 myPosition = new Vector2(this.anim.transform.position.x, this.anim.transform.position.y);
                //myPosition = new Vector2(0, -1.5f);
                //this.anim.transform.position = myPosition;
                //anim.Play("PlayerCrouch");

           // }

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                //animator.Play("PlayerRunning");
                anim.SetInteger("PlayerState", 1);
                var scale = transform.localScale;
                var sign = 1;

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    // left
                    if (scale.x > 0)
                    {
                        scale.x *= -1;
                    }
                    sign = -1;
                }

                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    // right
                    if (scale.x < 0)
                    {
                        scale.x *= -1;
                    }
                    // sign = 1;

                }

                this.transform.localScale = scale;

                transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime * sign), transform.position.y, 0);

            }

        }

    }
}

