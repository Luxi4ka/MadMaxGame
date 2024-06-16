using System;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject bullet;
    public GameObject mines;
    public Transform spawn;
    public Transform LandBombs;

    public Transform player;
    public float distance;
    public float fireRate;
    public float lastShootTime;

    public float lastMine;
    public float mineRate;
    private void Update()
    {
        AmmunitionAttack();
        DropBombs();
    }
    public void AmmunitionAttack()
    {
        if (Math.Abs(transform.position.x - player.position.x) < distance && Time.time > fireRate + lastShootTime)
        {
            Instantiate(bullet, spawn.position, spawn.rotation);
            lastShootTime = Time.time;
        }
    }
    public void DropBombs()
    {
        if (Time.time > mineRate + lastMine)
        {
            Instantiate(mines, LandBombs.position, LandBombs.rotation);
            lastMine = Time.time;
        }
    }
}
