using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInputReader : MonoBehaviour
{
    InputAction move;
    public Vector2 MoveDirection => isActiveAndEnabled ? move.ReadValue<Vector2>() : Vector2.zero;
    private void Awake()
    {
        move = InputSystem.actions.FindAction("Player/Move", throwIfNotFound: true);
    }
}
