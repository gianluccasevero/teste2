using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
public class InventorySlotsUI : MonoBehaviour
{
    ItemTemplate item;
    public TMP_Text amount;
    public GameObject prefabItem;
    //public Canvas canvas;
    public GameObject panel;
    private GameObject gameObj;
    public int index;
    public void AddItem(ItemTemplate newItem, int _amount, Vector3 position)
    {
        gameObj = Instantiate(prefabItem, position, Quaternion.identity, panel.transform);
        var image = gameObj.GetComponent<Image>();
        item = newItem;
        image.sprite = item.image;
        image.enabled = true;
        amount.SetText(_amount.ToString());
    }
    public void ClearItem() 
    {
        //icon.enabled = false;
        //amount.SetText("");
    }
}
