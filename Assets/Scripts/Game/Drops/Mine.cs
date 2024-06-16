using UnityEngine;

public class Mine : MonoBehaviour
{
    public int damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().ExplodeOnMine(damage);
        }
        Destroy(gameObject);
    }
}
