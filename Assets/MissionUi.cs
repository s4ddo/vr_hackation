using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionUi : MonoBehaviour
{

    public GameObject ui;
    public Material skybox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ui.SetActive(true);
        RenderSettings.skybox = skybox;
    }
    private void OnTriggerExit(Collider other)
    {
        ui.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
