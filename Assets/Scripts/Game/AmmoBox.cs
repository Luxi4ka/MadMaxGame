using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    public int AmmoInBox;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponentInChildren<Shooting>().IncreaseAmmo(AmmoInBox);
            Destroy(gameObject);
        }
    }
}

