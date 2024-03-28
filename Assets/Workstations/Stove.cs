using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : Workstation
{
    
    bool potPlaced = false;

    public override bool TryPlaceItem(Item item)
    {
        if (!potPlaced){
            if (!base.TryPlaceItem(item)) return false;
            if (item is Pot pot)
                potPlaced = true;
                return true;
        } else {
            return true;
        }

    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
