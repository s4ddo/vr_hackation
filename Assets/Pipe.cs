using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public int item_count = 0;
    public int item_count_max = 1;
    public int water_cost = 20;

    private bool finished;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pipe"))
        {
            item_count += 1;
            CheckFull(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pipe"))
        {
            item_count -= 1;
        }
    }

    void CheckFull(GameObject pipe)
    {
        if (item_count < item_count_max || finished)
        {
            return;
        }
        finished = true;
        pipe.SetActive(false);
        Debug.Log("FILLED");
        GameObject.FindWithTag("Master").GetComponent<Master>().water.ReduceWater(water_cost);
        GameObject.FindWithTag("Master").GetComponent<Master>().current_zone.FinishTask(1);

    }
    // Update is called once per frame
    void Update()
    {

    }
}
