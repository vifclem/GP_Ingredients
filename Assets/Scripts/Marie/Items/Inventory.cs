using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<string> _foundItems = new List<string>();
    [SerializeField] private List<KeyItem> usableItems;
    [SerializeField] private GameObject holdingHand;

    private int objectInHand = -1;


    public void PickupKeyItem(string id)
    {
        int item = FindItemInList(id);
        if (item == -1)
        {
            Debug.LogError("Wrong item ID : "+id+" is not an object from the list");
        }
        else
        {
            if (objectInHand != -1)
            {
                usableItems[objectInHand].gameObject.SetActive(false);
            }
            _foundItems.Add(id);
            objectInHand = item;
            usableItems[objectInHand].gameObject.SetActive(true);
        }
    }

    private int FindItemInList(string id)
    {
        for (int item = 0; item < usableItems.Count; item++)
        {
            if (usableItems[item].GetComponent<KeyItem>().ID == id)
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
        if (_foundItems.Count != 0)
        {
            int next = (objectInHand+1)-1;
            
        }
    }

    public bool IsItemFound(string id)
    {
        //Empty ID means no necessary key item
        //true if the string is found in the list, false otherwise
        return id=="" || _foundItems.Contains(id);
    }
}
