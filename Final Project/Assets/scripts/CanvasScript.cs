using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    
    public GameObject crashForCopy;
    public GameObject lowTomForCopy;
    public GameObject hiTomForCopy;
    public GameObject midTomForCopy;
    public GameObject snareForCopy;
    public GameObject bassForCopy;

    public Material red;
    public Material black;
    public Material blue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    // BUTTON FUNCTIONS
    public void Button_add_hiTom_On_Click()
    {
        // NEW HI TOM ON THE Left SIDE
        Quaternion newrotationHiTom = Quaternion.Euler(-20, 0, -15);
        GameObject hiTomClone;
        hiTomClone = Instantiate(hiTomForCopy, new Vector3(-2.0f, 2.5f, -1.8f), newrotationHiTom); 
        hiTomClone.transform.localScale = new Vector3(1.1f, 0.35f, 1.1f);
    }

    public void Button_add_floorTom_On_Click()
    {
        // NEW LOW/FLOOR TOM ON THE RIGHT SIDE
        Quaternion newrotationLowTom = Quaternion.Euler(0, -20, 20);
        GameObject lowTomClone;
        lowTomClone = Instantiate(lowTomForCopy, new Vector3(2.60f, 1.18f, -2.75f), newrotationLowTom); 
        lowTomClone.transform.localScale = new Vector3(1.2f, 0.75f, 1.2f);
    }

    public void Button_add_crashCymbal_On_Click()
    {
        // NEW CRASH ON THE RIGHT SIDE
        Quaternion newrotationCrash = Quaternion.Euler(-30, 0, 30);
        Instantiate(crashForCopy, new Vector3(1.5f, 2.75f, -3.0f), newrotationCrash);
    }

    // TOGGLE FUNCTIONS

    public void Standard_Toggled(bool newValue)
    {
        if (newValue == true)
        {
            snareForCopy.GetComponent<Renderer>().material = blue;
            lowTomForCopy.GetComponent<Renderer>().material = blue;
            hiTomForCopy.GetComponent<Renderer>().material = blue;
            midTomForCopy.GetComponent<Renderer>().material = blue;
            bassForCopy.GetComponent<Renderer>().material = blue;
        }
    }

    public void Jazz_Toggled(bool newValue)
    {
        if (newValue == true)
        {
            snareForCopy.GetComponent<Renderer>().material = red;
            lowTomForCopy.GetComponent<Renderer>().material = red;
            hiTomForCopy.GetComponent<Renderer>().material = red;
            midTomForCopy.GetComponent<Renderer>().material = red;
            bassForCopy.GetComponent<Renderer>().material = red;
        }
    }

    public void Rock_Toggled(bool newValue)
    {
        if (newValue == true)
        {
            snareForCopy.GetComponent<Renderer>().material = black;
            lowTomForCopy.GetComponent<Renderer>().material = black;
            hiTomForCopy.GetComponent<Renderer>().material = black;
            midTomForCopy.GetComponent<Renderer>().material = black;
            bassForCopy.GetComponent<Renderer>().material = black;
        }
    }
    
}
