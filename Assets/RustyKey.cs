using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RustyKey : Interactive
{
    public KeyItemData rustyKey;

    public override void OnInteraction()
    {
        Inventory.Instance.PickupKeyItem(rustyKey);
        Debug.Log("Prenez cette clef rouillée");
    }




    












}
