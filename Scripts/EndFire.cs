using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndFire : MonoBehaviour
{
    public Text DP;
    static int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        DP = GameObject.Find("DP").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        DP.text = "" + i / 2;
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
