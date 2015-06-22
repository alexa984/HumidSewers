using UnityEngine;
using System.Collections;

public class RatAnimCNTR : MonoBehaviour {
    private Animator anim;
	void Start () {
        this.anim = this.GetComponent<Animator>();
	}
	void Update () {
        anim.Play("Rat");
	}
}
