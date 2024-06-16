using UnityEngine;

public class MedKit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth.GetCurrentHealth() < playerHealth.GetMaxHealth())
            {
                playerHealth.SetCurrentHealth();
                playerHealth.SetSprite();
                Destroy(gameObject);
            }
        }
    }
}
