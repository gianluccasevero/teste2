using UnityEngine;
using UnityEngine.UI;
public class InventoryUI : MonoBehaviour
{
    public Transform parent;
    Inventory inventory;
    InventorySlotsUI[] slotsUI;
    void Start()
    {
        slotsUI = parent.GetComponentsInChildren<InventorySlotsUI>();
        for (int i = 0; i < slotsUI.Length; i++)
        {

        }
    }

    void Update()
    {
        
    }
    public void UpdateUI()
    {
    }
}
