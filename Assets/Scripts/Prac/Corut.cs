using System.Collections;
using UnityEngine;

public class Corut : MonoBehaviour
{
    //number = number > 0 ? 5 : -5; 
    private void Start()
    {

    }
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.L))
        {
            Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        }
    }
    public IEnumerator Prnt()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            print("Print 1");
        }
    }
    public IEnumerator PrntTwo()
    {
        while(true)
        {
            yield return new WaitForSecondsRealtime(1);
            print("Print 2");
        }
        
    }
}
