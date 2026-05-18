using System;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class Count_down_Timer : MonoBehaviour
{

    public GameObject Timer_Screen;
    public GameObject score_Text;
    public TMP_Text timer_text;
    public float gameplay_timer = 180f;
    public AudioSource backgroundAudioSource; 
    public AudioSource countdownAudioSource; 
    public AudioClip countdownsound;
    public AudioClip backgroundmusic;
    public AudioMixer gameMixer;
    public float fadeDuration = 10f;
    private bool soundplayed = false;
    public static bool countdownStarted = false;

    void Start()
    {
        backgroundAudioSource.clip = backgroundmusic;
        backgroundAudioSource.loop = true;
        backgroundAudioSource.Play();
        
        gameMixer.SetFloat("MusicVolume", -5f);
    }
    

    // Update is called once per frame
    void Update()
    {
        gameplay_timer = Math.Max(gameplay_timer - Time.deltaTime, 0);
        timer_text.text = gameplay_timer.ToString("0");
        
        if (gameplay_timer <= 36f && !soundplayed) //36sec because of the fading effect from background to countdown
        {
            soundplayed = true;
            countdownStarted = true;
            StartCoroutine(FadeOutAndPlayCountdown());
        }

        if (gameplay_timer <= 0) // What this does when the count down hit 0 the player will die
        {
            gameplay_timer = 0;
            timer_text.text = "0";
            
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                Destroy(player);
                Game_Over.gameover = true;
                Timer_Screen.SetActive(false); //This to hide ui once timer runs out
                score_Text.SetActive(false);
                
                
            }
        }
    }
    
    private System.Collections.IEnumerator FadeOutAndPlayCountdown()
    {
        float currentVolume;
        gameMixer.GetFloat("MusicVolume", out currentVolume);

        // fades out the background music
        float timer = 0f;
        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            float newVolume = Mathf.Lerp(currentVolume, -30f, timer / fadeDuration); // the amout of vol will go down slowly
            gameMixer.SetFloat("MusicVolume", newVolume);
            yield return null;
        }

        backgroundAudioSource.Stop();
        
        countdownAudioSource.clip = countdownsound;
        countdownAudioSource.Play();

        gameMixer.SetFloat("MusicVolume", currentVolume);
    }
    
    public static void StopAllMusic()
    {
        Count_down_Timer timer = FindAnyObjectByType<Count_down_Timer>();
        if (timer == null) return;
        timer.StopAllCoroutines();

        if (countdownStarted)
        {
            timer.backgroundAudioSource.Stop();
            timer.countdownAudioSource.Stop();
        }
        countdownStarted = false; 
    }
}
