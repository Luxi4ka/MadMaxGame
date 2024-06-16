using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLvl : MonoBehaviour
{
    public float fadeDuration;
    public Image panel;
    public float waitingTime;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int moneyCollected = collision.GetComponent<MoneyPickUp>().GetmoneyAmount();
            Save(moneyCollected);
            StartCoroutine(EndLVL());
        }
    }
    public void Save(int moneyPickedUp)
    {
        if (SceneManager.GetActiveScene().buildIndex == PlayerPrefs.GetInt("LvlProgress",2))
        {
            PlayerPrefs.SetInt("LvlProgress", SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (PlayerPrefs.GetInt("GoldBag") == 1)
        {
            moneyPickedUp *= 2;
        }
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + moneyPickedUp);
        print(PlayerPrefs.GetInt("LvlProgtess"));
    }
     public IEnumerator EndLVL()
     {
        yield return new WaitForSecondsRealtime(waitingTime);
        Color color = panel.color;
        while (panel.color.a < 1)
        {
            color.a += fadeDuration;
            panel.color = color;
            yield return null;
        }
        SceneManager.LoadScene("Menu");
     }

}
