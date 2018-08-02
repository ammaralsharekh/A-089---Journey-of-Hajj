using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour {

    public float timer=0;
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        if (!anim.enabled) return;
        timer += Time.deltaTime;
        Debug.Log(
       timer
       );
	}
}
