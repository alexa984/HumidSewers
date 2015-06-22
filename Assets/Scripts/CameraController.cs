using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private float offsetX;
    public void Start()
    {
        this.offsetX = this.transform.position.x - this.player.transform.position.x;

    }
    public void Update()
    {

        var position = this.transform.position;
        if(this.transform.position.x <=75.5f){
        if (this.player.transform.position.x > -10.2f )
        {
            
                position.x = this.player.transform.position.x + offsetX;
                this.transform.position = position;
            
        }
       // else position.x = 0f;
        }

    }

}
