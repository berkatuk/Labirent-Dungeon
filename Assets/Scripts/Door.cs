using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    //public Animator door;
    public GameObject door;
    // Update is called once per frame
    void Update()
    {
        if (Lever.leverCount == 0)
        {
            door.SetActive(false);
        }
    }
}
