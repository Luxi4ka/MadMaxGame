using TMPro;
using UnityEngine;


public class LanguageSet : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TMP_Dropdown>().value = PlayerPrefs.GetInt("Language");
    }
    public void ChangeLanguaged(int language)
    {
        PlayerPrefs.SetInt("Language", language);
    }
}
