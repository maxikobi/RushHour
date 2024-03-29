using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : InteractableItem
{
    [SerializeField] private Transform inside;
    private Item itemOn = null;
    
    public override bool CanPlaceItem(Item item)
    {

        return true;
    }

    public override bool CanTakeItem()
    {
        throw new System.NotImplementedException();
    }

    public override void PlaceItem(Item item)
    {
        throw new System.NotImplementedException();
    }

    public override bool CanTakeItem()
    {
        throw new System.NotImplementedException();
    }

    public override Item TakeItem()
    {
        throw new System.NotImplementedException();
    }
}
