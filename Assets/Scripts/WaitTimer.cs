using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitTimer : MonoBehaviour
{
    public Animator animator;
    public float time;

    void Update()
    {
        time -= Time.deltaTime;
        animator.SetFloat("WaitTimer", time);
    }
}