using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : InteractableItem
{
    public override bool TryPlaceItem(Item item)
    {
        return true;
    }
}
