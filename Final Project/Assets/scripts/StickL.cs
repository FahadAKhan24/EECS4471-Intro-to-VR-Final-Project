using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickL : MonoBehaviour
{
    public AudioSource lowTom;
    public AudioSource midTom;
    public AudioSource hiTom;
    public AudioSource snare;
    public AudioSource rideCymbal;
    public AudioSource crashCymbal;
    public AudioSource hihatCymbal;
    public AudioSource bass;

    public float maxForce = 20;
    public Rigidbody rb; // left drum stick
    
    public GameObject crashForCopy;
    public GameObject lowTomForCopy;
    public GameObject hiTomForCopy;
    public GameObject midTomForCopy;
    public GameObject snareForCopy;
    public GameObject bassForCopy;
    
    public Material red;
    public Material black;
    public Material blue;


    public AudioClip jazzLowTom;
    public AudioClip jazzMidTom;
    public AudioClip jazzHiTom;
    public AudioClip jazzSnare;
    public AudioClip jazzRideCymbal;
    public AudioClip jazzCrashCymbal;
    public AudioClip jazzHihatCymbal;
    public AudioClip jazzBass;

    public AudioClip rockLowTom;
    public AudioClip rockMidTom;
    public AudioClip rockHiTom;
    public AudioClip rockSnare;
    public AudioClip rockRideCymbal;
    public AudioClip rockCrashCymbal;
    public AudioClip rockHihatCymbal;
    public AudioClip rockBass;

    public Canvas screen_overlay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        // PERPENDICULAR RAY CAST FOR VR
        RaycastHit hitDrum;
        //Vector3 rayDir = ;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitDrum, 1))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitDrum.distance, Color.yellow);
            Debug.Log("Did Hit");
            // Debug.Log(hitDrum.collider.tag);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
        */




        /* ADDING FORCE TO THE STICK SO THAT IT HITS A PARTICULAR DRUM with three different speeds AND CREATES A SOUND
         * USED FOR INITIAL TESTING OF RIGIDBODY COLLISION (IN ABSENCE OF TOUCH CONTROLLERS)
         * ALSO USED IN DEMO
         */

        // LOW TOM : 1 slow , 2 : medium , 3 : fast
        Vector3 targetPositionLowTom = new Vector3(1.0f, 1.5f, -2.75f);
        Vector3 rayDirLowTom = targetPositionLowTom - transform.position;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            rb.AddForce(rayDirLowTom * 100, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            rb.AddForce(rayDirLowTom * 300, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            rb.AddForce(rayDirLowTom * 500, ForceMode.Acceleration);
        }

        // CRASH CYMBAL + BASS : 4 slow , 5 : medium , 6 : fast
        Vector3 targetPositionCrashCymbal = new Vector3(-1.5f, 3.5f, -2.5f);
        Vector3 rayDirCrashCymbal = targetPositionCrashCymbal - transform.position;
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            rb.AddForce(rayDirCrashCymbal * 100, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            rb.AddForce(rayDirCrashCymbal * 350, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            rb.AddForce(rayDirCrashCymbal * 600, ForceMode.Acceleration);
        }

        // SNARE : 8 slow , 9 : medium , 10 : fast
        Vector3 targetPositionSnare = new Vector3(-1.0f, 2.0f, -3.1f);
        Vector3 rayDirSnare = targetPositionSnare - transform.position;
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            rb.AddForce(rayDirSnare * 100, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            rb.AddForce(rayDirSnare * 300, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            rb.AddForce(rayDirSnare * 500, ForceMode.Acceleration);
        }

        // RIDE cymbal : Q slow , W : medium , E : fast
        Vector3 targetPositionRideCymbal = new Vector3(1.5f, 3.5f, -2.5f);
        Vector3 rayDirRideCymbal = targetPositionRideCymbal - transform.position;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rb.AddForce(rayDirRideCymbal * 100, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(rayDirRideCymbal * 300, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            rb.AddForce(rayDirRideCymbal * 500, ForceMode.Acceleration);
        }

        // MID TOM : I slow , O : medium , P : fast
        Vector3 targetPositionMidTom = new Vector3(0.65f, 2.5f, -1.8f);
        Vector3 rayDirMidTom = targetPositionMidTom - transform.position;
        if (Input.GetKeyDown(KeyCode.I))
        {
            rb.AddForce(rayDirMidTom * 150, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            rb.AddForce(rayDirMidTom * 300, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            rb.AddForce(rayDirMidTom * 550, ForceMode.Acceleration);
        }

        // HI TOM : A slow , Z : medium , X : fast
        Vector3 targetPositionHiTom = new Vector3(-0.65f, 2.5f, -1.8f);
        Vector3 rayDirHiTom = targetPositionHiTom - transform.position;
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(rayDirHiTom * 200, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.AddForce(rayDirHiTom * 325, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.AddForce(rayDirHiTom * 600, ForceMode.Acceleration);
        }

        // HIHAT : [ slow , ] : medium , \ : fast
        Vector3 targetPositionHihatCymbal = new Vector3(-2.0f, 2.5f, -3.1f);
        Vector3 rayDirHihatCymbal = targetPositionHihatCymbal - transform.position;
        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            rb.AddForce(rayDirHihatCymbal * 170, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            rb.AddForce(rayDirHihatCymbal * 350, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.Backslash))
        {
            rb.AddForce(rayDirHihatCymbal * 600, ForceMode.Acceleration);
        }


        /* Testing/Demo code for adding new crash/lowtom/hitom 
         * and hitting it with the stick by hurling the stick at it
         */
        // NEW CRASH ON THE RIGHT SIDE
        Quaternion newrotationCrash = Quaternion.Euler(-30,0, 30);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Instantiate(crashForCopy, new Vector3(1.5f, 2.75f, -3.0f), newrotationCrash); //Quaternion.identity //new Vector3(-30.0f, -30.0f, 0.0f)
        }

        // NEW CRASH  : hit it with V 
        Vector3 targetPositionNewCrash = new Vector3(1.5f, 2.75f, -3.0f);
        Vector3 rayDirNewCrash = targetPositionNewCrash - transform.position;

        if (Input.GetKeyDown(KeyCode.V))
        {
            rb.AddForce(rayDirNewCrash * 600, ForceMode.Acceleration);
        }

        // NEW LOW/FLOOR TOM ON THE RIGHT SIDE
        Quaternion newrotationLowTom = Quaternion.Euler(0, -20, 20);
        GameObject lowTomClone;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            lowTomClone = Instantiate(lowTomForCopy, new Vector3(2.60f, 1.18f, -2.75f), newrotationLowTom); //Quaternion.identity //new Vector3(-30.0f, -30.0f, 0.0f)
            lowTomClone.transform.localScale = new Vector3(1.2f, 0.75f, 1.2f);
        }

        //NEW LOW/FLOOR TOM  : hit it with K 
        Vector3 targetPositionNewLowTom = new Vector3(2.60f, 1.18f, -2.75f);
        Vector3 rayDirNewLowTom = targetPositionNewLowTom - transform.position;

        if (Input.GetKeyDown(KeyCode.K))
        {
            rb.AddForce(rayDirNewLowTom * 600, ForceMode.Acceleration);
        }

        // NEW HI TOM ON THE Left SIDE
        Quaternion newrotationHiTom = Quaternion.Euler(-20, 0, -15);
        GameObject hiTomClone;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            hiTomClone = Instantiate(hiTomForCopy, new Vector3(-2.0f, 2.5f, -1.8f), newrotationHiTom); //Quaternion.identity //new Vector3(-30.0f, -30.0f, 0.0f)
            hiTomClone.transform.localScale = new Vector3(1.1f, 0.35f, 1.1f);
        }

        //NEW HI TOM  : hit it with G
        Vector3 targetPositionNewHiTom = new Vector3(-2.0f, 2.5f, -1.8f);
        Vector3 rayDirNewHiTom = targetPositionNewHiTom - transform.position;

        if (Input.GetKeyDown(KeyCode.G))
        {
            rb.AddForce(rayDirNewHiTom * 600, ForceMode.Acceleration);
        }

        // CHANGE COLOR OF KIT USING KEYBOARD
        if (Input.GetKeyDown(KeyCode.J))
        {
            snareForCopy.GetComponent<Renderer>().material = red;
            lowTomForCopy.GetComponent<Renderer>().material = red;
            hiTomForCopy.GetComponent<Renderer>().material = red;
            midTomForCopy.GetComponent<Renderer>().material = red;
            bassForCopy.GetComponent<Renderer>().material = red;
        }


        if (Input.GetKeyDown(KeyCode.Tab))
        {
            snareForCopy.GetComponent<Renderer>().material = black;
            lowTomForCopy.GetComponent<Renderer>().material = black;
            hiTomForCopy.GetComponent<Renderer>().material = black;
            midTomForCopy.GetComponent<Renderer>().material = black;
            bassForCopy.GetComponent<Renderer>().material = black;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            snareForCopy.GetComponent<Renderer>().material = blue;
            lowTomForCopy.GetComponent<Renderer>().material = blue;
            hiTomForCopy.GetComponent<Renderer>().material = blue;
            midTomForCopy.GetComponent<Renderer>().material = blue;
            bassForCopy.GetComponent<Renderer>().material = blue;
        }

        // enabling/disabling Canvas using keyboard
        if (Input.GetKeyDown(KeyCode.U)) 
        {
            screen_overlay.enabled = !screen_overlay.enabled;
        }
    }


    void OnCollisionEnter(Collision col)
    {
        float force = col.relativeVelocity.magnitude;
        float volume = 1;

        if (force <= maxForce)
        {
            volume = force / maxForce;
        }

        Debug.Log("Enter called");
        Debug.Log(col.relativeVelocity.magnitude);
        Debug.Log(volume);

        // TOUCH CONTROLLER INPUT
        // STANDARD MODE/KIT   
        if (OVRInput.Get(OVRInput.RawButton.RHandTrigger))
        {

            if (col.gameObject.name == "lowTomCylinder" || col.gameObject.tag == "lowTom")
            {
                //lowTom.Play();
                lowTom.PlayOneShot(lowTom.clip, volume);
                Debug.Log("lowTom hit");
            }
            if (col.gameObject.name == "snareCylinder" || col.gameObject.tag == "snare")
            {
                // snare.Play();
                snare.PlayOneShot(snare.clip, volume);
                Debug.Log("snare hit");
            }
            if (col.gameObject.name == "midTomCylinder" || col.gameObject.tag == "midTom")
            {
                //midTom.Play();
                midTom.PlayOneShot(midTom.clip, volume);
                Debug.Log("midTom hit");
            }
            if (col.gameObject.name == "hiTomCylinder" || col.gameObject.tag == "hiTom")
            {
                // hiTom.Play();
                hiTom.PlayOneShot(hiTom.clip, volume);
                Debug.Log("hiTom hit");
            }
            if (col.gameObject.name == "rideCymbalSphere" || col.gameObject.tag == "ride")
            {
                //rideCymbal.Play();
                rideCymbal.PlayOneShot(rideCymbal.clip, volume);
                Debug.Log("ride hit");
            }
            if (col.gameObject.name == "crashCymbalSphere" || col.gameObject.tag == "crash")
            {
                //crashCymbal.Play();
                //bass.Play();
                crashCymbal.PlayOneShot(crashCymbal.clip, volume);
                bass.PlayOneShot(bass.clip, volume);
                Debug.Log("crash hit");
            }
            if (col.gameObject.name == "hihatCymbalSphere" || col.gameObject.tag == "hihat")
            {
                //hihatCymbal.Play();
                hihatCymbal.PlayOneShot(hihatCymbal.clip, volume);
                Debug.Log("hihat hit");
            }
            if (col.gameObject.name == "bassCylinder" || col.gameObject.tag == "bass")
            {
                // bass.Play();
                bass.PlayOneShot(bass.clip, volume);
                Debug.Log("bass hit");
            }
        }

        // GO INTO JAZZ MODE
        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
        {


            if (col.gameObject.name == "lowTomCylinder" || col.gameObject.tag == "lowTom")
            {
                lowTom.PlayOneShot(jazzLowTom, volume);
                Debug.Log("jazz lowTom hit");
            }

            if (col.gameObject.name == "snareCylinder" || col.gameObject.tag == "snare")
            {
                // snare.Play();
                snare.PlayOneShot(jazzSnare, volume);
                Debug.Log("jazz snare hit");
            }
            if (col.gameObject.name == "midTomCylinder" || col.gameObject.tag == "midTom")
            {
                //midTom.Play();
                midTom.PlayOneShot(jazzMidTom, volume);
                Debug.Log("jazz midTom hit");
            }
            if (col.gameObject.name == "hiTomCylinder" || col.gameObject.tag == "hiTom")
            {
                // hiTom.Play();
                hiTom.PlayOneShot(jazzHiTom, volume);
                Debug.Log("jazz hiTom hit");
            }
            if (col.gameObject.name == "rideCymbalSphere" || col.gameObject.tag == "ride")
            {
                //rideCymbal.Play();
                rideCymbal.PlayOneShot(jazzRideCymbal, volume);
                Debug.Log("jazz ride hit");
            }
            if (col.gameObject.name == "crashCymbalSphere" || col.gameObject.tag == "crash")
            {
                //crashCymbal.Play();
                //bass.Play();
                crashCymbal.PlayOneShot(jazzCrashCymbal, volume);
                bass.PlayOneShot(jazzBass, volume);
                Debug.Log("jazz crash hit");
            }
            if (col.gameObject.name == "hihatCymbalSphere" || col.gameObject.tag == "hihat")
            {
                //hihatCymbal.Play();
                hihatCymbal.PlayOneShot(jazzHihatCymbal, volume);
                Debug.Log("jazz hihat hit");
            }
            if (col.gameObject.name == "bassCylinder" || col.gameObject.tag == "bass")
            {
                // bass.Play();
                bass.PlayOneShot(jazzBass, volume);
                Debug.Log("jazz bass hit");
            }



        }

        // GO INTO ROCK MODE
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {


            if (col.gameObject.name == "lowTomCylinder" || col.gameObject.tag == "lowTom")
            {
                lowTom.PlayOneShot(rockLowTom, volume);
                Debug.Log("rock lowTom hit");
            }

            if (col.gameObject.name == "snareCylinder" || col.gameObject.tag == "snare")
            {
                // snare.Play();
                snare.PlayOneShot(rockSnare, volume);
                Debug.Log("rock snare hit");
            }
            if (col.gameObject.name == "midTomCylinder" || col.gameObject.tag == "midTom")
            {
                //midTom.Play();
                midTom.PlayOneShot(rockMidTom, volume);
                Debug.Log("rock midTom hit");
            }
            if (col.gameObject.name == "hiTomCylinder" || col.gameObject.tag == "hiTom")
            {
                // hiTom.Play();
                hiTom.PlayOneShot(rockHiTom, volume);
                Debug.Log("rock hiTom hit");
            }
            if (col.gameObject.name == "rideCymbalSphere" || col.gameObject.tag == "ride")
            {
                //rideCymbal.Play();
                rideCymbal.PlayOneShot(rockRideCymbal, volume);
                Debug.Log("rock ride hit");
            }
            if (col.gameObject.name == "crashCymbalSphere" || col.gameObject.tag == "crash")
            {
                //crashCymbal.Play();
                //bass.Play();
                crashCymbal.PlayOneShot(rockCrashCymbal, volume);
                bass.PlayOneShot(rockBass, volume);
                Debug.Log("rock crash hit");
            }
            if (col.gameObject.name == "hihatCymbalSphere" || col.gameObject.tag == "hihat")
            {
                //hihatCymbal.Play();
                hihatCymbal.PlayOneShot(rockHihatCymbal, volume);
                Debug.Log("rock hihat hit");
            }
            if (col.gameObject.name == "bassCylinder" || col.gameObject.tag == "bass")
            {
                // bass.Play();
                bass.PlayOneShot(rockBass, volume);
                Debug.Log("rock bass hit");
            }



        }

        /*
        FOR PRESENTATIONAL/TESTING PURPOSES : KEYBOARD INPUT
        */
        // STANDARD MODE/KIT
        if (Input.GetKey(KeyCode.Space))
        {

            if (col.gameObject.name == "lowTomCylinder" || col.gameObject.tag == "lowTom")
            {
                //lowTom.Play();
                lowTom.PlayOneShot(lowTom.clip, volume);
                Debug.Log("lowTom hit");
            }
            if (col.gameObject.name == "snareCylinder" || col.gameObject.tag == "snare")
            {
                // snare.Play();
                snare.PlayOneShot(snare.clip, volume);
                Debug.Log("snare hit");
            }
            if (col.gameObject.name == "midTomCylinder" || col.gameObject.tag == "midTom")
            {
                //midTom.Play();
                midTom.PlayOneShot(midTom.clip, volume);
                Debug.Log("midTom hit");
            }
            if (col.gameObject.name == "hiTomCylinder" || col.gameObject.tag == "hiTom")
            {
                // hiTom.Play();
                hiTom.PlayOneShot(hiTom.clip, volume);
                Debug.Log("hiTom hit");
            }
            if (col.gameObject.name == "rideCymbalSphere" || col.gameObject.tag == "ride")
            {
                //rideCymbal.Play();
                rideCymbal.PlayOneShot(rideCymbal.clip, volume);
                Debug.Log("ride hit");
            }
            if (col.gameObject.name == "crashCymbalSphere" || col.gameObject.tag == "crash")
            {
                //crashCymbal.Play();
                //bass.Play();
                crashCymbal.PlayOneShot(crashCymbal.clip, volume);
                bass.PlayOneShot(bass.clip, volume);
                Debug.Log("crash hit");
            }
            if (col.gameObject.name == "hihatCymbalSphere" || col.gameObject.tag == "hihat")
            {
                //hihatCymbal.Play();
                hihatCymbal.PlayOneShot(hihatCymbal.clip, volume);
                Debug.Log("hihat hit");
            }
            if (col.gameObject.name == "bassCylinder" || col.gameObject.tag == "bass")
            {
                // bass.Play();
                bass.PlayOneShot(bass.clip, volume);
                Debug.Log("bass hit");
            }
        }

        // GO INTO JAZZ MODE
        if (Input.GetKey(KeyCode.J))
        {
            

            if (col.gameObject.name == "lowTomCylinder" || col.gameObject.tag == "lowTom")
            {
                lowTom.PlayOneShot(jazzLowTom, volume);
                Debug.Log("jazz lowTom hit");
            }

            if (col.gameObject.name == "snareCylinder" || col.gameObject.tag == "snare")
            {
                // snare.Play();
                snare.PlayOneShot(jazzSnare, volume);
                Debug.Log("jazz snare hit");
            }
            if (col.gameObject.name == "midTomCylinder" || col.gameObject.tag == "midTom")
            {
                //midTom.Play();
                midTom.PlayOneShot(jazzMidTom, volume);
                Debug.Log("jazz midTom hit");
            }
            if (col.gameObject.name == "hiTomCylinder" || col.gameObject.tag == "hiTom")
            {
                // hiTom.Play();
                hiTom.PlayOneShot(jazzHiTom, volume);
                Debug.Log("jazz hiTom hit");
            }
            if (col.gameObject.name == "rideCymbalSphere" || col.gameObject.tag == "ride")
            {
                //rideCymbal.Play();
                rideCymbal.PlayOneShot(jazzRideCymbal, volume);
                Debug.Log("jazz ride hit");
            }
            if (col.gameObject.name == "crashCymbalSphere" || col.gameObject.tag == "crash")
            {
                //crashCymbal.Play();
                //bass.Play();
                crashCymbal.PlayOneShot(jazzCrashCymbal, volume);
                bass.PlayOneShot(jazzBass, volume);
                Debug.Log("jazz crash hit");
            }
            if (col.gameObject.name == "hihatCymbalSphere" || col.gameObject.tag == "hihat")
            {
                //hihatCymbal.Play();
                hihatCymbal.PlayOneShot(jazzHihatCymbal, volume);
                Debug.Log("jazz hihat hit");
            }
            if (col.gameObject.name == "bassCylinder" || col.gameObject.tag == "bass")
            {
                // bass.Play();
                bass.PlayOneShot(jazzBass, volume);
                Debug.Log("jazz bass hit");
            }
            
            

        }

        // GO INTO ROCK MODE
        if (Input.GetKey(KeyCode.Tab))
        {


            if (col.gameObject.name == "lowTomCylinder" || col.gameObject.tag == "lowTom")
            {
                lowTom.PlayOneShot(rockLowTom, volume);
                Debug.Log("rock lowTom hit");
            }

            if (col.gameObject.name == "snareCylinder" || col.gameObject.tag == "snare")
            {
                // snare.Play();
                snare.PlayOneShot(rockSnare, volume);
                Debug.Log("rock snare hit");
            }
            if (col.gameObject.name == "midTomCylinder" || col.gameObject.tag == "midTom")
            {
                //midTom.Play();
                midTom.PlayOneShot(rockMidTom, volume);
                Debug.Log("rock midTom hit");
            }
            if (col.gameObject.name == "hiTomCylinder" || col.gameObject.tag == "hiTom")
            {
                // hiTom.Play();
                hiTom.PlayOneShot(rockHiTom, volume);
                Debug.Log("rock hiTom hit");
            }
            if (col.gameObject.name == "rideCymbalSphere" || col.gameObject.tag == "ride")
            {
                //rideCymbal.Play();
                rideCymbal.PlayOneShot(rockRideCymbal, volume);
                Debug.Log("rock ride hit");
            }
            if (col.gameObject.name == "crashCymbalSphere" || col.gameObject.tag == "crash")
            {
                //crashCymbal.Play();
                //bass.Play();
                crashCymbal.PlayOneShot(rockCrashCymbal, volume);
                bass.PlayOneShot(rockBass, volume);
                Debug.Log("rock crash hit");
            }
            if (col.gameObject.name == "hihatCymbalSphere" || col.gameObject.tag == "hihat")
            {
                //hihatCymbal.Play();
                hihatCymbal.PlayOneShot(rockHihatCymbal, volume);
                Debug.Log("rock hihat hit");
            }
            if (col.gameObject.name == "bassCylinder" || col.gameObject.tag == "bass")
            {
                // bass.Play();
                bass.PlayOneShot(rockBass, volume);
                Debug.Log("rock bass hit");
            }

        }
        
    }
}