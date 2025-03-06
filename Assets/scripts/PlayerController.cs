using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

public class PlayerController : MonoBehaviour
    {
        public float speed = 5.0f;
        public float turnSpeed;
        public float hotizontalInput;
        public float forwardInput;
      // Start is called once before the first execution of Update after the MonoBehaviour is created
      void Start()
     {
        
      }

     // Update is called once per frame
     void Update()
        {
        hotizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
       
       //move the tank
    
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
        transform.Rotate(Vector3.up, turnSpeed * hotizontalInput * Time.deltaTime);
        }
    }
