using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanhasaralma : MonoBehaviour
{
    public static float dusmansay�s� = 8;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "atestopu")
        {
            dusmansay�s�--;
            gameObject.SetActive(false);
        }
    }
}
