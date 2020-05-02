using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marmilon : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherObject = other.gameObject;
        if (otherObject.GetComponent<Attacker>())
        {
            GetComponent<Defender>().Attack(otherObject);
        }

    }

}
