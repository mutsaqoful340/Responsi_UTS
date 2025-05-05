using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameObject buttonAnimation, popUp;
    private Animator animator1, animator2;
    // animator1 > popup
    // animator2 > button

    public void PopUpSystemOpen() => StartCoroutine(ShowPupUpCoroutine());
    public void PopUpSystemClose() => StartCoroutine(HidePupUpCoroutine());

    private void Start()
    {
        animator1 = popUp.GetComponent<Animator>();
        animator2 = buttonAnimation.GetComponent<Animator>();
    }
    public IEnumerator ShowPupUpCoroutine()
    {
        animator2.Play("close");
        yield return new WaitForSeconds(0.5f);
        animator1.Play("popup");
    }

    public IEnumerator HidePupUpCoroutine()
    {
        animator2.Play("popup");
        yield return new WaitForSeconds(0.1f);
        animator1.Play("close");
    }
}
