using UnityEngine;

public class RandBoosters : MonoBehaviour
{
    //перед тем как спавнить обьект я проверяю на null
    //если он не null я спавню 
    //когда я спавню обьяект в каком то месте это место = null
    //  если null сново выбира место
    public Transform[] spawners;
    public GameObject[] boosters;
    public int quantitySpawners;
    private void Start()
    {
        SpawnBoosters();
    }
    public void SpawnBoosters()
    {
        int count = 0;
        while(count<quantitySpawners)
        {
            int random = Random.Range(0,spawners.Length);
            Transform spawnPosition = spawners[random];
            if (spawnPosition!=null)
            {
                Instantiate(boosters[Random.Range(0, boosters.Length)], spawnPosition.position, Quaternion.identity);
                spawners[random] = null;
                count++;
            }
        }
    }
}
