using UnityEngine;

public class bullet_deleting : MonoBehaviour
{
    public float timer = 5f;

    void Start()
    {
        Destroy(gameObject, timer);
        
    }
}
