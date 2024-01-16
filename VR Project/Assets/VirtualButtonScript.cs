using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript: MonoBehaviour
{
    public GameObject botella;
    public Animator animator;
    public VirtualButtonBehaviour vb;
    public AudioSource audioSource;
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed); 
        vb.RegisterOnButtonReleased(OnButtonReleased);
        animator.GetComponentInChildren<Animator>();
        botella.SetActive(false);
        audioSource.Pause();
    }
    private void Update()
    {
        //vb.RegisterOnButtonPressed(OnButtonPressed);
        //vb.RegisterOnButtonPressed(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        botella.SetActive(true);
        Debug.Log("Pressed");
        animator.SetBool("IsIdle", true);
        audioSource.Play();
    }     
    public void OnButtonReleased(VirtualButtonBehaviour vb2)
    {
        botella.SetActive(false);
        Debug.Log("Pressednt");
        animator.SetBool("IsIdle", false); 
        audioSource.Pause();
    }    
}
