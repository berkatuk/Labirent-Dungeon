using System;
using TMPro;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Transform cam;
    public float activeDistance;
    private RaycastHit hit;
    public GameObject txt;
    


    private void Start()
    {
        
    }

    private void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);

        Debug.DrawRay(ray.origin, ray.direction * activeDistance, Color.green);
        
        
        if (Physics.Raycast(ray, out hit, activeDistance))
        {
            Debug.Log(hit.collider.gameObject.tag);
            if (hit.collider.gameObject.CompareTag("Lever"))
            {
                txt.SetActive(true);
                
            }
            else
            {
                txt.SetActive(false);
            }
            if (hit.collider.gameObject.CompareTag("Lever") && Input.GetKeyDown(KeyCode.E))
            {
                txt.SetActive(false);
                hit.transform.gameObject.GetComponent<Lever>().lvr.SetBool("LeverCheck", true);
                Lever.leverCount--;
                Debug.Log(Lever.leverCount);
            }
         
        }
        
        
        
        
        
    }
}