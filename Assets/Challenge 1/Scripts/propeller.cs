using UnityEngine;

public class propeller : MonoBehaviour
{

    public float rotationSpeed;
    public float speed;
    public float Rotate;
    private float propellerspeed = 10000;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

       transform.Rotate(Vector3.forward, propellerspeed * Time.deltaTime);
    }
}


