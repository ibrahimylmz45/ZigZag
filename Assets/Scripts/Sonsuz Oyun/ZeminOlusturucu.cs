using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZeminOlusturucu : MonoBehaviour
{
    int objectCount;
    public GameObject zemin;
    GameObject yeniZemin;
    Vector3 yeniZeminVector3;

    void Update()
    {
        objectCount = GameObject.FindGameObjectsWithTag("zemin").Length;

        if (objectCount == 0)
        {
            yeniZemin = Instantiate(zemin, new Vector3(-1, 10, 2), zemin.transform.rotation);
            yeniZeminVector3 = zemin.transform.position;
        }
        else
        {
            if (objectCount < 20)
            {
                int randomNumber = Random.Range(0, 2);
                zeminOlustur(randomNumber);
            }
        }
    }

    void zeminOlustur(int random)
    {
        //Zeminler yukarýdan düþsün. Kendi konumlarýna geldiðinde donsunlar.
        if (random == 0)
        {
            Vector3 forward = new Vector3(0, 10, 1);
            yeniZemin = Instantiate(zemin, yeniZeminVector3 + forward, zemin.transform.rotation);
            yeniZeminVector3 = new Vector3(yeniZemin.transform.position.x, 0, yeniZemin.transform.position.z);

        }
        else
        {
            Vector3 left = new Vector3(-1, 10, 0);
            yeniZemin = Instantiate(zemin, yeniZeminVector3 + left, zemin.transform.rotation);
            yeniZeminVector3 = new Vector3(yeniZemin.transform.position.x, 0, yeniZemin.transform.position.z);
        }   
    }
}