using UnityEngine;
using System.Collections;

public class SplashAnim : MonoBehaviour {

    public Animator anim1;
    public Animator anim2;
    IEnumerator Loading() 
    {
        anim1.Play("Splash");
        anim2.Play("SplashLoader");
        yield return new WaitForSeconds(5);
        Application.LoadLevel("MainMenu");
    }
	void Update () {
        StartCoroutine(Loading());
        //Application.LoadLevel("MainMenu");
	}
}
