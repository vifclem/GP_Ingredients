using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KyleController : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5, _rotationSpeed = 100;
    private Vector2 _movement = Vector2.zero;
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        transform.position += transform.forward * (_movement.y * _movementSpeed * Time.deltaTime);
        transform.Rotate(0, _movement.x * Time.deltaTime * _rotationSpeed, 0);
    }

    //Values are already normalized through the new Input System
    public void Move(InputAction.CallbackContext ctx)
    {
        _movement = ctx.ReadValue<Vector2>();
        _animator.SetFloat("Speed", _movement.sqrMagnitude == 0 ? 0 : 2);
    }
}
