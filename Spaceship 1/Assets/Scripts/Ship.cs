using UnityEngine;
using UnityEngine.InputSystem;

public class Ship : MonoBehaviour
{
    public Rigidbody2D ship;
    public float engineSpeed;
    private InputAction _moveAction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _moveAction = InputSystem.actions.FindAction("move");
    }

    // Update is called once per frame
    void Update()
    {
        if (_moveAction.inProgress)
        {
            Vector2 direction = _moveAction.ReadValue<Vector2>().normalized;
            ship.linearVelocity = direction * engineSpeed;
        }
        else
        {
            ship.linearVelocity = Vector2.zero;
        }
    }
    
}
