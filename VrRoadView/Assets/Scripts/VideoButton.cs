using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VideoButton : MonoBehaviour
{
    public GameObject infoVideo;
 
     public void VB()
    {
        infoVideo.SetActive(true);
        


        GameObject.Find("VideoButton").SetActive(false);
        GameObject.Find("ImageButton").SetActive(false);
        GameObject.Find("ExitButton").SetActive(false);
    }
}
