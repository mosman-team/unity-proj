﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] GameObject deathVFX;

    public virtual void DealDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            GetComponent<Collider2D>().enabled = false;
            Debug.Log("Here");
            GetComponent<Animator>().SetBool("isDead", true);
        }
    }

    private void TriggerDeathVFX()
    {
        if (!deathVFX) { return; }

        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, Quaternion.identity);

        Destroy(deathVFXObject, 1f);
        
    }
    void DestroyWarrior()
    {
        Destroy(gameObject);
    }
    public int getHealth()
    {
        return health;
    }
    public void setHealth(int health)
    {
        this.health = health;
    }
}
