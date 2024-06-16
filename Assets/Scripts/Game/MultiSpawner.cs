using UnityEngine;

public class MultiSpawner : MonoBehaviour
{
    public GameObject spawnedObject;
    public float repeatingTime;
    public float invokeTime;
    public float forceThrowing;
    public Transform player;
    void Start()
    {
        InvokeRepeating(nameof(InstanceGranade), invokeTime, repeatingTime);
    }
    public void InstanceGranade()
    {
        GameObject granade = Instantiate(spawnedObject, transform.position, transform.rotation);
        granade.GetComponent<Granade>().ThrowGranade( player, forceThrowing);
    }
}
