using UnityEngine;

public class AmmoDirection : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float timeDestroy;
    public int damage;

    public AudioSource sound;
    public GameObject soundBox;
    private void Start()
    {
        sound = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed * transform.right;
        ShootSound();
    }
    private void Update()
    {
        Destroy(gameObject, timeDestroy);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(soundBox, transform.position, transform.rotation);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyDamage>().TakeDamage(damage);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
    public void ShootSound()
    {
        sound.Play();
    }
}
