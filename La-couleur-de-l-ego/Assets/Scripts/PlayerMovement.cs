using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        MovePlayer(horizontal, vertical);
        Flip(rb.velocity.x);
        float characterVelocity = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("Speed", characterVelocity);
    }

    void MovePlayer(float _horizontal, float _vertical)
    {
        Vector3 targetVelocity = new Vector2(_horizontal, _vertical);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, 0.05f);
    }

    void Flip(float _velocity)
    {
        if (_velocity > 0.1f) {
            spriteRenderer.flipX = false;
        } else if (_velocity < -0.1f) {
            spriteRenderer.flipX = true;
        }
    }
}
