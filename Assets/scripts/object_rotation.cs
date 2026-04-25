using UnityEngine;

public class object_rotation : MonoBehaviour
{
   public float rotatiospeed = 180f;
       // Start is called once before the first execution of Update after the MonoBehaviour is created
       void Start()
       {
           
       }
   
       // Update is called once per frame
       void Update()
       {
           if (gameObject.CompareTag("Powerup"))
           {
               transform.Rotate(Vector3.up * rotatiospeed * Time.deltaTime);
           }
           else
           {
               transform.Rotate(Vector3.forward * rotatiospeed * Time.deltaTime);
           }
       }
}
