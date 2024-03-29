using System. Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChoiceHolderScript : MonoBehaviour
{
    public TextMeshPro n1;
    public TextMeshPro n2;
    public TextMeshPro n3;
    public TextMeshPro n4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetOrder(string[] order)
    {
        // int i = 0;
        //  foreach(GameObject child in transform.GetChild(i)){
        ///  child.GetComponent<TextMeshPro>().SetText(order[i++]);
        //}
        n1.SetText(order[0]);
        n2.SetText(order[1]);
        n3.SetText(order[2]);
        n4.SetText(order[3]);

    }
}
