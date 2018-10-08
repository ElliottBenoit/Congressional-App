using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    Animator animator;
    public bool Bool = false;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Update()
    {
        animator.SetBool("Disappear", Bool);
    }

    public void Switch()
    {
        Bool = true;
    }

    public void Off()
    {
        GameObject.Find("Get Started").SetActive(false);
    }
}
