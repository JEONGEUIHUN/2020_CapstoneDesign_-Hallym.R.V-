using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserScript : MonoBehaviour
{
    public Text LocationText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        switch(other.tag)
        {
            case "Eng":
                LocationText.text = "공학관";
                break;
            case "SaSec":
                LocationText.text = "사색의 길";
                break;
            case "ilsong_park":
                LocationText.text = "일송 공원";
                break;
            case "HyukShin":
                LocationText.text = "혁신의 길";
                break;
            case "Life":
                LocationText.text = "생명의 숲";
                break;
            case "Jihye":
                LocationText.text = "지혜의 길";
                break;
            case "Society":
                LocationText.text = "사회 경영관";
                break;
            case "PlayGround":
                LocationText.text = "운동장";
                break;
            case "DavidPlaza":
                LocationText.text = "David Plaza";
                break;
            case "H_Square":
                LocationText.text = "H_SQUARE";
                break;
            case "Medical":
                LocationText.text = "의학관";
                break;
            case "SasecPark":
                LocationText.text = "사색의 정원";
                break;
            case "MainDoor":
                LocationText.text = "정문";
                break;
            case "Doheon":
                LocationText.text = "도헌글로벌";
                break;
            case "Clc":
                LocationText.text = "C.L.C";
                break;
            case "International":
                LocationText.text = "국제교육관";
                break;
            case "Dormitory":
                LocationText.text = "기숙사";
                break;
            case "Parking":
                LocationText.text = "주차장";
                break;
        }
    }
}
