using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeSpeed : MonoBehaviour {

    public float Timer;

    public int loop = 0;


    public float[] eventsTimers;
    public UnityEvent[] events;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer > 0)

        {
            Time.timeScale = 20F;
            return;
        }
        else
        {
            Time.timeScale = 1;
        }

        if (loop == events.Length) return;

        eventsTimers[loop] -= Time.deltaTime;
        if(eventsTimers[loop] <0)
        {
            events[loop].Invoke();
            loop++;
        }
    }
}
