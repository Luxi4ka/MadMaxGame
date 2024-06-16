using UnityEngine;

public class RandBoosters : MonoBehaviour
{
    //����� ��� ��� �������� ������ � �������� �� null
    //���� �� �� null � ������ 
    //����� � ������ ������� � ����� �� ����� ��� ����� = null
    //  ���� null ����� ������ �����
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
