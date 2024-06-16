using UnityEngine;

public class RayCastPrac : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D[] hit = Physics2D.CircleCastAll(transform.position, 5, Vector2.zero, 5, LayerMask.GetMask("PickUp"));
            for (int i = 0; i < hit.Length; i++)
            {
               
                Destroy(hit[i].collider.gameObject);
            }
            
        }

    }
}
