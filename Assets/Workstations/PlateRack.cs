using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateRack : Workstation
{

    [SerializeField] GameObject platePrefab;

    public override bool CanPlaceItem(Item item)
    {
        return false;
    }

    public override bool CanTakeItem()
    {
        return true;
    }

    public override void PlaceItem(Item item)
    {
        throw new System.NotImplementedException();
    }

    public override Item TakeItem()
    {
        return Instantiate(platePrefab).GetComponent<Item>();
    }
}
