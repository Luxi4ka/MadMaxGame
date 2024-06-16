using UnityEngine;

public class ButtonDynamic : MonoBehaviour
{
    public Animator animator;
    private void Start()
    {
       animator =  GetComponent<Animator>();
    }
    public void OnMouseEnter()
    {
        animator.Play("ButtonHower");
    }
    public void OnMouseExit()
    {
        animator.Play("ButtonUnscale");
    }
}
