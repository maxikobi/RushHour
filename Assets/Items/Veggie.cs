using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veggie : Ingredient
{
    public enum VeggieType
    {
        Tomato,
        Lettuce,
        Cucumber
    }

    private VeggieType Type;
    private bool Sliced = false;

    public VeggieType GetVeggieType() {  return Type; }
    public bool IsSliced() {  return Sliced; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Slicing()
    {
        Sliced = true;
    }
}
