using UnityEngine;

public class NextRoadPart : MonoBehaviour
{
    public Transform roadSpawner;
    public GameObject nextRoad;
    public float timeDestroy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(nextRoad, roadSpawner.position, roadSpawner.rotation);
            Destroy(transform.parent.gameObject, timeDestroy);
        }
    }
}
