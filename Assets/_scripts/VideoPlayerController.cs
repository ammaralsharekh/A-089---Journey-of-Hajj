using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{

    public long startFrame;
    public long EndFrame;
    public long PauseFrame;

    public UnityEvent eventPause;
    public UnityEvent eventEnd;

    VideoPlayer video;
    // Use this for initialization
    void Start()
    {
        video = GetComponent<VideoPlayer>();
       video.frame = startFrame;
        video.Play();
    }

    // Update is called once per frame
    void Update()
    {
        print(video.frame);

        if (video.frame == PauseFrame)
        {
            video.Pause();
            eventPause.Invoke();
        }

        if (video.frame == EndFrame)
        {
            video.Stop();
            eventEnd.Invoke();
        }
    }
    public void continueAnimation() {

        video.frame = video.frame + 1;
        video.Play(); 
    }
}
