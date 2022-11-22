using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampFire : Interactive
{
    [SerializeField] private Inventory _inventory;
    public KeyItemData litTorch;
    public override void OnInteraction()
    {
        //If I want to do the base OnInteraction anyway first
        //base.OnInteraction();
        //In addition, add LIT_TORCH to found objects
        _inventory.PickupKeyItem(litTorch);
    }
}
