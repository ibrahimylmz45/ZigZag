using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_topScript : MonoBehaviour
{
    Vector3 yon;
    float hiz;

    public Material zeminMaterial;
    public AudioSource rewardAudio;

    [Header("Biti� Ekran�")]
    public GameObject biti�Ekrani;
    public Image sonucImage;
    public Sprite star1;
    public Sprite star2;
    public Sprite star3;
    public Sprite basarisiz;

    void Start()
    {
        hiz = 1.8f;
        yon = Vector3.forward;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale == 1)
        {
            if (yon.x == 0)
            {
                yon = Vector3.left;
            }
            else
            {
                yon = Vector3.forward;
            }
        }
        gameObject.transform.position += yon * hiz * Time.deltaTime;

        if (transform.position.y < -3)
        {
            //Buraya ba�ar�s�z olarak eklenecek.
            BitisKontrol(basarisiz);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="son zemin")
        {
            BitisKontrol(star3);
        }
    }
    private void BitisKontrol(Sprite basariDurumu)
    {
        Time.timeScale = 0;
        biti�Ekrani.SetActive(true);

        //Ba�ar� oran�na g�re burada y�ld�z belirlenecek.
        //Y�ksek puan almas� i�in yapmas� gereken yaz�labilir.
        sonucImage.sprite = basariDurumu;
    }
    public void backButton()
    {
        //Ana men�ye y�nlendirir.
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void reStartButton()
    {
        //Oyunu yeniden y�kler.
        //Her b�l�m i�in yeniden ayarla.
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void nextLevelButton()
    {
        //Bir sonraki seviyeye ge�er.
        //Her seviye i�in yeniden ayarla.
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }
}