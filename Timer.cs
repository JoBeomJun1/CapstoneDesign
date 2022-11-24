using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timeText;
    private float time;
    public int endTime;
    public GameObject endButton;
    public GameObject img;

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("ReStartText").GetComponent<Text>().enabled)
        {
            time += Time.deltaTime;
            timeText.text = "Time : " + string.Format("{0:N2}", time);
            if (time >= endTime)
            {
                endButton.GetComponent<Text>().enabled = true;
                Destroy(GameObject.Find("ReStartText").GetComponent<ReStrartOn>());
                img.SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
            
    }
}
