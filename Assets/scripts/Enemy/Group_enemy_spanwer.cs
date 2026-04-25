using UnityEngine;

public class Group_enemy_spanwer : MonoBehaviour
{
    
    //This will be set when it reach 30/60 sec pass the obejcts will start falling  
    
    public GameObject object_fall;
    public Transform[] object_spawner;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (gameObject.CompareTag("enemy_spawner1")) 
        {
            InvokeRepeating("Spawnobjects", 1f, 1f); 
        }
        else if(gameObject.CompareTag("enemy_spawner2"))
        {
            InvokeRepeating("Spawnobjects",10f, 1f); 
        }
        else if(gameObject.CompareTag("enemy_spawner3"))
        {
            InvokeRepeating("Spawnobjects",20f, 1f);
        }
        else if(gameObject.CompareTag("enemy_spawner4"))
        {
            InvokeRepeating("Spawnobjects",30f, 1f); 
        }
        
       
    }

    // Update is called once per frame
    private void Spawnobjects()
    {
        int inside_list= Random.Range(0, object_spawner.Length);
        Transform spawnPoint = object_spawner[inside_list];
        Instantiate(object_fall, spawnPoint.position, spawnPoint.rotation);
    }
}