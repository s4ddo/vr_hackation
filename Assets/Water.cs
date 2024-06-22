using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    // Start is called before the first frame update
    public int water_level = 100;
    private float height;
    void Start()
    {
        height = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReduceWater(int amount)
    {
        water_level -= amount;
        transform.localScale = new Vector3(transform.localScale.x, height * water_level/100 ,transform.localScale.z);
    }
    
}
