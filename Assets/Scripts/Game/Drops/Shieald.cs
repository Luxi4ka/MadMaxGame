using UnityEngine;

public class Shieald : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHealth>().SetEternuty(true);
            Destroy(gameObject);
        }
    }
}
