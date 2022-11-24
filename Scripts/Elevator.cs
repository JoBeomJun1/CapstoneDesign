using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Elevator : MonoBehaviour
{
    private float time;
    private bool TimerOn = false;
    [SerializeField] Text ElevatorText;
    [SerializeField] Image ElevatorImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 3){
            ElevatorText.gameObject.SetActive(true);
            ElevatorImage.gameObject.SetActive(true);
            GameObject.Find("EndText").GetComponent<Text>().enabled = true;
            Destroy(GameObject.Find("ReStartText").GetComponent<ReStrartOn>());
        }
        if(time<3){
            if(TimerOn){
                time += Time.deltaTime;
            }
        }
    }
    void OnCollisionEnter(Collision col){
	    if (col.gameObject.name == "Player")
        TimerOn = true;
    }
    void OnCollisionExit(Collision col){
        TimerOn = false;
        time = 0;
    }
}
