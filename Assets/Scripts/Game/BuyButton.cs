using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    public int price;
    public SetMoney setMoney;
    public string itemName;
    private void Start()
    {
        if (PlayerPrefs.GetInt(itemName) == 1)
        {
            GetComponent<Button>().interactable = false;
        }
    }
    public void Buying()
    {
        int  moneyTotal = setMoney.GetMoneyAmount();
        if (moneyTotal >= price)
        {
            setMoney.BuyItem(price);
            PlayerPrefs.SetInt(itemName, 1);
            GetComponent<Button>().interactable = false;
        }
        else
        {
            print("No money bomj");
        }
    }
    private void OnValidate()
    {
        GetComponentInChildren<TMP_Text>().text = price.ToString();
    }
}
