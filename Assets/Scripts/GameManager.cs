using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool bittimi;
    public GameObject teleport;
    [SerializeField] Text dusmanSayisi;

    void Update()
    {
        dusmanSayisi.text = "X "+dusmanhasaralma.dusmansay�s�.ToString();
        if (dusmanhasaralma.dusmansay�s� == 0)
        {
            dusmanSayisi.text = "Kap� A��ld�";
            teleport.SetActive(true);
        }
    }
}
