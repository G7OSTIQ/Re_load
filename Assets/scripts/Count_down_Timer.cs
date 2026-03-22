using System;
using TMPro;
using UnityEngine;

public class Count_down_Timer : MonoBehaviour
{

    public GameObject Timer_Screen;
    public GameObject score_Text;
    public TMP_Text timer_text;
    public float gameplay_timer = 180f;
    

    // Update is called once per frame
    void Update()
    {
        gameplay_timer = Math.Max(gameplay_timer - Time.deltaTime, 0);
        timer_text.text = gameplay_timer.ToString("0");

        if (gameplay_timer <= 0) // What this does when the count down hit 0 the player will die
        {
            gameplay_timer = 0;
            timer_text.text = "0";
            
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                Destroy(player);
                Game_Over.gameover = true;
                Timer_Screen.SetActive(false);
                score_Text.SetActive(false);
            }
        }
    }
}
