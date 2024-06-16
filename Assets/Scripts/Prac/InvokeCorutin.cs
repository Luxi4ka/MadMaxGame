using UnityEngine;

public class InvokeCorutin : MonoBehaviour
{
    //2 кубика нужно рандомить кубик и спавнить пока не будет 3 синих кубика
    public GameObject cube;
    public int countBlue;
    public Transform spavning;
    private void Start()
    {
        InvokeRepeating(nameof(RandCube), 3, 3);
    }

    public void RandCube()
    {
        int rand = Random.Range(0, 2);
        SpriteRenderer newSpriteRenderer = Instantiate(cube, spavning.position, spavning.rotation).GetComponent<SpriteRenderer>();
        if (rand == 0)
        {
            newSpriteRenderer.color = Color.blue;
            countBlue++;
            if (countBlue == 3)
            {
                CancelInvoke();
            }
        }
        else if (rand == 1)
        {
            newSpriteRenderer.color = Color.red;
        }
    }
}
