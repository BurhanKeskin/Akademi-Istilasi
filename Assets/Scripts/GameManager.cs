using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool bittimi;
    public GameObject teleport;

    public Text d��manText; 
    
    void Update()
    {
        d��manText.text = "X " + dusmanhasaralma.dusmansay�s�.ToString();

        if (dusmanhasaralma.dusmansay�s� == 0)
        {
            teleport.SetActive(true);
        }
    }
}
