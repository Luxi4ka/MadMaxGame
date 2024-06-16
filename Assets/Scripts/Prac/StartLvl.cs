using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartLvl : MonoBehaviour
{

    public int currentLevelIndex;
    private void Start()
    {
        if (PlayerPrefs.GetInt("LvlProgress", 1) < currentLevelIndex)
        {
            GetComponent<Button>().interactable = false;
        }
    }
    public void LvlLoad()
     {
        SceneManager.LoadScene(currentLevelIndex);
     }
    public void ChangeIndex(int index)
    {
        currentLevelIndex = index;
    }
}
