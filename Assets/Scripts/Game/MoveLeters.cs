using UnityEngine;

public class MoveLeters : MonoBehaviour
{
    public Transform target;
    public float speed;
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
