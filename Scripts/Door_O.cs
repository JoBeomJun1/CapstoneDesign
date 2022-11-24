using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_O : MonoBehaviour
{
    Animator animator;
    public GameObject dr1;
    public GameObject dr2;
    void Start()
    {
        animator = GetComponent<Animator>();
        dr1.GetComponent<MeshRenderer>().enabled = true;
        dr2.GetComponent<MeshRenderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Door")
            animator.SetBool("IsOpen", true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door")
            animator.SetBool("IsOpen", false);
    }
}
