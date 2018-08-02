
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour {



    // Use this for initialization
    void Start () {


        //if(isRandom)
        //{
        //    SetRandom();
        //}
    }

   
    // Update is called once per frame
    void Update () {
      // return;

        transform.LookAt(new Vector3(0,2,0));
        transform.Rotate(0, 80, 0);

    }
}
