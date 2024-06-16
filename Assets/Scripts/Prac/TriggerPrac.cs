using UnityEngine;

public class TriggerPrac : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject);
    }
}
