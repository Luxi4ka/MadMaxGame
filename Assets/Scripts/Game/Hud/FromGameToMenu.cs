using UnityEngine;
using UnityEngine.SceneManagement;

public class FromGameToMenu : MonoBehaviour
{
    public  void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }  
}
