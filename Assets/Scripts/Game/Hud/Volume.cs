using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    private void Start()
    {
        float sound = PlayerPrefs.GetFloat("SaveVolume");
        GetComponent<Slider>().value = sound;
        AudioListener.volume = sound;
    }
    public void ChangeVolume(float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("SaveVolume", volume);
    }
}
