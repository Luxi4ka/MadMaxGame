using UnityEngine;
using System;

public class Shotgun : MonoBehaviour
{
    public GameObject bullet;

    public Transform[] spawnBullet;
    public Transform player;


    public float shootRate;
    public float lastShoot;
    public float distance;

    private void Update()
    {
        if (Math.Abs(transform.position.x - player.position.x) < distance && Time.time > shootRate + lastShoot)
        {
            for (int i = 0; i < spawnBullet.Length; i++)
            {
                Instantiate(bullet, spawnBullet[i].position, spawnBullet[i].rotation);
            }
            lastShoot = Time.time;
        }
    }
}
