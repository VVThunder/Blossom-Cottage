using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStore : MonoBehaviour
{
    //What do I put in here to store the items?

    private List<InteractableItems> itemList;

    public ItemStore()
    {
        itemList = new List<InteractableItems>();

        AddItem(new InteractableItems { itemType = InteractableItems.ItemType.WateringCan, amount = 1 });
        Debug.Log(itemList.Count);

        //Debug.Log("Inventory");
    }

    public void AddItem(InteractableItems item)
    {
        itemList.Add(item);
    }

}
