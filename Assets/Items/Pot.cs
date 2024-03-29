using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : InteractableItem
{
    [SerializeField] private Transform inside;
    private Pasta pastaInside = null;
    public bool onStove = true;
   
    public bool GetHasPasta() {  return pastaInside != null; }

    public override bool CanPlaceItem(Item item)
    {
        if (item is Pasta && GetHasPasta() == false) return true;
        return false;
    }

    public override void PlaceItem(Item item)
    {
        pastaInside = item as Pasta;
        item.transform.SetParent(inside, false);
        checkCook();
    }

    public override bool CanTakeItem()
    {
        return pastaInside != null;
    }

    public override Item TakeItem()
    {
        pastaInside.stopCooking();
        Item result = pastaInside;
        pastaInside = null;
        return result;
    }

    public void checkCook()
    {
        if (pastaInside != null && onStove)
        {
            pastaInside.startCooking();
            return;
        }
        pastaInside.stopCooking();
    }
}
