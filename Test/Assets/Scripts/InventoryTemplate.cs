using UnityEngine;

[CreateAssetMenu(fileName ="New Inventory Template",menuName ="Inventory/Inventory")]
public class InventoryTemplate : ScriptableObject
{
    public InventorySlot[] inventorySlot = new InventorySlot[24];
    public InventoryTemplate inventory;
    //public Inventory inventory;
    public void AddItem(ItemTemplate _item, int _amount)
    {
        for (int i = 0; i < inventorySlot.Length; i++)
        {
            //Debug.Log("inside for loop, i = " + i);
            //If Item already existis and the amount on the inventory is less than the max stack of the item
            if (inventorySlot[i].item == _item && inventorySlot[i].amount < inventorySlot[i].item.maxStack)
            {
                //Debug.Log("inside first if");
                inventorySlot[i].AddAmount(_amount);
                //Add Amount to already existing item
                //Destroy GameObject
                return;
            }
            //If there is free slots on the inventory
            if (inventorySlot[i].item == null) //inventorySlot[i].id <= -1)
            {
                //Debug.Log("inside second if");
                inventorySlot[i].AddItem(_item, _amount);
                //AddItem to new Slot
                //Destroy GameObject
                return;
            }
        }
    }
    public void RemoveItem(ItemTemplate _item)
    {
    }
    public void SwapItems(InventorySlot _item1, InventorySlot _item2)
    {
        //Create temp variable to store one of the items
        //Swap Item that wasnt store into the item that has temp variable
        //Put the temp variable into the slot of the swapped item
    }
    public void TakeAll()
    {
        for (int i = 0; i < inventorySlot.Length; i++)
        {
            if (inventorySlot[i].item != null)
            {
                inventory.AddItem(inventorySlot[i].item, inventorySlot[i].amount);
            }
        }
    }
    public void SlotUpdated()
    {
        //var test = ;
    }
}
