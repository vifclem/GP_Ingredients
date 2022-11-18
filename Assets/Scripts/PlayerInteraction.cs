using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    private PlayerInteractionAnim _anim;

    private void Start()
    {
        _anim = GetComponent<PlayerInteractionAnim>();
    }

    public void Interact(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            _anim.PlayAnimation(KyleAnim.PushButton);
        }
    }
}
