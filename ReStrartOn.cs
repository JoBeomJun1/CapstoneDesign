using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReStrartOn : MonoBehaviour
{
    public GameObject img;
    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.R))
        {
            new Skippingthescene().SceneChanhe();
        }
        */
        if (Input.GetKeyDown(KeyCode.Escape)&& gameObject.name.Equals("ReStartText"))
        {
            gameObject.GetComponent<Text>().enabled = true;
            img.SetActive(true);
        }
        if (gameObject.GetComponent<Text>().enabled)
        {
            if (Input.GetKeyDown(KeyCode.R))
                SceneManager.LoadScene("FireScene");
            else if (Input.GetKeyDown(KeyCode.E)&&gameObject.name.Equals("ReStartText"))
            {
                gameObject.GetComponent<Text>().enabled = false;
                img.SetActive(false);
            }
            
        }
            

    }
}
