using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Zone : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> endings;
    public TextMeshProUGUI yield;
    public Material ending_skybox;
    public int endings_done;
    void Start()
    {
        
    }

    public void FinishTask(int ending)
    {
        if(ending >= endings.Count)
        {
            return;
        }

        endings[ending].SetActive(true);
        endings_done += 1;

        if (endings_done >= endings.Count)
        {
            RenderSettings.skybox = ending_skybox;
            yield.text = "95% Yield";
            yield.color = Color.green;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
