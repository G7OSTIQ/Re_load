using UnityEngine;

public class bullet_spawners : MonoBehaviour
{
    
    public GameObject bullet;
    public Transform[] Bullet_spawner;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnBullet", 1f, 10f); //10 is there for the amout of time for a bullet to spawn
    }

    // Update is called once per frame
    private void SpawnBullet()
    {
        int inside_list= Random.Range(0, Bullet_spawner.Length);
        Transform spawnPoint = Bullet_spawner[inside_list];
        Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
    }
}
