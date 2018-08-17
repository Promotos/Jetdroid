using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienB : MonoBehaviour {

    private Animator animator;
    private bool readyToAttack = false;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}

	void OnTriggerStay2D(Collider2D target)
    {
        if (readyToAttack && target.gameObject.tag == "Player")
        {
            target.GetComponent<Explode>().OnExplode();
        }
    }

    void Attack()
    {
        readyToAttack = true;
    }

    void Sleep()
    {
        readyToAttack = false;
    }
}
