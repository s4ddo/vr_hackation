using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Water : MonoBehaviour
{
    // Start is called before the first frame update
    public int water_level = 100;
    [SerializeField] TextMeshProUGUI text;
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

        if (water_level < 0)
        {
            water_level = 0;
        }
        text.text = $"{water_level}%";
        transform.localScale = new Vector3(transform.localScale.x, height * water_level/100 ,transform.localScale.z);
    }

    public void AddWater(int amount)
    {
        water_level += amount;

        if (water_level > 100)
        {
            water_level = 100;
            return;
        }
        text.text = $"{water_level}%";
        transform.localScale = new Vector3(transform.localScale.x, height * water_level / 100, transform.localScale.z);
    }

}
