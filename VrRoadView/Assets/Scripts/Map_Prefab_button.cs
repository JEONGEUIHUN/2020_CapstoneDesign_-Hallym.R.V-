using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Prefab_button : MonoBehaviour
{
    public GameObject next;

    public void MPB()
    {
        Destroy(UserScript.col.gameObject);
        GameObject instance = Instantiate(next, new Vector3(0, 0, 0), next.transform.rotation);
    }
}
