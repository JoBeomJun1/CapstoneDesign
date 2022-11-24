using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItem : MonoBehaviour
{
    [SerializeField] Text pickUpText;
    bool isPickUp;

    // Start is called before the first frame update
    void Start()
    {
        pickUpText = GameObject.Find("pickUpText").GetComponent<Text>();
        pickUpText.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPickUp && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Find("Player").GetComponent<Inventory>().ItemName = gameObject.name;
            PickUp();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            pickUpText.GetComponent<Text>().enabled=true;
            isPickUp = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            pickUpText.GetComponent<Text>().enabled=false;
            isPickUp = false;
        }
    }

    void PickUp()
    {
        Destroy(gameObject);
        pickUpText.GetComponent<Text>().enabled=false;
    }
}
