using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 move;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = Vector2.zero;

        if (Keyboard.current.wKey.isPressed)
            move.y = 1;

        if (Keyboard.current.sKey.isPressed)
            move.y = -1;

        if (Keyboard.current.aKey.isPressed)
            move.x = -1;

        if (Keyboard.current.dKey.isPressed)
            move.x = 1;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move.normalized * speed * Time.fixedDeltaTime);
    }
}