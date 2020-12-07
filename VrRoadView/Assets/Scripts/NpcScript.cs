using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcScript : MonoBehaviour
{
    public GameObject info;
    private Animator ani;

    // 해당 물체에 마우스가 터치했을 때
    void OnMouseEnter()
    {
        if (Move.normal)
        {
            ani.SetBool("MouseOn", true);
        }
    }

    // 해당 물체에 마우스가 떨어졌을 때
    void OnMouseExit()
    {
        ani.SetBool("MouseOn", false);
    }

    // 해당 물체를 마우스로 클릭했을 때
    void OnMouseDown()
    {
        if (Move.normal)
        {
            info.SetActive(true);
            info.transform.Find("InfoVideo")?.gameObject.SetActive(false);
            info.transform.Find("ImageButton")?.gameObject.SetActive(true);
            info.transform.Find("VideoButton")?.gameObject.SetActive(true);
            info.transform.Find("ExitButton")?.gameObject.SetActive(true);
            if (info.transform.Find("InfoVideo") == null)
            {
                info.transform.Find("InfoImage").gameObject.SetActive(true);
            }
            else
            {
                info.transform.Find("InfoImage").gameObject.SetActive(false);
            }
            Move.normal = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }
}
