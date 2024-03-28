using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableItem : Item
{
    public abstract bool TryPlaceItem(Item item);
}
