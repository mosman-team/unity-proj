using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Detector : MonoBehaviour
{
    HealthDisplay healthText;

    private void Start()
    {
        healthText = FindObjectOfType<HealthDisplay>();
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Attacker>())
        {
            healthText.decreaseHealth();
            Destroy(collision.gameObject, 1f);
        }
        
    }

}
















