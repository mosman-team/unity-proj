using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En_Archer : MonoBehaviour
{
    [SerializeField] ProjectileController projectile;
    [SerializeField] GameObject gun;

    void Start()
    {
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }

}
