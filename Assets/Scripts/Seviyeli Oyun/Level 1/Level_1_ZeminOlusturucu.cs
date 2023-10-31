using UnityEngine;

public class Level_1_ZeminOlusturucu : MonoBehaviour
{
    int zeminObjectCount, sonZeminAdedi;
    public GameObject zemin;
    public GameObject sonZemin;
    GameObject yeniZemin;
    Vector3 yeniZeminVector3;
    int toplamZeminSayisi = 0;

    void Update()
    {
        zeminObjectCount = GameObject.FindGameObjectsWithTag("zemin").Length;
        sonZeminAdedi = GameObject.FindGameObjectsWithTag("son zemin").Length;

        if (zeminObjectCount == 0)
        {
            yeniZemin = Instantiate(zemin, new Vector3(-1, 10, 2), zemin.transform.rotation);
            yeniZeminVector3 = zemin.transform.position;
        }
        else
        {
            if (zeminObjectCount < 10 && sonZeminAdedi < 1)
            {
                if (toplamZeminSayisi < 30)
                {
                    int randomNumber = Random.Range(0, 2);
                    zeminOlustur(randomNumber, zemin);
                    toplamZeminSayisi++;
                }
                else
                {
                    int randomNumber = Random.Range(0, 2);
                    zeminOlustur(randomNumber, sonZemin);
                }

            }
        }
    }

    void zeminOlustur(int random, GameObject olusturulacakZemin)
    {
        //Zeminler yukarýdan düþsün. Kendi konumlarýna geldiðinde donsunlar.
        if (random == 0)
        {
            Vector3 forward = new Vector3(0, 10, 1);
            yeniZemin = Instantiate(olusturulacakZemin, yeniZeminVector3 + forward, zemin.transform.rotation);
            yeniZeminVector3 = new Vector3(yeniZemin.transform.position.x, 0, yeniZemin.transform.position.z);

        }
        else
        {
            Vector3 left = new Vector3(-1, 10, 0);
            yeniZemin = Instantiate(olusturulacakZemin, yeniZeminVector3 + left, zemin.transform.rotation);
            yeniZeminVector3 = new Vector3(yeniZemin.transform.position.x, 0, yeniZemin.transform.position.z);
        }
    }
}