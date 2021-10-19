using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryTemplate inventory;


    public void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Item");
        inventory.AddItem(other.GetComponent<Item>().item, 1);
        //Destroy(other.gameObject);
    }
}
