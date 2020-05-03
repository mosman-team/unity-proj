using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{

    [Range(1f, 5f)] [SerializeField] float projectileSpeed;
    [SerializeField] int damage = 50;

    Vector2 projectileDirection;

    void Start()
    {
        projectileDirection = Vector2.left;
    }

    //[SerializeField] float rotateBy;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(projectileDirection * Time.deltaTime * projectileSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        var health = other.GetComponent<Health>();
        var attacker = other.GetComponent<Defender>();

        if (health && attacker)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }

    }
    public void setProjectileDirection(Vector2 dir)
    {
        this.projectileDirection = dir;
    }

}









