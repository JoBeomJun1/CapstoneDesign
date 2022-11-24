using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{
    bool HaveTape = false;
    bool HaveHelmet = false;
    public bool HaveExtinguisher = false;

    public String ItemName = null;
    public String updateName = null;

    public int InvenNumber = 1;

    //public int AA = 0;
    // public int BB = 0;


    // Start is called before the first frame update
    void Start()
    {
        //ItemName="Tape";
    }

    // Update is called once per frame
    void Update()
    {
        if (ItemName != updateName)
        {
            updateName = ItemName;
            CheckItem();
            //AA++;
        }
        switch (Input.inputString)
        {
            case "1":
                InvenNumber = 1;
                Debug.Log(InvenNumber);
                break;

            case "2":
                InvenNumber = 2;
                Debug.Log(InvenNumber);
                break;

            case "3":
                InvenNumber = 3;
                Debug.Log(InvenNumber);
                break;
        }

    }

    public void CheckItem()
    {
        //Inventory Items = new Inventory();
        Debug.Log(ItemName);

        switch (ItemName)
        {
            case ("Tape(Clone)"):
                HaveTape = true;
                GameObject.Find("empty_img1").GetComponent<ChangeImage>().Change_Image(1);
                InvenNumber = 1;
                //BB ++;
                break;
            case ("Hat(Clone)"):
                HaveHelmet = true;
                GameObject.Find("empty_img2").GetComponent<ChangeImage>().Change_Image(2);
                InvenNumber = 2;
                break;
            case ("Extinguisher(Clone)"):
                HaveExtinguisher = true;
                GameObject.Find("empty_img3").GetComponent<ChangeImage>().Change_Image(3);
                InvenNumber = 3;
                break;
        }
    }
    //public void Change_meth(){
    //    HaveTape = true;
    //    Havehelmet = true;
    //}


}
