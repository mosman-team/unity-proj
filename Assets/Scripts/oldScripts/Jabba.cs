using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jabba : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        GameObject otherObject = other.gameObject;

       
        if (otherObject.GetComponent<Scarecow>())
        {
            GetComponent<Attacker>().setMovementDirection(Vector2.right);
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            Debug.Log("Get Back");
        }
        else if (otherObject.GetComponent<Defender>())
        {
            Debug.Log("Crash!");
        }

    }
}
