using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class topScript : MonoBehaviour
{
    Vector3 yon;
    float hiz;
    int gameScore;
    public TextMeshProUGUI scoreText;

    public Material zeminMaterial;
    public AudioSource rewardAudio;

    void Start()
    {
        hiz = 1.4f;
        gameScore = 0;
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

        gameLevelControl();

        if (transform.position.y < -3)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            gameScore += 1;
            scoreText.text = gameScore.ToString();
            if(gameScore> PlayerPrefs.GetInt("highScore"))
            {
                PlayerPrefs.SetInt("highScore", gameScore);
            }
        }
    }

    void gameLevelControl()
    {
        Vector3 topScaleMin = new Vector3(0.3f, 0.3f, 0.3f);
        Vector3 topScaleMid = new Vector3(0.5f, 0.5f, 0.5f);
        Vector3 topScaleMax = new Vector3(1, 1, 1);

        switch (gameScore)
        {
            case 0:
                hiz = 1.4f;
                break;
            case 9:
                rewardAudio.PlayDelayed(0.05f);
                break;
            case 10:
                hiz = 1.6f;
                zeminMaterial.color = Color.green;
                break;

            case 19:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 20:
                hiz = 1.8f;
                zeminMaterial.color = Color.grey;
                break;

            case 29:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 30:
                hiz = 2.1f;
                zeminMaterial.color = Color.magenta;
                break;

            case 39:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 40:
                hiz = 2.4f;
                zeminMaterial.color = Color.red;
                break;

            case 54:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 55:
                hiz = 2.6f;
                zeminMaterial.color = Color.yellow;
                break;

            case 69:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 70:
                hiz = 2.8f;
                zeminMaterial.color = Color.cyan;
                break;

            case 89:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 90:
                hiz = 3.0f;
                zeminMaterial.color = Color.green;
                break;

            case 109:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 110:
                hiz = 3.1f;
                zeminMaterial.color = Color.grey;
                transform.localScale = Vector3.Slerp(transform.localScale, topScaleMin, 0.1f);
                break;

            case 139:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 140:
                hiz = 3.2f;
                zeminMaterial.color = Color.magenta;
                break;

            case 169:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 170:
                hiz = 3.3f;
                zeminMaterial.color = Color.red;
                break;

            case 199:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 200:
                hiz = 3.4f;
                zeminMaterial.color = Color.yellow;
                break;

            case 229:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 230:
                hiz = 3.5f;
                zeminMaterial.color = Color.cyan;
                transform.localScale = Vector3.Slerp(transform.localScale, topScaleMid, 0.1f);
                break;

            case 259:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 260:
                hiz = 3.6f;
                zeminMaterial.color = Color.green;
                break;

            case 289:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 290:
                hiz = 3.7f;
                zeminMaterial.color = Color.grey;
                break;

            case 319:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 320:
                hiz = 3.8f;
                zeminMaterial.color = Color.magenta;
                break;

            case 349:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 350:
                hiz = 3.9f;
                zeminMaterial.color = Color.red;
                break;

            case 379:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 380:
                hiz = 4.0f;
                zeminMaterial.color = Color.yellow;
                transform.localScale = Vector3.Slerp(transform.localScale, topScaleMax, 0.1f);
                break;

            case 419:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 420:
                hiz = 4.1f;
                zeminMaterial.color = Color.cyan;
                break;

            case 459:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 460:
                hiz = 4.2f;
                zeminMaterial.color = Color.green;
                break;

            case 499:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 500:
                hiz = 4.3f;
                zeminMaterial.color = Color.grey;
                break;

            case 539:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 540:
                hiz = 4.4f;
                zeminMaterial.color = Color.magenta;
                transform.localScale = Vector3.Slerp(transform.localScale, topScaleMin, 0.1f);
                break;

            case 579:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 580:
                hiz = 4.5f;
                zeminMaterial.color = Color.red;
                break;

            case 619:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 620:
                hiz = 4.6f;
                zeminMaterial.color = Color.yellow;
                break;

            case 669:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 670:
                hiz = 4.7f;
                zeminMaterial.color = Color.cyan;
                transform.localScale = Vector3.Slerp(transform.localScale, topScaleMid, 0.1f);
                break;

            case 719:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 720:
                hiz = 4.8f;
                zeminMaterial.color = Color.green;
                break;

            case 769:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 770:
                hiz = 4.9f;
                zeminMaterial.color = Color.grey;
                break;

            case 849:
                rewardAudio.PlayDelayed(0.1f);
                break;
            case 850:
                hiz = 5.0f;
                zeminMaterial.color = Color.magenta;
                transform.localScale = Vector3.Slerp(transform.localScale, topScaleMax, 0.1f);
                break;
        }
    }
}