using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    TextMeshPro textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();
        textMeshPro.SetText("aaaa");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
