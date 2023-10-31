using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_topScript : MonoBehaviour
{
    Vector3 yon;
    float hiz;

    public Material zeminMaterial;
    public AudioSource rewardAudio;

    [Header("Bitiþ Ekraný")]
    public GameObject bitiþEkrani;
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
            //Buraya baþarýsýz olarak eklenecek.
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
        bitiþEkrani.SetActive(true);

        //Baþarý oranýna göre burada yýldýz belirlenecek.
        //Yüksek puan almasý için yapmasý gereken yazýlabilir.
        sonucImage.sprite = basariDurumu;
    }
    public void backButton()
    {
        //Ana menüye yönlendirir.
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void reStartButton()
    {
        //Oyunu yeniden yükler.
        //Her bölüm için yeniden ayarla.
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void nextLevelButton()
    {
        //Bir sonraki seviyeye geçer.
        //Her seviye için yeniden ayarla.
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }
}