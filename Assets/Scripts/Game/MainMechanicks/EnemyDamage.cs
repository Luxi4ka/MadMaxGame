using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float currentHealth;
    public Animator enemyAnimator;
    public float chanceDropAidKit;
    public float chanceDropAmmoBox;

    public GameObject instanceAidKit;
    public GameObject instanceAmmoBox;
    private void Start()
    {
        enemyAnimator = GetComponent<Animator>();
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        enemyAnimator.Play("EnemyTakeDamage");
        if(currentHealth <= 0)
        {
            Death();
        }
    }
    public void Death()
    {
        int chance = Random.Range(0, 101);

        if (chance <= chanceDropAmmoBox)
        {
            Instantiate(instanceAidKit, transform.position, transform.rotation);
        }
        else if (chance <= chanceDropAidKit+chanceDropAmmoBox)
        {
            Instantiate(instanceAmmoBox, transform.position, transform.rotation);
        }
        Destroy(gameObject);
    }

}
