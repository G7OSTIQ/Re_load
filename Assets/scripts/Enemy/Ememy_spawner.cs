using UnityEngine;

public class Ememy_spawner : MonoBehaviour
{
    public GameObject []Enemy;
    public Transform[] Emimies_spawner;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (gameObject.CompareTag("enemy_spawner1")) 
        {
            InvokeRepeating("SpawnEnemy", 1f, 4f); 
        }
        else if(gameObject.CompareTag("enemy_spawner2"))
        {
            InvokeRepeating("SpawnEnemy",10f, 4f); 
        }
        else if(gameObject.CompareTag("enemy_spawner3"))
        {
            InvokeRepeating("SpawnEnemy",20f, 4f);
        }
        else if(gameObject.CompareTag("enemy_spawner4"))
        {
            InvokeRepeating("SpawnEnemy",30f, 4f); 
        }
    }

    // Update is called once per frame
    private void SpawnEnemy()
    {
        int inside_list= Random.Range(0, Emimies_spawner.Length);
        Transform spawnPoint = Emimies_spawner[inside_list];
        
        int differentenemy = Random.Range(0, Enemy.Length);
        Instantiate(Enemy[differentenemy], spawnPoint.position, spawnPoint.rotation);
    }
}
