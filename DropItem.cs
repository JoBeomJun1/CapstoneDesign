using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    //public GameObject target4;
    public Transform spawnPosition;
    public GameObject[] targets = new GameObject[3];
    int thatnum;
    public Vector3 Item_loc;
    // Start is called before the first frame update
    void Start()
    {
        targets[0]= GetComponent<ItemControl>().Item_Push("tape");
        targets[1]= GetComponent<ItemControl>().Item_Push("hat");
        targets[2]= GetComponent<ItemControl>().Item_Push("fire");
        // targets[3]=target4;
        Debug.Log(thatnum);
        Debug.Log(Item_loc);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
            SpawnItem();
        Item_loc = GameObject.Find("Player").transform.position;
    }
    void SpawnItem()
    {
        thatnum = GameObject.Find("Player").GetComponent<Inventory>().InvenNumber;
        GameObject instance = Instantiate(targets[thatnum-1], Item_loc,Quaternion.identity);
        if (thatnum == 1)
        {
            GameObject.Find("empty_img1").GetComponent<ChangeImage>().Return_Image();
        }else if (thatnum == 2)
        {
            GameObject.Find("empty_img2").GetComponent<ChangeImage>().Return_Image();
        }
        else if (thatnum == 3)
        {
            GameObject.Find("empty_img3").GetComponent<ChangeImage>().Return_Image();
        }
        Debug.Log(instance.name);
        instance.GetComponent<Rigidbody>().AddForce(0, 100, 0);
    }
}
