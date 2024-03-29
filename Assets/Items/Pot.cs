using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : InteractableItem
{
    public override bool CanPlaceItem(Item item)
    {
        return false;
    }

    public override void PlaceItem(Item item)
    {
        throw new System.NotImplementedException();
    }
}
