using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int cost;
    StarDisplay starDisplay;
    [SerializeField] float currentSpeed;
    GameObject currentTarget;

    Animator animator;

    void Start()
    {
        starDisplay = FindObjectOfType<StarDisplay>();
        animator = GetComponent<Animator>();

    }
    void DestroyDefender()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Translate(Vector2.right * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }
        
    private void UpdateAnimationState()
    {
        if (gameObject.GetComponent<CastleHealth>())
        {
            return;
        }
        if (!currentTarget)
        {
            animator.SetBool("isAttacking", false);
        }
    }

    public void StrikeCurrentTarget(int damage)
    {
        if (!currentTarget) { return; }
        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            health.DealDamage(damage);
        }

    }


    public int GetCost()
     {
        return cost;
     }

    public void Attack(GameObject target)
    {
        animator.SetBool("isAttacking", true);
        currentTarget = target;
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void CallAddToStars(int amount)
    {
        starDisplay.AddToStars(amount);
    }
}





















