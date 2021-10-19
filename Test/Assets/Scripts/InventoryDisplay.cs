using UnityEngine;
using System.Collections;
public class InventoryDisplay : MonoBehaviour
{
    public Transform parent;
    public InventoryTemplate inventory;
    public InventorySlotsUI[] slotsUI;
    void Start()
    {
        slotsUI = parent.GetComponentsInChildren<InventorySlotsUI>();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UpdateUI();

        }
    }

    public void UpdateUI() 
    {
        for (int i = 0; i < slotsUI.Length; i++)
        {
            if (inventory.inventorySlot[i].item != null) 
            {
                slotsUI[i].AddItem(inventory.inventorySlot[i].item, inventory.inventorySlot[i].amount, slotsUI[i].transform.position);
            }
            else
            {
                slotsUI[i].ClearItem();
            }
        }
    }
}
