using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.UIElements;

public class Chef : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] float distance = 0.5f;
    [SerializeField] Transform handAttach;
    Item heldItem = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
        if (Input.GetMouseButtonDown(0))
        {
            if (!TryGetWorkstation(out var workstation)) return;

            workstation.Interact();
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (!TryGetWorkstation(out var workstation)) return;

            if (heldItem == null)
                if (workstation.TryTakeItem(out Item item))
                {
                    heldItem = item;
                    item.transform.SetParent(handAttach, false);
                }
                else
                {
                    if (workstation.TryPlaceItem(heldItem))
                        heldItem = null;
                }
        } 
    }

    private void MovePlayer()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            moveDirection += Vector3.forward;

        if (Input.GetKey(KeyCode.A))
            moveDirection += Vector3.left;

        if (Input.GetKey(KeyCode.S))
            moveDirection += Vector3.back;

        if (Input.GetKey(KeyCode.D))
            moveDirection += Vector3.right;

        if (moveDirection == Vector3.zero)
            return;

        moveDirection.Normalize();

        transform.rotation = Quaternion.LookRotation(moveDirection);
        transform.position += moveDirection * speed * Time.deltaTime;
    }

    private bool TryGetWorkstation(out Workstation workstation)
    {
        workstation = null;

        Ray ray = new Ray(transform.position, transform.forward);
        if (!Physics.Raycast(ray, out RaycastHit hitInfo, distance))
            return false;

        GameObject hit = hitInfo.collider.gameObject;
        return hit.TryGetComponent(out workstation);
        
    }

}
