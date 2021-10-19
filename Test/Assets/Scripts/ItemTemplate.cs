using UnityEngine;

public enum ItemTypes
{
    Sword,
    Shield,
    Helmet,
    Boots,
    Ring,
    Staff,
    Bow,
    Spear,
    Potion
}
[CreateAssetMenu(fileName = "New Item Template", menuName = "Inventory/Item")]
public class ItemTemplate : ScriptableObject
{
    public Sprite image;
    [TextArea(15, 20)]
    public string description;
    public int maxStack;
    public ItemTypes itemType;
    public ItemBuffs[] itemBuffs;

}
