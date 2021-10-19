using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventorySlot
{
    public ItemTemplate item;
    public int amount;
    public bool isValid = false;
    public InventorySlot() 
    {
        amount = 0;
        isValid = false;
    }
    public void UpdateSlot(ItemTemplate _item, int _amount) 
    {
        //item = _item;
        //amount = _amount;
    }
    public void RemoveItem()
    {

    }
    public void AddItem(ItemTemplate _item, int _amount)
    {
        item = _item;
        amount = _amount;
        isValid = true;
    }
    public void AddAmount(int _amount) 
    {
        amount += _amount;
    }
}
