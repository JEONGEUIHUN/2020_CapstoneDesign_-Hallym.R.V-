using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageButton : MonoBehaviour
{
    public GameObject infoImage;
    public void IB()
    {
        infoImage.SetActive(true);
        GameObject.Find("VideoButton").SetActive(false);
        GameObject.Find("ImageButton").SetActive(false);
        GameObject.Find("ExitButton").SetActive(false);
    }
}
