using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasta : Ingredient
{
    [SerializeField] float cooked = 5;
    [SerializeField] float burnt = 7;

    [SerializeField] Material CookedPasta;
    [SerializeField] Material BurntPasta;

    private float cookingTime = 0;
    private bool cooking = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cooking)
        {
            cookingTime += Time.deltaTime;
            if (cookingTime >= cooked && cookingTime < burnt)
            {
                GetComponent<Renderer>().material = CookedPasta;
            }
            else if (cookingTime >= burnt)
            {
                GetComponent<Renderer>().material = BurntPasta;
            }
        }
    }

    public void startCooking()
    {
        cooking = true;
    }

    public void stopCooking()
    {
        cooking = false;
    }
}
