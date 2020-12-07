using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ExitButton : MonoBehaviour
{
    //VideoPlayer vp;

    void Start()
    {
        transform.Find("Text").GetComponent<Text>().text = "X";
       // vp = GetComponent<VideoPlayer>();

    }
    public void EB()
    {
        GameObject.Find("Video Player")?.GetComponent<VideoPlayer>().Stop();
        transform.parent.gameObject.SetActive(false);
        Move.normal = true;
        Debug.Log("동영상 멈춤");
    }
}
