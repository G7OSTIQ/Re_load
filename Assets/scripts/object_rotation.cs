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
           transform.Rotate(Vector3.forward * rotatiospeed * Time.deltaTime);
       }
}
