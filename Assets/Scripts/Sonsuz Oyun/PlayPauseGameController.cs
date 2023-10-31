using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayPauseGameController : MonoBehaviour
{
    public GameObject playButton, musicButton, soundButton, privacyButton;
    public Sprite musicOn, musicOff, soundOn, soundOff;
    public AudioSource backGroundMusic, rewardMusic;
    public TextMeshProUGUI scoreText;


    private void Awake()
    {
        GameStartControl();

        Time.timeScale = 0;
    }

    public void StartButton()
    {
        playButton.SetActive(false);
        musicButton.SetActive(false);
        soundButton.SetActive(false);
        privacyButton.SetActive(false);
        Time.timeScale = 1;
        scoreText.text = 0.ToString();
    }

    public void MusicButton()
    {
        if (PlayerPrefs.GetInt("musicButton") == 1)
        {
            musicButton.GetComponent<Button>().image.sprite = musicOff;
            backGroundMusic.Pause();
            PlayerPrefs.SetInt("musicButton", 0);
        }
        else
        {
            musicButton.GetComponent<Button>().image.sprite = musicOn;
            backGroundMusic.Play();
            PlayerPrefs.SetInt("musicButton", 1);
        }
    }

    public void SoundButton()
    {
        if (PlayerPrefs.GetInt("soundButton") == 1)
        {
            soundButton.GetComponent<Button>().image.sprite = soundOff;
            rewardMusic.mute = true;
            PlayerPrefs.SetInt("soundButton", 0);
        }
        else
        {
            soundButton.GetComponent<Button>().image.sprite = soundOn;
            rewardMusic.mute = false;
            PlayerPrefs.SetInt("soundButton", 1);
        }
    }

    public void PrivacyButton()
    {
        //System.Diagnostics.Process.Start("https://ibrahimyilmaz45.blogspot.com/2022/08/zig-zag-privacy-policy.html");
        Application.OpenURL("https://ibrahimyilmaz45.blogspot.com/2022/08/zig-zag-privacy-policy.html");

    }

    void GameStartControl()
    {

        //High Score Control
        if (PlayerPrefs.GetInt("highScore") > 0)
        {
            scoreText.text = PlayerPrefs.GetInt("highScore").ToString();
        }
        else
        {
            PlayerPrefs.SetInt("highScore", 0);
            scoreText.text = PlayerPrefs.GetInt("highScore").ToString();
        }

        //Music Control

        if (PlayerPrefs.GetInt("musicButton") == 0)
        {
            musicButton.GetComponent<Button>().image.sprite = musicOff;
            backGroundMusic.Pause();
        } 
        else 
        {
            musicButton.GetComponent<Button>().image.sprite = musicOn;
            backGroundMusic.Play();
            PlayerPrefs.SetInt("musicButton", 1);
        }

        //Sound Effect Control

        if(PlayerPrefs.GetInt("soundButton") == 0)
        {
            soundButton.GetComponent<Button>().image.sprite = soundOff;
            rewardMusic.mute = true;
        }
        else
        {
            soundButton.GetComponent<Button>().image.sprite = soundOn;
            rewardMusic.mute = false;
            PlayerPrefs.SetInt("soundButton", 1);
        }
    }
}