using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public int ammoCount;

    public float fireRate;
    public float lastShootTime;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        if (ammoCount > 0 && Time.time > fireRate + lastShootTime)
        {
            Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            lastShootTime = Time.time;
            ammoCount--;
        }   
    }
    public void IncreaseAmmo(int ammoAmount)
    {
        ammoCount += ammoAmount;
    }
}
