using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Map_img_button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject img;
    public string str;

    private Text text;

    public void MIB()
    {
        text.text = "";
        img.SetActive(true);
        GameObject.Find("MapImage").SetActive(false);
    }

    void Start()
    {
        text = transform.Find("Text").GetComponent<Text>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.text = str;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.text = "";
    }
}
