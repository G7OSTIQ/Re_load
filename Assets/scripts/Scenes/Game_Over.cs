using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{
    
    public GameObject gameoverScreen;
    public TMP_Text player_score;
    public static bool gameover = false; 
    
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
            player_score.text = "Score: " + Enemy.player_total_score; // finds the enemy script
            Time.timeScale = 0f;
        }
    }
    
    public void RestartGame()
    {
        Time.timeScale = 1f;
        Enemy.player_total_score = 0;
        Powerup_collection.powerupActive = false; // will reset the players pwoerup if it was claimed
        gameover = false;
        SceneManager.LoadScene("SampleScene");
    }
}
