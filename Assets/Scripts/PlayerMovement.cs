using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Time;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController playerController;
    
    public float speed;
    private float current_speed = 5;
    public float sprint_speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

      
        if (Input.GetKey(KeyCode.LeftShift))
        {
           
            current_speed = sprint_speed;
           
            
        }
        else 
        {
            
            current_speed = speed;
        }

       
        
        
        


        Vector3 move = transform.right * x + transform.forward * z;
        playerController.Move(move * (current_speed * deltaTime));



   
       
    }
}
