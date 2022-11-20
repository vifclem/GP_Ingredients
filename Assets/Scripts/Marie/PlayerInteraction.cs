using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    public InteractionHelper ui;
    private PlayerInteractionAnim _anim;
    private InteractionType _possibleInteraction = InteractionType.None;

    private void Start()
    {
        _anim = GetComponent<PlayerInteractionAnim>();
    }

    public void SetInteraction(InteractionType interaction)
    {
        _possibleInteraction = interaction;
        ui.Show(interaction!=InteractionType.None);
    }

    public void Interact(InputAction.CallbackContext ctx)
    {
        if (_possibleInteraction != InteractionType.None && ctx.started)
        {
            _anim.PlayAnimation(_possibleInteraction);
        }
    }
}
