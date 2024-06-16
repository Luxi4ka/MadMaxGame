using UnityEngine;

public class Spikes : MonoBehaviour
{
    public int damage;
    public float decreaseSpeed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<EnemyDamage>().TakeDamage(damage);
        }
        else if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHealth>().TakeDamage(damage);
            collision.GetComponent<PlayerMovement>().SetSpeed(decreaseSpeed);
        }

    }
}
