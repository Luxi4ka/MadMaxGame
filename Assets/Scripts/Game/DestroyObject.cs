using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float timeToDestroy;
    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
}
