﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ArrowScript : MonoBehaviour
{
    // 해당 화살표를 클릭하면 나올 로드뷰 사진
    public GameObject NextView;

    // 해당 화살표를 터치할때 바뀌는 Material
    public Material ClickMaterial;
    Material OriginalMaterial;
    // 메인 카메라
    GameObject cam;

    // 해당 물체에 마우스가 터치했을 때
    void OnMouseEnter()
    {
        if (Move.normal)
        {
            // 현재 오브젝트의 Material를 변경
            gameObject.GetComponent<MeshRenderer>().material = ClickMaterial;
        }
    }

    // 해당 물체에 마우스가 떨어졌을 때
    void OnMouseExit()
    {
        // 현재 오브젝트의 Material를 기존의 것으로 변경
        gameObject.GetComponent<MeshRenderer>().material = OriginalMaterial;
    }

    // 해당 물체를 마우스로 클릭했을 때
    void OnMouseUp()
    {
        if (Move.normal)
        {
            // 카메라가 정지했을때만
            if (cam.transform.position == new Vector3(0, 0, 0))
            {
                StartCoroutine(Moving());
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // 기존의 Material를 따로 저장
        OriginalMaterial = gameObject.GetComponent<MeshRenderer>().material;
        
        // 메인 카메라 저장
        cam = GameObject.Find("Main Camera");
    }

    IEnumerator Moving()
    {
        // 무한 반복문
        while(true)
        {
            // 이동 속도
            float deltaMove = 1f * Time.deltaTime;

            // 이동할 좌표벡터 선언
            Vector3 v = transform.Find("ArrowPoint").transform.position;

            // 결정된 좌표로 이동
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, v, deltaMove);

            // 좌표에 도달하면 카메라 원위치 + 반복문 종료
            if (cam.transform.position == v)
            {
                cam.transform.position = new Vector3(0, 0, 0);
                break;
            }

            // 0.01초를 기다린다
            yield return new WaitForSeconds(0.01f);
        }

        // 도달한 위치에 해당되는 로드뷰 사진 오브젝트를 불러오고 현재 오브젝트를 삭제
        GameObject instance = Instantiate(NextView, new Vector3(0, 0, 0), NextView.transform.rotation);
        Destroy(gameObject.transform.parent.gameObject.transform.parent.gameObject);
    }
}
