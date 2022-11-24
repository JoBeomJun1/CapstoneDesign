using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireSpread2 : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject firePrefab;
    Transform tar1;
    Transform tar2;
    Transform tar3;
    float timer = 0.0f;
    int waitingTime = 7;

    // Start is called before the first frame update
    void Start()
    {
        tar1 = target1.transform;
        tar2 = target2.transform;
        tar3 = target3.transform;
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
        GameObject fire3 = Instantiate(firePrefab, tar3);
        if (target1.GetComponent<FireSpread>())
        {
            target1.GetComponent<FireSpread>().enabled = true;
        }
        if (target2.GetComponent<FireSpread>())
        {
            target2.GetComponent<FireSpread>().enabled = true;
        }
        if (target3.GetComponent<FireSpread>())
        {
            target3.GetComponent<FireSpread>().enabled = true;
        }
        if (target1.GetComponent<FireSpread2>())
        {
            target1.GetComponent<FireSpread2>().enabled = true;
        }
        if (target2.GetComponent<FireSpread2>())
        {
            target2.GetComponent<FireSpread2>().enabled = true;
        }
        if (target3.GetComponent<FireSpread2>())
        {
            target3.GetComponent<FireSpread2>().enabled = true;
        }
        Destroy(GetComponent<FireSpread2>());
    }
}
