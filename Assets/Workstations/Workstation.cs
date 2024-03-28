using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Workstation : MonoBehaviour
{
    [SerializeField] protected Transform attach;
    protected Item placedItem;
    


    public virtual bool TryPlaceItem(Item item){
        if (placedItem != null) {
            if (item is not InteractableItem intItem) return false;
            return intItem.TryPlaceItem(item);
        }
        placedItem = item;
        placedItem.transform.position = attach.position;
        placedItem.transform.rotation = attach.rotation;
        return true;
    }

    public virtual bool TryTakeItem(out Item item){
        item = placedItem;
        if (placedItem == null) return false;
        placedItem = null;
        return true;
    }

    public virtual void Interact() {}
}
