using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleController : MonoBehaviour
{
    //gameObject.tag = "NewTag";

    float timeSpan;
    float checkTime1;

    Renderer sphereColor;

    // Start is called before the first frame update
    void Start()
    {
        timeSpan = 0.0f;
        checkTime1 = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeSpan += Time.deltaTime;
        if (timeSpan > checkTime1)
        {
            //this.transform.localScale += new Vector3(1.0f, 3f, 1.0f);
            this.transform.localScale = this.transform.localScale + new Vector3(0, 1, 0);
            timeSpan = 0;
        }       
    }
}
