﻿using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

    private Animator attachedAnimator;

	// Use this for initialization
	void Start () {

        attachedAnimator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        attachedAnimator.SetFloat("verticalSpeed", Input.GetAxis("Vertical"));
        attachedAnimator.SetFloat("horizontalSpeed", Input.GetAxis("Horizontal"));

        //if (Input.GetButton("Jump"))
        //{
        //    attachedAnimator.SetBool("jumping", true);
        //    Invoke("StopJumping", 0.1f);
        //}

        if (Input.GetButton("Run"))
        {
            attachedAnimator.SetBool("running", true);
        }
        else
        {
            attachedAnimator.SetBool("running", false);
        }
	}

    void StopJumping()
    {
        attachedAnimator.SetBool("jumping", false);
    }
}
