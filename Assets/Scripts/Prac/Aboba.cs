using UnityEngine;

public class Aboba : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
            
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(transform.position + Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(transform.position + Vector3.left * Time.deltaTime * speed);
        }
    }
    private void FixedUpdate()
    {
        
    }
}

