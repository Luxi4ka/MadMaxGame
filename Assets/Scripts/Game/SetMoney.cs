using TMPro;
using UnityEngine;

public class SetMoney : MonoBehaviour
{
    public int moneyAmount;
    public TMP_Text moneyText;
    private void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("Money");
        SetText();
    }
    public int GetMoneyAmount()
    {
        return moneyAmount;
    }
    public void BuyItem(int price)
    {
        moneyAmount -= price;
        SetText();
    }
    public void SetText()
    {
        PlayerPrefs.SetInt("Money", moneyAmount);
        moneyText.text = moneyAmount.ToString();
    }
}
