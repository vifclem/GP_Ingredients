using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KyleInteraction : MonoBehaviour
{
    private KyleInteractionAnimations _animations;

    private void Start()
    {
        _animations = GetComponent<KyleInteractionAnimations>();
    }

    public void Interact(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            _animations.PlayAnimation(KyleAnim.PushButton);
        }
    }
}
