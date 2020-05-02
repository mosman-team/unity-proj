using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other)
    {

        GameObject otherObject = other.gameObject;

        if (otherObject.GetComponent<Gravestone>())
        {
            Jump();
        }
        else if (otherObject.GetComponent<Scarecow>())
        {
            GetComponent<Attacker>().setMovementDirection(Vector2.right);
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        } 
        else if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
        
    }

    private void Jump()
    {
        GetComponent<Animator>().SetTrigger("JumpTrigger");
    }
}















