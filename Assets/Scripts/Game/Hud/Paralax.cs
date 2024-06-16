using UnityEngine;

public class Paralax : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float parallaxModifier;
    public PlayerMovement playerMowement;
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void FixedUpdate()
    {

        float playerSpeed = playerMowement.GetSpeed();
        meshRenderer.material.mainTextureOffset += new Vector2(playerSpeed / parallaxModifier * Time.deltaTime, 0);
    }
}
