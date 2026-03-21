using UnityEngine;

public class Power_up_Deleting : MonoBehaviour
{
    public float timer = 5f;

    void Start()
    {
        Destroy(gameObject, timer);
        
    }
}
