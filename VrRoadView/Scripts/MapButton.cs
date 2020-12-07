using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapButton : MonoBehaviour
{
    public GameObject Map;
    public void MB()
    {
        if (Move.normal)
        {
            Map.SetActive(true);
            Move.normal = false;
        }
    }
}
