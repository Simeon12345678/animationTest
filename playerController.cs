using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField]
    Animator animator;

    float speed = 8;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movementX = new Vector2(moveX, 0);
        Vector2 movementY = new Vector2(0, moveY);

        Vector2 movement = movementX + movementY;

        transform.Translate(movement * speed * Time.deltaTime);

        if (movement.x > 0)
        {
            animator.Play("walkRight");
        }
        else if (movement.x < 0)
        {
            animator.Play("walkLeft");
        }
        else if (movement.y > 0)
        {
            animator.Play("walkUp");
        }
        else if (movement.y < 0)
        {
            animator.Play("walkDown");
        }
        else
        {
            animator.Play("idle");
        }
    }
}
