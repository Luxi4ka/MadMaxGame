using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private void Start()
    {
        rb =  GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Move();
    }
    public void Move()
    {
        rb.velocity = Vector2.right * speed;
    }
    public void SetSpeed(float playerSpeed)
    {
        speed = playerSpeed;
    }
}
