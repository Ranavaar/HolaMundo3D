using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //Public Attributes
    public string itemName;
    public int price;

    //Private Attributes
    private int _count;
    
    //Public Methods
    public void Use()
    {
        print("You used " + itemName);
    }
    //Private Methods
}
