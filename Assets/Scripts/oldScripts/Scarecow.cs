using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scarecow : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Debug.Log("Scarecow has a collision");

        if (otherCollider.GetComponent<Attacker>())
        {
            Debug.Log("Colision with Attacker");
            animator.SetBool("isDead", true);
        }

    }
    public void destroyScarecow()
    {

        Destroy(gameObject);
    }
}
