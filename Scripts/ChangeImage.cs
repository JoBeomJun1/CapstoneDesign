using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public Sprite fire_img;
    public Sprite hat_img;
    public Sprite tape_img;
    public Sprite ThisImg;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Change_Image(int n)
    {
        if (n == 1)
        {
            gameObject.GetComponent<Image>().sprite = tape_img;
        }
        else if (n == 2)
        {
            gameObject.GetComponent<Image>().sprite = hat_img;
        }
        else if (n == 3)
        {
            gameObject.GetComponent<Image>().sprite = fire_img;
        }
    }
    public void Return_Image()
    {
        gameObject.GetComponent<Image>().sprite = ThisImg;
    }

}
