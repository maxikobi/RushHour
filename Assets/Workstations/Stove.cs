using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : Workstation
{

    bool cooking = false;
    float timeCooking = 0;

    public override void PlaceItem(Item item)
    {
        if (placedItem != null && placedItem is Pot)
            cooking = true;
    }

    public override Item TakeItem()
    {
        if (cooking){
            cooking = false;
            timeCooking = 0;
        }
        return base.TakeItem();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
