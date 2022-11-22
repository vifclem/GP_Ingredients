using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<KeyItemData> _foundKeys;
    [SerializeField] private List<KeyItem> usableItems;
    [SerializeField] private Transform hand;

    private int objectInHand = -1;


    public void PickupKeyItem(KeyItemData keyItem)
    {
        // int item = FindItemInList(keyItem.ID);
        // if (item == -1)
        // {
        //     Debug.LogError("Wrong item ID : "+keyItem.ID+" is not an object from the list");
        // }
        // else
        // {
        //     if (objectInHand != -1)
        //     {
        //         usableItems[objectInHand].gameObject.SetActive(false);
        //     }
        //     _foundItems.Add(keyItem);
        //     objectInHand = item;
        //     usableItems[objectInHand].gameObject.SetActive(true);
        // }
        
        if (!_foundKeys.Contains(keyItem))
        {
            KeyItem keyInstance = Instantiate<KeyItem>(keyItem.prefab, hand);
            _foundKeys.Add(keyItem);
            usableItems.Add(keyInstance);
            //Utilise le dernier trouvé
            HoldItem(usableItems.Count-1);
        }
    }

    private int FindItemInList(string id)
    {
        for (int item = 0; item < usableItems.Count; item++)
        {
            if (usableItems[item].GetComponent<KeyItem>().data.ID == id)
            {
                return item;
            }
        }
        
        //Easier method would be
        //return usableItems.FindIndex(item => item.GetComponent<KeyItem>()?.ID == id);

        return -1;
    }

    private void HoldItem(int number)
    {
        if (number < -1 || number >= usableItems.Count)
        {
            //Index out of bounds, nothing can be done
            return;
        }
        if (objectInHand != -1)
        {
            usableItems[objectInHand].gameObject.SetActive(false);
        }

        objectInHand = number;
        usableItems[objectInHand].gameObject.SetActive(true);
    }

    public void NextItem()
    {
        if (usableItems.Count != 0)
        {
            int next = ((objectInHand+1)%usableItems.Count)-1;
            HoldItem(next);
        }
    }

    public bool IsItemFound(KeyItemData key)
    {
        //Empty ID means no necessary key item
        //true if the id is found in the list, false otherwise
        return key==null|| _foundKeys.Contains(key);
    }
}
