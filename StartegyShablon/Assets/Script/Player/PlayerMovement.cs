using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour, IMovement
{
    [SerializeField] private float speed;
    private bool canMove;

    private Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        canMove = true;
    }

    private void Update()
    {
        TurnInMoveDirection();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void TurnInMoveDirection()
    {
        if (rigidbody.velocity.x > 0.01f)
            transform.localScale = new Vector2(1f, 1f);
        else if (rigidbody.velocity.x < -0.01f)
            transform.localScale = new Vector2(-1f, 1f);
    }

    public void Move()
    {
        if (canMove == false) return;

        rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime,
Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime);
    }

    public void CanMove() => canMove = true;
    public void CantMove() => canMove = false;
}
