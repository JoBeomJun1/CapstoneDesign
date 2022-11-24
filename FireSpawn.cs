using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawn : MonoBehaviour
{
    int tar;
    Transform target;
    public GameObject firePrefab;

    [SerializeField]
    GameObject FireSpawns;
    // Start is called before the first frame update
    void Start()
    {
        tar = Random.Range(0,9);
        Spawn(tar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn(int tar)
    {
        target = FireSpawns.transform.GetChild(tar).transform;
        target.GetComponent<FireSpread>().enabled = true;
        GameObject fire = Instantiate(firePrefab, target);
    }
}
