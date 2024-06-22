using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class buttonvr : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress,onRelease;
    GameObject presser;
    AudioSource sound;
    bool ispressed;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        ispressed = false;
        
    }
    private void onTriggerEnter(Collider other)
    {
        if (!ispressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            ispressed = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            ispressed = false;
        }
    }
    public void Spawnsphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sphere.transform.localPosition = new Vector3(0, 1, 2);
        sphere.AddComponent<Rigidbody>();
    }
}
