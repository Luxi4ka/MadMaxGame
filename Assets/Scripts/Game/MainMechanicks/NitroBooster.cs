using UnityEngine;
using UnityEngine.UI;

public class NitroBooster : MonoBehaviour
{
    public float boosterForce;
    private Slider boosterSlider;
    public GameObject boosterLine;
    public float boosterDecrease;
    public PlayerMovement playerMovement;

    private void Start()
    {
        boosterSlider = boosterLine.GetComponent<Slider>();
        playerMovement = GetComponent<PlayerMovement>();
        if (PlayerPrefs.GetInt("Nitro") == 1)
        {
            boosterLine.SetActive(true);
        }
    }
    private void Update()
    {
        if (boosterLine && Input.GetKey(KeyCode.Space) && boosterSlider.value > 0)
        {
            boosterSlider.value -= boosterDecrease * Time.deltaTime; ;
            playerMovement.PushForce(boosterForce);
        }
    }
}
