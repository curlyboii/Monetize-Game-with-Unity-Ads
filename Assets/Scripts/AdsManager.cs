using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{

    public static AdsManager instance; //By creating a public static variable, you can reference it from anywhere in your code
                                       //without needing to pass a reference to an instance of the AdsManager class.
                                       //This can be useful for things like accessing a single instance of a manager or controller object
                                       //such as for managing advertisements.

    private void Awake()
    {
        if (instance == null)
        { 
        
            instance = this;
        
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
