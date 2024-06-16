using UnityEngine;

public class GizmosPrac : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position, Vector3.one);
        Gizmos.DrawWireSphere(transform.position, 3);
    }
}
