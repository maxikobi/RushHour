using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : InteractableItem
{
    [SerializeField] private Transform on;
    private Pasta pasta = null;
    private Veggie v1 = null;
    private Veggie v2 = null;
    private Veggie v3 = null;

    public override bool CanPlaceItem(Item item)
    {
        if (item is Pasta) return CanPlacePasta((Pasta)item);
        if (item is Veggie) return CanPlaceVeggie((Veggie)item);
        return false;
    }
    public bool CanPlacePasta(Pasta pasta)
    {
        if (pasta == null) return true;
        return false;
    }


    public bool CanPlaceVeggie(Veggie veggie)
    {
        if (v1 == null) return true;
        if (v2 == null) return true;
        if (v3 == null) return true;
        return false;
    }

    public override void PlaceItem(Item item)
    {
        if(item is Pasta) PlacePasta((Pasta)item);
        PlaceVeggie((Veggie)item);
    }
    public void PlacePasta(Pasta pasta)
    {
        this.pasta = pasta;
    }

    public void PlaceVeggie(Veggie veggie)
    {
        if (v1 == null) v1 = veggie;
        if (v2 == null) v2 = veggie;
        v3 = veggie;
    }

    public override bool CanTakeItem() // checks if anything on plate so can take anything from plate
    { 
        if (pasta != null) return true;
        if (v1 != null) return true;
        if (v2 != null) return true;
        if (v3  != null) return true;
        return false;
    }

    public override Item TakeItem() // return whatever it finds first, checks in the order: v3 -> v2 -> v1 -> pasta
    { 
        Item result = null;
        if (v3 != null)
        {
            result = v3;
            v3 = null;
            return result;
        }
        if (v2 != null)
        {
            result = v2;
            v2 = null;
            return result;
        }
        if (v1 != null)
        {
            result = v1;
            v1 = null;
            return result;
        }
        result = pasta;
        pasta = null;
        return result;
    }
}
