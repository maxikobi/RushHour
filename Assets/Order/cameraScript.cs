using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public Transform order;
    private Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        transform.position = order.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
