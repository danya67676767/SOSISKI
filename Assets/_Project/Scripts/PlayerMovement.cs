using UnityEngine;

[RequireComponent(typeof(PlayerInputReader), typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Min(0f)] private float speed = 5f;

    private PlayerInputReader input;
    private Rigidbody2D body;

    private void Awake()
    {
        input = GetComponent<PlayerInputReader>();
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 direction = Vector2.ClampMagnitude(input.MoveDirection, 1f);
        body.linearVelocity = direction * speed;
    }

    private void OnDisable()
    {
        body.linearVelocity = Vector2.zero;
    }
}