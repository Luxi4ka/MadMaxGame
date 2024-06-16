using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntryPartEnd : MonoBehaviour
{
    public float waitingTime;
    void Start()
    {
        StartCoroutine(TheEnd());
    }
    public IEnumerator TheEnd()
    {
        yield return new WaitForSecondsRealtime(waitingTime);
        if (SceneManager.GetActiveScene().buildIndex == PlayerPrefs.GetInt("LvlProgress", 1))
        {
            PlayerPrefs.SetInt("LvlProgress", SceneManager.GetActiveScene().buildIndex + 1);
        }
        SceneManager.LoadScene("Level1");
    }
}
