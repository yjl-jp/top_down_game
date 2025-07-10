using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    private PlayerControls playerControls;
    private Vector2 movement;
    private Rigidbody2D rb;
    private void Awake()
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void Update()
    {
        PlayerIuput();
    }

    private void FixedUpdate()
    {
        Move();
    }
    private void PlayerIuput()
    {
        movement = playerControls.Movement.Move.ReadValue<Vector2>();
    }
    private void Move()
    {
        rb.MovePosition(rb.position + movement*(moveSpeed*Time.fixedDeltaTime));
    }
}
