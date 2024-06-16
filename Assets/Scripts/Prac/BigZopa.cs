using UnityEngine;

public class BigZopa : MonoBehaviour
{
    //каждые несколько секунд должен менять свой цвет на рандомный, когда мячик косается стенки , онокаршивает ее в свой цвет
    // в начале игры мячик пуляется в рандомную сторону, нонстоп попрыгун 
    //отскакивания

    public SpriteRenderer spriteRenderer;
    public int rateColor;

    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating(nameof(RandColour), rateColor, rateColor);
        RandomForce();
    }
    public void RandColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<WallColor>().SetColor(spriteRenderer.color);
    }
    public void RandomForce()
    {
        Vector2 direction = new Vector2(Random.Range(-3000, 3001), Random.Range(-3000, 3001));
        rb.AddForce(direction);
    }

}
