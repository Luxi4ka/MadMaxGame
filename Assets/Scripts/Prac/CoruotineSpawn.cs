using System.Collections;
using UnityEngine;

public class CoruotineSpawn : MonoBehaviour
{
    public int timeSpawn;
    public GameObject triangle;
    public Transform spawner;
    private void Start()
    {
        StartCoroutine(Spawn());
    }
    public IEnumerator Spawn()
    {
        while (true) 
        {
            yield return new WaitForSeconds(timeSpawn);
            Instantiate(triangle, transform.position, transform.rotation);
            timeSpawn++;
        }
    }
}
