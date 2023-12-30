using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lever : MonoBehaviour
{
    
    public Animator lvr;
    public static int leverCount;

    private void Start()
    {
        leverCount++;
    }
}
