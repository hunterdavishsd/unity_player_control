using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

public class PlayerController : MonoBehaviour
    {
      // Start is called once before the first execution of Update after the MonoBehaviour is created
      void Start()
     {
        
      }

     // Update is called once per frame
     void Update()
        {
       //move the tank
    
        transform.Translate(Vector3.forward * Time.deltaTime * 20); 
      }
    }
