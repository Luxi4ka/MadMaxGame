using UnityEngine;

public class TargetArea : MonoBehaviour
{
    //ctrl+K+D
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            float playerSpeed = collision.GetComponent<PlayerMovement>().GetSpeed();
            GetComponentInParent<EnemyMovement>().SetSpeed(playerSpeed - 1);
            Destroy(gameObject);
        }
    }
}
