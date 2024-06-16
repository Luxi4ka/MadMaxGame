using TMPro;
using UnityEngine;

public class MoneyPickUp : MonoBehaviour
{
    public TMP_Text score;
    public int moneyAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PickUp"))
        {
            moneyAmount++;
            score.text = moneyAmount.ToString();
            Destroy(collision.gameObject);
        }
    }
    public int GetmoneyAmount()
    {
        return moneyAmount;
    }
}
