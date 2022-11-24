using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : Interactive
{
    public Animator anim;

    public override void OnInteraction()
    {
       Inventory.Instance.RemoveFromInventory(requiredItem);

        anim.enabled = true;
    }
}
