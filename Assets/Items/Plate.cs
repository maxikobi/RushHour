using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : InteractableItem
{
    public override bool CanPlaceItem(Item item)
    {
        return true;
    }

    public override void PlaceItem(Item item)
    {
        throw new System.NotImplementedException();
    }
}
