using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door_OC : MonoBehaviour
{
    Animator animator;
    public GameObject dr1;
    void Start()
    {
        animator = GetComponent<Animator>();
        dr1.GetComponent<MeshRenderer>().enabled = true;
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
