using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItems
{
    public enum ItemType
    {
        WateringCan,
        Broom,
        BoxofMushrooms,
        Sunflower,
        Daffodil,
        Mushroom,
        OpenBook
    }

    public ItemType itemType;
    public int amount;
}
