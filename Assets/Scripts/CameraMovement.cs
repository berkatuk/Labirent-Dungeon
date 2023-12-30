using System.Collections;
using System.Collections.Generic;
using UnityEngine;




 
public class CameraMovement : MonoBehaviour
{
    private float xRotation = 0f;
   
   
    public Transform player;
    public float mouseSens;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
       
        float mouseX = Input.GetAxis("Mouse X") * mouseSens /* Time.deltaTime*/;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens /* Time.deltaTime*/;


        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        transform.localRotation= Quaternion.Euler(xRotation,-360f,0f);
        player.Rotate(Vector3.up*mouseX);

     
        
    }
}
