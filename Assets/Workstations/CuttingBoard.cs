using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingBoard : Workstation
{
    public override void PlaceItem(Item item)
    {
        base.PlaceItem(item);
    }

    public override Item TakeItem()
    {
        return base.TakeItem();
    }

    public override void Interact()
    {
        if (placedItem != null && placedItem is Veggie veggie)
            veggie.Slicing();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
