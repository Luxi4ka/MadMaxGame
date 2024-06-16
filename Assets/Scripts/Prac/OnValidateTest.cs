using TMPro;
using UnityEngine;

public class OnValidateTest : MonoBehaviour
{
    public Transform[] lvls;
    private void Start()
    {
      
    }
    private void OnValidate()
    {
        lvls = GetComponentsInChildren<Transform>();
        for (int i = 1; i < lvls.Length; i++)
        {
            lvls[i].name = $"Lvl {i}";
        }
    }
}
