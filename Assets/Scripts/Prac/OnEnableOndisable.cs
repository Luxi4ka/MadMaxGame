using Unity.VisualScripting;
using UnityEngine;

public class OnEnableOndisable : MonoBehaviour
{
    private void Awake()
    {
        print("Awake");
    }
    private void OnEnable()
    {
        print("enable");
    }
    private void Start()
    {
        print("Start");
    }
  /*  private void FixedUpdate()
    {
        print("FIXED UPDATE");
    }
    private void Update()
    {
        print("Update");
    }
    private void LateUpdate()
    {
        print("Late Update");
    }*/
    private void OnDisable()
    {
        print("disable");
    }
    private void OnDestroy()
    {
        print("Destroy");
    }
}