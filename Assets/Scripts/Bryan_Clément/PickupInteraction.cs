using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupInteraction : Interactive
{
    public KeyItemData itemToPick;
    public override void OnInteraction()
    {
        Inventory.Instance.PickupKeyItem(itemToPick);
        InteractionHelper.Instance.Show(InteractionType.None);
        gameObject.SetActive(false);
        
    }
}
