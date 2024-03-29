using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : Workstation
{
    public override void PlaceItem(Item item)
    {
        base.PlaceItem(item);
        if (placedItem is Pot pot)
        {
            pot.onStove = true;
            pot.checkCook();
        }
            
    }

    public override Item TakeItem()
    {
        return base.TakeItem();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
