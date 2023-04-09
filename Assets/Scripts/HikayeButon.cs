using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HikayeButon : MonoBehaviour
{
    [SerializeField] Text konusma;
    [SerializeField] Image AnaKarakter;
    [SerializeField] Image YanKarakter;
    private int sayac = 0;
    private void Start()
    {
        AnaKarakter.enabled = false;
        YanKarakter.enabled = true;

    }
    void Update()
    {
        if(sayac == 0)
        {
            YanKarakter.enabled = true;
            konusma.text = "Akademide olmak i�in ne kadar g�zel bir g�n :)";
        }
        else if(sayac == 1)
        {
            YanKarakter.enabled = false;
            AnaKarakter.enabled = true;
            konusma.text = "Bence de hem hava da �ok g�zel. Peki ��k��ta bir yerlere gitmek ister misin?";
        }
        else if (sayac == 2)
        {
            YanKarakter.enabled = true;
            AnaKarakter.enabled = false;
            konusma.text = "�eyy... !!! O SESLER DE NE!!!";
        }
        else if (sayac == 3)
        {
            YanKarakter.enabled = true;
            AnaKarakter.enabled = true;
            konusma.text = "'!' AKADEM�Y� �ST�LA ED�YORLAR'!'";
        }
        else if (sayac == 4)
        {
            AnaKarakter.enabled = true;
            YanKarakter.enabled = false;
            konusma.text = "��TE BEN�M SIRAM!! HEP HAYAL�N� KURDU�UM H�KAYE, T�M AKADEM�Y� �ST�LADAN KURTARMALIYIM!!";
        }
        else if (sayac == 5)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void TusaBasildi()
    {
        sayac++;
        

    }
}
