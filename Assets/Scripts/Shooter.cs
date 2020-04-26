using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject gun;
    AttackerSpawner myLaneSpawner;

    Animator animator; 

    void Start()
    {
        animator = GetComponent<Animator>();
        SetLaneSpawner();
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in spawners)
        {
            bool isClose = Math.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon;

            if (isClose)
            {
                myLaneSpawner = spawner;
            }
        }
        
    }

    void Update()
    {
        if (IsAttakerInLane())
        {
            animator.SetBool("IsAttacking", true);
        }
        else
        {
            animator.SetBool("IsAttacking", false);

        }
    }

    private bool IsAttakerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else return true;
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation); 
    }

}
 