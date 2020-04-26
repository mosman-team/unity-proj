using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherObject = other.gameObject;

        if (otherObject.GetComponent<Scarecow>())
        {
            GetComponent<Attacker>().setMovementDirection(Vector2.right);
            gameObject.transform.localScale = new Vector3(-1, 1, 1);

        }
        else if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }

    }



}
