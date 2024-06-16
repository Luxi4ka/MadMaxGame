using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float currentHealth;
    public Animator animatorPlayer;
    public float maxHealth;
    public bool isEternuty;

    public int ExplodeTrack;
    public int countOfExplode;

    public Sprite[] spritesHealth;
    public Image imageHealth;

    public float timeOffEternity;
    private void Start()
    {
        if (PlayerPrefs.GetInt("Health") == 1)
        {
            maxHealth += 5;
        }
        animatorPlayer = GetComponent<Animator>();
        SetCurrentHealth();
    }
    public void TakeDamage(int damage)
    {
        if (isEternuty)
        {
            return;
        }
        currentHealth -= damage;
        animatorPlayer.Play("PlayerTakeDamage");
        ChangeSprite();
        if (currentHealth <= 0)
        {
            Death();
        }
    }
    public void ExplodeOnMine(int damageExplode)
    {
        TakeDamage(damageExplode);
        ExplodeTrack++;
        if(ExplodeTrack >= countOfExplode)
        {
            Death();
        }
    }
    public void Death()
    {
        print("Lost");
    }
    public void SetCurrentHealth()
    {
        currentHealth = maxHealth;
    }
    public float GetCurrentHealth()
    {
        return currentHealth;
    }
    public float GetMaxHealth()
    {
        return maxHealth;
    }
    public void SetEternuty(bool change)
    {
        isEternuty = change;
        Invoke(nameof(DeactiveEternity), timeOffEternity);
    }
    public void SetSprite()
    {
        imageHealth.sprite = spritesHealth[0];
    }
    public void DeactiveEternity()
    {
        isEternuty = false;
    }
    
    public void ChangeSprite()
    {
        switch (currentHealth)
        {
            case > 19:
                imageHealth.sprite = spritesHealth[0];
                break;
            case > 15:
                imageHealth.sprite = spritesHealth[1];
                break;
            case > 10:
                imageHealth.sprite = spritesHealth[2];
                break;
            case > 5:
                imageHealth.sprite = spritesHealth[3];
                break;
            case < 5:
                imageHealth.sprite = spritesHealth[3];
                break;
        }
    }
}
