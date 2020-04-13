using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
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
    public Rigidbody rb;    // right drum stick
    //public float speed;

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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        // PERPENDICULAR RAY CAST From Stick FOR VR
        RaycastHit hitDrum;
        //Vector3 rayDir = ;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitDrum, 1))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitDrum.distance, Color.yellow);
            Debug.Log("Did Hit");
            Debug.Log(hitDrum.collider.tag);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
        */


        // RAY CASTING to test/demo sound feature of the standard 5 piece kit using keyboard
        // LOW TOM RAY CAST
        RaycastHit hitLowTom;
        Vector3 targetPositionLowTom = new Vector3(1.0f, 1.5f, -2.75f);
        Vector3 rayDirLowTom = targetPositionLowTom - transform.position;
        bool flagLowTom = true;

        if (Input.GetKeyDown(KeyCode.L))
        { 
            if (flagLowTom)
            {
                if (Physics.Raycast(transform.position, rayDirLowTom, out hitLowTom, 2))
                {
                    Debug.DrawRay(transform.position, rayDirLowTom * hitLowTom.distance, Color.yellow);
                   // Debug.Log("Did Hit");
                    Debug.Log(hitLowTom.collider.tag);
                    if (hitLowTom.collider.tag == "lowTom")
                    {
                        lowTom.Play();
                        //lowTom.PlayOneShot(lowTom.clip, volume);
                       // Debug.Log("lowTom hit");
                        flagLowTom = false;
                    }
                }
            }
        }

        // RIDE CYMBAL RAY CAST
        RaycastHit hitRideCymbal;
        Vector3 targetPositionRideCymbal = new Vector3(1.5f, 3.5f, -2.5f);
        Vector3 rayDirRideCymbal = targetPositionRideCymbal - transform.position;
        bool flagRideCymbal = true;

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (flagRideCymbal)
            {
                if (Physics.Raycast(transform.position, rayDirRideCymbal, out hitRideCymbal, 2))
                {
                    Debug.DrawRay(transform.position, rayDirRideCymbal * hitRideCymbal.distance, Color.yellow);
                    //Debug.Log("Did Hit");
                    Debug.Log(hitRideCymbal.collider.tag);
                    if (hitRideCymbal.collider.tag == "ride")
                    {
                        rideCymbal.Play();
                        //lowTom.PlayOneShot(lowTom.clip, volume);
                      //  Debug.Log("ride hit");
                        flagRideCymbal = false;
                    }
                    
                }
            }
        }

        // MID TOM RAY CAST
        RaycastHit hitMidTom;
        Vector3 targetPositionMidTom = new Vector3(0.65f, 2.5f, -1.8f);
        Vector3 rayDirMidTom = targetPositionMidTom - transform.position;
        bool flagMidTom = true;

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (flagMidTom)
            {
                if (Physics.Raycast(transform.position, rayDirMidTom, out hitMidTom, 2))
                {
                    Debug.DrawRay(transform.position, rayDirMidTom * hitMidTom.distance, Color.yellow);
                    //Debug.Log("Did Hit");
                    Debug.Log(hitMidTom.collider.tag);
                    if (hitMidTom.collider.tag == "midTom")
                    {
                        midTom.Play();
                        //lowTom.PlayOneShot(lowTom.clip, volume);
                      //  Debug.Log("MidTom hit");
                        flagMidTom = false;
                    }
                    
                }
            }
        }

        // Hi TOM RAY CAST
        RaycastHit hitHiTom;
        Vector3 targetPositionHiTom = new Vector3(-0.65f, 2.5f, -1.8f);
        Vector3 rayDirHiTom = targetPositionHiTom - transform.position;
        bool flagHiTom = true;

        if (Input.GetKeyDown(KeyCode.H))
        {
            if (flagHiTom)
            {
                if (Physics.Raycast(transform.position, rayDirHiTom, out hitHiTom, 2))
                {
                    Debug.DrawRay(transform.position, rayDirHiTom * hitHiTom.distance, Color.yellow);
                   // Debug.Log("Did Hit");
                    Debug.Log(hitHiTom.collider.tag);
                    if (hitHiTom.collider.tag == "hiTom")
                    {
                        hiTom.Play();
                        //lowTom.PlayOneShot(lowTom.clip, volume);
                      //  Debug.Log("hiTom hit");
                        flagHiTom = false;
                    }
                   
                }
            }
        }

        // SNARE RAY CAST
        RaycastHit hitSnare;
        Vector3 targetPositionSnare = new Vector3(-1.0f, 2.0f, -3.1f);
        Vector3 rayDirSnare = targetPositionSnare - transform.position;
        bool flagSnare = true;

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (flagSnare)
            {
                if (Physics.Raycast(transform.position, rayDirSnare, out hitSnare, 2))
                {
                    Debug.DrawRay(transform.position, rayDirSnare * hitSnare.distance, Color.yellow);
                  //  Debug.Log("Did Hit");
                    Debug.Log(hitSnare.collider.tag);
                    if (hitSnare.collider.tag == "snare")
                    {
                        snare.Play();
                        //lowTom.PlayOneShot(lowTom.clip, volume);
                      //  Debug.Log("Snare hit");
                        flagSnare = false;
                    }
                   
                }
            }
        }

        // CRASH CYMBAL RAY CAST
        RaycastHit hitCrashCymbal;
        Vector3 targetPositionCrashCymbal = new Vector3(-1.5f, 3.5f, -2.5f);
        Vector3 rayDirCrashCymbal = targetPositionCrashCymbal - transform.position;
        bool flagCrashCymbal = true;

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (flagCrashCymbal)
            {
                if (Physics.Raycast(transform.position, rayDirCrashCymbal, out hitCrashCymbal, 2))
                {
                    Debug.DrawRay(transform.position, rayDirCrashCymbal * hitCrashCymbal.distance, Color.yellow);
                   // Debug.Log("Did Hit");
                    Debug.Log(hitCrashCymbal.collider.tag);
                    if (hitCrashCymbal.collider.tag == "crash")
                    {
                        crashCymbal.Play();
                        bass.Play();
                        //lowTom.PlayOneShot(lowTom.clip, volume);
                       // Debug.Log("crash  hit");
                        flagCrashCymbal = false;
                    }
                }
            }
        }

        // HI HAT CYMBAL RAY CAST
        RaycastHit hitHihatCymbal;
        Vector3 targetPositionHihatCymbal = new Vector3(-2.0f, 2.5f, -3.1f);
        Vector3 rayDirHihatCymbal = targetPositionHihatCymbal - transform.position;
        bool flagHihatCymbal = true;

        if (Input.GetKeyDown(KeyCode.T))  // hihat is T press
        {
            if (flagHihatCymbal)
            {
                if (Physics.Raycast(transform.position, rayDirHihatCymbal, out hitHihatCymbal, 3))
                {
                    Debug.DrawRay(transform.position, rayDirHihatCymbal * hitHihatCymbal.distance, Color.yellow);
                   // Debug.Log("Did Hit");
                    Debug.Log(hitHihatCymbal.collider.tag);
                    if (hitHihatCymbal.collider.tag == "hihat")
                    {
                        hihatCymbal.Play();
                        //lowTom.PlayOneShot(lowTom.clip, volume);
                        //Debug.Log("HihatCymbal  hit");
                        flagHihatCymbal = false;
                    }
                    
                }
            }
        }

        // BASS RAY CAST
        RaycastHit hitBass;
        Vector3 targetPositionBass = new Vector3(0.0f, 1.0f, -1.5f);
        Vector3 rayDirBass = targetPositionBass - transform.position;
        bool flagBass = true;

        if (Input.GetKeyDown(KeyCode.B))  
        {
            if (flagBass)
            {
                if (Physics.Raycast(transform.position, rayDirBass, out hitBass, 3))
                {
                    Debug.DrawRay(transform.position, rayDirBass * hitBass.distance, Color.yellow);
                   // Debug.Log("Did Hit");
                    Debug.Log(hitBass.collider.tag);
                    if (hitBass.collider.tag == "bass")
                    {
                        bass.Play();
                        //lowTom.PlayOneShot(lowTom.clip, volume);
                       // Debug.Log("Bass  hit");
                        flagBass = false;
                    }
                    
                }
            }
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
        
        
    }

}
