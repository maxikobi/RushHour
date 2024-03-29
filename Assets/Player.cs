using Unity.Netcode;
using UnityEngine;

public class Chef : NetworkBehaviour
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
        if (!IsOwner) return;

        MovePlayer();

        Interactions();
    }

    private void Interactions()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (TryGetWorkstation(out var workstation))
                workstation.Interact();
        }

        if (Input.GetMouseButtonDown(1))
            TakeOrPlace();
    }

    private void TakeOrPlace()
    {
        if (!TryGetWorkstation(out var workstation)) return;

        if (heldItem == null)
        {
            if (workstation.CanTakeItem())
            {
                heldItem = workstation.TakeItem();
                heldItem.transform.SetParent(handAttach, false);
            }
            else
            {
                if (workstation.CanPlaceItem(heldItem))
                {
                    workstation.PlaceItem(heldItem);
                    heldItem = null;
                }
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
