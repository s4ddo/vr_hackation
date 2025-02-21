using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int item_count = 0;
    public int item_count_max = 3;
    public int water_cost = 5;

    private bool finished;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TaskObject"))
        {
            item_count += 1;
            CheckFull();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TaskObject"))
        {
            item_count -= 1;
        }
    }

    void CheckFull()
    {
        if (item_count < item_count_max || finished)
        {
            return;
        }
        finished = true;
        Debug.Log("FILLED");
        GameObject.FindWithTag("Master").GetComponent<Master>().water.ReduceWater(water_cost);
        GameObject.FindWithTag("Master").GetComponent<Master>().current_zone.FinishTask(0);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
