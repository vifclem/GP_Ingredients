using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverKey : Interactive
{
    public KeyItemData silverKey;



    public override void OnInteraction()
    {
        Inventory.Instance.PickupKeyItem(silverKey);
        Debug.Log("Prenez cette clef rouillée");
    }
}


