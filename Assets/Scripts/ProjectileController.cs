using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{

    [Range(1f, 5f)] [SerializeField] float projectileSpeed;
    [SerializeField] int damage = 50; 

    //[SerializeField] float rotateBy;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * projectileSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        var health = other.GetComponent<Health>();
        var attacker = other.GetComponent<Attacker>();

        if (health && attacker)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }

    }

}









