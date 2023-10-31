using UnityEngine;

public class MainSceneZeminOlusturucu : MonoBehaviour
{
    int zeminObjectCount;
    public GameObject zemin1;
    public GameObject zemin2;
    GameObject yeniZemin;
    Vector3 yeniZeminVector3;
    Vector3 topYon;
    float topHizi;

    private void Start()
    {
        topHizi = 1.8f;
        topYon = Vector3.left;
    }

    void Update()
    {
        zeminObjectCount = GameObject.FindGameObjectsWithTag("zemin").Length;

        if (zeminObjectCount == 0)
        {
            yeniZemin = Instantiate(zemin1, new Vector3(-1, 10, 0), zemin1.transform.rotation);
            yeniZeminVector3 = yeniZemin.transform.position;
        }
        else
        {
            if (zeminObjectCount < 10)
            {
                    int randomNumber = Random.Range(0, 2);
                    zeminOlustur(randomNumber);
            }
        }


        //Top hareketini burada saðlayacaðýz.
        gameObject.transform.position += topYon * topHizi * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "mainSceneAnim1")
        {
            topYon = Vector3.forward;
        }

        if (collision.gameObject.tag == "mainSceneAnim2")
        {
            topYon = Vector3.left;
        }
    }

    void zeminOlustur(int random)
    {
        //Zeminler yukarýdan düþsün. Kendi konumlarýna geldiðinde donsunlar.
        if (random == 0)
        {
            Vector3 forward = new Vector3(0, 10, 1);
            yeniZemin = Instantiate(zemin2, yeniZeminVector3 + forward, zemin2.transform.rotation);
            yeniZeminVector3 = new Vector3(yeniZemin.transform.position.x, 0, yeniZemin.transform.position.z);

        }
        else
        {
            Vector3 left = new Vector3(-1, 10, 0);
            yeniZemin = Instantiate(zemin1, yeniZeminVector3 + left, zemin1.transform.rotation);
            yeniZeminVector3 = new Vector3(yeniZemin.transform.position.x, 0, yeniZemin.transform.position.z);
        }
    }
}