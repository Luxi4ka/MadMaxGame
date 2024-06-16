using UnityEngine;

public class Granade : MonoBehaviour
{
    public float timeToExplode;
    public float radius;
    public int damage;
    public Transform player;
    public Rigidbody2D rb;
    private void Start()
    {
        Invoke(nameof(Explode), timeToExplode);
    }
    public void Explode()
    {
        RaycastHit2D hit = Physics2D.CircleCast(transform.position, radius, Vector2.zero, radius, LayerMask.GetMask("Player"));
        if(hit.collider != null)
        {
            hit.collider.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
    public void ThrowGranade(Transform player , float force )
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 direction = player.position - transform.position;
        transform.right = direction;
        rb.AddForce(direction * force);
       
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
