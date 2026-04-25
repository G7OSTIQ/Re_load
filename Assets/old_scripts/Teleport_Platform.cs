using UnityEngine;

public class Teleport_Platform : MonoBehaviour
{
    private bool isTeleporting = false;

    private void OnTriggerEnter(Collider other)
    {
        // ignore player completely
        if (other.CompareTag("Player")) return;

        if (other.CompareTag("Small_enimie"))
        {
            if (isTeleporting) return;
            isTeleporting = true;

           // Platform_movement snake = FindObjectOfType<Platform_movement>();
            //if (snake != null)
            {
                // pick a random DIFFERENT platform to teleport to
            //    int randomIndex = Random.Range(0, snake.platforms.Length);
              //  Vector3 newPos = snake.platforms[randomIndex].transform.position;
           //     newPos.y = other.transform.position.y; // keep enemy's Y so it doesn't fall
           //     other.transform.position = newPos;
            }

            isTeleporting = false;
        }
    }
}