using UnityEngine;

public class Ememy_spawner : MonoBehaviour
{
    public GameObject bullet;
    public Transform[] Emimies_spawner;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnBullet", 2f, 4f); 
    }

    // Update is called once per frame
    private void SpawnBullet()
    {
        int inside_list= Random.Range(0, Emimies_spawner.Length);
        Transform spawnPoint = Emimies_spawner[inside_list];
        Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
    }
}
