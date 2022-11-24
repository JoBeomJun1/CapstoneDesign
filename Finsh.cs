using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finsh : MonoBehaviour
{
    public Text FP;
    static int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        FP.text = "" + i/2;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("AI"))
        {
            Destroy(other.gameObject);
            i++;
        }
    }
}
