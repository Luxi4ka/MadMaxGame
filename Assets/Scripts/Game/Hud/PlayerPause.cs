using UnityEngine;

public class PlayerPause : MonoBehaviour
{
    public GameObject menu;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(!menu.activeSelf);
        }
    }
}
