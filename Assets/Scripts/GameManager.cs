using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool bittimi;
    public GameObject teleport;

    void Update()
    {
        if (d�smanhasaralma.dusmansay�s� == 0)
        {
            teleport.SetActive(true);
        }
    }
}
