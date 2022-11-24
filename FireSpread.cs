using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireSpread : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;
    public GameObject firePrefab;
    Transform tar1;
    Transform tar2;
    float timer = 0.0f;
    int waitingTime = 7;

    // Start is called before the first frame update
    void Start()
    {
        tar1 = target1.transform;
        tar2 = target2.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("ReStartText").GetComponent<Text>().enabled)
        {
            timer += Time.deltaTime;
            if (timer > waitingTime)
            {
                Spawn();
            }
        }
    }

    void Spawn()
    {
        GameObject fire1 = Instantiate(firePrefab, tar1);
        GameObject fire2 = Instantiate(firePrefab, tar2);
        if (target1.GetComponent<FireSpread>())
        {
            target1.GetComponent<FireSpread>().enabled = true;
        }
        if (target2.GetComponent<FireSpread>())
        {
            target2.GetComponent<FireSpread>().enabled = true;
        }
        if (target1.GetComponent<FireSpread2>())
        {
            target1.GetComponent<FireSpread2>().enabled = true;
        }
        if (target2.GetComponent<FireSpread2>())
        {
            target2.GetComponent<FireSpread2>().enabled = true;
        }
        Destroy(GetComponent<FireSpread>());
    }
}
