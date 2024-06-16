using UnityEngine;
using UnityEngine.SceneManagement;

public class SwichScene : MonoBehaviour
{
    public string sceneName;

    public void SwichTheScenes()
    {
        SceneManager.LoadScene(sceneName);
    }
}
