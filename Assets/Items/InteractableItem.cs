using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableItem : Item
{
    public abstract bool CanPlaceItem(Item item);
    public abstract void PlaceItem(Item item);
    public abstract bool CanTakeItem();
    public abstract Item TakeItem();
}
