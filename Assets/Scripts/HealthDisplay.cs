using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] int health = 10;
    [SerializeField] Text healthText;

    
    void Start()
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        healthText.text = health.ToString();
    }
    public void decreaseHealth()
    {
        health--;
        UpdateHealth();

        if (health <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }

}
