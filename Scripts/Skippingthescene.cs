using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skippingthescene : MonoBehaviour
{
    public void SceneChanhe()
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneChanhe();
            }
        }

        Scene scene = SceneManager.GetActiveScene();
        int i = 0;
        i = Random.Range(0,4);
        if (!scene.name.Equals("StartScene"))
        {
            SceneManager.LoadScene("StartScene");
        }
        else if (i == 0)
        {
            SceneManager.LoadScene("EarthquakeScene");
        }else if(i == 1)
        {
            SceneManager.LoadScene("FireScene");
        }
        else if (i == 2)
        {
            SceneManager.LoadScene("FloodScene");
        }
        else if (i == 3)
        {
            SceneManager.LoadScene("TyphoonScene");
        }
    }
}
