using UnityEngine;

public class CorutTest : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.K))
        {
            print("Yuo");
            StartCoroutine(GetComponent<Corut>().PrntTwo());
        }
    }
}
