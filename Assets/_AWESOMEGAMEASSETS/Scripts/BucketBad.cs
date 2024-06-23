using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketBad : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject good_item;
    public int item_count = 0;
    public int item_count_max = 3;
    public int water_cost = 5;
    
    private bool finished;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BadObject"))
        {
            Debug.Log("BADDIE");
            other.gameObject.SetActive(false);
            BadFull();
        }

        if (other.CompareTag("TaskObject"))
        {
            item_count += 1;
            CheckFull();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("BadObject"))
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
        GameObject.FindWithTag("Master").GetComponent<Master>().current_zone.DisableTask(1);
        GameObject.FindWithTag("Master").GetComponent<Master>().current_zone.FinishTask(2);
        GameObject.FindWithTag("Master").GetComponent<Master>().current_zone.FinishTask(0);


    }

    void BadFull()
    {
        Debug.Log("BADDIED");
        GameObject.FindWithTag("Master").GetComponent<Master>().water.ReduceWater(water_cost);
        GameObject.FindWithTag("Master").GetComponent<Master>().current_zone.DisableTask(0);
        GameObject.FindWithTag("Master").GetComponent<Master>().current_zone.FinishTask(1);
        good_item.SetActive(true);
    }
}
