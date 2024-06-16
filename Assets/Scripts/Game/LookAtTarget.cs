using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform target;

    private void FixedUpdate()
    {
        transform.right = target.position - transform.position;
    }
}
