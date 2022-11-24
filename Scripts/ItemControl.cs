using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemClass{
    public GameObject Item;
    public int SpawnPlaceNum;
    public int SpawnCount;
    public Vector3 SpawnLoc;
}

public class ItemControl : MonoBehaviour
{
    int Location_Count;
    int loc_num=0;
    public GameObject[] LocationArray_GO = new GameObject[4];

    public ItemClass Fire = new ItemClass();
    public ItemClass Helmet = new ItemClass();
    public ItemClass Tape = new ItemClass();


    public int[] a = new int[4];
    public bool Mark = false;

    public GameObject Item_Push(string item_n)
    {
        if (item_n.Equals("fire"))
        {
            return Fire.Item;
        }
        else if (item_n.Equals("hat"))
        {
            return Helmet.Item;
        }
        else if (item_n.Equals("tape"))
        {
            return Tape.Item;
        }
        return Fire.Item;
    }

    // Start is called before the first frame update
    public void Start()
    {
        //Vector3[] LocationArray = new Vector3[Location_Count];
        //GameObject[] LocationArray_GO = new GameObject[8];
        SetRandomMatch();
        SpawnItem_Class(Fire.Item,Fire.SpawnCount);
        SpawnItem_Class(Helmet.Item,Helmet.SpawnCount);
        SpawnItem_Class(Tape.Item,Tape.SpawnCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetRandomMatch(){
        int ran;
        for (int i = 0; i < a.Length; i++)
        {
            while (a[i] == 0)
            {
                ran = Random.Range(1, 5);
                for (int j = 0; j <= i; j++)
                {
                    if (a[j] == ran)
                    {
                        break;
                    }
                    else if (j == i)
                    {
                        a[i] = ran;
                    }
                }
            }
        }
        for (int i = 0; i < a.Length; i++)
        {
            a[i] -= 1;
        }

    }
    public void SpawnItem_Class(GameObject Item,int SpawnCount){
        for(int i = 0; i < SpawnCount; i++){
            Debug.Log(SpawnCount +"   "+i);
            Vector3 SpawnLoc = LocationArray_GO[a[loc_num]].transform.position;
            GameObject instance = Instantiate(Item,SpawnLoc,Quaternion.identity);
            instance.GetComponent<Rigidbody>().AddForce(0, 100, 0);
            loc_num++;
        }
        Debug.Log(SpawnCount);
    }
}
