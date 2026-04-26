using TMPro;
using UnityEngine;

public class Small_Bug_enemy : MonoBehaviour
{
    public int score = 5;
    public int powerup_score = 10;
    //private bool alreadyhit = false;
    private TMP_Text Player_score;

    void Start()
    {
        Player_score = GameObject.Find("Score").GetComponent<TMP_Text>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Game_Over.gameover = true;
            GameObject.Find("Timer").SetActive(false);
            GameObject.Find("Score").SetActive(false);
        }

        // if (other.CompareTag("Players_bullet"))
        // {
        //     if (alreadyhit) return;
        //     alreadyhit = true;
        //     
        //     if (Powerup_collection.powerupActive)
        //     {
        //         Enemy.player_total_score += powerup_score;
        //     }
        //     else
        //     {
        //         Enemy.player_total_score += score;
        //     }
        //
        //     Player_score.text = "Score: " + Enemy.player_total_score;
        //
        //     if (!Powerup_collection.powerupActive)
        //     {
        //         Destroy(other.gameObject);
        //     }
        //     
        //     Destroy(gameObject);
        // }
    }
}
