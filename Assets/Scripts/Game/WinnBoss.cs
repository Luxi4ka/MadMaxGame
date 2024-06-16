using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnBoss : MonoBehaviour
{
    private void OnDestroy()
    {
        SceneManager.LoadScene("Menu");
    }
}
