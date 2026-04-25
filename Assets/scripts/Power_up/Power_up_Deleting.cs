using UnityEngine;

public class Power_up_Deleting : MonoBehaviour
{
    public float timer = 10f;  
    public float maxtimer = 20f; 

    void Start()
    {
        float randomtimer = Random.Range(timer, maxtimer); // will be random when a power up will be deleted. Timer is from 10 to 20 sec but random
        Destroy(gameObject, randomtimer);
    }
    
    
}