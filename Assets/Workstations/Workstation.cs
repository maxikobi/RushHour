using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Workstation : MonoBehaviour
{
    [SerializeField] protected Transform attach;
    protected Item placedItem;
    

#region Placing
    public virtual bool CanPlaceItem(Item item){
    
        if (placedItem == null) return true; 
        if (item is not InteractableItem interactableItem) return false;
        return interactableItem.CanPlaceItem(item);
    }
    

    public virtual void PlaceItem(Item item)
    {
        if (placedItem != null) // = 1, == 2 ???
        {
            item.transform.SetParent(attach, false);
        }
        else
        {
            if (placedItem is InteractableItem interactable)
                interactable.PlaceItem(item);
        }
        placedItem = item;
    }
    

#endregion

#region Taking
    
    public virtual bool CanTakeItem(){
        return placedItem != null;
    }

    public virtual Item TakeItem()
    {
        Item result = placedItem;
        placedItem = null;
        return result;
    }

#endregion

    public virtual void Interact() {}
}
