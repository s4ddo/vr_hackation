using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{

    // Start is called before the first frame update
    public int water_level;
    public 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReduceWater(int amount)
    {
        water_level -= amount;
    }
}
