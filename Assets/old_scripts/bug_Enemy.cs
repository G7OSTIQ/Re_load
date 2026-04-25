using TMPro;
using UnityEngine;

public class bug_Enemy : MonoBehaviour
{
    public int score = 15;
    public int powerup_score = 25;
    public GameObject small_enemy_prefab; 
    public int small_enemy_count = 3;
    public int hp = 5;
    private bool alreadyhit = false;

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
        
        
        if (other.CompareTag("Players_bullet"))
        {
            if (alreadyhit) return;
            alreadyhit = true;
            hp--; 

            if (!Powerup_collection.powerupActive)
            {
                Destroy(other.gameObject);
            }

            if (hp <= 0)  
            {
                if (Powerup_collection.powerupActive)
                {
                    Enemy.player_total_score += powerup_score;
                }
                else
                {
                    Enemy.player_total_score += score;
                }

                Player_score.text = "Score: " + Enemy.player_total_score;

                for (int i = 0; i < small_enemy_count; i++)
                {
                    Vector3 small_bugs = new Vector3(
                        transform.position.x + Random.Range(-1f, 1f),
                        transform.position.y,
                        transform.position.z + Random.Range(-1f, 1f)
                    );
                    Instantiate(small_enemy_prefab, small_bugs, Quaternion.identity);
                }

                Destroy(gameObject);
            }
            else
            {
                alreadyhit = false; 
            }
        }
    }
}
