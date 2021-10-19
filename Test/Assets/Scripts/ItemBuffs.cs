using UnityEngine;

public enum Attributes
{
    Strenght,
    Agility,
    Intellect,
    Stamina,
}
public class ItemBuffs : MonoBehaviour
{
    public Attributes[] attributes;
    public int value;
    public int maxValue;
    public int minValue;


    public void GenerateValue()
    {
        //Generate Random value between min and max and assign to value
    }
}
