using UnityEngine;

public class SwitchPlayerMowement : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerMovement>().EnableScript();
        }
    }
}
