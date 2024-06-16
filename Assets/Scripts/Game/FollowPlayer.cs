using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float speedFollow;

    private void Update()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
}
