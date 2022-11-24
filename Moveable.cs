using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Moveable : MonoBehaviour
{
    Animator animator;
    public NavMeshAgent agent;
    Transform target;
    int tar;
    int pose;
    float timer = 0.0f;
    int watingTime = 20;

    [SerializeField]
    GameObject targets;

    private void Start()
    {
        animator = GetComponent<Animator>();
        tar = Random.Range(0, 2);
        pose = Random.Range(0, 3);
        target = targets.transform.GetChild(tar).transform;
        if (pose == 0)
        {
            animator.SetBool("pose1", true);
        }
        else if (pose == 1)
        {
            animator.SetBool("pose2", true);
        }
        else if (pose == 2)
        {
            animator.SetBool("pose3", true);
        }
    }

    void Update()
    {
        if (GameObject.Find("ReStartText").GetComponent<Text>().enabled)
        {
            animator.SetBool("move", false);
            GetComponent<NavMeshAgent>().enabled = false;
        }
        else
        {
            GetComponent<NavMeshAgent>().enabled = true;
            if (timer > watingTime)
            {
                animator.SetBool("move", true);
                agent.SetDestination(target.position);
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
    }
}
