using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    //[Range(0f, 5f)] [SerializeField] float walkSpeed = 1f;

    float currentSpeed = 1f;
    GameObject currentTarget;
    Animator animator;

    LevelController levelController;

    // new
    Vector2 movementDirection;

    private void Awake()
    {
        levelController = FindObjectOfType<LevelController>();
        levelController.AttackerCreated();
    }

    private void Start()
    {
        movementDirection = Vector2.left;
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementDirection * Time.deltaTime * currentSpeed);
        UpdateAnimationState();
    }

    void OnDestroy()
    {
        if (levelController != null)
        {
            levelController.AttackerKilled();
        }
    }

    private void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            animator.SetBool("isAttacking", false);
        }
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void Attack(GameObject target)
    {
        animator.SetBool("isAttacking", true);
        currentTarget = target;
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
    public void setMovementDirection(Vector2 dir)
    {
        this.movementDirection = dir;
    }
}
























