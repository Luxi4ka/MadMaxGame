using UnityEngine;

public class LaserRaycast : MonoBehaviour
{
    private void Start()
    {
           
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.position + Vector3.right, 5, LayerMask.GetMask("Bumper", "Enemy"));
            Debug.Log(hit.collider);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * 5);
    }
}
