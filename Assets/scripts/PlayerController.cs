using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Collider2D swordCollider;
    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        swordCollider.enabled = false;
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        if (Input.GetButton("Fire1"))
        {
            animator.Play("player_attack");
            swordCollider.enabled = true;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y);
        if (rb.velocity.x != 0)
        {
            if (rb.velocity.x < 0)
            {
                //spriteRenderer.flipX = true;
                transform.localScale = new Vector3(-0.6705313f, 0.724982f, 1);
            }
            else
            {
                //spriteRenderer.flipX = false;
                transform.localScale = new Vector3(0.6705313f, 0.724982f, 1);
            }
        }
    }
}
