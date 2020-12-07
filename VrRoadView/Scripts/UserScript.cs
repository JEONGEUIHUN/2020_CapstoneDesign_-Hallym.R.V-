using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserScript : MonoBehaviour
{
    public Text LocationText;
    public static Collider col;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other?.GetComponent<SphereCollider>())
        {
            col = other;
        }

        switch(other.tag)
        {
            case "University headquarters":
                LocationText.text = "대학 본부";
                 break;
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
                LocationText.text = "사회 경영";
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
            case "Library":
                LocationText.text = "도서관";
                break;
            case "Library_1":
                LocationText.text = "도서관 1F";
                break;
            case "Library_2":
                LocationText.text = "도서관 2F";
                break;
            case "Library_3":
                LocationText.text = "도서관 3F";
                break;
            case "Library_4":
                LocationText.text = "도서관 4F";
                break;
            case "Library_5":
                LocationText.text = "도서관 5F";
                break;

            case "Biotechnology_1":
                LocationText.text = "생명과학관 1F";
                break;
            case "Biotechnology_2":
                LocationText.text = "생명과학관 2F";
                break;
            case "Biotechnology_3":
                LocationText.text = "생명과학관 3F";
                break;
            case "Biotechnology_4":
                LocationText.text = "생명과학관 4F";
                break;
            case "Biotechnology_5":
                LocationText.text = "생명과학관 5F";
                break;
            case "Biotechnology_6":
                LocationText.text = "생명과학관 6F";
                break;

            case "JaYeon_1":
                LocationText.text = "자연과학관 1F";
                break;
            case "JaYeon_2":
                LocationText.text = "자연과학관 2F";
                break;
            case "JaYeon_3":
                LocationText.text = "자연과학관 3F";
                break;
            case "JaYeon_4":
                LocationText.text = "자연과학관 4F";
                break;
            case "JaYeon_5":
                LocationText.text = "자연과학관 5F";
                break;
            case "JaYeon_6":
                LocationText.text = "자연과학관 6F";
                break;

            case "Medical_2":
                LocationText.text = "의학관 2F";
                break;
            case "Medical_3":
                LocationText.text = "의학관 3F";
                break;
            case "Medical_4":
                LocationText.text = "의학관 4F";
                break;
            case "Medical_5":
                LocationText.text = "의학관 5F";
                break;
            case "Medical_6":
                LocationText.text = "의학관 6F";
                break;

            case "Administration_1":
                LocationText.text = "대학본부 1F";
                break;
            case "Administration_2":
                LocationText.text = "대학본부 2F";
                break;
            case "Administration_3":
                LocationText.text = "대학본부 3F";
                break;
            case "Administration_4":
                LocationText.text = "대학본부 4F";
                break;
            case "Administration_5":
                LocationText.text = "대학본부 5F";
                break;
            case "Administration_6":
                LocationText.text = "대학본부 6F";
                break;

            case "CLC_1":
                LocationText.text = "CLC 1F";
                break;
            case "CLC_2":
                LocationText.text = "CLC 2F";
                break;
            case "CLC_3":
                LocationText.text = "CLC 3F";
                break;
            case "CLC_4":
                LocationText.text = "CLC 4F";
                break;

            case "SanHack_1":
                LocationText.text = "산학협력관 1F";
                break;
            case "SanHack_2":
                LocationText.text = "산학협력관 2F";
                break;
            case "SanHack_3":
                LocationText.text = "산학협력관 3F";
                break;
            case "SanHack_4":
                LocationText.text = "산학협력관 4F";
                break;
            case "SanHack_5":
                LocationText.text = "산학협력관 5F";
                break;

            case "Society_1":
                LocationText.text = "사회·경영 1F";
                break;
            case "Society_2":
                LocationText.text = "사회·경영 2F";
                break;
            case "Society_3":
                LocationText.text = "사회·경영 3F";
                break;
            case "Society_4":
                LocationText.text = "사회·경영 4F";
                break;
            case "Society_5":
                LocationText.text = "사회·경영 5F";
                break;
        }
    }
}
