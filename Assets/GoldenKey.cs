using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenKey : Interactive
{
    public KeyItemData silverKey;

    public override void OnInteraction()
    {
        Inventory.Instance.PickupKeyItem(silverKey);
        Debug.Log("Prenez cette clef");
    }




    












}
