using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fire_audioController : MonoBehaviour
{
    float timer;
    int waitingTime;
    bool isPlay = false;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        waitingTime = 7;
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        audioSource.mute = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("ReStartText").GetComponent<Text>().enabled && !GameObject.Find("EndText").GetComponent<Text>().enabled)
        {
            timer += Time.deltaTime;
            if (timer > waitingTime || isPlay)
            {
                isPlay = true;
                audioSource.playOnAwake = false;
                audioSource.mute = false;
                timer = 0;
            }
        }
        else
        {
            audioSource.mute = true;
        }
        
    }
}
