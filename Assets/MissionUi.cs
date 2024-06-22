using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionUi : MonoBehaviour
{

    public GameObject ui;
    public Material skybox;
    public Zone zone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() == null)
        {
            return;
        }


        if (ui != null) { ui.SetActive(true); }

        if (zone != null)
        {
            GameObject.FindWithTag("Master").GetComponent<Master>().current_zone = zone;

            if (!(zone.endings_done >= zone.endings.Count))
            {
                RenderSettings.skybox = skybox;
            }
            else
            {
                RenderSettings.skybox = zone.ending_skybox;
            }
        }
        else
        {
            RenderSettings.skybox = skybox;
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() == null)
        {
            return;
        }

        if (ui != null)
        {
            ui.SetActive(false);
        }
        ui.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
