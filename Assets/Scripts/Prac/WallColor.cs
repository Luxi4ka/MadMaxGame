using UnityEngine;

public class WallColor : MonoBehaviour
{
    public SpriteRenderer wallRenderer;
    private void Start()
    {
        wallRenderer = GetComponent<SpriteRenderer>();
    }
    public void SetColor(Color color)
    {
        wallRenderer.color = color;
    }
}
