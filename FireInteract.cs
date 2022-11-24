using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireInteract : MonoBehaviour
{
    [SerializeField] Text ItemUseText_fire;
    bool isClose;
    bool isvalid;
    // Start is called before the first frame update
    void Start()
    {
        ItemUseText_fire = GameObject.Find("ItemUseText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isClose && Input.GetKeyDown(KeyCode.E))
            Fire_Interaction();
        isvalid = GameObject.Find("Player").GetComponent<Inventory>().HaveExtinguisher;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isvalid)
        {
            Debug.Log("1");
            if (other.gameObject.tag.Equals("Player"))
            {
                Debug.Log("2");
                ItemUseText_fire.GetComponent<Text>().enabled = true;
                isClose = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            ItemUseText_fire.GetComponent<Text>().enabled = false;
            isClose = false;
        }
    }
    public void Fire_Interaction(){
        Destroy(transform.parent.gameObject);
        ItemUseText_fire.GetComponent<Text>().enabled = false;
    }
}
