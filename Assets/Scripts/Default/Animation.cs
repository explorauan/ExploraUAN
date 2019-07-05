using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {

	private Animator anim;


	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Walk(){
		anim.Play("walk", -1, 0f);
	}

	public void Hit1(){
		anim.Play("hit01", -1, 0f);
	}

	public void Hit2(){
		anim.Play("hit02", -1, 0f);
	}

	public void Jump(){
		anim.Play("jump", -1, 0f);
	}
}
