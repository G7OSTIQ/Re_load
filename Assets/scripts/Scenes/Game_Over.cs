using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{
    
    public GameObject gameoverScreen;
    public TMP_Text player_score;
    public static bool gameover = false; 
    public Count_down_Timer countdowntimer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameover = false;
        gameoverScreen.SetActive(false); //we don't want to show it to the player when the game stars
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover)
        {
            gameoverScreen.SetActive(true);
            Time.timeScale = 0f;
            
            if (countdowntimer != null)
            {
                float timesurvived = 180f - countdowntimer.gameplay_timer;
                player_score.text = "You survived: " + Mathf.FloorToInt(timesurvived) + " seconds!";
            }
        }
    }
    
    public void RestartGame()
    {
        Time.timeScale = 1f;
        Enemy.player_total_score = 0;
        Powerup_collection.powerupActive = false; // will reset the players power if it was claimed
        gameover = false;
        SceneManager.LoadScene("SampleScene");
    }
}
