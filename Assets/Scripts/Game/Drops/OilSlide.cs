using UnityEngine;

public class OilSlide : MonoBehaviour
{
    public float slideSpeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var player = collision.GetComponent<PlayerMovement>();
            player.SetSpeed(slideSpeed);
            player.LockTurn();
        }
    }
}
