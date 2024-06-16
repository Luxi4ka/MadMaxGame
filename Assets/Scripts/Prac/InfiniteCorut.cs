using System.Collections;
using UnityEngine;

public class InfiniteCorut : MonoBehaviour
{
    public IEnumerator myMethod;
    private void Start()
    {
        myMethod = Prnt();
        StartCoroutine(myMethod); 
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            StopCoroutine(myMethod);
        }
    }
    public IEnumerator Prnt()
    {
        yield return new WaitForSeconds(10);
        print("ijfenvifivi");
    }
}
