using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Hand : MonoBehaviour
{
    Animator animator;
    SkinnedMeshRenderer mesh;
    public float speed;
    private float gripTarget;
    private float triggerTarget;
    private float gripCurrent;
    private float triggerCurrent;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        mesh = GetComponentInChildren<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }

    internal void SetGrip(float v)
    {
        gripTarget = v;
    }

    internal void SetTrigger(float v)
    {
        triggerTarget = v;
    }

    void AnimateHand(){
        if(gripCurrent != gripTarget)
        {
            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * speed);
            animator.SetFloat("Grip", gripCurrent);
        }
        if(triggerCurrent != gripTarget)
        {
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * speed);
            animator.SetFloat("Trigger", triggerCurrent);
        }
    }

    public void ToggleVisibility()
    {
        mesh.enabled = !mesh.enabled;
    }
}
