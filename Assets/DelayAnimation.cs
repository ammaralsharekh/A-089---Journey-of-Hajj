using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayAnimation : MonoBehaviour {
    Animator animator;
    float Timer; 

	// Use this for initialization
	void Start () {

        animator = GetComponent<Animator>();
        Timer = Random.Range(0, 70);

	}
	
	// Update is called once per frame
	void Update () {
        Timer -= Time.deltaTime;
        if (Timer < 0)
        {
            animator.enabled = true;
          //  Destroy(this);

        }


	}
}
