using UnityEngine;

public class Ememy_spawner : MonoBehaviour
{
    public GameObject []Enemy;
    public Transform[] Emimies_spawner;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f, 4f); //wait 2 sec before enemy spawns when game stars
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
