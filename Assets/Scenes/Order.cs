using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;


public class Order : MonoBehaviour
{

    [SerializeField]
    private int DishNum {  get; set; }
    [SerializeField]
    private string MainDish {  get; set; }
    [SerializeField]
    private string Sauce {  get; set; }
    [SerializeField]
    private string drink {  get; set; }
    [SerializeField]
    private int salad { get; set; }

    public GameObject choiceHolder;

    // Start is called before the first frame update
    void Start()
    {
        string[] order = new string[4];
        for(int i = 0; i < order.Length; i++)
        {
            int num = Random.Range(1, 4);
            
            if (i == 0)
            {
                if (num % 2 == 0) order[i] = "Pasta";
                else order[i] = "Rice";
            }
            if (i == 1)
            {
                if (num == 1) order[i] = "Tomato";
                if(num == 2) order[i] = "Alfredo";
                if (num == 3) order[i] = "Pesto";
            }
            if (i == 2) { order[i] = "Drink"; }
            if (i == 3)
            {
                if (num == 1) order[i] = "Tomato";
                if (num == 2) order[i] = "Lettuce";
                if (num == 3) order[i] = "Cucumber";
            }
        }
        choiceHolder.GetComponent<ChoiceHolderScript>().SetOrder(order);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
