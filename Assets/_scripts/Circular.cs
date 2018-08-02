
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circular : MonoBehaviour {

     Vector3 orginPostion;
    public float speed;
    public float whidth;
    public float hight ;
    float timeCounter = 0;

    //public bool isRandom = true;
    //public Vector2 postionRange;
    //public Vector2 speedRang;
    // Use this for initialization
    void Start () {
        orginPostion = transform.position;

        //if(isRandom)
        //{
        //    SetRandom();
        //}
    }

    //public void SetRandom()
    //{
    //    whidth = Random.Range(postionRange.x, postionRange.y);
    //    hight = whidth;
    //    speed = Random.Range(speedRang.x, speedRang.y);
    //}

    // Update is called once per frame
    void Update () {
      // return;
        float x;
        float y;
        float z;

        
         timeCounter -= Time.deltaTime * speed;
        x = Mathf.Sin(timeCounter) * whidth;
        y = 0.77f;
        z = Mathf.Cos(timeCounter)* hight;

        transform.position = new Vector3(orginPostion.x +x, orginPostion.y+ y, orginPostion.z+ z);
        transform.LookAt(new Vector3(0,2,0));
        transform.Rotate(0, 80, 0);

    }
}
