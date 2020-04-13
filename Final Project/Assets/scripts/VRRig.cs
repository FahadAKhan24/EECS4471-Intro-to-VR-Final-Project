using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRRig : MonoBehaviour
{
    
    public Transform touchL;
    public Transform touchR;

    public GameObject crashForCopy;
    public GameObject lowTomForCopy;
    public GameObject hiTomForCopy;
    public GameObject midTomForCopy;
    public GameObject snareForCopy;
    public GameObject bassForCopy;

    public Material red;
    public Material black;
    public Material blue;

    public Canvas screen_overlay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set position for each controller (explicitly)
        touchL.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        touchR.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        // set rotation for each controller (explicitly)
        touchL.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
        touchR.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);
        
        
        // NEW CRASH ON THE RIGHT SIDE
        Quaternion newrotationCrash = Quaternion.Euler(-30, 0, 30);
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            Instantiate(crashForCopy, new Vector3(1.5f, 2.75f, -3.0f), newrotationCrash);    
        }

        // NEW LOW/FLOOR TOM ON THE RIGHT SIDE
        Quaternion newrotationLowTom = Quaternion.Euler(0, -20, 20);
        GameObject lowTomClone;
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            lowTomClone = Instantiate(lowTomForCopy, new Vector3(2.60f, 1.18f, -2.75f), newrotationLowTom);
            lowTomClone.transform.localScale = new Vector3(1.2f, 0.75f, 1.2f);
        }

        // NEW HI TOM ON THE Left SIDE
        Quaternion newrotationHiTom = Quaternion.Euler(-20, 0, -15);
        GameObject hiTomClone;
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            hiTomClone = Instantiate(hiTomForCopy, new Vector3(-2.0f, 2.5f, -1.8f), newrotationHiTom);
            hiTomClone.transform.localScale = new Vector3(1.1f, 0.35f, 1.1f);
        }

        // enabling/disabling  Canvas
        if (OVRInput.GetDown(OVRInput.RawButton.Y)) 
        {
            screen_overlay.enabled = !screen_overlay.enabled;
        }

        // TURN ON JAZZ
        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
        {
            snareForCopy.GetComponent<Renderer>().material = red;
            lowTomForCopy.GetComponent<Renderer>().material = red;
            hiTomForCopy.GetComponent<Renderer>().material = red;
            midTomForCopy.GetComponent<Renderer>().material = red;
            bassForCopy.GetComponent<Renderer>().material = red;
        }

        // TURN ON ROCK
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            snareForCopy.GetComponent<Renderer>().material = black;
            lowTomForCopy.GetComponent<Renderer>().material = black;
            hiTomForCopy.GetComponent<Renderer>().material = black;
            midTomForCopy.GetComponent<Renderer>().material = black;
            bassForCopy.GetComponent<Renderer>().material = black;
        }

        // TURN ON STANDARD KIT
        if (OVRInput.Get(OVRInput.RawButton.RHandTrigger))
        {
            snareForCopy.GetComponent<Renderer>().material = blue;
            lowTomForCopy.GetComponent<Renderer>().material = blue;
            hiTomForCopy.GetComponent<Renderer>().material = blue;
            midTomForCopy.GetComponent<Renderer>().material = blue;
            bassForCopy.GetComponent<Renderer>().material = blue;
        }

    }
    
}
