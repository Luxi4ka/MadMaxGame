using UnityEngine;

public class Nitrous : MonoBehaviour
{
    public float force;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerMovement>().PushForce(force);
            Destroy(gameObject);
        }
    }
}
