using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lever : MonoBehaviour
{
    
    public Animator lvr;
    public Transform cam;
    public float activeDistance;
    private bool active;
    private Ray ray;
    private RaycastHit hit;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(cam.transform.position, cam.transform.forward);
        if (Physics.Raycast(ray, out  hit,activeDistance))
        {
            if (hit.collider.gameObject.CompareTag("Lever")&& Input.GetKeyDown(KeyCode.E))
            {
                lvr.SetBool("LeverCheck",true);
            }
        }
    }

    
}
